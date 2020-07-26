using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using TruckApp.Database;

namespace TruckApp.Application.Contractors.FactoryStaffAdmin
{
    public class GetFactoryStaff
    {
        private readonly ApplicationDbContext _ctx;

        public GetFactoryStaff(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        public IEnumerable<FactoryViewModel> Do()
        {
            var factoryStaff = _ctx.Factories
                .Include(x => x.FactoryStaff)
                .Select(x => new FactoryViewModel
                {
                    Id = x.Id,
                    Name = x.Name,

                    FactoryStaff = x.FactoryStaff.Select(y => new FactoryStaffViewModel
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

            return factoryStaff;
        }

        public class FactoryStaffViewModel
        {
            public int Id { get; set; }

            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }
            public string Phone1 { get; set; }
            public string Fax1 { get; set; }

            public string Description { get; set; }

        }

        public class FactoryViewModel
        {
            public int Id { get; set; }
            public string Name { get; set; }

            public IEnumerable<FactoryStaffViewModel> FactoryStaff { get; set; }
        }
    }
}
