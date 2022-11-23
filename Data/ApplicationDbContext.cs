using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DemoMVC.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace DemoMVC.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating (ModelBuilder builder) {
            base.OnModelCreating (builder);
            // Remove AspNet prefix of tables default
            foreach (var entityType in builder.Model.GetEntityTypes ()) {
                var tableName = entityType.GetTableName ();
                if (tableName.StartsWith ("AspNet")) {
                    entityType.SetTableName (tableName.Substring (6));
                }
            }
        }
    }
}