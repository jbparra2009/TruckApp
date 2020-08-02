using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using TruckApp.Database;

namespace TruckApp.Application.Contractors.Brokers
{
    public class GetBroker
    {
        private readonly ApplicationDbContext _ctx;

        public GetBroker(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        public BrokerViewModel Do(string brokerName) =>
            _ctx.Brokers
            .Include(x => x.BrokerStaff)
            .Where(x => x.BrokerName == brokerName)
            .Select(x => new BrokerViewModel
            {
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

                BrokerStaff = x.BrokerStaff.Select(y => new BrokerStaffViewModel
                {
                    Id = y.Id,
                    FirstName = y.FirstName,
                    LastName = y.LastName,
                    Email = y.Email,
                    Phone1 = y.Phone1,
                })
            })
            .FirstOrDefault();

        public class BrokerViewModel
        {
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

            public IEnumerable<BrokerStaffViewModel> BrokerStaff { get; set; }
        }

        public class BrokerStaffViewModel
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }
            public string Phone1 { get; set; }
        }
    }
}
