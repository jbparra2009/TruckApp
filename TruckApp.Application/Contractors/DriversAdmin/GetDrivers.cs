using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using TruckApp.Database;

namespace TruckApp.Application.Contractors.DriversAdmin
{
    public class GetDrivers
    {
        private readonly ApplicationDbContext _ctx;

        public GetDrivers(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        public IEnumerable<DriverViewModel> Do() =>
            _ctx.Drivers.ToList().Select(x => new DriverViewModel
            {
                Id = x.Id,
                FirstName = x.FirstName,
                LastName = x.LastName,
                Email = x.Email,
                Phone1 = x.Phone1,
                Address1 = x.Address1,
                City = x.City,
                State = x.State,
                ZipCode = x.ZipCode,

                Description = x.Description,
                Rate = x.Rate,

                CorpName = x.CorpName,
                EIN = x.EIN,

                SS = x.SS,
                DOB = x.DOB.ToString("yyyy-MM-dd"),
                CDLClass = x.CDLClass,
                CDLIssued = x.CDLIssued.ToString("yyyy-MM-dd"),
                CDLExpires = x.CDLExpires.ToString("yyyy-MM-dd"),
                CDLState = x.CDLState,

                Created = x.Created.ToString("yyyy-MM-dd"),
                Status = x.Status,
            });

        public class DriverViewModel
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }
            public string Phone1 { get; set; }
            public string Address1 { get; set; }
            public string City { get; set; }
            public string State { get; set; }
            public string ZipCode { get; set; }

            public string Description { get; set; }
            public decimal Rate { get; set; }

            public string CorpName { get; set; }
            public string EIN { get; set; }

            public string SS { get; set; }
            public string DOB { get; set; }
            public string CDLClass { get; set; }
            public string CDLIssued { get; set; }
            public string CDLExpires { get; set; }
            public string CDLState { get; set; }

            public string Created { get; set; }
            public string Status { get; set; } // Active, Standby, Deleted.
        }
    }
}
