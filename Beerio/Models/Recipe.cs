using Beerio.Exceptions;
using System;
using System.Collections.Generic;

namespace Beerio.Models
{
    public class Recipe
    {
        public int ID { get; set; } = 0;

        public string Name { get; set; }

        public string Creator { get; set; }

        public string Notes { get; set; }

        public string Tempature { get; set; }

        public string Time { get; set; }

        public List<RecipeIngredient> RecipeIngredients { get; set; } = new List<RecipeIngredient> { };

        public void AddIngredient(Ingredient ingredient, float quantity, RecipeIngredient.Units units)
        {
            CustomContract.Requires<ArgumentNullException>(ingredient != null);
            CustomContract.Requires<ArgumentNullException>(quantity > float.Epsilon);

            RecipeIngredients.Add(new RecipeIngredient() { IngredientID = ingredient.ID, Quantity = quantity, Unit = (int)units });
        }

    }
}
