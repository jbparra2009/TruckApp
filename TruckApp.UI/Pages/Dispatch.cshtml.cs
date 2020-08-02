using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TruckApp.Application.Contractors.Dispatches;
using TruckApp.Database;

namespace TruckApp.UI.Pages
{
    public class DispatchModel : PageModel
    {
        private readonly ApplicationDbContext _ctx;

        public DispatchModel(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        public GetDispatch.DispatchViewModel Dispatch { get; set; }

        public IActionResult OnGet(string firstName)
        {
            Dispatch = new GetDispatch(_ctx).Do(firstName.Replace("-", " "));
            if (Dispatch == null)
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
