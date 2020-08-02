using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TruckApp.Application.Assets.Trucks;
using TruckApp.Database;

namespace TruckApp.UI.Pages
{
    public class TruckModel : PageModel
    {
        private readonly ApplicationDbContext _ctx;

        public TruckModel(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        public GetTruck.TruckViewModel Truck { get; set; }

        public IActionResult OnGet(string truckNumber)
        {
            Truck = new GetTruck(_ctx).Do(truckNumber.Replace("-", " "));
            if (Truck == null)
                return RedirectToPage("Index");
            else
                return Page();
        }

        public IActionResult OnPost()
        {

            return RedirectToPage("Index");
        }
    }
}
