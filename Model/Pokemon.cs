using Microsoft.AspNetCore.Mvc.ViewEngines;

namespace PokemonReviewApp.Model
{
    public class Pokemon
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }

        //we are using ICollevtion for the many to many relation
        public ICollection<Review> Reviews { get; set; }

        public ICollection<PokemonOwner> PokemonOwners { get; set; }

        public ICollection<PokemonCategory> PokemonCategories { get; set; }
    }
}
