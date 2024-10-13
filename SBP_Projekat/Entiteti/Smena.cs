using System;
using System.Collections.Generic;

namespace SBP_Projekat.Entiteti
{
    public class Smena
    {
        public virtual int Id { get; set; }
        public virtual DateTime Pocetak { get; set; }
        public virtual DateTime Kraj { get; set; }

        public virtual IList<Radi> ListaRadi { get; set; }
        public virtual IList<Ekipa> Ekipe { get; set; }

        public virtual IList<Obidjen> ListaObidjen { get; set; }
        public virtual IList<Objekat> Objekti { get; set; }

        public Smena()
        {
            ListaObidjen = new List<Obidjen>();
            ListaRadi = new List<Radi>();
            Ekipe = new List<Ekipa>();
            Objekti = new List<Objekat>();
        }
    }
}
