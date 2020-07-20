﻿using System.Linq;
using System.Threading.Tasks;
using TruckApp.Database;

namespace TruckApp.Application.Contractors.DispatchesAdmin
{
    public class DeleteDispatch
    {
        private readonly ApplicationDbContext _ctx;

        public DeleteDispatch(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        public async Task<bool> Do(int id)
        {
            var Dispatch = _ctx.Dispatches.FirstOrDefault(x => x.Id == id);
            _ctx.Dispatches.Remove(Dispatch);

            await _ctx.SaveChangesAsync();

            return true;
        }
    } 
}
