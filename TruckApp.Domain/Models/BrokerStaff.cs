using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruckApp.Domain.Models
{
    public class BrokerStaff
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }    
        public string Email { get; set; }
        public string Phone1 { get; set; }
        public string Fax1 { get; set; }

        public string Description { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;

        public int BrokerId { get; set; }
        public Broker Broker { get; set; }
    }
}
