using System.Linq;
using System.Threading.Tasks;
using TruckApp.Database;

namespace TruckApp.Application.Contractors.DispatchesAdmin
{
    public class UpdateDispatch
    {
        private readonly ApplicationDbContext _ctx;

        public UpdateDispatch(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        public async Task<Response> Do(Request request)
        {
            var dispatch = _ctx.Dispatches.FirstOrDefault(x => x.Id == request.Id);

            dispatch.FirstName = request.FirstName;
            dispatch.LastName = request.LastName;
            dispatch.Email = request.Email;
            dispatch.Phone1 = request.Phone1;
            dispatch.Address1 = request.Address1;
            dispatch.City = request.City;
            dispatch.State = request.State;
            dispatch.ZipCode = request.ZipCode;
            dispatch.Description = request.Description;
            dispatch.Rate = request.Rate;
            dispatch.SS = request.SS;
            dispatch.CorpName = request.CorpName;
            dispatch.EIN = request.EIN;
            dispatch.Status = request.Status;

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
                Rate = dispatch.Rate,

                SS = dispatch.SS,
                CorpName = dispatch.CorpName,
                EIN = dispatch.EIN,

                Created = dispatch.Created.ToString("yyyy-MM-dd"),
                Status = dispatch.Status,

            };
        }

        public class Request
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
