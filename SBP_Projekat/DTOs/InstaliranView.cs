using System;
using SBP_Projekat.Entiteti;


namespace SBP_Projekat.DTOs
{
    public class InstaliranView
    {
        public int Id { get; set; }
        public DateTime Datum { get; set; }
        //public AlarmView InstaliranAlarm { get; set; }
        //public ObjekatView UObjektu { get; set; }

        public InstaliranView()
        {

        }
        public InstaliranView(Instaliran i)
        {
            this.Id = i.Id;
            this.Datum = i.Datum;
           // this.InstaliranAlarm = new AlarmView(i.InstaliranAlarm);
           // this.UObjektu = new ObjekatView(i.UObjektu);
        }
    }
}
