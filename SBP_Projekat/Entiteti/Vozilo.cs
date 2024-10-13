using System.Collections.Generic;

namespace SBP_Projekat.Entiteti
{
    public class Vozilo
    {
        public virtual int Id { get; set; }
        public virtual string RegistarskaOznaka { get; set; }
        public virtual string Boja { get; set; }
        public virtual string Tip { get; set; }
        public virtual string Model { get; set; }
        public virtual string Proizvodjac { get; set; }

        public virtual RegionalniCentar PripadaCentru { get; set; }

        public virtual IList<Duzi> ListaDuzi { get; set; }
        public virtual IList<Ekipa> Ekipe { get; set; }

        public Vozilo()
        {
            ListaDuzi = new List<Duzi>();
            Ekipe = new List<Ekipa>();
           
        }
    }
}
