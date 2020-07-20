using System;
using System.Collections.Generic;
using System.Linq;
using TruckApp.Database;

namespace TruckApp.Application.Contractors.BrokersAdmin
{
    public class GetBrokers
    {
        private readonly ApplicationDbContext _ctx;

        public GetBrokers(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        public IEnumerable<BrokerViewModel> Do() =>
            _ctx.Brokers.ToList().Select(x => new BrokerViewModel
            {
                Id = x.Id,
                BrokerName = x.BrokerName,
                Email = x.Email,
                Phone1 = x.Phone1,
                Address1 = x.Address1,
                City = x.City,
                State = x.State,
                ZipCode = x.ZipCode,

                Description = x.Description,

                Created = x.Created.ToString("yyyy-MM-dd"),
                Status = x.Status,
            });

        public class BrokerViewModel
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

            public string Created { get; set; }
            public string Status { get; set; } // Active, Standby, Deleted.
        }
    }   
}
