using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace mission6.Models
{
    public class ApplicationContext : DbContext
    {
        // constructor
      public ApplicationContext(DbContextOptions<ApplicationContext> options) : base (options)
        {  // Blank
         
        }

      //Seed Data
      public DbSet<ApplicationResponse> NewResponses { get; set; }
      public DbSet<Task> Task { get; set; }
      

        protected override void OnModelCreating(ModelBuilder mb)
        {
      

            mb.Entity<ApplicationResponse>().HasData(


                new ApplicationResponse
                {
                    ApplicationId = 1,

                    Task = "IS Homework",
                 
                },
                new ApplicationResponse
                {
                    ApplicationId = 2,

                    Task = "Spending time with wife",
                
                
                },
                new ApplicationResponse
                {
                    ApplicationId = 3,

                    Task = "Intern",
            
                }



                );
        }
    }
}
