using SBP_Projekat.Entiteti;

namespace SBP_Projekat.DTOs
{
    public class StrucnaSpremaView
    {
        public int Id { get; set; }
        public string Struka { get; set; }
        //public TehnickoLiceView Tehnicar { get; set; }

        public StrucnaSpremaView()
        {

        }
        public StrucnaSpremaView(StrucnaSprema o)
        {
            this.Id = o.Id;
            this.Struka = o.StrucnaSpremaTehnicara;
            //this.Tehnicar = new TehnickoLiceView(o.TehLice);
        }
    }
}
