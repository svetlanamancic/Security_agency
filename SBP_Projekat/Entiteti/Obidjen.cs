namespace SBP_Projekat.Entiteti
{
    public class Obidjen
    {
        public virtual int Id { get; set; }
        public virtual Smena IdSmene { get; set; }
        public virtual Objekat IdObjekta { get; set; }
    }
}
