namespace PokemonReviewApp.Model
{
    public class PokemonCategory
    {
        public int PokemonId { get; set; }
        public int CategoryId { get; set; }
        /*  public Pokemon Pokemon { get; set; }
          public Category Category { get; set; }*/

        //for one to one relation we will not create an Icollection
        public Pokemon Pokemon { get; set; }
        public Category Category { get; set; }
    }
}
