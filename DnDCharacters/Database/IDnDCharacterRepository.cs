using DnDCharacters.Models;

namespace DnDCharacters.Database
{
    public interface IDnDCharacterRepository
    {
        void AddCharacter(Character character);

        List<Character> GetAllCharacters();
    }
}
