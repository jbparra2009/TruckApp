using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TruckApp.Database;
using TruckApp.Domain.Models;

namespace TruckApp.Application.Contractors.FactoryStaffAdmin
{
    public class UpdateFactoryStaff
    {
        private readonly ApplicationDbContext _ctx;

        public UpdateFactoryStaff(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        public async Task<Response> Do(Request request)
        {
            var factoriesStaff = new List<FactoryStaff>();

            foreach (var factoryStaff in request.FactoryStaff)
            {
                factoriesStaff.Add(new FactoryStaff
                {
                    Id = factoryStaff.Id,
                    FirstName = factoryStaff.FirstName,
                    LastName = factoryStaff.LastName,
                    Email = factoryStaff.LastName,
                    Phone1 = factoryStaff.Phone1,
                    Fax1 = factoryStaff.Fax1,
                    Description = factoryStaff.Description,
                    Created = DateTime.Parse(factoryStaff.Created),
                    FactoryId = factoryStaff.FactoryId,
                });
            }

            _ctx.FactoryStaff.UpdateRange(factoriesStaff);

            await _ctx.SaveChangesAsync();

            return new Response
            {
                FactoryStaff = request.FactoryStaff
            };
        }

        public class FactoryStaffViewModel
        {
            public int Id { get; set; }
            public int FactoryId { get; set; }

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
            public IEnumerable<FactoryStaffViewModel> FactoryStaff { get; set; }
        }

        public class Response
        {
            public IEnumerable<FactoryStaffViewModel> FactoryStaff { get; set; }
        }
    }
}
