﻿namespace PokemonReviewApp.Model
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //we are using ICollevtion for the many to many relation
        public ICollection<PokemonCategory> PokemonCategories { get; set; }
    }
}
