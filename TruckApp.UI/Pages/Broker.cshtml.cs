using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TruckApp.Application.Contractors.Brokers;
using TruckApp.Application.LoadCart;
using TruckApp.Database;

namespace TruckApp.UI.Pages
{
    public class BrokerModel : PageModel
    {
        private readonly ApplicationDbContext _ctx;

        public BrokerModel(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        [BindProperty]
        public AddToLoadCart.Request LoadCartViewModel { get; set; }

        public GetBroker.BrokerViewModel Broker { get; set; }

        public IActionResult OnGet(string brokerName)
        {
            Broker = new GetBroker(_ctx).Do(brokerName.Replace("-", " "));
            if (Broker == null)
                return RedirectToPage("Index");
            else
                return Page();
        }

        public IActionResult OnPost()
        {
            new AddToLoadCart(HttpContext.Session).Do(LoadCartViewModel);

            return RedirectToPage("Index");
        }
    }
}
