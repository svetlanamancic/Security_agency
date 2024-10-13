using System;
using SBP_Projekat.Entiteti;


namespace SBP_Projekat.DTOs
{
    public class JeZaduzenView
    {
        public int Id { get; set; }
        public DateTime ZaduzenOd { get; set; }
        public DateTime? ZaduzenDo { get; set; }
        public RegionalniCentarView Centar { get; set; }
        public MenadzerView MenadzerCentra { get; set; }

        public JeZaduzenView()
        {

        }
        public JeZaduzenView(JeZaduzen jz)
        {
            this.Id = jz.Id;
            this.ZaduzenDo = jz.ZaduzenDo;
            this.ZaduzenOd = jz.ZaduzenOd;
            this.Centar = new RegionalniCentarView(jz.Centar);
            this.MenadzerCentra = new MenadzerView(jz.MenadzerCentra);
        }
    }
}
