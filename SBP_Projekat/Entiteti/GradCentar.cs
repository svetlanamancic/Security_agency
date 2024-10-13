namespace SBP_Projekat.Entiteti
{
    public class GradCentar
    {
        public virtual int Id { set; get; }

        public virtual string Grad { set; get; }

        public virtual RegionalniCentar Centar { get; set; }
    }
}
