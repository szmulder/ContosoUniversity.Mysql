using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ContosoUniversity.Data;
using System.Collections.Generic;
using ContosoUniversity.Models;

namespace ContosoUniversity.Controllers
{
    [Route("api/[controller]")]
    public class ApiFactoryController : Controller
    {
        private readonly SchoolContext _context;

        public ApiFactoryController(SchoolContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Student> Get()
        {
            var schoolContextFactory = new SchoolContextFactory();
            var schoolContextWriter = schoolContextFactory.GetContext(EndpointTypes.Writer);
            var schoolContextReader = schoolContextFactory.GetContext(EndpointTypes.Reader);

            var students = from s in schoolContextReader.Students
                           select s;

            return students;
        }
    }
}