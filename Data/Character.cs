using System.ComponentModel.DataAnnotations;

namespace ProyectoMatematicasDiscretas.Data
{
    public class Character
    {
        public char Symbol { get; set; }

        [Range(0, 200, ErrorMessage = "El rango de pesos va de 0 a 200")]
        public int Weight { get; set; }
        
        public string Code { get; set; } = string.Empty;

        public Character? Left { get; set; } = null;
        
        public Character? Right { get; set; } = null;

    }
}
