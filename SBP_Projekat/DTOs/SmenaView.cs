using System;
using SBP_Projekat.Entiteti;

namespace SBP_Projekat.DTOs
{
    public class SmenaView
    {
        public int Id { get; set; }
        public DateTime Pocetak { get; set; }
        public DateTime Kraj { get; set; }
       // private IList<EkipaView> Ekipe { get; set; }
        //private IList<ObjekatView> Objekti { get; set; }

        public SmenaView()
        {

        }
        public SmenaView(Smena s)
        {
            this.Id = s.Id;
            this.Pocetak = s.Pocetak;
            this.Kraj = s.Kraj;
          //  this.Ekipe = new List<EkipaView>();
           // this.Objekti = new List<ObjekatView>();
            /*foreach (Ekipa e in s.Ekipe)
            {
                this.Ekipe.Add(new EkipaView(e));
            }
            foreach (Objekat o in s.Objekti)
            {
                this.Objekti.Add(new ObjekatView(o));
            }*/
        }
        public override string ToString()
        {
            return this.Pocetak.ToString()+" "+this.Kraj.ToString();
        }
    }
}
