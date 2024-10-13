using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Linq;
using SBP_Projekat.Entiteti;
using System.Windows.Forms;
using SBP_Projekat.DTOs;


namespace SBP_Projekat
{
    public class DTOManager
    {
        #region Zaposleni

        #region Menadzeri
        public static List<ZaposleniView> getMenadzere()
        {
            List<ZaposleniView> lista = new List<ZaposleniView>();
            try
            {
                ISession s = DataLayer.GetSession();

                ISQLQuery q = s.CreateSQLQuery("SELECT O.* FROM ZAPOSLENI O WHERE POZICIJA='Menadzer'");
                q.AddEntity(typeof(Menadzer));


                IList<Menadzer> zap = q.List<Menadzer>();

                foreach (Menadzer m in zap)
                {
                    lista.Add(new ZaposleniView(m));
                }

                s.Close();

            }
            catch
            {

            }
            return lista;
        }
        public static List<MenadzerView> getMenadzerViews()
        {
            List<MenadzerView> lista = new List<MenadzerView>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Menadzer> zap = from o in s.Query<Menadzer>()
                                            select o;

                foreach (Menadzer m in zap)
                {
                    lista.Add(new MenadzerView(m));
                }

                s.Close();

            }
            catch
            {

            }
            return lista;
        }

        public static Menadzer getMenadzer(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Menadzer o = s.Get<Menadzer>(id);

                if (o != null)
                {
                    return o;
                }

                s.Close();

                return null;
            }
            catch
            {
            }
            return null;
        }
        public static MenadzerView getMenadzerView(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Menadzer m = s.Load<Menadzer>(id);

                MenadzerView men = new MenadzerView(m);

                s.Close();

                return men;
            }
            catch  
            {

            }
            return null;
        }

        public static void AddMenadzer(Menadzer m)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                s.Save(m);

                s.Flush();
                s.Close();
            }
            catch  
            {

            }
        }

        public static void deleteMenadzer(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Menadzer m = s.Load<Menadzer>(id);
                
                s.Delete(m); 

                s.Flush();
                s.Close();
            }
            catch  (Exception ex)
            {
                MessageBox.Show(ex.InnerException.Message);
            }
        }

        public static void updateMenadzer(MenadzerView menadzer)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Menadzer m = s.Load<Menadzer>(menadzer.Id);
                m.Ime = menadzer.Ime;
                m.Prezime = menadzer.Prezime;
                m.JMBG = menadzer.Jmbg;
                m.Pol = menadzer.Pol;

                s.SaveOrUpdate(m);

                s.Flush();
                s.Close();
            }
            catch  
            {

            }
        }

        #endregion

        #region FizickoObezbedjenje

        public static List<ZaposleniView> getFizickoObezbedjenje()
        {
            List<ZaposleniView> lista = new List<ZaposleniView>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<FizickoObezbedjenje> zap = from o in s.Query<FizickoObezbedjenje>()
                                                       select o;

                foreach (FizickoObezbedjenje fo in zap)
                {
                    lista.Add(new ZaposleniView(fo));
                }

                s.Close();

            }
            catch  
            {

            }
            return lista;
        }

        public static FizickoObezbedjenje getFizickoObezbedjenje(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                FizickoObezbedjenje m = s.Load<FizickoObezbedjenje>(id);

                s.Close();

                return m;
            }
            catch  
            {

            }
            return null;
        }

        public static FizickoObezbedjenjeView getFizickoObezbedjenjeView(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                FizickoObezbedjenje m = s.Load<FizickoObezbedjenje>(id);//da pitamo jel moze load i koja je razlika u odnosu na query? jel mora query?



                FizickoObezbedjenjeView f = new FizickoObezbedjenjeView(m);


                s.Close();

                return f;

            }
            catch  
            {

            }
            return null;
        }

        public static void deleteFizickoObezbedjenje(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                FizickoObezbedjenje m = s.Load<FizickoObezbedjenje>(id);

                

                s.Delete(m);
                s.Flush();
                s.Close();
            }
            catch  (Exception E)
            {
                MessageBox.Show(E.InnerException.Message);
            }
        }

        public static void AddFizickoObezbedjenje(FizickoObezbedjenje m)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                s.Save(m);

                s.Flush();
                s.Close();
            }
            catch  
            {

            }
        }

        public static void updateFizickoObezbedjenje(FizickoObezbedjenjeView fo)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                FizickoObezbedjenje f = s.Load<FizickoObezbedjenje>(fo.Id);
                f.Ime = fo.Ime;
                f.Prezime = fo.Prezime;
                f.JMBG = fo.Jmbg;
                f.Pol = fo.Pol;

                s.SaveOrUpdate(f);

                s.Flush();
                s.Close();
            }
            catch  
            {

            }
        }

        #endregion

        #region TehnickoLice

        public static List<ZaposleniView> getTehnicari()
        {
            List<ZaposleniView> lista = new List<ZaposleniView>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<TehnickoLice> zap = from o in s.Query<TehnickoLice>()
                                                select o;

                foreach (TehnickoLice tl in zap)
                {
                    lista.Add(new ZaposleniView(tl));
                }

                s.Close();
            }
            catch  
            {

            }
            return lista;
        }

        public static List<TehnickoLiceView> getTehnickoLiceViews()
        {
            List<TehnickoLiceView> lista = new List<TehnickoLiceView>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<TehnickoLice> zap = from o in s.Query<TehnickoLice>()
                                                select o;

                foreach (TehnickoLice tl in zap)
                {
                    lista.Add(new TehnickoLiceView(tl));
                }

                s.Close();
            }
            catch
            {

            }
            return lista;
        }

        public static TehnickoLice getTehnickoLice(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                TehnickoLice m = s.Load<TehnickoLice>(id);

                s.Close();

                return m;

            }
            catch  
            {

            }
            return null;
        }

        public static void deleteTehnickoLice(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                TehnickoLice m = s.Load<TehnickoLice>(id);

         
                s.Delete(m);

                s.Flush();
                s.Close();
            }
            catch  (Exception e)
            {
                MessageBox.Show(e.InnerException.Message);
            }
        }

        public static TehnickoLiceView getTehnickoLiceView(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                TehnickoLice m = s.Load<TehnickoLice>(id);//da pitamo jel moze load i koja je razlika u odnosu na query? jel mora query?



                TehnickoLiceView f = new TehnickoLiceView(m);


                s.Close();

                return f;

            }
            catch  
            {

            }
            return null;
        }

        public static void AddTehnickoLice(TehnickoLice m)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                s.Save(m);

                s.Flush();
                s.Close();
            }
            catch  
            {

            }
        }

        public static void updateTehnickoLice(TehnickoLiceView t)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                TehnickoLice f = s.Load<TehnickoLice>(t.Id);
                f.Ime = t.Ime;
                f.Prezime = t.Prezime;
                f.JMBG = t.Jmbg;
                f.Pol = t.Pol;

                s.SaveOrUpdate(f);

                s.Flush();
                s.Close();
            }
            catch  
            {

            }
        }

        #endregion

        #endregion

        #region dodavanjaZaZaposlene

        
        public static void addGradMenadzer(int idMen, string grad)
        {
            try
            {
                ISession session = DataLayer.GetSession();
                Menadzer menadzer = session.Load<Menadzer>(idMen);
                GradMenadzer gm = new GradMenadzer();
                gm.Grad = grad;
                gm.MenadzerGrada = menadzer;

                session.Save(gm);

                menadzer.Gradovi.Add(gm);
                session.Save(menadzer);
                session.Flush();
                session.Close();
            }
            catch
            {

            }
        }

        public static void addOblastTehnike(int idT, string oblast)
        {
            try
            {
                ISession session = DataLayer.GetSession();
                TehnickoLice t = session.Load<TehnickoLice>(idT);
                OblastTehnike o = new OblastTehnike();
                o.ObTeh = oblast;
                o.TehLice = t;

                session.Save(o);

                t.OblastiTehnike.Add(o);
                session.Save(t);
                session.Flush();
                session.Close();
            }
            catch
            {

            }
        }

        public static void addStrucnaSprema(int idT, string sprema)
        {
            try
            {
                ISession session = DataLayer.GetSession();
                TehnickoLice t = session.Load<TehnickoLice>(idT);
                StrucnaSprema o = new StrucnaSprema();
                o.StrucnaSpremaTehnicara = sprema;
                o.TehLice = t;

                session.Save(o);

                t.StrucneSpreme.Add(o);
                session.Save(t);
                session.Flush();
                session.Close();
            }
            catch
            {

            }
        }

        public static void addBorilackaVestina(int idF, string vestina)
        {
            try
            {
                ISession session = DataLayer.GetSession();
                FizickoObezbedjenje f = session.Load<FizickoObezbedjenje>(idF);
                BorilackaVestina b = new BorilackaVestina();
                b.Vestina = vestina;
                b.FizOb = f;

                session.Save(b);

                f.BorilackeVestine.Add(b);
                session.Save(f);
                session.Flush();
                session.Close();
            }
            catch
            {

            }
        }

        public static void deleteBorilackaVestina(int id)
        {
            try
            {
                ISession session = DataLayer.GetSession();

                BorilackaVestina b = session.Load<BorilackaVestina>(id);

                session.Delete(b);

                session.Flush();
                session.Close();
            }
            catch
            {

            }
        }

        public static void deleteGradMenadzer(int id)
        {
            try
            {
                ISession session = DataLayer.GetSession();

                GradMenadzer b = session.Load<GradMenadzer>(id);

                session.Delete(b);

                session.Flush();
                session.Close();
            }
            catch
            {

            }
        }

        public static void deleteStrucnaSprema(int id)
        {
            try
            {
                ISession session = DataLayer.GetSession();

                StrucnaSprema b = session.Load<StrucnaSprema>(id);

                session.Delete(b);

                session.Flush();
                session.Close();
            }
            catch
            {

            }
        }

        public static void deleteOblastTehnike(int id)
        {
            try
            {
                ISession session = DataLayer.GetSession();

                OblastTehnike b = session.Load<OblastTehnike>(id);

                session.Delete(b);

                session.Flush();
                session.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.InnerException.Message);
            }
            
        }

        #endregion

        #region Objekti

        public static List<ObjekatView> getObjekte()
        {
            List<ObjekatView> lista = new List<ObjekatView>();
            try
            {
                ISession s = DataLayer.GetSession();

                IQuery q = s.CreateQuery("from Objekat");

                IList<Objekat> obj = q.List<Objekat>();

                foreach (Objekat m in obj)
                {
                    lista.Add(new ObjekatView(m));
                }

                s.Close();

            }
            catch
            {

            }
            return lista;
        }

        public static Objekat getObjekat(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Objekat o = s.Load<Objekat>(id);

                s.Close();

                return o;
            }
            catch
            {

            }
            return null;
        }

        public static ObjekatView getObjekatView(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Objekat o = s.Load<Objekat>(id);

                ObjekatView ov = new ObjekatView(o);

                s.Close();

                return ov;
            }
            catch
            {

            }
            return null;
        }

        public static void addObjekat(Objekat objekat)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                s.Save(objekat);

                s.Flush();
                s.Close();
            }
            catch
            {

            }
        }

        public static void updateObjekat(ObjekatView objekat)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Objekat o = s.Load<Objekat>(objekat.Id);
                o.Tip = objekat.Tip;
                o.Povrsina = objekat.Povrsina;
                o.Adresa = objekat.Adresa;
                
                s.Update(o);

                s.Flush();
                s.Close();
            }
            catch
            {

            }
        }

        public static void deleteObjekat(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Objekat o = s.Load<Objekat>(id);

                

                s.Delete(o);

                s.Flush();

                s.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.InnerException.Message);
            }
        }

        public static void addKontaktTelefon(int idObj, string telefon)
        {
            try
            {
                ISession session = DataLayer.GetSession();
                Objekat objekat = session.Load<Objekat>(idObj);
                KontaktTelefon kt = new KontaktTelefon();
                kt.Telefon = telefon;
                kt.IdObjekta = objekat;

                session.Save(kt);

                objekat.Telefoni.Add(kt);
                session.Save(objekat);
                session.Flush();
                session.Close();
            }
            catch
            {

            }
        }

        #endregion

        #region RegionalniCentri
        public static List<RegionalniCentarView> getCentre()
        {
            List<RegionalniCentarView> lista = new List<RegionalniCentarView>();
            try
            {
                ISession s = DataLayer.GetSession();

                IQuery q = s.CreateQuery("from RegionalniCentar");

                IEnumerable<RegionalniCentar> obj = q.Enumerable<RegionalniCentar>();

                foreach (RegionalniCentar m in obj)
                {
                    lista.Add(new RegionalniCentarView(m));
                }
                s.Close();
            }
            catch
            {

            }
            return lista;
        }



        public static RegionalniCentarView getCentarView(int id)
        {

            try
            {
                ISession s = DataLayer.GetSession();

                IQuery q = s.CreateQuery("select o from RegionalniCentar o where o.Id = ? ");
                q.SetInt32(0, id);


                RegionalniCentar o = q.UniqueResult<RegionalniCentar>();
                RegionalniCentarView r = new RegionalniCentarView(o);

                s.Close();

                return r;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.Message);
            }
            return null;
        }

        public static RegionalniCentar getCentar(int id)
        {

            try
            {
                ISession s = DataLayer.GetSession();

                RegionalniCentar r = s.Load<RegionalniCentar>(id);

                s.Close();

                return r;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.Message);
            }
            return null;
        }

        public static void AddRegionalniCentar(RegionalniCentar m)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                s.Save(m);

                s.Flush();
                s.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.InnerException.Message);
            }

        }

        public static void updateRegionalniCentar(RegionalniCentarView r)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                RegionalniCentar reg = s.Load<RegionalniCentar>(r.Id);

                reg.Adresa = r.Adresa;

                s.Update(reg);

                s.Flush();
                s.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.InnerException.Message);
            }
        }

        public static void deleteRegionalniCentar(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                RegionalniCentar r = s.Load<RegionalniCentar>(id);

                s.Delete(r);

                s.Flush();
                s.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.InnerException.Message);
            }
        }
        #endregion

        #region BrojTelefona

        public static void deleteBrojTelefona(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                KontaktTelefon r = s.Load<KontaktTelefon>(id);

                s.Delete(r);

                s.Flush();
                s.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.InnerException.Message);
            }
        }

        public static void deleteTelefon(int id)
        {
            try
            {
                ISession session = DataLayer.GetSession();

                BrojTelefona b = session.Load<BrojTelefona>(id);

                session.Delete(b);

                session.Flush();
                session.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.InnerException.Message);
            }
        }

        public static void addTelefon(int id, string t)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Objekat r = s.Load<Objekat>(id);

                KontaktTelefon g = new KontaktTelefon();

                g.IdObjekta = r;
                g.Telefon = t;
                s.Save(g);

                r.Telefoni.Add(g);

                s.Save(r);

                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.Message);
            }
        }

        public static void addBrojTelefona(int idr, string m)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                RegionalniCentar r = s.Load<RegionalniCentar>(idr);

                BrojTelefona g = new BrojTelefona();

                g.Centar = r;
                g.BrTel = m;
                s.Save(g);

                r.Telefoni.Add(g);

                s.Save(r);

                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.Message);
            }
        }

        #endregion

        #region GradCentar

        public static void deleteGradCentar(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                GradCentar r = s.Load<GradCentar>(id);

                s.Delete(r);

                s.Flush();
                s.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.InnerException.Message);
            }
        }

        public static void addGradCentar(GradCentar m)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                s.Save(m);

                s.Flush();
                s.Close();
            }
            catch
            {

            }
        }

        public static void addGradCentar(int idr, string m)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                RegionalniCentar r = s.Load<RegionalniCentar>(idr);

                GradCentar g = new GradCentar();

                g.Centar = r;
                g.Grad = m;
                s.Save(g);

                r.Gradovi.Add(g);

                s.Save(r);

                s.Flush();
                s.Close();
            }
            catch
            {

            }
        }

        #endregion


        #region Vozilo

        public static List<VoziloView> getVozila()
        {
            List<VoziloView> lista = new List<VoziloView>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Vozilo> v = s.Query<Vozilo>()
                                            .Select(p => p);

                foreach (Vozilo m in v)
                {
                    lista.Add(new VoziloView(m));
                }

                s.Close();
            }
            catch
            {

            }
            return lista;
        }

        public static Vozilo getVozilo(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Vozilo v = s.Load<Vozilo>(id);

                s.Close();

                return v;
            }
            catch
            {

            }
            return null;
        }

        public static List<VoziloView> getVozilaCentra(int id)
        {
            List<VoziloView> lista = new List<VoziloView>();
            try
            {
                ISession s = DataLayer.GetSession();

                RegionalniCentar r = s.Load<RegionalniCentar>(id);

                IEnumerable<Vozilo> v = s.Query<Vozilo>()
                                            .Where(p => (p.PripadaCentru==r))
                                            .Select(p => p);

                foreach (Vozilo m in v)
                {
                    lista.Add(new VoziloView(m));
                }

                s.Close();

            }
            catch
            {

            }
            return lista;
        }

        public static void updateVozilo(VoziloView v)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Vozilo vozilo = s.Load<Vozilo>(v.Id);

                vozilo.Model = v.Model;
                vozilo.Tip = v.Tip;
                vozilo.Proizvodjac = v.Proizvodjac;
                vozilo.RegistarskaOznaka = v.RegistarskaOznaka;
                vozilo.Boja = v.Boja;

                s.Update(vozilo);

                s.Flush();
                s.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.InnerException.Message);
            }
        }

        public static void AddVozilo(Vozilo v)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                s.Save(v);

                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.Message);
            }
        }
        #endregion

        #region Intervencija

        public static List<IntervencijaView> getintervencije()
        {
            List<IntervencijaView> lista = new List<IntervencijaView>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<VrsiIntervenciju> obj = from o in s.Query<VrsiIntervenciju>()
                                                    select o;

                foreach (VrsiIntervenciju m in obj)
                {
                    lista.Add(new IntervencijaView(m));
                }

                s.Close();

            }
            catch
            {

            }
            return lista;
        }

        public static IntervencijaView getIntervencijaView(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                VrsiIntervenciju vi = s.Load<VrsiIntervenciju>(id);//da pitamo jel moze load i koja je razlika u odnosu na query? jel mora query?

                IntervencijaView intervencija = new IntervencijaView(vi);

                s.Close();

                return intervencija;
            }
            catch
            {

            }
            return null;
        }

        public static void addIntervencija(VrsiIntervenciju intervencija)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                s.Save(intervencija);

                s.Flush();
                s.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.InnerException.Message);
            }
        }

        public static void updateIntervencija(IntervencijaView view)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                VrsiIntervenciju intervencija = s.Load<VrsiIntervenciju>(view.Id);
                intervencija.OpisTipa = view.OpisTipa;
                intervencija.Datum = view.Datum;
                intervencija.UObjektu = s.Load<Objekat>(view.Objektic.Id);
                intervencija.VrsiEkipa = s.Load<Ekipa>(view.Ekipica.Id);

                s.SaveOrUpdate(intervencija);

                s.Flush();
                s.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.InnerException.Message);
            }
        }

        #endregion

        #region Ekipe

        public static void deleteEkipa(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Ekipa e = s.Load<Ekipa>(id);

                s.Delete(e);
                s.Flush();
                s.Close();
            }
            catch
            {

            }
        }

        public static List<EkipaView> getEkipe()
        {
            List<EkipaView> lista = new List<EkipaView>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Ekipa> obj = from o in s.Query<Ekipa>()
                                         select o;

                foreach (Ekipa m in obj)
                {
                    lista.Add(new EkipaView(m));
                }

                s.Close();
            }
            catch
            {

            }
            return lista;
        }

        public static Ekipa getEkipa(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Ekipa e = s.Load<Ekipa>(id);

                s.Close();

                return e;
            }
            catch
            {

            }
            return null;
        }

        public static EkipaView getEkipaView(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Ekipa e = s.Load<Ekipa>(id);
                EkipaView ev = new EkipaView(e);

                s.Close();

                return ev;
            }
            catch
            {

            }
            return null;
        }

        public static void addEkipa(Ekipa ekipa)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                s.Save(ekipa);

                s.Flush();
                s.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("addEkipa \n " + e.InnerException.Message);
            }
        }

        public static void addClanaEkipe(int idEkipe, int idClana)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                FizickoObezbedjenje fizickoObezbedjenje = s.Load<FizickoObezbedjenje>(idClana);
                Ekipa ekipa = s.Load<Ekipa>(idEkipe);

                fizickoObezbedjenje.PripadaEkipi = ekipa;

                s.SaveOrUpdate(fizickoObezbedjenje);

                ekipa.ClanoviEkipe.Add(fizickoObezbedjenje);

                s.SaveOrUpdate(ekipa);

                s.Flush();
                s.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("addClan \n " + e.InnerException.Message);
            }
        }

        public static List<BasicZaposleniView> getNerasporedjeni()
        {
            List<BasicZaposleniView> lista = new List<BasicZaposleniView>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<FizickoObezbedjenje> obj = from o in s.Query<FizickoObezbedjenje>()
                                                       where o.PripadaEkipi == null
                                                       select o;


                foreach (FizickoObezbedjenje m in obj)
                {
                    lista.Add(new BasicZaposleniView(m));
                }

                s.Close();

            }
            catch
            {

            }
            return lista;
        }

        #endregion

        #region Smene
        public static List<SmenaView> getSmene()
        {
            List<SmenaView> lista = new List<SmenaView>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Smena> obj = from o in s.Query<Smena>()
                                         select o;

                foreach (Smena m in obj)
                {
                    lista.Add(new SmenaView(m));
                }

                s.Close();
            }
            catch
            {

            }
            return lista;
        }

        public static void AddSmene(Smena m)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                s.Save(m);

                s.Flush();
                s.Close();
            }
            catch
            {

            }
        }

        public static void updateSmena(DateTime p, DateTime k, int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Smena sm = s.Load<Smena>(id);

                sm.Pocetak = p;
                sm.Kraj = k;


                s.Update(sm);

                s.Flush();
                s.Close();
            }
            catch
            {

            }
        }
        #endregion

        #region Alarm

        public static void deleteAlarm(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Alarm a = s.Load<Alarm>(id);

                s.Delete(a);

                s.Flush();
                s.Close();
            }
            catch
            {
                
            }
        }

        #region Detektor pokreta
        

        public static void addDetektorPokreta(DetektorPokreta alarm)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                s.Save(alarm);

                

                s.Flush();
                s.Close();

               
            }
            catch (Exception e)
            {
                MessageBox.Show(e.InnerException.Message);
            }
        }
        public static void addInstaliran(ObjekatView o,int ida)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Objekat ob = s.Load<Objekat>(o.Id);
                Alarm a = s.Load<Alarm>(ida);


                Instaliran i = new Instaliran();
                i.InstaliranAlarm = a;
                i.UObjektu = ob;
                i.Datum = DateTime.Today;
                s.Save(i);



                s.Flush();
                s.Close();


            }
            catch (Exception e)
            {
                MessageBox.Show(e.InnerException.Message);
            }
            
        }

        #endregion

        #region Ultrazvucni alarm

        public static void addUltrazvucniAlarm(UltrazvucniAlarm alarm)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                s.Save(alarm);

                s.Flush();
                s.Close();

                
            }
            catch
            {

            }
        }

        #endregion

        #region Toplotni odraz

        public static void addToplotniOdraz(ToplotniOdraz alarm)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                s.Save(alarm);

                s.Flush();
                s.Close();

                
            }
            catch (Exception e)
            {
                MessageBox.Show(e.InnerException.Message);
            }
        }

        #endregion

        public static void addTehnicarAlarm(int idTehnicara, int idAlarma)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                TehnickoLice tehnickoLice = s.Load<TehnickoLice>(idTehnicara);
                Alarm alarm = s.Load<Alarm>(idAlarma);

                ZaduzenZa zz = new ZaduzenZa();
                zz.Od = DateTime.Today;
                zz.ZaAlarm = alarm;
                zz.ZaduzenTehnicar = tehnickoLice;

                s.Save(zz);

                

                s.Flush();
                s.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.InnerException.Message);
            }
        }

        public static List<AlarmView> getAlarmi()
        {
            List<AlarmView> lista = new List<AlarmView>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Alarm> obj = from o in s.Query<Alarm>()
                                         select o;

                foreach (Alarm m in obj)
                {
                    lista.Add(new AlarmView(m));
                }

                s.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.InnerException.Message);
            }
            return lista;
        }

        public static List<AlarmView> getAlarmi(int id)
        {
            List<AlarmView> lista = new List<AlarmView>();
            try
            {
                ISession s = DataLayer.GetSession();

                
                IEnumerable<Alarm> obj = from o in s.Query<Alarm>()
                                         select o;


                foreach (Alarm m in obj)
                {
                    if (m.Objekti.Where(x => x.Id == id).ToList().Count() > 0)
                    {
                        lista.Add(new AlarmView(m));
                    }
                }

                s.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.InnerException.Message);
            }
            return lista;
        }

        #endregion

        public static List<SmenaView> getSmeneEkipa(int idEkipe)
        {
            List<SmenaView> lista = new List<SmenaView>();
            try
            {
                ISession s = DataLayer.GetSession();

                Ekipa ekipa = s.Load<Ekipa>(idEkipe);

                IEnumerable<Smena> obj= from o in s.Query<Radi>()
                                        where o.Ekipica==ekipa
                                        select o.RadiUSmeni;

                foreach (Smena m in obj)
                {
                    lista.Add(new SmenaView(m));
                }

                s.Close();
            }
            catch
            {

            }
            return lista;
        }

        public static List<ObjekatView> getObjekteZaEkipu(int ide)
        {
            List<ObjekatView> lista = new List<ObjekatView>();
            try
            {
                ISession s = DataLayer.GetSession();

                Ekipa e = s.Load<Ekipa>(ide);

                foreach (Objekat m in e.Objekti)
                {
                    lista.Add(new ObjekatView(m));
                }

                s.Close();
            }
            catch
            {

            }
            return lista;
        }
        public static List<VoziloView> getVozilaEkipe(int idEkipe)
        {
            List<VoziloView> lista = new List<VoziloView>();
            try
            {
                ISession s = DataLayer.GetSession();

                Ekipa e = s.Load<Ekipa>(idEkipe);

                IQuery q = s.CreateQuery("from Duzi as o where o.UzelaEkipa = ?");
                q.SetParameter(0, e);


                IList<Duzi> d = q.List<Duzi>();


                foreach (Duzi m in d)
                {
                    lista.Add(new VoziloView(m.UzetoVozilo));
                }

                s.Close();
            }
            catch
            {

            }
            return lista;
        }
        public static void addObjekatEkipi(int ido, int ide)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Ekipa e = s.Load<Ekipa>(ide);
                Objekat o = s.Load<Objekat>(ido);

                if (!e.Objekti.Contains(o))
                {
                    e.Objekti.Add(o);
                    s.SaveOrUpdate(e);
                }
                s.Flush();
                s.Close();
            }
            catch
            {

            }
        }
        public static void addSmenaEkipi(int ids, int ide)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Ekipa e = s.Load<Ekipa>(ide);
                Smena o = s.Load<Smena>(ids);

                if (!e.Smene.Contains(o))
                {
                    e.Smene.Add(o);
                    s.SaveOrUpdate(e);
                }
                s.Flush();
                s.Close();
            }
            catch
            {

            }
        }
        public static void addDuzi(Duzi d)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                s.Save(d);

                s.Flush();
                s.Close();
            }
            catch
            {

            }
        }

        public static List<MenadzerView> getMenadzereIzCentra(int id)
        {
            List<MenadzerView> lista = new List<MenadzerView>();
            try
            {
                ISession s = DataLayer.GetSession();


                RegionalniCentar regC = s.Load<RegionalniCentar>(id);

                foreach (Menadzer m in regC.Menadzeri)
                {
                    lista.Add(new MenadzerView(m));
                }
                s.Close();
            }
            catch
            {

            }
            return lista;
        }

        public static void addJeZaduzen(JeZaduzen m)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                s.Save(m);

                s.Flush();
                s.Close();
            }
            catch
            {

            }
        }

    }
}
