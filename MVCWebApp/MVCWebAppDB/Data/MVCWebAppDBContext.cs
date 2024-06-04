using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCWebAppDB.Models;

namespace MVCWebAppDB.Data
{
    public class MVCWebAppDBContext : DbContext
    {
        public MVCWebAppDBContext (DbContextOptions<MVCWebAppDBContext> options)
            : base(options)
        {
        }

        public MVCWebAppDBContext()
        {
        }

        public DbSet<Employee> Employees { get; set; }

        public string connectionString = @"Data Source=DESKTOP-0E2DNFV\SQLEXPRESS;Initial Catalog=EntityFramework;Integrated Security=True;Connect Timeout=30;Encrypt=False";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
