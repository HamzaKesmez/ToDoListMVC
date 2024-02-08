using Microsoft.EntityFrameworkCore;

namespace ToDoListMVC.Models
{ 
    public class Contex : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=MSI; database=ToDoList; user=sa; password=1234; TrustServerCertificate=True;");
        }
    public DbSet<List> Lists
        { 
        get; set; 
         }
    }
}
