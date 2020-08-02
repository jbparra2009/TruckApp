using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TruckApp.Application.Assets.Trailers;
using TruckApp.Database;

namespace TruckApp.UI.Pages
{
    public class TrailerModel : PageModel
    {
        private readonly ApplicationDbContext _ctx;

        public TrailerModel(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        public GetTrailer.TrailerViewModel Trailer { get; set; }

        public IActionResult OnGet(string trailerNumber)
        {
            Trailer = new GetTrailer(_ctx).Do(trailerNumber.Replace("-", " "));
            if (Trailer == null)
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
