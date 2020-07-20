using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace TruckApp.Domain.Models
{
    public class Load
    {
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public string LoadNumber { get; set; }

        //public string TruckNumber { get; set; }
        //public string TrailerNumber { get; set; }
        //public string BrokerName { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal LoadRate { get; set; }

        public string PickupAddress { get; set; }
        public string PickupCity { get; set; }
        public string PickupState { get; set; }
        public string PickupZipCode { get; set; }
        public DateTime PickupDate { get; set; }

        public string DeliveryAddress { get; set; }
        public string DeliveryCity { get; set; }
        public string DeliveryState { get; set; }
        public string DeliveryZipCode { get; set; }
        public DateTime DeliveryDate { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Mileage { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal MileageEmpty { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal MileageTotal { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal LoadAverage { get; set; }

        //public string DriveName { get; set; }
        //[Column(TypeName = "decimal(18,2)")]
        //public decimal DriverRate { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal DriverPayment { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal DriverAdvance { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal DriverFinalDeposit { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal FuelAverage { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal FuelCost { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal FixedCost { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal LoadExpenses { get; set; }
        public string LoadExpensesDetail { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal LoadTotalDeposit { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal LoadRealDeposit { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal LoadRevenue { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal LoadAdvance { get; set; }
        public string LoadAdvanceDetail { get; set; }

        //[Column(TypeName = "decimal(18,2)")]
        //public decimal DispatchRate { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal DispatchCost { get; set; }

        //[Column(TypeName = "decimal(18,2)")]
        //public decimal FactoryRate { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal FactoryCost { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal LumperValue { get; set; }
        public string LumperDetail { get; set; }

        public ICollection<LoadDataRelationship> LoadDataRelationships { get; set; }
    }
}
