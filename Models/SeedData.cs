using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace MvcStaffboard.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {

            using (var context = new MvcStatusContext(
                serviceProvider.GetRequiredService<DbContextOptions<MvcStatusContext>>() ) )
                {
                    if(context.Status.Any( ))
                    {
                        return; //Db has been sealed
                    }

                    context.Status.AddRange(
                        new Status {
                            Name = "In",
                            IconClassString = "status-in"
                        },

                        new Status {
                            Name = "Out",
                            IconClassString = "status-out"
                        }

                    );
                }


            /*
            using (var context = new MvcUserContext(
                serviceProvider.GetRequiredService<DbContextOptions<MvcUserContext>>() ) )
                {
                    if(context.User.Any( ))
                    {
                        return; //Db has been sealed
                    }

                    context.User.AddRange(
                        new User {
                            FirstName   = "Gene",
                            LastName    = "Culling"
                        }


                    );
                }
             */

              
        }
    }

}

