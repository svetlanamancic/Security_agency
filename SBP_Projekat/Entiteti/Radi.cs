namespace SBP_Projekat.Entiteti
{
    public class Radi
    {
        public virtual int Id { get; set; }

        public virtual Ekipa Ekipica { get; set; }
        public virtual Smena RadiUSmeni { get; set; }
    }
}
