using System;
using System.Collections.Generic;

namespace TruckApp.Domain.Models
{
    public class Broker
    {
        public int Id { get; set; }
        public string BrokerName { get; set; }
        public string Email { get; set; }
        public string Phone1 { get; set; }
        public string Address1 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }

        public string Description { get; set; }

        public DateTime Created { get; set; } = DateTime.Now;
        public string Status { get; set; } // Active, Standby, Deleted.

        public ICollection<BrokerStaff> BrokerStaff { get; set; }
        public ICollection<LoadDataRelationship> LoadDataRelationships { get; set; }
    }
}
