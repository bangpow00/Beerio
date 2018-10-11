using Microsoft.VisualStudio.TestTools.UnitTesting;
using Beerio.Models;


namespace Beerio.Tests
{
    [TestClass]
    public class RecipeTests
    {
        [TestMethod]
        public void TestRecipe()
        {
            var recipe = new Recipe() { Name = "foo" };
            var ingredient = new Ingredient() { Name = "water" };
            recipe.AddRecipeIngredient(ingredient, 1, Units.gal);

            var l = recipe.RecipeIngredients;

            Assert.IsTrue(l.Count == 1);
        }

        [TestMethod]
        public void TestRecipeIngredients()
        {
            var recipe = new Recipe() { Name = "test 2" };
            recipe.AddRecipeIngredient(new Ingredient() { Name = "water" },
                                        1, Units.gal);
            recipe.AddRecipeIngredient(new Ingredient() { Name = "hops" },
                                       2, Units.cup);
            recipe.AddRecipeIngredient(new Ingredient() { Name = "yeast" },
                           5, Units.oz);

            var l = recipe.RecipeIngredients;

            Assert.IsTrue(l.Count == 3);
        }


        [TestMethod]
        [ExpectedException(typeof(System.ArgumentNullException))]
        public void TestNullIngredientException()
        {
            var recipe = new Recipe() { Name = "no ingredient" };

            recipe.AddRecipeIngredient(null, 1, Units.oz);

        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentNullException))]
        public void TestNullQuantityException()
        {
            var recipe = new Recipe() { Name = "no quantity" };
            var ingredient = new Ingredient() { Name = "hops" };

            recipe.AddRecipeIngredient(ingredient, 0, Units.lb);

        }

    }
}
