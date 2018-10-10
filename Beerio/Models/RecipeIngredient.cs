namespace Beerio.Models
{
    // a Recipe is made up of a group of this class.
    public class RecipeIngredient
    {
        public Ingredient Ingredient { get; set; }

        public Quantity Quantity { get; set; }
    }
}
