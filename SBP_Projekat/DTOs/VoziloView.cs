using SBP_Projekat.Entiteti;

namespace SBP_Projekat.DTOs
{
    public class VoziloView
    {
        public int Id { get; set; }
        public string RegistarskaOznaka { get; set; }
        public string Tip { get; set; }
        public string Proizvodjac { get; set; }
        public string Model { get; set; }
        public string Boja { get; set; }

        private RegionalniCentarView PripadaCentru { get; set; }

      //  private IList<EkipaView> Ekipe { get; set; }
        //private IList<DuziView> Duzenja { get; set; }
        public VoziloView()
        {

        }
        public VoziloView(Vozilo v)
        {
            this.Id = v.Id;
            this.Model = v.Model;
            this.Boja = v.Boja;
            this.Tip = v.Tip;
            this.Proizvodjac = v.Proizvodjac;
            this.RegistarskaOznaka = v.RegistarskaOznaka;
            this.PripadaCentru = new RegionalniCentarView(v.PripadaCentru);
           
        }
        public override string ToString()
        {
            return this.RegistarskaOznaka+" "+this.Proizvodjac;
        }
    }
}
