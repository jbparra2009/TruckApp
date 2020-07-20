using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using TruckApp.Database;

namespace TruckApp.Application.Contractors.FactoriesAdmin
{
    public class GetFactories
    {
        private readonly ApplicationDbContext _ctx;

        public GetFactories(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        public IEnumerable<FactoryViewModel> Do() =>

            _ctx.Factories.ToList().Select(x => new FactoryViewModel
            {
                Id = x.Id,
                Name = x.Name,
                Email = x.Email,
                Phone1 = x.Phone1,
                Address1 = x.Address1,
                City = x.City,
                State = x.State,
                ZipCode = x.ZipCode,

                Description = x.Description,
                Rate = x.Rate,

                Created = x.Created.ToString("yyyy-MM-dd"),
                Status = x.Status,
            });

        public class FactoryViewModel
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
