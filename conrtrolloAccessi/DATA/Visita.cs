using System.ComponentModel.DataAnnotations.Schema;

namespace conrtrolloAccessi.DATA
{
    public class Visita
    {
        public int Id { get; set; }
        public required string Luogo { get; set; }
        public int DipendenteId { get; set; }
        [ForeignKey(nameof(DipendenteId))]
        public required Dipendente Dipendente { get; set; }
    }
}
