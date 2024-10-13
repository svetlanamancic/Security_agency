namespace SBP_Projekat.Entiteti
{
    public class JeZaduzena
    {
        public virtual int Id { get; set; }
        public virtual Ekipa ZaduzenaEkipa { get; set; }
        public virtual Objekat ZaduzenaZaObjekat { get; set; }
    }
}
