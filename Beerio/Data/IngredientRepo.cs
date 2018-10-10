using Beerio.Exceptions;
using Beerio.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Beerio.Data
{
    public class IngredientRepo : IIngredientRepo
    {
        private List<Ingredient> ingredients;

        public IngredientRepo()
        {
            // for this test, I won't setup a database, but will simply create a runtime
            // list.
            ingredients = new List<Ingredient>
            {
                new Ingredient() {Name = "Water" },
                new Ingredient() {Name = "Hops" },
                new Ingredient() {Name = "Barley" },
                new Ingredient() {Name = "Malted Barley" },
                new Ingredient() {Name = "Wheat" },
                new Ingredient() {Name = "Yeast" },
            };
        }

        public int Count()
        {
            return ingredients.Count();
        }

        public Ingredient Get(string name)
        {
            return ingredients.Where(x => x.Name == name).FirstOrDefault();
        }


        public void Add(string name)
        {
            CustomContract.Requires<ArgumentNullException>(!string.IsNullOrWhiteSpace(name));

            if (ingredients.Any(x => x.Name == name))
            {
                return;
            }

            ingredients.Add(new Ingredient() { Name = name });
        }

        public void Add(Ingredient ingredient)
        {
            CustomContract.Requires<ArgumentNullException>(ingredient != null);

            if ( ingredients.Any(x => x.Name == ingredient.Name))
            {
                return;
            }

            ingredients.Add(ingredient);
        }

        public List<Ingredient> Search(string pattern)
        {
            return ingredients.Where(x => 
                    x.Name.IndexOf(pattern, 0, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
        }

        public void ClearIngredientsForTesting()
        {
            ingredients.Clear();
        }
    }
}
