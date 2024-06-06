using Microsoft.EntityFrameworkCore;

using MvcRegisterFormApp.Models;

namespace MvcRegisterFormApp.DataContext
{
    public class DbContextRegisterForm:DbContext
    {
        public DbSet<RegisterForm> RegisterForms { get; set; }

        public string conString = @"server=localhost;port=3306;user=root;password=password;database=practice;";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL(conString);
        }
    }
}
