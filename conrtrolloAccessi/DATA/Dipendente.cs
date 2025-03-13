using System.ComponentModel.DataAnnotations.Schema;

namespace conrtrolloAccessi.DATA
{
    public class Dipendente
    {
        public int Id { get; set; }
        public required string Nome { get; set; }
        public required string Cognome { get; set; }
        public required string Mansione { get; set; }
        public int AziendaId { get; set; }
        [ForeignKey(nameof(AziendaId))]
        public Azienda? Azienda { get; set; }

    }
}
