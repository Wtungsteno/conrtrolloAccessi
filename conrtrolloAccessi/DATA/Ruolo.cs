namespace conrtrolloAccessi.DATA
{
    public class Ruolo
    {
        public int Id { get; set; }
        public required string Nome { get; set; }
        public required List<Utente> Utenti { get; set; }
    }
}
