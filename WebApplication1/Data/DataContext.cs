using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class DataContext : DbContext {
        public DbSet<Item> Items {get;set;}
        public DataContext(DbContextOptions<DataContext> options):base(options){
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder){
            modelBuilder.Entity<Item>().ToTable("Item");
        }
    }
}