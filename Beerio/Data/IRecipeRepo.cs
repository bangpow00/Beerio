﻿using Beerio.Models;
using System.Collections.Generic;

namespace Beerio.Data
{
    public interface IRecipeRepo
    {
        void Add(Recipe recipe);
        List<Recipe> Get();
        Recipe Get(int id);
        List<Recipe> Get(string name);
    }
}
