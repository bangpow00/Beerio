using Beerio.Models;
using System.Collections.Generic;

namespace Beerio.Data
{
    public interface IIngredientRepo
    {
        Ingredient Get(string name);
        void Add(string name);
        void Add(Ingredient ingredient);
        List<Ingredient> Search(string pattern);
        int Count();
    }
}
