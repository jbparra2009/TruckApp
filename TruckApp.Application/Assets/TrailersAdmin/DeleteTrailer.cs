using System.Linq;
using System.Threading.Tasks;
using TruckApp.Database;

namespace TruckApp.Application.Assets.TrailersAdmin
{
    public class DeleteTrailer
    {
        private readonly ApplicationDbContext _ctx;

        public DeleteTrailer(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        public async Task<bool> Do(int id)
        {
            var Trailer = _ctx.Trailers.FirstOrDefault(x => x.Id == id);
            _ctx.Trailers.Remove(Trailer);

            await _ctx.SaveChangesAsync();

            return true;
        }
    }
}
