using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;
using TruckApp.Database;
using TruckApp.Domain.Models;

namespace TruckApp.Application.Contractors.FactoriesAdmin
{
    public class CreateFactory
    {
        private readonly ApplicationDbContext _ctx;

        public CreateFactory(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        public async Task<Response> Do(Request request)
        {
            var factory = new Factory
            {
                Name = request.Name,
                Email = request.Email,
                Phone1 = request.Phone1,
                Address1 = request.Address1,
                City = request.City,
                State = request.State,
                ZipCode = request.ZipCode,
                Description = request.Description,
                Rate = request.Rate,
                Status = request.Status,
            };

            _ctx.Factories.Add(factory);

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
