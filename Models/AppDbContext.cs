using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace TodoListMVC.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<TaskItem> Tasks { get; set; }
    }
}
