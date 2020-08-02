using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TruckApp.Database;
using TruckApp.Domain.Models;

namespace TruckApp.Application.LoadCart
{
    public class GetLoadCart
    {
        private readonly ISession _session;
        private readonly ApplicationDbContext _ctx;

        public GetLoadCart(ISession session, ApplicationDbContext ctx)
        {
            _session = session;
            _ctx = ctx;
        }

        public class Response
        {
            public int BrokerId { get; set; }
            public string BrokerName { get; set; }

            public int DispatchId { get; set; }
            public string DispatchFName { get; set; }
            public string DispatchLName { get; set; }
            public decimal DispatchRate { get; set; }

            public int DriverId { get; set; }
            public string DriverFName { get; set; }
            public string DriverLName { get; set; }
            public decimal DriverRate { get; set; }

            public int FactoryId { get; set; }
            public string FactoryName { get; set; }
            public decimal FactoryRate { get; set; }

            public int TrailerId { get; set; }
            public string TrailerNumber { get; set; }

            public int TruckId { get; set; }
            public string TruckNumber { get; set; }
        }

        public Response Do()
        {
            var stringObject = _session.GetString("loadcart");

            var loadCartProduct = JsonConvert.DeserializeObject<LoadCartProduct>(stringObject);

            //TODO: appending the load cart

            var response = _ctx.Brokers
                .Where(x => x.Id == loadCartProduct.BrokerId)
                .Select(x => new Response
                {

                })



            return new Response();
        }
    }
}
