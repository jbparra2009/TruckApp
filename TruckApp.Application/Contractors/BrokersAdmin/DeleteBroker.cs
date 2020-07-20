using System.Linq;
using System.Threading.Tasks;
using TruckApp.Database;

namespace TruckApp.Application.Contractors.BrokersAdmin
{
    public class DeleteBroker
    {
        private readonly ApplicationDbContext _ctx;

        public DeleteBroker(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        public async Task<bool> Do(int id)
        {
            var Broker = _ctx.Brokers.FirstOrDefault(x => x.Id == id);
            _ctx.Brokers.Remove(Broker);

            await _ctx.SaveChangesAsync();

            return true;
        }
    }
}
