namespace Beerio.Models
{
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

    public class RecipeIngredient
    {

        public int ID { get; set; }

        public int RecipeID { get; set; }

        public int IngredientID { get; set; }

        public float Quantity { get; set; }

        public Units Unit { get; set; }

    }
}
