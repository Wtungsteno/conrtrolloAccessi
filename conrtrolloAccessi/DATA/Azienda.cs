namespace conrtrolloAccessi.DATA
{
    public class Azienda
    {
        public int Id { get; set; }
        public required string Nome { get; set; }
        public required List<Dipendente> Dipendenti { get; set; }
    }
}
