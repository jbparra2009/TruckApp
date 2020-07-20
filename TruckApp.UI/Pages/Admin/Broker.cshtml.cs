using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TruckApp.Application.Contractors.Brokers;
using TruckApp.Database;

namespace TruckApp.UI.Pages.Admin
{
    public class BrokerModel : PageModel
    {
        private readonly ApplicationDbContext _ctx;

        public BrokerModel(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        public IEnumerable<GetBrokers.BrokerViewModel> Brokers { get; set; }

        public void OnGet()
        {
            Brokers = new GetBrokers(_ctx).Do();
        }
    }
}
