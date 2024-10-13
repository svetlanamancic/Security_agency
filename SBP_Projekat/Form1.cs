using System;
using System.Collections.Generic;
using System.Windows.Forms;
using NHibernate;
using SBP_Projekat.Entiteti;

namespace SBP_Projekat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDodajZaposlenog_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                //JMBG mora da se promeni zbog unique constrainta
                Entiteti.Menadzer z = new Entiteti.Menadzer();

                z.Ime = "Miki";
                z.Prezime = "Minic";
                z.JMBG = "10";
                z.DatRodj = DateTime.Now;
                z.Pol = 'M';
                z.Pozicija = "Menadzer";

                s.Save(z);

                //dodaje grad menadzeru

                GradMenadzer gr = new GradMenadzer();

                gr.Grad = "Bela Palanka";
                gr.MenadzerGrada = z;

                s.Save(gr);

                z.Gradovi.Add(gr);

                s.Save(z);

                //pravi fizicko obezbedjenje
                Entiteti.FizickoObezbedjenje f = new Entiteti.FizickoObezbedjenje();

                f.Ime = "Kristina";
                f.Prezime = "Stevanovic";
                f.JMBG = "16";
                f.DatRodj = DateTime.Now;
                f.Pol = 'Z';
                f.Pozicija = "Fizicko obezbedjenje";

                s.Save(f);

                //dodaje borilacke vestine
                BorilackaVestina bv = new BorilackaVestina();

                bv.Vestina = " Kung fu";
                bv.FizOb = f;
                

                s.Save(bv);

                f.BorilackeVestine.Add(bv);


                s.Save(f);

                //pravi tehnicko lice

                Entiteti.TehnickoLice t = new Entiteti.TehnickoLice();

                t.Ime = "Kristina";
                t.Prezime = "Micic";
                t.JMBG = "17";
                t.DatRodj = DateTime.Now;
                t.Pol = 'Z';
                t.Pozicija = "Tehnicko lice";

                s.Save(t);
                //dodaje oblast tehnike

                OblastTehnike ot = new OblastTehnike();

                ot.ObTeh = "bela tehnika";
                ot.TehLice = t;

                s.Save(ot);

                t.OblastiTehnike.Add(ot);

                s.Save(t);

                //dodaje strucnu spremu

                StrucnaSprema ss = new StrucnaSprema();

                ss.StrucnaSpremaTehnicara = "ekonomista";
                ss.TehLice = t;

                s.Save(ss);

                t.StrucneSpreme.Add(ss);
                s.Save(t);

                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnBorilackaVestina_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                FizickoObezbedjenje f = new FizickoObezbedjenje()
                {
                    Ime = "Mica",
                    Prezime = "Krstic",
                    JMBG = "8828288282",
                    DatRodj = DateTime.Now,
                    Pol = 'M',
                    Pozicija = "Fizicko obezbedjenje"
                };

                s.Save(f);

                BorilackaVestina b = new BorilackaVestina();

                b.Vestina = "Karate";
                b.FizOb = f;

                s.Save(b);

                f.BorilackeVestine.Add(b);

                s.Save(f);
                s.Flush();
                s.Close();
                
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnGradM_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Menadzer m = new Menadzer()
                {
                    Ime = "Kaca",
                    Prezime = "Ristic",
                    JMBG = "92923873727",
                    DatRodj = DateTime.Now,
                    Pol = 'Z',
                    Pozicija = "Menadzer"
                };

                s.Save(m);

                GradMenadzer g = new GradMenadzer();

                g.Grad = "Pirot";
                g.MenadzerGrada = m;

                s.Save(g);

                m.Gradovi.Add(g);

                s.Save(m);
                s.Flush();
                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnStrucnaSprema_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                TehnickoLice t = new TehnickoLice()
                {
                    Ime = "Danica",
                    Prezime = "Markovic",
                    JMBG = "73737377373",
                    DatRodj = DateTime.Now,
                    Pol = 'Z',
                    Pozicija = "Tehnicko lice"
                };

                s.Save(t);

                StrucnaSprema str = new StrucnaSprema();

                str.StrucnaSpremaTehnicara = "dipl. masinski inzenjer";
                str.TehLice = t;

                s.Save(str);

                t.StrucneSpreme.Add(str);

                s.Save(t);
                s.Flush();
                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

        }

        private void btnDodajOblastiTehnike_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                TehnickoLice t = new TehnickoLice()
                {
                    Ime = "Danica",
                    Prezime = "Markovic",
                    JMBG = "5743726746904",
                    DatRodj = DateTime.Now,
                    Pol = 'Z',
                    Pozicija = "Tehnicko lice"
                };

                s.Save(t);

                OblastTehnike o = new OblastTehnike();

                o.ObTeh = "masinstvo";
                o.TehLice = t;

                s.Save(o);

                t.OblastiTehnike.Add(o);

                s.Save(t);
                s.Flush();
                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

        }

        private void btnUcitavanjeZaposlenog_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();


                SBP_Projekat.Entiteti.Menadzer m = s.Load<SBP_Projekat.Entiteti.Menadzer>(2);

                MessageBox.Show(m.Id.ToString() + " , " + m.Ime +" " + m.Prezime + " pol: "+ m.Pol);
      
                SBP_Projekat.Entiteti.FizickoObezbedjenje f = s.Load<SBP_Projekat.Entiteti.FizickoObezbedjenje>(3);
                SBP_Projekat.Entiteti.BorilackaVestina bor = s.Load<SBP_Projekat.Entiteti.BorilackaVestina>(1);

                MessageBox.Show(f.Id.ToString() + " , " +f.Ime + " " + f.Prezime + " " + f.BorilackeVestine.ToString());
             
                SBP_Projekat.Entiteti.TehnickoLice t = s.Load<SBP_Projekat.Entiteti.TehnickoLice>(11);

                MessageBox.Show(t.Id.ToString() + " , " + t.Ime + " " + t.Prezime);

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnManyToOne_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                FizickoObezbedjenje f = s.Load<FizickoObezbedjenje>(9);

                MessageBox.Show(f.Ime + f.Prezime);
                MessageBox.Show(f.PripadaEkipi.Id.ToString());

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnOneToMany_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                

                Ekipa ek = s.Load<Ekipa>(1);

                foreach (FizickoObezbedjenje f in ek.ClanoviEkipe)
                {
                    MessageBox.Show(f.Id.ToString() + " " + f.Ime + " " + f.Prezime);
                }

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnHasManyToMany_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Menadzer m1 = s.Load<Menadzer>(2);

                foreach (RegionalniCentar r1 in m1.ListaCentara)
                {
                    MessageBox.Show(r1.Id.ToString()+" "+r1.Adresa);
                }


                RegionalniCentar r2 = s.Load<RegionalniCentar>(1);

                foreach (Menadzer m2 in r2.Menadzeri)
                {
                    MessageBox.Show(m2.Ime + " " + m2.Prezime);
                }

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnCreateJeZaduzen_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Menadzer m = s.Load<Menadzer>(1);
                RegionalniCentar rc = s.Load<RegionalniCentar>(2);

                JeZaduzen jz = new JeZaduzen();
                jz.MenadzerCentra = m;
                jz.Centar = rc;
                jz.ZaduzenOd = DateTime.Now;


                s.Save(jz);

                s.Flush();
                s.Close();



            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnKreirajSmenu_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Entiteti.Smena sm = new Entiteti.Smena();

                sm.Pocetak = DateTime.Now;
                sm.Kraj = DateTime.Now;

                s.Save(sm);

                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnDodajVozilo_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Entiteti.Vozilo vo = new Entiteti.Vozilo();

                Entiteti.RegionalniCentar reg = s.Load<Entiteti.RegionalniCentar>(1);

                vo.Proizvodjac = "Mercedes";
                vo.Model = "A1";
                vo.Tip = "autic";
                vo.RegistarskaOznaka = "KI-007-KA";
                vo.Boja = "Zuta";
                vo.PripadaCentru = reg;

                s.Save(vo);

                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

        }

        private void btnDodajRegCentar_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Entiteti.RegionalniCentar regCen = new Entiteti.RegionalniCentar();

                

                regCen.Adresa = "Vojvode Tankosica 33/10, 18000 Nis";
               // regCen.Gradovi = 
                // regCen.Telefoni =

                s.Save(regCen);

                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

        }

        private void btnKreirajObjekat_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Entiteti.Objekat oB = new Entiteti.Objekat();

                oB.Adresa = "Milorada Stosica 18, 17500 Vranje";
                oB.Tip = "Stambena zgrada";
                oB.Povrsina = 700;
                //oB.Telefoni

                

                s.Save(oB);

                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnDodajEkipu_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Entiteti.Ekipa ek = new Entiteti.Ekipa();

                Entiteti.FizickoObezbedjenje fizOb = s.Load<Entiteti.FizickoObezbedjenje>(6);

                ek.Vodja = fizOb;

          
                s.Save(ek);

                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

        }

        private void btnKreirajAlarme_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

               
                Entiteti.DetektorPokreta dp = new Entiteti.DetektorPokreta();

                dp.Osetljivost = 500;
                dp.Tip = "Detektor pokreta";
                dp.Proizvodjac = "ZUU";
                dp.GodinaProizvodnje = 2013;
                

                s.Save(dp);

                Entiteti.UltrazvucniAlarm ua = new Entiteti.UltrazvucniAlarm();

                ua.Od = 30;
                ua.Do = 35;
                ua.Tip = "Ultrazvucni alarm";
                ua.Proizvodjac = "BUU";
                ua.GodinaProizvodnje = 2015;

                s.Save(ua);

                Entiteti.ToplotniOdraz to = new Entiteti.ToplotniOdraz();

                to.HorizontalnaRezolucija = 900;
                to.VertikalnaRezolucija = 1900;
                to.Tip = "Topolotni odraz";
                to.Proizvodjac = "RUU";
                to.GodinaProizvodnje = 2018;

                s.Save(to);

                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnBorilackaVestina_Click_1(object sender, EventArgs e)
        {

        }

        private void btnDuzi_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Vozilo v = s.Load<Vozilo>(2);
                Ekipa ek = s.Load<Ekipa>(2);

                Duzi dz = new Duzi();

                dz.UzetoVozilo = v;
                dz.UzelaEkipa = ek;
                dz.Od = DateTime.Now;


                s.Save(dz);

                s.Flush();
                s.Close();



            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnInstaliran_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Alarm al = s.Load<Alarm>(1);
                Objekat ob = s.Load<Objekat>(2);

                Instaliran ins = new Instaliran();

                ins.InstaliranAlarm = al;
                ins.UObjektu = ob;
                ins.Datum = DateTime.Now;

                s.Save(ins);

                s.Flush();
                s.Close();



            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnJeZaduzena_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Ekipa ek = s.Load<Ekipa>(1);
                Objekat ob = s.Load<Objekat>(21);

                JeZaduzena jz = new JeZaduzena();

                jz.ZaduzenaEkipa = ek;
                jz.ZaduzenaZaObjekat = ob;

                s.Save(jz);

                s.Flush();
                s.Close();



            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnObidjen_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Smena sm = s.Load<Smena>(1);
                Objekat ob = s.Load<Objekat>(21);

                Obidjen o = new Obidjen();

                o.IdObjekta = ob;
                o.IdSmene = sm;

                s.Save(o);

                s.Flush();
                s.Close();



            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnRadi_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Ekipa ek = s.Load<Ekipa>(1);
                Smena sm = s.Load<Smena>(2);

                Radi r = new Radi();

                r.Ekipica = ek;
                r.RadiUSmeni = sm;
                
                s.Save(r);

                s.Flush();
                s.Close();



            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnVrsiIntervenciju_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Ekipa ek = s.Load<Ekipa>(2);
                Objekat ob = s.Load<Objekat>(21);

                VrsiIntervenciju vi = new VrsiIntervenciju();

                vi.VrsiEkipa = ek;
                vi.UObjektu = ob;
                vi.Vreme = DateTime.Parse(DateTime.Now.TimeOfDay.ToString());
                vi.Datum = DateTime.Now.Date;

                s.Save(vi);

                s.Flush();
                s.Close();



            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnZaduzenZa_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Alarm al = s.Load<Alarm>(2);
                TehnickoLice th = s.Load<TehnickoLice>(19);

                ZaduzenZa zz = new ZaduzenZa();

                zz.ZaduzenTehnicar = th;
                zz.ZaAlarm = al;
                zz.Od = DateTime.Now;

                s.Save(zz);

                s.Flush();
                s.Close();



            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IList<Alarm> alarmi = s.QueryOver<Alarm>().List<Alarm>();

                foreach(Alarm a in alarmi)
                {
                    if(a.GetType()==typeof(DetektorPokreta))
                    {
                        DetektorPokreta dp = (DetektorPokreta)a;
                    }
                    else if(a.GetType()==typeof(ToplotniOdraz))
                    {
                        ToplotniOdraz to = (ToplotniOdraz)a;
                    }
                    else 
                    {
                        UltrazvucniAlarm ua = (UltrazvucniAlarm)a;
                    }
                }

                s.Close();



            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IList<Zaposleni> zaposleni = s.QueryOver<Zaposleni>().List<Zaposleni>();

                foreach (Zaposleni a in zaposleni)
                {
                    if (a.GetType() == typeof(Menadzer))
                    {
                        Menadzer m = (Menadzer)a;
                    }
                    else if (a.GetType() == typeof(TehnickoLice))
                    {
                        TehnickoLice tl = (TehnickoLice)a;
                    }
                    else
                    {
                        FizickoObezbedjenje fo = (FizickoObezbedjenje)a;
                    }
                }

                s.Close();



            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();


                IList<Zaposleni> zaposleni = s.QueryOver<Zaposleni>()
                                                .Where(z => z.Id == 2)
                                                .List<Zaposleni>();

                Menadzer m = (Menadzer)zaposleni[0];

                MessageBox.Show(m.Ime + " " + m.Prezime);

                s.Close();



            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
    }
}
