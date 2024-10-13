namespace SBP_Projekat.Entiteti
{
    public class GradMenadzer
    {
        public virtual int Id { get; set; }
        public virtual string Grad { get; set; }
        public virtual Menadzer MenadzerGrada { get; set; }
    }
}
