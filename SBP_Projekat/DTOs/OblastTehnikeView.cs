using SBP_Projekat.Entiteti;

namespace SBP_Projekat.DTOs
{

    public class OblastTehnikeView
    {
        public int Id { get; set; }
        public string Oblast { get; set; }
       // public TehnickoLiceView Tehnicar { get; set; }

        public OblastTehnikeView()
        {

        }
        public OblastTehnikeView(OblastTehnike o)
        {
            this.Id = o.Id;
            this.Oblast = o.ObTeh;
           // this.Tehnicar=new TehnickoLiceView(o.TehLice);
        }
    }
}
