using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ContosoUniversity.Data;
using System.Collections.Generic;
using ContosoUniversity.Models;

namespace ContosoUniversity.Controllers
{
    [Route("api/[controller]")]
    public class ApiTestWriterController : Controller
    {
        private readonly SchoolContext _context;

        public ApiTestWriterController(SchoolContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Student> Get()
        {
            var schoolContextFactory = new SchoolContextFactory();
            var schoolContextReader = schoolContextFactory.GetContext(EndpointTypes.Writer);

            var students = from s in schoolContextReader.Students
                           select s;

            return students;
        }
    }
}