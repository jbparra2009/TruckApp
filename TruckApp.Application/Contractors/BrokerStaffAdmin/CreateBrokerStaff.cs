using System;
using System.Threading.Tasks;
using TruckApp.Database;
using TruckApp.Domain.Models;

namespace TruckApp.Application.Contractors.BrokerStaffAdmin
{
    public class CreateBrokerStaff
    {
        private readonly ApplicationDbContext _ctx;

        public CreateBrokerStaff(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        public async Task<Response> Do(Request request)
        {
            var brokerStaff = new BrokerStaff
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                Email = request.LastName,
                Phone1 = request.Phone1,
                Fax1 = request.Fax1,
                Description = request.Description,
                Created = DateTime.Parse(request.Created),

                BrokerId = request.BrokerId,
            };

            _ctx.BrokerStaff.Add(brokerStaff);

            await _ctx.SaveChangesAsync();

            return new Response
            {
                Id = brokerStaff.Id,
                FirstName = brokerStaff.FirstName,
                LastName = brokerStaff.LastName,
                Email = brokerStaff.LastName,
                Phone1 = brokerStaff.Phone1,
                Fax1 = brokerStaff.Fax1,
                Description = brokerStaff.Description,
                Created = brokerStaff.Created.ToString("yyyy-MM-dd"),
            };
        }

        public class Request
        {

            public int BrokerId { get; set; }

            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }
            public string Phone1 { get; set; }
            public string Fax1 { get; set; }

            public string Description { get; set; }
            public string Created { get; set; } 
        }

        public class Response
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }
            public string Phone1 { get; set; }
            public string Fax1 { get; set; }

            public string Description { get; set; }
            public string Created { get; set; }
        }
    }
}
