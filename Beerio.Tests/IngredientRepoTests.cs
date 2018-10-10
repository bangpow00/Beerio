using Microsoft.VisualStudio.TestTools.UnitTesting;
using Beerio.Data;
using Beerio.Models;

namespace Beerio.Tests
{
    [TestClass]
    public class IngredientRepoTests
    {
        private IngredientRepo repo;

        [TestInitialize]
        public void TestInit()
        {
            repo = new IngredientRepo();
        }

        [TestMethod]
        public void TestCreateRepo()
        {
            Assert.IsTrue(repo.Count() > 0);
        }

        [TestMethod]
        public void TestClearRepo()
        {
            repo.ClearIngredientsForTesting();

            Assert.IsTrue(repo.Count() == 0);
        }

        [TestMethod]
        public void TestAddIngredientCount()
        {
            var cnt = repo.Count();

            repo.Add(new Ingredient() { Name = "foo123" });
            
            Assert.IsTrue(repo.Count() == cnt + 1);
        }

        [TestMethod]
        public void TestAddIngredient()
        {
            var name = "foo321";

            repo.Add(new Ingredient() { Name = name });

            var ingredient = repo.Get(name);

            Assert.IsNotNull(ingredient);
            Assert.IsTrue(ingredient.Name == name);
        }

        [TestMethod]
        public void TestSearchIngredients()
        {
            repo.ClearIngredientsForTesting();

            var name = "foo";

            repo.Add(new Ingredient() { Name = name.ToLower() });
            repo.Add(new Ingredient() { Name = name.ToUpper() });
            repo.Add(new Ingredient() { Name = "xxx" + name });
            repo.Add(new Ingredient() { Name = name + "1" });
            repo.Add(new Ingredient() { Name = name + "o" });
            repo.Add(new Ingredient() { Name = "ooo" });
            repo.Add(new Ingredient() { Name = "fff" });

            var ingredients = repo.Search(name);

            Assert.IsNotNull(ingredients);
            Assert.IsTrue(ingredients.Count == 5);
        }

        [TestMethod]
        public void TestNotFoundSearchIngredients()
        {
            var ingredients = repo.Search("1234567890");

            Assert.IsNotNull(ingredients);
            Assert.IsTrue(ingredients.Count == 0);
        }
    }
}
