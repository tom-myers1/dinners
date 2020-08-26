using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dinners.Data
{
    public class ProductDbContext : DbContext
    {
        #region Contructor
        public ProductDbContext(DbContextOptions<ProductDbContext> options)
                : base(options)
        {

        }
        #endregion

        #region Public properties
        public DbSet<Recipes> Recipes { get; set; }

        public DbSet<Ingredients> Ingredients { get; set; }
        #endregion

        #region Overidden methods
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Recipes>().HasData(GetProducts());
            base.OnModelCreating(modelBuilder);
        }
        #endregion


        #region Private methods
        private List<Recipes> GetProducts()
        {
            return new List<Recipes>
    {
        new Recipes { Id = 99991, Title = "Laptop", Servings = 1},
        new Recipes { Id = 99992, Title = "Microsoft Office", Servings = 2},
        new Recipes { Id = 99993, Title = "Lazer Mouse", Servings = 1},
        new Recipes { Id = 99994, Title = "USB Storage", Servings = 2}
    };
        }
        #endregion
    }
}
