using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TruckApp.Application.Contractors.Factories;
using TruckApp.Database;

namespace TruckApp.UI.Pages
{
    public class FactoryModel : PageModel
    {
        private readonly ApplicationDbContext _ctx;

        public FactoryModel(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        public GetFactory.FactoryViewModel Factory { get; set; }

        public IActionResult OnGet(string factoryName)
        {
            Factory = new GetFactory(_ctx).Do(factoryName.Replace("-", " "));
            if (Factory == null)
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
