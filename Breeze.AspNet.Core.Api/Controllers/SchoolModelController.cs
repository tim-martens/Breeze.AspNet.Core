using Breeze.AspNet.Core.Data.Context;
using Breeze.AspNet.Core.Data.Models;
using Breeze.AspNetCore;
using Breeze.Persistence;
using Breeze.Persistence.EF6;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System.Linq;

namespace Breeze.AspNet.Core.Api.Controllers
{
    [Route("breeze/[controller]/[action]")]
    [BreezeQueryFilter]
    public class SchoolModelController : Controller
    {
        private SchoolPersistenceManager PersistenceManager;

        // called via DI 
        public SchoolModelController(SchoolContext context)
        {
            PersistenceManager = new SchoolPersistenceManager(context);
        }

        [HttpGet]
        public IActionResult Metadata()
        {
            return Ok(PersistenceManager.Metadata());
        }
        [HttpPost]
        public SaveResult SaveChanges([FromBody] JObject saveBundle)
        {
            return PersistenceManager.SaveChanges(saveBundle);
        }

        [HttpGet]
        public IQueryable<Student> Students()
        {
            return PersistenceManager.Context.Students.Include("Enrollments");
        }
    }

    internal class SchoolPersistenceManager : EFPersistenceManager<SchoolContext>
    {
        public SchoolPersistenceManager(SchoolContext context) : base(context) { }

        // additional stuff goes here. Checkout the NorthwindIBModelController of the Breeze.AspNetCore.InternalTest.sln in the breeze.server.net repo
        // https://github.com/Breeze/breeze.server.net/blob/master/Tests/Test.AspNetCore/Controllers/NorthwindIBModelController.cs
    }
}
