using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using TruckApp.Domain.Models;

namespace TruckApp.Application.LoadCart
{
    public class AddToLoadCart
    {
        private readonly ISession _session;

        public AddToLoadCart(ISession session)
        {
            _session = session;
        }

        public class Request
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

        public void Do(Request request)
        {
            var loadCartProduct = new LoadCartProduct
            {
                BrokerId = request.BrokerId,
                BrokerName = request.BrokerName,

                DispatchId = request.DispatchId,
                DispatchFName = request.DispatchFName,
                DispatchLName = request.DispatchLName,
                DispatchRate = request.DispatchRate,

                DriverId = request.DriverId,
                DriverFName = request.DriverFName,
                DriverLName = request.DriverLName,
                DriverRate = request.DriverRate,

                FactoryId = request.FactoryId,
                FactoryName = request.FactoryName,
                FactoryRate = request.FactoryRate,

                TrailerId = request.TrailerId,
                TrailerNumber = request.TrailerNumber,

                TruckId = request.TruckId,
                TruckNumber = request.TruckNumber,
            };

            var stringObject = JsonConvert.SerializeObject(loadCartProduct);

            //TODO: appending the load cart

            _session.SetString("loadcart", stringObject);
        }
    }
}
