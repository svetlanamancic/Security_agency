using System.Collections.Generic;

namespace SBP_Projekat.Entiteti
{
    public class Alarm

    {
        public virtual int Id { get; set; }
        public virtual string Proizvodjac { get; set; }
        public virtual int GodinaProizvodnje { get; set; }

        public virtual string Tip { get; set; }

        public virtual IList<Instaliran> ListaInstaliran { get; set; }
        public virtual IList<Objekat> Objekti { get; set; }
        
        public virtual IList<ZaduzenZa> ListaZaduzenZa { get; set; }
        public virtual IList<TehnickoLice> TehnickaLica { get; set; }

        public Alarm()
        {
            TehnickaLica = new List<TehnickoLice>();
            ListaZaduzenZa = new List<ZaduzenZa>();
            Objekti = new List<Objekat>();
            ListaInstaliran = new List<Instaliran>();
        }

    }

    public class DetektorPokreta : Alarm
    {
        public virtual int Osetljivost { get; set; }

    }

    public class UltrazvucniAlarm : Alarm
    {
        public virtual int Od { get; set; }
        public virtual int Do { get; set; }
    }

    public class ToplotniOdraz : Alarm
    {
        public virtual int HorizontalnaRezolucija { get; set; }
        public virtual int VertikalnaRezolucija { get; set; }
    }
}

