using System.Collections.Generic;
using System.Linq;
using TruckApp.Database;

namespace TruckApp.Application.Assets.Trailers
{
    public class GetTrailers
    {
        private readonly ApplicationDbContext _ctx;

        public GetTrailers(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        public IEnumerable<TrailerViewModel> Do() => 
            _ctx.Trailers.ToList().Select(x => new TrailerViewModel
            {
                VIN = x.VIN,
                Year = x.Year,
                Make = x.Make,
                Model = x.Model,
                Description = x.Description,
                TrailerPlate = x.TrailerPlate,
                TrailerNumber = x.TrailerNumber,
                Status = x.Status,
            });

        public class TrailerViewModel
        {
            public string VIN { get; set; }
            public string Year { get; set; }
            public string Make { get; set; }
            public string Model { get; set; }
            public string Description { get; set; }

            public string TrailerPlate { get; set; }
            public string TrailerNumber { get; set; }

            public string Status { get; set; } // Active, Standby, Deleted.
        }
    } 
}
