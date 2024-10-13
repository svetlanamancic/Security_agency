using System;

namespace SBP_Projekat.Entiteti
{
    public class Duzi
    {
        public virtual int Id { get; set; }
        public virtual DateTime Od { get; set; }
        public virtual DateTime? Do { get; set; }

        public virtual Vozilo UzetoVozilo { get; set; }
        public virtual Ekipa UzelaEkipa { get; set; }
    }
}
