using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TruckApp.Application.Contractors.Drivers;
using TruckApp.Database;

namespace TruckApp.UI.Pages.Admin
{
    public class DriverModel : PageModel
    {
        private readonly ApplicationDbContext _ctx;

        public DriverModel(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        public IEnumerable<GetDrivers.DriverViewModel> Drivers { get; set; }

        public void OnGet()
        {
            Drivers = new GetDrivers(_ctx).Do();
        }
    }
}
