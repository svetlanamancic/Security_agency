using System.Collections.Generic;

namespace SBP_Projekat.Entiteti
{
    public class Objekat
    {
        public virtual int Id { get; set; }
        public virtual string Adresa { get; set; }
        public virtual string Tip { get; set; }
        public virtual float Povrsina { get; set; }

        public virtual IList<Obidjen> ListaObidjen { get; set; }
        public virtual IList<Smena> Smene { get; set; }
        
        public virtual IList<JeZaduzena> ListaJeZaduzena { get; set; }
        public virtual IList<Ekipa> Ekipe { get; set; }

        public virtual IList<VrsiIntervenciju> ListaIntervencije { get; set; }
        public virtual IList<Ekipa> EkipeVrsileIntervenciju { get; set; }

        public virtual IList<Instaliran> ListaInstaliran { get; set; }
        public virtual IList<Alarm> Alarmi { get; set; }

        public virtual IList<KontaktTelefon> Telefoni { get; set; }

        public Objekat()
        {
            ListaInstaliran = new List<Instaliran>();
            Alarmi = new List<Alarm>();
            Telefoni = new List<KontaktTelefon>();
            EkipeVrsileIntervenciju = new List<Ekipa>();
            ListaIntervencije = new List<VrsiIntervenciju>();
            Ekipe = new List<Ekipa>();
            ListaJeZaduzena = new List<JeZaduzena>();
            Smene = new List<Smena>();
            ListaObidjen = new List<Obidjen>();
        }

    }
}
