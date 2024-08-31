namespace PokemonReviewApp.Model
{
    public class Owner
    {

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gym { get; set; }
        ////for one to one relation we will not create an Icollection
        public Country Country { get; set; }

        //we are using ICollevtion for the many to many relation
        public ICollection<PokemonOwner> PokemonOwners { get; set; }
    }
}
