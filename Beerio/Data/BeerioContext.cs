using Beerio.Models;
using Microsoft.EntityFrameworkCore;

namespace Beerio.Data
{
    public class BeerioContext : DbContext
    {
        public BeerioContext(DbContextOptions<BeerioContext> options) : base(options)
        {
        }

        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<RecipeIngredient> RecipeIngredients { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Recipe>().ToTable("Recipe");
            modelBuilder.Entity<Ingredient>().ToTable("Ingredient");
            modelBuilder.Entity<RecipeIngredient>().ToTable("RecipeIngredient");
        }
    }
}
