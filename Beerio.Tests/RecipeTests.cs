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
            recipe.AddIngredient(ingredient, 1, RecipeIngredient.Units.gal);

            var l = recipe.RecipeIngredients;

            Assert.IsTrue(l.Count == 1);
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentNullException))]
        public void TestNullIngredientException()
        {
            var recipe = new Recipe() { Name = "no ingredient" };

            recipe.AddIngredient(null, 1, RecipeIngredient.Units.oz);

        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentNullException))]
        public void TestNullQuantityException()
        {
            var recipe = new Recipe() { Name = "no quantity" };
            var ingredient = new Ingredient() { Name = "hops" };

            recipe.AddIngredient(ingredient, 0, RecipeIngredient.Units.lb);

        }

    }
}
