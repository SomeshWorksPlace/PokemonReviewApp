namespace PokemonReviewApp.Model
{
    public class Reviewer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //we are using ICollevtion for the many to many relation
        public ICollection<Review> Reviews { get; set; }

    }
}
