using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TruckApp.Database;
using TruckApp.Domain.Models;

namespace TruckApp.Application.Contractors.BrokerStaffAdmin
{
    public class UpdateBrokerStaff
    {
        private readonly ApplicationDbContext _ctx;

        public UpdateBrokerStaff(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        public async Task<Response> Do(Request request)
        {
            var brokersStaff = new List<BrokerStaff>();

            foreach(var brokerStaff in request.BrokerStaff)
            {
                brokersStaff.Add(new BrokerStaff
                {
                    Id = brokerStaff.Id,
                    FirstName = brokerStaff.FirstName,
                    LastName = brokerStaff.LastName,
                    Email = brokerStaff.LastName,
                    Phone1 = brokerStaff.Phone1,
                    Fax1 = brokerStaff.Fax1,
                    Description = brokerStaff.Description,
                    Created = DateTime.Parse(brokerStaff.Created),
                    BrokerId = brokerStaff.BrokerId,
                });
            }

            _ctx.BrokerStaff.UpdateRange(brokersStaff);

            await _ctx.SaveChangesAsync();

            return new Response
            {
                BrokerStaff = request.BrokerStaff
            };
        }

        public class BrokerStaffViewModel
        {
            public int Id { get; set; }
            public int BrokerId { get; set; }

            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }
            public string Phone1 { get; set; }
            public string Fax1 { get; set; }

            public string Description { get; set; }
            public string Created { get; set; }
        }

        public class Request
        {
            public IEnumerable<BrokerStaffViewModel> BrokerStaff { get; set; }
        }

        public class Response
        {
            public IEnumerable<BrokerStaffViewModel> BrokerStaff { get; set; }
        }
    }
}
