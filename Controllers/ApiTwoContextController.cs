using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ContosoUniversity.Data;
using System.Collections.Generic;
using ContosoUniversity.Models;

namespace ContosoUniversity.Controllers
{
    [Route("api/[controller]")]
    public class ApiTwoContextController : Controller
    {
        private readonly SchoolContext _context;
        private readonly SchoolContext _readerContext;

        public ApiTwoContextController(SchoolContext context, SchoolReaderContext readerContext)
        {
            _context = context;
            _readerContext = readerContext;
        }

        [HttpGet]
        public IEnumerable<Student> Get()
        {            
            var students = from s in _readerContext.Students
                           select s;

            return students;
        }
    }
}