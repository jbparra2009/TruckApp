using System.Threading.Tasks;
using TruckApp.Database;
using TruckApp.Domain.Models;

namespace TruckApp.Application.Contractors.BrokersAdmin
{
    public class CreateBroker
    {
        private readonly ApplicationDbContext _ctx;

        public CreateBroker(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        public async Task<Response> Do(Request request)
        {
            var broker = new Broker
            {
                BrokerName = request.BrokerName,
                Email = request.Email,
                Phone1 = request.Phone1,
                Address1 = request.Address1,
                City = request.City,
                State = request.State,
                ZipCode = request.ZipCode,
                Description = request.Description,
                Status = request.Status,
            };

            _ctx.Brokers.Add(broker);

            await _ctx.SaveChangesAsync();

            return new Response
            {
                Id = broker.Id,
                BrokerName = broker.BrokerName,
                Email = broker.Email,
                Phone1 = broker.Phone1,
                Address1 = broker.Address1,
                City = broker.City,
                State = broker.State,
                ZipCode = broker.ZipCode,
                Description = broker.Description,
                Created = broker.Created.ToString("yyyy-MM-dd"),
                Status = broker.Status,
            };
        }

        public class Request
        {
            public string BrokerName { get; set; }
            public string Email { get; set; }
            public string Phone1 { get; set; }
            public string Address1 { get; set; }
            public string City { get; set; }
            public string State { get; set; }
            public string ZipCode { get; set; }

            public string Description { get; set; }

            public string Status { get; set; } // Active, Standby, Deleted.
        }

        public class Response
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
