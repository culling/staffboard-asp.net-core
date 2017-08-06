using Microsoft.EntityFrameworkCore;

namespace MvcStaffboard.Models
{
    public class MvcStatusContext : DbContext
    {
        public MvcStatusContext (DbContextOptions<MvcStatusContext> options) : base(options)
        {

        }

        public DbSet<MvcStaffboard.Models.Status> Status { get; set; }
    }
}