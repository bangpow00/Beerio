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
            var recipe = new Recipe("foo");
            var ingredient = new Ingredient() { Name = "Ingredient" };
            var quantity = new Quantity() { Value = "1", Units = "Gal" };
            recipe.AddIngredient(ingredient, quantity);

            var l = recipe.RecipeIngredients;

            Assert.IsTrue(l.Count == 1);
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentNullException))]
        public void TestNullIngredientException()
        {
            var recipe = new Recipe("no ingredient");
            var quantity = new Quantity() { Value = "1", Units = "Gal" };

            recipe.AddIngredient(null, quantity);

        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentNullException))]
        public void TestNullQuantityException()
        {
            var recipe = new Recipe("no quantity");
            var ingredient = new Ingredient() { Name = "Ingredient" };

            recipe.AddIngredient(ingredient, null);

        }

        [TestMethod]
        public void TestRecipeToString()
        {
            var recipe = new Recipe("yuck");
            recipe.AddIngredient(
                new Ingredient() { Name = "water" },
                new Quantity() { Value = "12", Units = "oz" }
                );
            recipe.AddIngredient(
                new Ingredient() { Name = "hops" },
                new Quantity() { Value = "1", Units = "cup" }
            );

            var s = recipe.ToString();

            Assert.IsFalse(string.IsNullOrEmpty(s));
            Assert.IsTrue(s.Contains("yuck"));
        }

    }
}
