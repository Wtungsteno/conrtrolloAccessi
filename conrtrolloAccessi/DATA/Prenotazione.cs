namespace conrtrolloAccessi.DATA
{
    public class Prenotazione
    {
        public int Id { get; set; }
        public required string Data { get; set; }
        public required string Ora { get; set; }
        public required string Luogo { get; set; }
        public int? DipendenteId { get; set; }
        public Dipendente? Dipendente { get; set; }
    }
}
