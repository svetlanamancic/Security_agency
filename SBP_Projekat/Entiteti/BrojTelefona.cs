namespace SBP_Projekat.Entiteti
{
    public class BrojTelefona
    {
        public virtual int Id { get; set; }
        public virtual string BrTel { get; set; }
        public virtual RegionalniCentar Centar { get; set; }
    }
}
