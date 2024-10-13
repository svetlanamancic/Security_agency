using System;

namespace SBP_Projekat.Entiteti
{
    public class VrsiIntervenciju
    {
        public virtual int Id { get; set; }
        public virtual DateTime Datum { get; set; }
        public virtual DateTime Vreme { get; set; }
        public virtual string OpisTipa { get; set; }

        public virtual Ekipa VrsiEkipa { get; set; }
        public virtual Objekat UObjektu { get; set; }

       
    }
}
