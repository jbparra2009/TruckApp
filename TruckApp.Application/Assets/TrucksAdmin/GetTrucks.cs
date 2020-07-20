using System;
using System.Collections.Generic;
using System.Linq;
using TruckApp.Database;

namespace TruckApp.Application.Assets.TrucksAdmin
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
                Id = x.Id,
                VIN = x.VIN,
                Year = x.Year,
                Make = x.Make,
                Type = x.Type,
                Class = x.Class,
                BodyType = x.BodyType,
                Lenght = x.Lenght,
                Description = x.Description,

                TruckPlate = x.TruckPlate,
                TruckNumber = x.TruckNumber,

                RegistrantName = x.RegistrantName,
                TitleState = x.TitleState,
                OwnerLessorName = x.OwnerLessorName,
                ExpiresDate = x.ExpiresDate.ToString("yyyy-MM-dd"),
                EfectiveDate = x.EfectiveDate.ToString("yyyy-MM-dd"),
                IssueDate = x.IssueDate.ToString("yyyy-MM-dd"),
                PurchasePrice = x.PurchasePrice,
                PurchaseDate = x.PurchaseDate.ToString("yyyy-MM-dd"),

                Status = x.Status,

            });

        public class TruckViewModel
        {
            public int Id { get; set; }
            public string VIN { get; set; }
            public string Year { get; set; }
            public string Make { get; set; }
            public string Type { get; set; }
            public string Class { get; set; }
            public string BodyType { get; set; }
            public string Lenght { get; set; }
            public string Description { get; set; }

            public string TruckPlate { get; set; }
            public string TruckNumber { get; set; }

            public string RegistrantName { get; set; }
            public string TitleState { get; set; }
            public string OwnerLessorName { get; set; }
            public string ExpiresDate { get; set; }
            public string EfectiveDate { get; set; }
            public string IssueDate { get; set; }
            public decimal PurchasePrice { get; set; }
            public string PurchaseDate { get; set; }

            public string Status { get; set; } // Active, Standby, Sold, Deleted.
        }
    } 
}
