using System.Collections.Generic;
using System.Linq;
using TruckApp.Database;

namespace TruckApp.Application.Assets.Trucks
{
    public class GetTrucks
    {
        private readonly ApplicationDbContext _ctx;

        public GetTrucks(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        public IEnumerable<TruckViewModel> Do() =>
            _ctx.Trucks.ToList().Select(x => new TruckViewModel
            {
                VIN = x.VIN,
                Year = x.Year,
                Make = x.Make,
                Description = x.Description,
                TruckPlate = x.TruckPlate,
                TruckNumber = x.TruckNumber,
                Status = x.Status,
            });

        public class TruckViewModel
        {
            public string VIN { get; set; }
            public string Year { get; set; }
            public string Make { get; set; }
            public string Description { get; set; }

            public string TruckPlate { get; set; }
            public string TruckNumber { get; set; }

            public string Status { get; set; } // Active, Standby, Sold, Deleted.
        }
    } 
}
