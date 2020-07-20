using System.Collections.Generic;
using System.Linq;
using TruckApp.Database;

namespace TruckApp.Application.Contractors.Dispatches
{
    public class GetDispatches
    {
        private readonly ApplicationDbContext _ctx;

        public GetDispatches(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        public IEnumerable<DispatchViewModel> Do() =>
            _ctx.Dispatches.ToList().Select(x => new DispatchViewModel
            {
                FirstName = x.FirstName,
                LastName = x.LastName,
                Email = x.Email,
                Phone1 = x.Phone1,
                Address1 = x.Address1,
                City = x.City,
                State = x.State,
                ZipCode = x.ZipCode,
                Description = x.Description,
                SS = x.SS,
                CorpName = x.CorpName,
                EIN = x.EIN,
                Rate = x.Rate,
                Status = x.Status,
            });

        public class DispatchViewModel
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }
            public string Phone1 { get; set; }
            public string Address1 { get; set; }
            public string City { get; set; }
            public string State { get; set; }
            public string ZipCode { get; set; }

            public string Description { get; set; }

            public string SS { get; set; }
            public string CorpName { get; set; }
            public string EIN { get; set; }

            public decimal Rate { get; set; }

            public string Status { get; set; } // Active, Standby, Deleted.
        }
    }  
}
