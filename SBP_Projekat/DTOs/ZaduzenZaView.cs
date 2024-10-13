using System;
using SBP_Projekat.Entiteti;

namespace SBP_Projekat.DTOs
{
    public class ZaduzenZaView
    {
        public int Id { get; set; }
        public DateTime Od { get; set; }
        public DateTime? Do { get; set; }

        public AlarmView ZaduzenZaAlarm { get; set; }
        public TehnickoLiceView ZaduzenTehnicar { get; set; }

        public ZaduzenZaView()
        {

        }
        public ZaduzenZaView(ZaduzenZa zz)
        {
            this.Id = zz.Id;
            this.Od = zz.Od;
            this.Do = zz.Do;
            this.ZaduzenZaAlarm = new AlarmView(zz.ZaAlarm);
            this.ZaduzenTehnicar = new TehnickoLiceView(zz.ZaduzenTehnicar);
        }
    }
}
