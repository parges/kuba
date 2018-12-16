using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;

namespace kubaapi.Models
{
    public class PatientContext : DbContext
    {
        public PatientContext(DbContextOptions<PatientContext> options) : base(options)
        {
        }

        public DbSet<Patient> Patients { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Patient>().HasData(new Patient
            {
                Id = 1,
                Firstname = "Kleiner",
                Lastname = "Hase",
                Age = 5,
                Address = "Irgendwo 12",
                Description = "Ein ganz lieber Patient"

            }, new Patient
            {
                Id = 2,
                Firstname = "Kleiner",
                Lastname = "Hase 2",
                Age = 5,
                Address = "Irgendwo 22",
                Description = "Ein ganz lieber Patient"

            });
        }
    }
}
