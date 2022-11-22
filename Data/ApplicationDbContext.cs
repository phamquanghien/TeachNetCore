using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DemoMVC.Models;

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Student> Student { get; set; } = default!;
        public DbSet<Employee> Employee { get; set; } = default!;

        public DbSet<Faculty> Faculty { get; set; } = default!;
        public DbSet<Person> Person { get; set; }
    }
