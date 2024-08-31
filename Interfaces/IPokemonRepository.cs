using PokemonReviewApp.Model;
using PokemonReviewApp.Dto;

namespace PokemonReviewApp.Interfaces
{
    public interface IPokemonRepository
    {
        ICollection<Pokemon> GetPokemons();
        Pokemon GetPokemon(int id);
        Pokemon GetPokemon(string name);
        
        Pokemon GetPokemonTrimToUpper(PokemonDto spokemonCreate);
        decimal GetPokemonRating(int pokeId);
        bool PokemonExists(int pokeId);

        //Crud 
        bool CreatePokemon(int ownerId, int categoryId, Pokemon pokemon);
        bool UpdatePokemon(int ownerId, int categoryId, Pokemon pokemon);
        bool DeletePokemon(Pokemon pokemon);
        bool Save();
    }
}
