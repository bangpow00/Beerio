using Microsoft.VisualStudio.TestTools.UnitTesting;
using Beerio.Data;
using Beerio.Models;

namespace Beerio.Tests
{
    [TestClass]
    public class RecipeRepoTests
    {
        private RecipeRepo repo;

        [TestInitialize]
        public void TestInit()
        {
            repo = new RecipeRepo();
        }

        [TestMethod]
        public void TestAddRecipe()
        {
            var recipe = new Recipe("foo");
            var ingredient = new Ingredient() { Name = "Ingredient" };
            var quantity = new Quantity() { Value = "1", Units = "Gal" };
            recipe.AddIngredient(ingredient, quantity);

            repo.Add(recipe);

            var result = repo.Get(recipe.Name);

            Assert.IsTrue(result.Count == 1);
            Assert.IsTrue(result[0].Name == recipe.Name);
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentNullException))]
        public void TestAddNullRecipeException()
        {
            repo.Add(null);
        }
    }
}
