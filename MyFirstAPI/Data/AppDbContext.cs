using Microsoft.EntityFrameworkCore;
using MyFirstAPI.Models;

namespace MyFirstAPI.Data
{
    public class AppDbContext: DbContext
    {
        public DbSet<Todo> Todos { get; set; }
        //prodected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlite("Data Source=app.db");
    }
}
