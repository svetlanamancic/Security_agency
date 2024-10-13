using System.Collections.Generic;

namespace SBP_Projekat.Entiteti
{
    public class Ekipa
    {
        public virtual int Id { get; set; }
        public virtual FizickoObezbedjenje Vodja { get; set; }//??????????????DA LI TREBA DA SE IZVEDE IZ FIZICKOG OBEZBEDJENJA VODJA?????

        public virtual IList<FizickoObezbedjenje> ClanoviEkipe { get; set; }

        public virtual IList<Duzi> ListaDuzi { get; set; }
        public virtual IList<Vozilo> Vozila { get; set; }

        public virtual IList<Radi> ListaRadi { get; set; }
        public virtual IList<Smena> Smene { get; set; }

        public virtual IList<JeZaduzena> ListaJeZaduzena { get; set; }
        public virtual IList<Objekat> Objekti { get; set; }

        public virtual IList<VrsiIntervenciju> ListaIntervencije { get; set; }
        public virtual IList<Objekat> IntervencijeUObjektima { get; set; }

        public Ekipa()
        {
            IntervencijeUObjektima = new List<Objekat>();
            ListaIntervencije = new List<VrsiIntervenciju>();
            Objekti = new List<Objekat>();
            ListaJeZaduzena = new List<JeZaduzena>();
            Smene = new List<Smena>();
            ListaRadi = new List<Radi>();
            Vozila = new List<Vozilo>();
            ListaDuzi = new List<Duzi>();
            ClanoviEkipe = new List<FizickoObezbedjenje>();
        }
    }
}
