namespace PokemonReviewApp.Model
{
    public class Review
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public int Rating { get; set; }
        //----------------------------------------------------------------------------
        //for one to one relation we will not create an Icollection
        public Reviewer Reviewer { get; set; }
        public Pokemon pokemon { get; set; }

    }
}
