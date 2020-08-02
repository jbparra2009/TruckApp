using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TruckApp.Application.Assets.Trailers;
using TruckApp.Application.Assets.Trucks;
using TruckApp.Application.Contractors.Brokers;
using TruckApp.Application.Contractors.Dispatches;
using TruckApp.Application.Contractors.Drivers;
using TruckApp.Application.Contractors.Factories;
using TruckApp.Database;

namespace TruckApp.UI.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _ctx;

        public IndexModel(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        public IEnumerable<GetBrokers.BrokerViewModel> Brokers { get; set; }
        public IEnumerable<GetDispatches.DispatchViewModel> Dispatches { get; set; }
        public IEnumerable<GetDrivers.DriverViewModel> Drivers { get; set; }
        public IEnumerable<GetFactories.FactoryViewModel> Factories { get; set; }
        public IEnumerable<GetTrailers.TrailerViewModel> Trailers { get; set; }
        public IEnumerable<GetTrucks.TruckViewModel> Trucks { get; set; }

        public void OnGet()
        {
            Brokers = new GetBrokers(_ctx).Do();
            Dispatches = new GetDispatches(_ctx).Do();
            Drivers = new GetDrivers(_ctx).Do();
            Factories = new GetFactories(_ctx).Do();
            Trailers = new GetTrailers(_ctx).Do();
            Trucks = new GetTrucks(_ctx).Do();
        }

        //private readonly ILogger<IndexModel> _logger;

        //public IndexModel(ILogger<IndexModel> logger)
        //{
        //    _logger = logger;
        //}
    }
}
