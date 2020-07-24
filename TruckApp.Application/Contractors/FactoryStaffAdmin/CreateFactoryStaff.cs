using System;
using System.Threading.Tasks;
using TruckApp.Database;
using TruckApp.Domain.Models;

namespace TruckApp.Application.Contractors.FactoryStaffAdmin
{
    public class CreateFactoryStaff
    {
        private readonly ApplicationDbContext _ctx;

        public CreateFactoryStaff(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        public async Task<Response> Do(Request request)
        {
            var factoryStaff = new FactoryStaff
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                Email = request.LastName,
                Phone1 = request.Phone1,
                Fax1 = request.Fax1,
                Description = request.Description,
                Created = DateTime.Parse(request.Created),

                FactoryId = request.FactoryId,
            };

            _ctx.FactoryStaff.Add(factoryStaff);

            await _ctx.SaveChangesAsync();

            return new Response
            {
                Id = factoryStaff.Id,
                FirstName = factoryStaff.FirstName,
                LastName = factoryStaff.LastName,
                Email = factoryStaff.LastName,
                Phone1 = factoryStaff.Phone1,
                Fax1 = factoryStaff.Fax1,
                Description = factoryStaff.Description,
                Created = factoryStaff.Created.ToString("yyyy-MM-dd"),
            };
        }

        public class Request
        {
            public int FactoryId { get; set; }

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
