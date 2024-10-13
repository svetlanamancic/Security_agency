using System.Collections.Generic;
using SBP_Projekat.Entiteti;

namespace SBP_Projekat.DTOs
{
    public class AlarmView
    {
        public int Id { get; set; }
        public string Proizvodjac { get; set; }
        public int GodinaProizvodnje { get; set; }
        public string Tip { get; set; }
        public int BrojObjekataUKojimaJeInstaliran { get; set; }
        //public IList<ObjekatView> Objekti { get; set; }
        public IList<TehnickoLiceView> TehnickaLica { get; set; }
        public IList<ZaduzenZaView> ZaduzenjaOdIDo { get; set; } // AKO ZA SVAKOG ZAPOSLENOG TREBA DA PRIKAZEMO OD KAD DO KAD JE BIO ZADUZEN ZA NEKI ALARM
       // public IList<InstaliranView> Instalirani { get; set; }
        public AlarmView()
        {

        }
        public AlarmView(Alarm a)
        {
            this.Id = a.Id;
            this.Proizvodjac = a.Proizvodjac;
            this.GodinaProizvodnje = a.GodinaProizvodnje;
            this.Tip = a.Tip;
            this.BrojObjekataUKojimaJeInstaliran = a.Objekti.Count;
          //  this.Objekti = new List<ObjekatView>();
            /*foreach (Objekat o in a.Objekti)
            {
                this.Objekti.Add(new ObjekatView(o));
            }*/
          /*  this.TehnickaLica = new List<TehnickoLiceView>();
            foreach (TehnickoLice t in a.TehnickaLica)
            {
                this.TehnickaLica.Add(new TehnickoLiceView(t));
            }
            this.ZaduzenjaOdIDo = new List<ZaduzenZaView>();
            foreach (ZaduzenZa zz in a.ListaZaduzenZa)
            {
                this.ZaduzenjaOdIDo.Add(new ZaduzenZaView(zz));
            }*/
            //this.Instalirani = new List<InstaliranView>();
            //foreach (Instaliran i in a.ListaInstaliran)
            //{
            //    this.Instalirani.Add(new InstaliranView(i));
            //}
        }

    }
    public class DetektorPokretaView:AlarmView
    {
        public int Osetljivost { get; set; }
        public DetektorPokretaView()
            :base()
        {

        }
        public DetektorPokretaView(DetektorPokreta d)
            :base(d)
        {
            this.Osetljivost = d.Osetljivost;
        }
    }
    public class UltrazvucniAlarmView:AlarmView
    {
        public int Od { get; set; }
        public int Do { get; set; }
        public UltrazvucniAlarmView()
            :base()
        {

        }
        public UltrazvucniAlarmView(UltrazvucniAlarm d)
            :base(d)
        {
            this.Od = d.Od;
            this.Do = d.Do;
        }
    }
    public class ToplotniOdrazView : AlarmView
    {
        public int HorizontalnaRezolucija { get; set; }
        public int VertikalnaRezolucija { get; set; }
        public ToplotniOdrazView()
            :base()
        {

        }
        public ToplotniOdrazView(ToplotniOdraz d)
            :base(d)
        {
            this.HorizontalnaRezolucija = d.HorizontalnaRezolucija;
            this.VertikalnaRezolucija = d.VertikalnaRezolucija;
        }
    }
}
