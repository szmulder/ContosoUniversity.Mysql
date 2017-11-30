using ContosoUniversity.Models;
using Microsoft.EntityFrameworkCore;

namespace ContosoUniversity.Data
{
    public class SchoolReaderContext : SchoolContext
    {
        public SchoolReaderContext(DbContextOptions<SchoolContext> options) 
            : base(options)
        {
        }
    }
}
