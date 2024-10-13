using System.Collections.Generic;

namespace SBP_Projekat.Entiteti
{
    public class RegionalniCentar
    {
        public virtual int Id { get; set; }
        public virtual string Adresa { get; set; }

        public virtual IList<JeZaduzen> ListaJeZaduzen { get; set; }
        public virtual IList<Menadzer> Menadzeri { get; set; }
        public virtual IList<BrojTelefona> Telefoni { get; set; }
        public virtual IList<GradCentar> Gradovi { get; set; }
        public virtual IList<Vozilo> VozilaCentra { get; set; }

        public RegionalniCentar()
        {
            ListaJeZaduzen = new List<JeZaduzen>();
            Menadzeri = new List<Menadzer>();
            Telefoni = new List<BrojTelefona>();
            Gradovi = new List<GradCentar>();
            VozilaCentra = new List<Vozilo>();
        }

    }
}
