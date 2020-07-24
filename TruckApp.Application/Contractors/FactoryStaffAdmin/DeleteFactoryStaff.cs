using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TruckApp.Database;

namespace TruckApp.Application.Contractors.FactoryStaffAdmin
{
    public class DeleteFactoryStaff
    {
        private readonly ApplicationDbContext _ctx;

        public DeleteFactoryStaff(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        public async Task<bool> Do(int id)
        {
            var factoryStaff = _ctx.FactoryStaff.FirstOrDefault(x => x.Id == id);
            _ctx.FactoryStaff.Remove(factoryStaff);

            await _ctx.SaveChangesAsync();

            return true;
        }
    }
}
