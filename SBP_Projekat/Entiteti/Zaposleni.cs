using System;
using System.Collections.Generic;

namespace SBP_Projekat.Entiteti
{
    public class Zaposleni
    {
        public virtual int Id { get; set; }
        public virtual string JMBG { get; set; }
        public virtual string Ime { get; set; }
        public virtual string Prezime { get; set; }
        public virtual DateTime DatRodj { get; set; }
        public virtual char Pol { get; set; }
        public virtual string Pozicija { get; set; }

    }
    public class Menadzer :Zaposleni
    {
        public virtual IList<GradMenadzer> Gradovi { get; set; }
        public virtual IList<RegionalniCentar> ListaCentara { get; set; }
        public virtual IList<JeZaduzen> ListaJeZaduzen { get; set; }
        public Menadzer()
        {
            Gradovi = new List<GradMenadzer>();
            ListaCentara = new List<RegionalniCentar>();
            ListaJeZaduzen = new List<JeZaduzen>();
        }
    }
    public class TehnickoLice : Zaposleni
    {
        public virtual IList<OblastTehnike> OblastiTehnike { get; set; }
        public virtual IList<StrucnaSprema> StrucneSpreme { get; set; }
        public virtual IList<Alarm> ListaAlarma { get; set; }
        public virtual IList<ZaduzenZa> ListaZaduzenja { get; set; }
        public TehnickoLice()
        {
            OblastiTehnike = new List<OblastTehnike>();
            StrucneSpreme = new List<StrucnaSprema>();
            ListaAlarma = new List<Alarm>();
            ListaZaduzenja = new List<ZaduzenZa>();
        }
    }
    public class FizickoObezbedjenje :Zaposleni
    {
        public virtual IList<BorilackaVestina> BorilackeVestine { get; set; }
        public virtual Ekipa PripadaEkipi { get; set; }

        public FizickoObezbedjenje()
        {
            BorilackeVestine = new List<BorilackaVestina>();
        }
    }
}
