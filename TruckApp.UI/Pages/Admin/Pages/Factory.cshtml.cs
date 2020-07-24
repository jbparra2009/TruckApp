using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TruckApp.Application.Contractors.Factories;
using TruckApp.Database;

namespace TruckApp.UI.Pages.Admin.Pages
{
    public class FactoryModel : PageModel
    {
        private readonly ApplicationDbContext _ctx;

        public FactoryModel(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        public IEnumerable<GetFactories.FactoryViewModel> Factories { get; set; }

        public void OnGet()
        {
            Factories = new GetFactories(_ctx).Do();
        }
    }
}
