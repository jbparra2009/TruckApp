using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TruckApp.Database;

namespace TruckApp.Application.Contractors.BrokerStaffAdmin
{
    public class DeleteBrokerStaff
    {
        private readonly ApplicationDbContext _ctx;

        public DeleteBrokerStaff(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        public async Task<bool> Do(int id)
        {
            var brokerStaff = _ctx.BrokerStaff.FirstOrDefault(x => x.Id == id);
            _ctx.BrokerStaff.Remove(brokerStaff);

            await _ctx.SaveChangesAsync();

            return true;
        }
    }
}
