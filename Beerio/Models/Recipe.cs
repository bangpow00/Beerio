using Beerio.Exceptions;
using System;
using System.Collections.Generic;

namespace Beerio.Models
{
    public class Recipe
    {
        public int ID { get; set; } = 0;

        public string Name { get; set; }

        public List<RecipeIngredient> RecipeIngredients { get; }

        public Recipe(string name)
        {
            Name = name;
            RecipeIngredients = new List<RecipeIngredient>();
        }

        public void AddIngredient(Ingredient ingredient, Quantity quantity)
        {
            CustomContract.Requires<ArgumentNullException>(ingredient != null);
            CustomContract.Requires<ArgumentNullException>(quantity != null);

            RecipeIngredients.Add(new RecipeIngredient() { Ingredient = ingredient, Quantity = quantity });
        }

        public void Print()
        {
            Console.WriteLine(Name);
            foreach (var r in RecipeIngredients)
            {
                Console.WriteLine("* {0}: {1} {2}", 
                                r.Ingredient.Name, 
                                r.Quantity.Value, 
                                r.Quantity.Units);
            }
        }

        public override string ToString()
        {
            string s = new string(Name + "\n");
            foreach (var r in RecipeIngredients)
            {
                s += ("* " + r.Ingredient.Name + 
                      ": " + r.Quantity.Value + 
                      " " + r.Quantity.Units);
            }
            return s;
        }
    }
}
