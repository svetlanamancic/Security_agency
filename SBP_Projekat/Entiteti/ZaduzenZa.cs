using System;

namespace SBP_Projekat.Entiteti
{
    public class ZaduzenZa
    {
        public virtual int Id { get; set; }
        public virtual DateTime Od { get; set; }
        public virtual DateTime? Do { get; set; }

        public virtual TehnickoLice ZaduzenTehnicar { get; set; }
        public virtual Alarm ZaAlarm { get; set; }

    }       
}
