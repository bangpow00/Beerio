using Beerio.Exceptions;
using Beerio.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Beerio.Data
{
    public class RecipeRepo : IRecipeRepo
    {
        private List<Recipe> recipes;

        public RecipeRepo()
        {
            recipes = new List<Recipe>();
        }

        public void Add(Recipe recipe)
        {
            CustomContract.Requires<ArgumentNullException>(recipe != null);

            recipe.ID = recipes.Count() + 1;
            recipes.Add(recipe);
        }

        public List<Recipe> Get()
        {
            List<Recipe> r = new List<Recipe>(recipes);
            return r;
        }

        public Recipe Get(int id)
        {
            return recipes.Where(x => x.ID == id).FirstOrDefault();
        }

        public List<Recipe> Get(string name)
        {
            return recipes.Where(x => x.Name == name).ToList();
        }
    }
}
