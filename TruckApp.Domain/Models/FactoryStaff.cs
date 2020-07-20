using System;

namespace TruckApp.Domain.Models
{
    public class FactoryStaff
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone1 { get; set; }
        public string Fax1 { get; set; }

        public string Description { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;

        public int FactoryId { get; set; }
        public Factory Factory { get; set; }
    }
}
