using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TruckApp.Application.Assets.Trailers;
using TruckApp.Database;

namespace TruckApp.UI.Pages.Admin
{
    public class TrailerModel : PageModel
    {
        private readonly ApplicationDbContext _ctx;

        public TrailerModel(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        public IEnumerable<GetTrailers.TrailerViewModel> Trailers { get; set; }

        public void OnGet()
        {
            Trailers = new GetTrailers(_ctx).Do();
        }
    }
}
