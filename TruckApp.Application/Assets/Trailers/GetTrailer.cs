using System.Linq;
using TruckApp.Database;

namespace TruckApp.Application.Assets.Trailers
{
    public class GetTrailer
    {
        private readonly ApplicationDbContext _ctx;

        public GetTrailer(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        public TrailerViewModel Do(string trailerNumber) =>
            _ctx.Trailers
            .Where(x => x.TrailerNumber == trailerNumber)
            .Select(x => new TrailerViewModel
            {
                VIN = x.VIN,
                Year = x.Year,
                Make = x.Make,
                Model = x.Model,
                Description = x.Description,
                TrailerPlate = x.TrailerPlate,
                TrailerNumber = x.TrailerNumber,
                Status = x.Status,
            })
            .FirstOrDefault();

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
