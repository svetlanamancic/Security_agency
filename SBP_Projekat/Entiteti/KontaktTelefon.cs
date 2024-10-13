namespace SBP_Projekat.Entiteti
{
    public class KontaktTelefon
    {
        public virtual int Id { get; set; }

        public virtual string Telefon { get; set; }

        public virtual Objekat IdObjekta { get; set; }
    }
}
