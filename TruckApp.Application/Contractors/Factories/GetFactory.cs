using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using TruckApp.Database;

namespace TruckApp.Application.Contractors.Factories
{
    public class GetFactory
    {
        private readonly ApplicationDbContext _ctx;

        public GetFactory(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        public FactoryViewModel Do(string name) =>
            _ctx.Factories
            .Include(x => x.FactoryStaff)
            .Where(x => x.Name == name)
            .Select(x => new FactoryViewModel
            {
                Name = x.Name,
                Email = x.Email,
                Phone1 = x.Phone1,
                Address1 = x.Address1,
                City = x.City,
                State = x.State,
                ZipCode = x.ZipCode,
                Description = x.Description,
                Rate = x.Rate,
                Status = x.Status,

                FactoryStaff = x.FactoryStaff.Select(y => new FactoryStaffViewModel
                {
                    Id = y.Id,
                    FirstName = y.FirstName,
                    LastName = y.LastName,
                })
            })
            .FirstOrDefault();

        public class FactoryViewModel
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

            public IEnumerable<FactoryStaffViewModel> FactoryStaff { get; set; }
        }

        public class FactoryStaffViewModel
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }
            public string Phone1 { get; set; }
        }
    }
}
