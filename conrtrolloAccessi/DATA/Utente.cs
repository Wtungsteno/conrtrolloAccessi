using System.ComponentModel.DataAnnotations.Schema;

namespace conrtrolloAccessi.DATA
{
    public class Utente
    {
        public int Id { get; set; }
        public required string Nome { get; set; }
        public required string Cognome { get; set; }
        public required string Email { get; set; }
        public required string Password { get; set; }
        public int RuoloId { get; set; }
        [ForeignKey(nameof(RuoloId))]
        public required Ruolo Ruolo { get; set; }
    }
}
