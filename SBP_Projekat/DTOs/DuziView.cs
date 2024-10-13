using System;
using SBP_Projekat.Entiteti;

namespace SBP_Projekat.DTOs
{
    public class DuziView
    {
        public int Id { get; set; }
        public DateTime Od { get; set; }
        public DateTime? Do { get; set; }

        public EkipaView UzelaEkipa { get; set; }
        public VoziloView UzetoVozilo { get; set; }

        public DuziView()
        {

        }
        public DuziView(Duzi d)
        {
            this.Id = d.Id;
            this.Od = d.Od;
            this.Do = d.Do;
            this.UzelaEkipa = new EkipaView(d.UzelaEkipa);
            this.UzetoVozilo = new VoziloView(d.UzetoVozilo);
        }
    }
}
