using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TruckApp.Application.Assets.Trucks;
using TruckApp.Database;

namespace TruckApp.UI.Pages.Admin.Pages
{
    public class TruckModel : PageModel
    {
        private readonly ApplicationDbContext _ctx;

        public TruckModel(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        public IEnumerable<GetTrucks.TruckViewModel> Trucks { get; set; }

        public void OnGet()
        {
            Trucks = new GetTrucks(_ctx).Do();
        }
    }
}
