using System.Linq;
using System.Threading.Tasks;
using TruckApp.Database;

namespace TruckApp.Application.Contractors.DriversAdmin
{
    public class DeleteDriver
    {
        private readonly ApplicationDbContext _ctx;

        public DeleteDriver(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        public async Task<bool> Do(int id)
        {
            var driver = _ctx.Drivers.FirstOrDefault(x => x.Id == id);
            _ctx.Drivers.Remove(driver);
            await _ctx.SaveChangesAsync();

            return true;
        }
    }
}
