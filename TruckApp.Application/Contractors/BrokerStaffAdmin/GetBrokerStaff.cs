using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using TruckApp.Database;

namespace TruckApp.Application.Contractors.BrokerStaffAdmin
{
    public class GetBrokerStaff
    {
        private readonly ApplicationDbContext _ctx;

        public GetBrokerStaff(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        public IEnumerable<BrokerViewModel> Do()
        {
            var brokerStaff = _ctx.Brokers
                .Include(x => x.BrokerStaff)
                .Select(x => new BrokerViewModel
                {
                    Id = x.Id,
                    BrokerName = x.BrokerName,

                    BrokerStaff = x.BrokerStaff.Select(y => new BrokerStaffViewModel 
                    {
                        Id = y.Id,
                        FirstName = y.FirstName,
                        LastName = y.LastName,
                        Email = y.LastName,
                        Phone1 = y.Phone1,
                        Fax1 = y.Fax1,
                        Description = y.Description,
                    })
                })
                .ToList();

            return brokerStaff;
        }

        public class BrokerStaffViewModel
        {
            public int Id { get; set; }

            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }
            public string Phone1 { get; set; }
            public string Fax1 { get; set; }

            public string Description { get; set; }
        }

        public class BrokerViewModel
        {
            public int Id { get; set; }
            public string BrokerName { get; set; }

            public IEnumerable<BrokerStaffViewModel> BrokerStaff { get; set; }
        }
    }
}
