using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Beerio.Models;

namespace Beerio.Data
{
    public interface IRecipeRepo
    {
        void Add(Recipe recipe);
        void Update(Recipe recipe);
        void SaveChanges();

        List<Recipe> Get();
        Recipe Get(int id);
        List<Recipe> Get(string name);
    }
}
