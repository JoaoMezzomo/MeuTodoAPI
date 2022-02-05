using MeuTodoAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace MeuTodoAPI.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Todo> Todos { get; set; }

        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlite(connectionString:"DataSource=app.db;Cache=Shared");
    }    
}