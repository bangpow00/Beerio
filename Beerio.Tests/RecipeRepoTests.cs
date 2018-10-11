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
            var recipe = new Recipe() { Name = "foo" };
            var ingredient = new Ingredient() { Name = "Ingredient" };
            recipe.AddIngredient(ingredient, 1, RecipeIngredient.Units.oz);

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
