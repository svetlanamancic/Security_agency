using System.Collections.Generic;
using SBP_Projekat.Entiteti;

namespace SBP_Projekat.DTOs
{
    public class ObjekatView
    {
        public int Id { get; set; }
        public string Adresa { get; set; }
        public string Tip { get; set; }
        public float Povrsina { get; set; }
        //public IList<AlarmView> Alarmi { get; set; }
        public IList<KontaktTelefonView> Telefoni { get; set; }
        //public IList<InstaliranView> Instalirani { get; set; }
        public ObjekatView()
        {

        }
        public ObjekatView(Objekat o)
        {
            this.Id = o.Id;
            this.Adresa = o.Adresa;
            this.Tip = o.Tip;
            this.Povrsina = o.Povrsina;
            /*this.Alarmi = new List<AlarmView>();
            foreach (Alarm a in o.Alarmi)
            {
                this.Alarmi.Add(new AlarmView(a));
            }
            */
            this.Telefoni = new List<KontaktTelefonView>();
            foreach (KontaktTelefon kt in o.Telefoni)
            {
                this.Telefoni.Add(new KontaktTelefonView(kt));
            }

            /*this.Instalirani = new List<InstaliranView>();
            foreach (Instaliran i in o.ListaInstaliran)
            {
                this.Instalirani.Add(new InstaliranView(i));
            }*/
        }
        public override string ToString()
        {
            string a = "Tip: " + Tip + " " + Adresa;
            return a;
        }   
    }
}
