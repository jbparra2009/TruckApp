using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruckApp.Domain.Models
{
    public class LoadCartProduct
    {
        public int Id { get; set; }
        //public DateTime DateCreated { get; set; }
        public string LoadNumber { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal LoadRate { get; set; }

        public int BrokerId { get; set; }
        public string BrokerName { get; set; }

        //public int DispatchId { get; set; }
        //public string DispatchFName { get; set; }
        //public string DispatchLName { get; set; }
        //public decimal DispatchRate { get; set; }

        //public int DriverId { get; set; }
        //public string DriverFName { get; set; }
        //public string DriverLName { get; set; }
        //public decimal DriverRate { get; set; }

        //public int FactoryId { get; set; }
        //public string FactoryName { get; set; }
        //public decimal FactoryRate { get; set; }

        //public int TrailerId { get; set; }
        //public string TrailerNumber { get; set; }

        //public int TruckId { get; set; }
        //public string TruckNumber { get; set; }

    }
}
