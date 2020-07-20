using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;
using TruckApp.Database;
using TruckApp.Domain.Models;

namespace TruckApp.Application.Contractors.DriversAdmin
{
    public class CreateDriver
    {
        private readonly ApplicationDbContext _ctx;

        public CreateDriver(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        public async Task<Response> Do(Request request)
        {
            var driver = new Driver
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

                Rate = request.Rate,
                CorpName = request.CorpName,
                EIN = request.EIN,

                SS = request.SS,
                DOB = DateTime.Parse(request.DOB),
                CDLClass = request.CDLClass,
                CDLIssued = DateTime.Parse(request.CDLIssued),
                CDLExpires = DateTime.Parse(request.CDLExpires),
                CDLState = request.CDLState,

                Status = request.Status,
            };

            _ctx.Drivers.Add(driver);

            await _ctx.SaveChangesAsync();

            return new Response
            {
                Id = driver.Id,
                FirstName = driver.FirstName,
                LastName = driver.LastName,
                Email = driver.Email,
                Phone1 = driver.Phone1,
                Address1 = driver.Address1,
                City = driver.City,
                State = driver.State,
                ZipCode = driver.ZipCode,
                Description = driver.Description,

                Rate = driver.Rate,
                CorpName = driver.CorpName,
                EIN = driver.EIN,

                SS = driver.SS,
                DOB = driver.DOB.ToString("yyyy-MM-dd"),
                CDLClass = driver.CDLClass,
                CDLIssued = driver.CDLIssued.ToString("yyyy-MM-dd"),
                CDLExpires = driver.CDLExpires.ToString("yyyy-MM-dd"),
                CDLState = driver.CDLState,

                Created = driver.Created.ToString("yyyy-MM-dd"),
                Status = driver.Status,
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

            public string CorpName { get; set; }
            public string EIN { get; set; }

            public string SS { get; set; }
            public string DOB { get; set; }
            public string CDLClass { get; set; }
            public string CDLIssued { get; set; }
            public string CDLExpires { get; set; }
            public string CDLState { get; set; }

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

            public string CorpName { get; set; }
            public string EIN { get; set; }

            public string SS { get; set; }
            public string DOB { get; set; }
            public string CDLClass { get; set; }
            public string CDLIssued { get; set; }
            public string CDLExpires { get; set; }
            public string CDLState { get; set; }

            public string Created { get; set; }
            public string Status { get; set; } // Active, Standby, Deleted.
        }
    }
}
