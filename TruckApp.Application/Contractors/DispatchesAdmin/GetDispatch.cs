using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using TruckApp.Database;

namespace TruckApp.Application.Contractors.DispatchesAdmin
{
    public class GetDispatch
    {
        private readonly ApplicationDbContext _ctx;

        public GetDispatch(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        public DispatchViewModel Do(int id) =>
            _ctx.Dispatches.Where(x => x.Id == id).Select(x => new DispatchViewModel
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

                SS = x.SS,
                CorpName = x.CorpName,
                EIN = x.EIN,

                Created = x.Created.ToString("yyyy-MM-dd"),
                Status = x.Status,
            })
            .FirstOrDefault();

        public class DispatchViewModel
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

            public string SS { get; set; }
            public string CorpName { get; set; }
            public string EIN { get; set; }

            public string Created { get; set; }
            public string Status { get; set; } // Active, Standby, Deleted.
        }
    }  
}
