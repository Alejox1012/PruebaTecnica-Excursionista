namespace PruebaTecnica.Models
{
    public class ConsultaOptimizar
    {
        // Representa la "cantidad mínima de calorías" exigida [1]
        public int MinCalorias { get; set; }

        // Representa el "peso máximo que se puede llevar" [1]
        public int MaxPeso { get; set; }

        // Es la lista de objetos (E1, E2, E3...) que el usuario desea evaluar [1]
        public List<Elemento> Elementos { get; set; }
    }
}