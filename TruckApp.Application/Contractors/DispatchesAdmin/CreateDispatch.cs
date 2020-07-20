using System;
using System.Threading.Tasks;
using TruckApp.Database;
using TruckApp.Domain.Models;

namespace TruckApp.Application.Contractors.DispatchesAdmin
{
    public class CreateDispatch
    {
        private readonly ApplicationDbContext _ctx;

        public CreateDispatch(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        public async Task<Response> Do(Request request)
        {
            var dispatch = new Dispatch
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                Email = request.Email,
                Phone1 = request.Phone1,
                Address1 = request.Address1,
                City = request.City,
                State = request.State,
                ZipCode = request.ZipCode,
                Description = request.Description,
                SS = request.SS,
                CorpName = request.CorpName,
                EIN = request.EIN,
                Rate = request.Rate,
                Status = request.Status,
            };

            _ctx.Dispatches.Add(dispatch);

            await _ctx.SaveChangesAsync();

            return new Response
            {
                Id = dispatch.Id,
                FirstName = dispatch.FirstName,
                LastName = dispatch.LastName,
                Email = dispatch.Email,
                Phone1 = dispatch.Phone1,
                Address1 = dispatch.Address1,
                City = dispatch.City,
                State = dispatch.State,
                ZipCode = dispatch.ZipCode,
                Description = dispatch.Description,
                SS = dispatch.SS,
                CorpName = dispatch.CorpName,
                EIN = dispatch.EIN,
                Rate = dispatch.Rate,
                Created = dispatch.Created.ToString("yyyy-MM-dd"),
                Status = dispatch.Status,
            };
        }

        public class Request
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }
            public string Phone1 { get; set; }
            public string Address1 { get; set; }
            public string City { get; set; }
            public string State { get; set; }
            public string ZipCode { get; set; }

            public string Description { get; set; }
            public decimal Rate { get; set; }

            public string SS { get; set; }
            public string CorpName { get; set; }
            public string EIN { get; set; }

            public string Status { get; set; } // Active, Standby, Deleted.
        }

        public class Response
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }
            public string Phone1 { get; set; }
            public string Address1 { get; set; }
            public string City { get; set; }
            public string State { get; set; }
            public string ZipCode { get; set; }

            public string Description { get; set; }
            public decimal Rate { get; set; }

            public string SS { get; set; }
            public string CorpName { get; set; }
            public string EIN { get; set; }

            public string Created { get; set; }
            public string Status { get; set; } // Active, Standby, Deleted.
        }
    } 
}
