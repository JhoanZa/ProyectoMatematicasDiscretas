namespace ProyectoMatematicasDiscretas.Data
{
    public class CharacterService
    {
        public Task<List<Character>> GetCharactersListAsync()
        {
            List<Character> characters = new();

            for (char c = 'A'; c <= 'Z'; c++)
            {
                characters.Add(new Character()
                {
                    Symbol = c,
                    Weight = 0,
                });
            }
            return Task.FromResult(characters);
        }
    }
}
