using Microsoft.EntityFrameworkCore;
using Mission6.Models;
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


            mb.Entity<ApplicationResponse>().HasData(

                new ApplicationResponse
                {
                    Applicationid = 1,
                    Task = "Shopping"
                 
                },

                new ApplicationResponse
                {
                    Applicationid = 1,
                    Task = "Clean"
                },
                new ApplicationResponse
                {
                    Applicationid = 1,
                    Task = "Homework"

                }
              );
        }
    }
}
