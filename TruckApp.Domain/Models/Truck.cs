using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace TruckApp.Domain.Models
{
    public class Truck
    {
        public int Id { get; set; }
        public string VIN { get; set; }
        public string Year { get; set; }
        public string Make { get; set; }
        public string Type { get; set; }
        public string Class { get; set; }
        public string BodyType { get; set; }
        public string Lenght { get; set; }
        public string Description { get; set; }

        public string TruckPlate { get; set; }
        public string TruckNumber { get; set; }

        public string RegistrantName { get; set; }
        public string TitleState { get; set; }
        public string OwnerLessorName { get; set; }
        public DateTime ExpiresDate { get; set; }
        public DateTime EfectiveDate { get; set; }
        public DateTime IssueDate { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal PurchasePrice { get; set; }
        public DateTime PurchaseDate { get; set; }

        public string Status { get; set; } // Active, Standby, Sold, Deleted.

        public ICollection<LoadDataRelationship> LoadDataRelationships { get; set; }
    }
}
