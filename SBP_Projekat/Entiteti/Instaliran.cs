using System;

namespace SBP_Projekat.Entiteti
{
    public class Instaliran
    {
        public virtual int Id { get; set; }
        public virtual DateTime Datum { get; set; }


        public virtual Objekat UObjektu { get; set; }
        public virtual Alarm InstaliranAlarm { get; set; }
    }
}
