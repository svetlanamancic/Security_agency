namespace SBP_Projekat.Entiteti
{
    public class BorilackaVestina
    {
        public virtual int Id { get; set; }
        public virtual string Vestina { get; set; }
        public virtual FizickoObezbedjenje FizOb { get; set; }
    }
}
