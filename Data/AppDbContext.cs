using Microsoft.EntityFrameworkCore;

namespace eTickets.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        //AppDbContext = constructor
        //DbContextOptions = Parameter
        //AppDbContext = Parameter Filename
        //options = Parameter name options
        //base = pass the parameter options to baseclass using base keyword
        {

        }
    }
}
