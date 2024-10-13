using System;

namespace SBP_Projekat.Entiteti
{
    public class JeZaduzen
    {
        public virtual int Id { get; set; }
        public virtual DateTime ZaduzenOd { get; set; }
        public virtual DateTime? ZaduzenDo { get; set; }

        public virtual Menadzer MenadzerCentra { get; set; }
        public virtual RegionalniCentar Centar { get; set; }

    }
}
