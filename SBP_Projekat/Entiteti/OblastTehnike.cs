namespace SBP_Projekat.Entiteti
{
    public class OblastTehnike
    {
        public virtual int Id { get; set; }
        public virtual string ObTeh { get; set; }
        public virtual TehnickoLice TehLice { get; set; }
    }
}
