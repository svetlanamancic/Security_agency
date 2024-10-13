using System.Collections.Generic;
using SBP_Projekat.Entiteti;

namespace SBP_Projekat.DTOs
{
    public class RegionalniCentarView
    {
        public int Id { get; set; }
        public string Adresa { get; set; }
        public IList<BrojTelefonaView> Telefoni { get; set; }
        //public IList<MenadzerView> Menadzeri { get; set; }
        public IList<GradCentarView> Gradovi { get; set; }

        public RegionalniCentarView()
        {

        }
        public RegionalniCentarView(RegionalniCentar r)
        {
            this.Id = r.Id;
            this.Adresa = r.Adresa;
            this.Telefoni = new List<BrojTelefonaView>();
            
            this.Gradovi = new List<GradCentarView>();
            foreach (BrojTelefona t in r.Telefoni)
            {
                this.Telefoni.Add(new BrojTelefonaView(t));
            }
            
            foreach (GradCentar gc in r.Gradovi)
            {
                this.Gradovi.Add(new GradCentarView(gc));
            }
        }
        public override string ToString()
        {
            return this.Adresa;
        }
    }
}
