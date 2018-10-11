namespace Beerio.Models
{
    // a Recipe is made up of a group of this class.
    public class RecipeIngredient
    {

        public int ID { get; set; }

        public int RecipeID { get; set; }

        public int IngredientID { get; set; }

        public float Quantity { get; set; }

        public int Unit { get; set; }
    }

    public enum Units
    {
        gal = 1,
        tb,
        oz,
        qt,
        ml,
        l,
        lb,
        g,
        kg,
        cup
    }
}
