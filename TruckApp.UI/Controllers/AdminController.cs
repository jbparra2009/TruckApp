using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TruckApp.Application.Assets.TrailersAdmin;
using TruckApp.Application.Assets.TrucksAdmin;
using TruckApp.Application.Contractors.BrokersAdmin;
using TruckApp.Application.Contractors.DispatchesAdmin;
using TruckApp.Application.Contractors.DriversAdmin;
using TruckApp.Application.Contractors.FactoriesAdmin;
using TruckApp.Database;

namespace TruckApp.UI.Controllers
{
    [Route("[controller]")]
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext _ctx;

        public AdminController(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        // Trailer Controllers

        [HttpGet("trailers")]
        public IActionResult GetTrailers() => Ok(new GetTrailers(_ctx).Do());

        [HttpGet("trailers/{id}")]
        public IActionResult GetTrailer(int id) => Ok(new GetTrailer(_ctx).Do(id));

        [HttpPost("trailers")]
        public async Task<IActionResult> CreateTrailer([FromBody] CreateTrailer.Request request) => Ok(await new CreateTrailer(_ctx).Do(request));

        [HttpDelete("trailes/{id}")]
        public async Task<IActionResult> DeleteTrailer(int id) => Ok(await new DeleteTrailer(_ctx).Do(id));

        [HttpPut("trailes")]
        public async Task<IActionResult> UpdateTrailer([FromBody] UpdateTrailer.Request request) => Ok(await new UpdateTrailer(_ctx).Do(request));

        // Truck Controllers

        [HttpGet("trucks")]
        public IActionResult GetTrucks() => Ok(new GetTrucks(_ctx).Do());

        [HttpGet("trucks/{id}")]
        public IActionResult GetTruck(int id) => Ok(new GetTruck(_ctx).Do(id));

        [HttpPost("trucks")]
        public async Task<IActionResult> CreateTruck([FromBody] CreateTruck.Request request) => Ok(await new CreateTruck(_ctx).Do(request));

        [HttpDelete("trucks/{id}")]
        public async Task<IActionResult> DeleteTruck(int id) => Ok(await new DeleteTruck(_ctx).Do(id));

        [HttpPut("trucks")]
        public async Task<IActionResult> UpdateTruck([FromBody] UpdateTruck.Request request) => Ok(await new UpdateTruck(_ctx).Do(request));

        // Broker Controllers

        [HttpGet("brokers")]
        public IActionResult GetBrokers() => Ok(new GetBrokers(_ctx).Do());

        [HttpGet("brokers/{id}")]
        public IActionResult GetBroker(int id) => Ok(new GetBroker(_ctx).Do(id));

        [HttpPost("brokers")]
        public async Task<IActionResult> CreateBroker([FromBody] CreateBroker.Request request) => Ok(await new CreateBroker(_ctx).Do(request));

        [HttpDelete("brokers/{id}")]
        public async Task<IActionResult> DeleteBroker(int id) => Ok(await new DeleteBroker(_ctx).Do(id));

        [HttpPut("brokers")]
        public async Task<IActionResult> UpdateBroker([FromBody] UpdateBroker.Request request) => Ok(await new UpdateBroker(_ctx).Do(request));

        // Dispatch Controllers

        [HttpGet("dispatches")]
        public IActionResult GetDispatches() => Ok(new GetDispatches(_ctx).Do());

        [HttpGet("dispatches/{id}")]
        public IActionResult GetDispatch(int id) => Ok(new GetDispatch(_ctx).Do(id));

        [HttpPost("dispatches")]
        public async Task<IActionResult> CreateDispatch([FromBody] CreateDispatch.Request request) => Ok(await new CreateDispatch(_ctx).Do(request));

        [HttpDelete("dispatches/{id}")]
        public async Task<IActionResult> DeleteDispatch(int id) => Ok(await new DeleteDispatch(_ctx).Do(id));

        [HttpPut("dispatches")]
        public async Task<IActionResult> UpdateDispatch([FromBody] UpdateDispatch.Request request) => Ok(await new UpdateDispatch(_ctx).Do(request));

        // Driver Controllers

        [HttpGet("drivers")]
        public IActionResult GetDrivers() => Ok(new GetDrivers(_ctx).Do());

        [HttpGet("drivers/{id}")]
        public IActionResult GetDriver(int id) => Ok(new GetDriver(_ctx).Do(id));

        [HttpPost("drivers")]
        public async Task<IActionResult> CreateDriver([FromBody] CreateDriver.Request request) => Ok(await new CreateDriver(_ctx).Do(request));

        [HttpDelete("drivers/{id}")]
        public async Task<IActionResult> DeleteDriver(int id) => Ok(await new DeleteDriver(_ctx).Do(id));

        [HttpPut("drivers")]
        public async Task<IActionResult> UpdateDriver([FromBody] UpdateDriver.Request request) => Ok(await new UpdateDriver(_ctx).Do(request));

        // Factory Controllers

        [HttpGet("factories")]
        public IActionResult GetFactories() => Ok(new GetFactories(_ctx).Do());

        [HttpGet("factories/{id}")]
        public IActionResult GetFactory(int id) =>  Ok(new GetFactory(_ctx).Do(id));

        [HttpPost("factories")]
        public async Task<IActionResult> CreateFactory([FromBody] CreateFactory.Request request) => Ok(await new CreateFactory(_ctx).Do(request));

        [HttpDelete("factories/{id}")]
        public async Task<IActionResult> DeleteFactory(int id) => Ok(await new DeleteFactory(_ctx).Do(id));

        [HttpPut("factories")]
        public async Task<IActionResult> UpdateFactory([FromBody] UpdateFactory.Request request) => Ok(await new UpdateFactory(_ctx).Do(request));

    }
}