using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//This page provides seeding for the database tables
namespace _413Mission06.Models
{
    public class TaskInfoCOntext : DbContext
    {
        //Constructor
        public TaskInfoCOntext(DbContextOptions<TaskInfoCOntext> options) : base(options)
        {
            //Leave blank for now
        }

        public DbSet<ApplicationResponse> R { get; set; }
        public DbSet<Task> Tasks { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {

            mb.Entity<Task>().HasData(

                  
                );

            mb.Entity<ApplicationResponse>().HasData(

                new ApplicationResponse
                {
                    TaskID = 1,
                    Task = "Shopping"
                 
                },

                new ApplicationResponse
                {
                    TaskID = 1,
                    Task = "Clean"
                },
                new ApplicationResponse
                {
                    TaskID = 1,
                    Task = "Homework"

                }
              );
        }
    }
}
