using System;
using System.Collections.Generic;
using SBP_Projekat.Entiteti;

namespace SBP_Projekat.DTOs
{
    public class BasicZaposleniView
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }

        public BasicZaposleniView()
        {

        }
        public BasicZaposleniView(Zaposleni z)
        {
            this.Id = z.Id;
            this.Ime = z.Ime;
            this.Prezime = z.Prezime;
        }
        public BasicZaposleniView(ZaposleniView z)
        {
            this.Id = z.Id;
            this.Ime = z.Ime;
            this.Prezime = z.Prezime;
        }
    }

    public class ZaposleniView// da li zaposleni view ili za svaki tip posebno view???????
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatRodj { get; set; }

        public char Pol { get; set;}

        public string Jmbg { get; set; }
      //  public string Pozicija { get; set; }

        public ZaposleniView()
        {

        }
        public ZaposleniView(Zaposleni z)
        {
            this.Id = z.Id;
            this.Ime = z.Ime;
            this.Prezime = z.Prezime;
            this.DatRodj = z.DatRodj;
            this.Jmbg = z.JMBG;
            this.Pol = z.Pol;
            //this.Pozicija = z.Pozicija;
        }
    }
    public class MenadzerView : ZaposleniView
    {
       // public IList<RegionalniCentarView> Centri { get; set; }
        public IList<GradMenadzerView> Gradovi { get; set; }
       // public IList<JeZaduzenView> ListaZaduzen { get; set; }

        public MenadzerView()
            :base()
        {

        }
        public MenadzerView(Menadzer m)
            : base(m)
        {
            this.Gradovi = new List<GradMenadzerView>();

            if (m.Gradovi.Count > 0)
            {
                foreach (GradMenadzer g in m.Gradovi)
                {
                    this.Gradovi.Add(new GradMenadzerView(g));
                }
            }
        }
            public override string ToString()
        {
            return Ime + " " + Prezime;
        }
    
    }
    public class FizickoObezbedjenjeView : ZaposleniView
    {
       // public EkipaView PripadaEkipi { get; set; }
        public IList<BorilackaVestinaView> BorilackeVestine { get; set; }

        public FizickoObezbedjenjeView()
            :base()
        {

        }
        public FizickoObezbedjenjeView(FizickoObezbedjenje f)
            :base(f)
        {
           // this.PripadaEkipi = new EkipaView(f.PripadaEkipi);
            this.BorilackeVestine = new List<BorilackaVestinaView>();
            foreach(BorilackaVestina b in f.BorilackeVestine)
            {
                this.BorilackeVestine.Add(new BorilackaVestinaView(b));
            }
        }

        public override string ToString()
        {
            String a = Ime + " " + Prezime;
            return a;
        }
    }
    public class TehnickoLiceView : ZaposleniView
    {
        public IList<OblastTehnikeView> OblastiTehnike { get; set; }
        public IList<StrucnaSpremaView> StrucneSpreme { get; set; }
        //public IList<AlarmView> Alarmi { get; set; }
       // public IList<ZaduzenZaView> ZaduzenLista { get; set; }
        public TehnickoLiceView()
            :base()
        {

        }
        public TehnickoLiceView(TehnickoLice t)
            :base(t)
        {
            this.OblastiTehnike = new List<OblastTehnikeView>();
            this.StrucneSpreme = new List<StrucnaSpremaView>();
           // this.Alarmi = new List<AlarmView>();
           // this.ZaduzenLista = new List<ZaduzenZaView>();

            foreach(OblastTehnike ot in t.OblastiTehnike)
            {
                this.OblastiTehnike.Add(new OblastTehnikeView(ot));
            }
            foreach(StrucnaSprema ss in t.StrucneSpreme)
            {
                this.StrucneSpreme.Add(new StrucnaSpremaView(ss));
            }
            //foreach(Alarm a in t.ListaAlarma)
            //{
            //    this.Alarmi.Add(new AlarmView(a));
            //}
            //foreach(ZaduzenZa zz in t.ListaZaduzenja)
            //{
            //    this.ZaduzenLista.Add(new ZaduzenZaView(zz));
            //}

        }

        public override string ToString()
        {
            String a = Ime + " " + Prezime;
            return a;
        }
    }
}
