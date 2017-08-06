using Microsoft.EntityFrameworkCore;

namespace MvcStaffboard.Models
{
    public class MvcUserContext : DbContext
    {
        public MvcUserContext (DbContextOptions<MvcUserContext> options) : base(options)
        {

        }

        public DbSet<MvcStaffboard.Models.User> User {get; set;}
    }
}