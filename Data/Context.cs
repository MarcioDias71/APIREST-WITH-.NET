using Core.Domain;
using Microsoft.EntityFrameworkCore;

namespace Data
{
  

    public class Context: DbContext
    {
        public DbSet<Cliente>  Cliente { get; set; }

        public Context(DbContextOptions options) : base(options)
        {
            
        }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

         
        }

    }


    
    
}