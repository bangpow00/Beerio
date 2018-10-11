using Beerio.Models;
using System;
using System.Linq;

namespace Beerio.Data
{
    public static class DbInitializer
    {
        public static void Initialize(BeerioContext context)
        {
            context.Database.EnsureCreated();

            if (context.Ingredients.Any())
            {
                return;
            }

            var ingredients = new Ingredient[]
            {
                new Ingredient{Name = "Water"},
                new Ingredient{Name = "Hops"},
                new Ingredient{Name = "Barley"},
                new Ingredient{Name = "Wheat"},
                new Ingredient{Name = "Yeast"},
                new Ingredient{Name = "Blueberries"}
            };
            foreach (Ingredient ing in ingredients)
            {
                context.Ingredients.Add(ing);
            }
            context.SaveChanges();

            
            var recipes = new Recipe[]
            {
                new Recipe{Name="Yuck", Creator="Tim", Temperature="100", Time="1 HR"}
            };
            foreach (Recipe r in recipes)
            {
                context.Recipes.Add(r);
            }
            context.SaveChanges();


            var recipeingredients = new RecipeIngredient[]
            {
                new RecipeIngredient{RecipeID=1, IngredientID=1, Quantity=1, Unit=Units.gal},
                new RecipeIngredient{RecipeID=1, IngredientID=2, Quantity=10, Unit=Units.oz},
                new RecipeIngredient{RecipeID=1, IngredientID=6, Quantity=2, Unit=Units.cup}
            };
            foreach (RecipeIngredient ri in recipeingredients)
            {
                context.RecipeIngredients.Add(ri);
            }
            context.SaveChanges();

        }
    }
}
