using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;


namespace MvcStaffboard.Models
{

    public static class DBinitialize
    {

        public static void EnsureCreated(IServiceProvider serviceProvider)
        {

            var statusContext = new MvcStatusContext(
                serviceProvider.GetRequiredService<DbContextOptions<MvcStatusContext>>());
            statusContext.Database.EnsureCreated();
            
            var userContext = new MvcUserContext(
                serviceProvider.GetRequiredService<DbContextOptions<MvcUserContext>>());
            userContext.Database.EnsureCreated();
            
        }
    }    
}
