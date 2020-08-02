using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TruckApp.Application.Contractors.Drivers;
using TruckApp.Database;

namespace TruckApp.UI.Pages
{
    public class DriverModel : PageModel
    {
        private readonly ApplicationDbContext _ctx;

        public DriverModel(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        public GetDriver.DriverViewModel Driver { get; set; }

        public IActionResult OnGet(string firstName)
        {
            Driver = new GetDriver(_ctx).Do(firstName.Replace("-", " "));
            if (Driver == null)
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
