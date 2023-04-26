using Microsoft.EntityFrameworkCore;
using EntityFrameworkLearn.Models;
using System.Configuration;

namespace EntityFrameworkLearn.Data
{

    public class UserContext : DbContext
    {
    
        public DbSet<User> Users { get; set; }
        public DbSet<Car> Cars { get; set; }
        

        public string DbPath;

        public UserContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "blogging.db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlite($"Data Source={DbPath}");
    }
}
