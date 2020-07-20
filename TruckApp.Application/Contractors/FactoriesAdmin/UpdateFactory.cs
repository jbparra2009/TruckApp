using System.Linq;
using System.Threading.Tasks;
using TruckApp.Database;

namespace TruckApp.Application.Contractors.FactoriesAdmin
{
    public class UpdateFactory
    {
        private readonly ApplicationDbContext _ctx;

        public UpdateFactory(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        public async Task<Response> Do(Request request)
        {
            var factory = _ctx.Factories.FirstOrDefault(x => x.Id == request.Id);

            factory.Name = request.Name;
            factory.Email = request.Email;
            factory.Phone1 = request.Phone1;
            factory.Address1 = request.Address1;
            factory.City = request.City;
            factory.State = request.State;
            factory.ZipCode = request.ZipCode;

            factory.Description = request.Description;
            factory.Rate = request.Rate;

            factory.Status = request.Status;

            await _ctx.SaveChangesAsync();

            return new Response
            {
                Id = factory.Id,
                Name = factory.Name,
                Email = factory.Email,
                Phone1 = factory.Phone1,
                Address1 = factory.Address1,
                City = factory.City,
                State = factory.State,
                ZipCode = factory.ZipCode,

                Description = factory.Description,
                Rate = factory.Rate,

                Created = factory.Created.ToString("yyyy-MM-dd"),
                Status = factory.Status,
            };
        }

        public class Request
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Email { get; set; }
            public string Phone1 { get; set; }
            public string Address1 { get; set; }
            public string City { get; set; }
            public string State { get; set; }
            public string ZipCode { get; set; }

            public string Description { get; set; }
            public decimal Rate { get; set; }

            public string Status { get; set; } // Active, Standby, Deleted.
        }

        public class Response
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Email { get; set; }
            public string Phone1 { get; set; }
            public string Address1 { get; set; }
            public string City { get; set; }
            public string State { get; set; }
            public string ZipCode { get; set; }

            public string Description { get; set; }
            public decimal Rate { get; set; }

            public string Created { get; set; }
            public string Status { get; set; } // Active, Standby, Deleted.
        }
    }  
}
