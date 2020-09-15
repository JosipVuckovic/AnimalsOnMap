using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AnimalsOnMap.Models;
using AnimalsOnMap.Data.Classes;

namespace AnimalsOnMap.Data
{
    public class AnimalsContext : DbContext
    {        
            public AnimalsContext(DbContextOptions<AnimalsContext> options) : base(options)
            {
            }

            public DbSet<Animal> Animals { get; set; }          

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Animal>().ToTable("Animal");            
        }
     
    }
}
