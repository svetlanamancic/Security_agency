namespace SBP_Projekat.Entiteti
{
    public class StrucnaSprema
    {
        public virtual int Id { get; set; }
        public virtual string StrucnaSpremaTehnicara{ get; set; }
        public virtual TehnickoLice TehLice { get; set; }
    }
}
