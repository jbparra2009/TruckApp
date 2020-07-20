using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TruckApp.Application.Contractors.Dispatches;
using TruckApp.Database;

namespace TruckApp.UI.Pages.Admin
{
    public class DispatchModel : PageModel
    {
        private readonly ApplicationDbContext _ctx;

        public DispatchModel(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        public IEnumerable<GetDispatches.DispatchViewModel> Dispatches { get; set; }

        public void OnGet()
        {
            Dispatches = new GetDispatches(_ctx).Do();
        }
    }
}
