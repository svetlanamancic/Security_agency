using NHibernate;
using SBP_Projekat.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate.Linq;
using SBP_Projekat.DTOs;

namespace SBP_Projekat
{
    public class DataProvider
    {
        #region Zaposleni

        #region Menadzer

        public List<MenadzerView> GetMenadzeri()
        {
            List<MenadzerView> lista = new List<MenadzerView>();

            ISession s = DataLayer.GetSession();

            IEnumerable<Menadzer> menadzeri = s.Query<Menadzer>()
                                                .Select(p => p);

            foreach(Menadzer m in menadzeri)
            {
                lista.Add(new MenadzerView(m));
            }

            return lista;
        }

        public Menadzer GetMenadzer(int id)
        {
            ISession s = DataLayer.GetSession();

            return s.Query<Menadzer>()
                .Where(v => v.Id == id).Select(p => p).FirstOrDefault();
        }

        public MenadzerView GetMenadzerView(int id)
        {
            ISession s = DataLayer.GetSession();

            Menadzer men = s.Query<Menadzer>()
                .Where(v => v.Id == id).Select(p => p).FirstOrDefault();

            if (men == null) return new MenadzerView();

            return new MenadzerView(men);
        }

        public int AddMenadzer(Menadzer m)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                s.Save(m);

                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }

        public int RemoveMenadzer(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Menadzer m = s.Load<Menadzer>(id);

                s.Delete(m);

                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception exc)
            {
                return -1;
            }

        }
        public int UpdateMenadzer(int id, Menadzer m)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Menadzer men = s.Load<Menadzer>(id);

                s.Close();

                men = m;

                ISession s1 = DataLayer.GetSession();

                s1.Update(m);
                s1.Flush();
                s1.Close();

                return 1;
            }
            catch (Exception exc)
            {
                return -1;
            }
        }

        #endregion

        #region FizickoObezbedjenje

        public List<FizickoObezbedjenjeView> GetFizickaObezbedjenja()
        {
            List<FizickoObezbedjenjeView> lista = new List<FizickoObezbedjenjeView>();

            ISession s = DataLayer.GetSession();

            IEnumerable<FizickoObezbedjenje> f = s.Query<FizickoObezbedjenje>()
                                                .Select(p => p);

            foreach (FizickoObezbedjenje m in f)
            {
                lista.Add(new FizickoObezbedjenjeView(m));
            }

            return lista;
        }

        public FizickoObezbedjenje GetFizickoObezbedjenje(int id)
        {
            ISession s = DataLayer.GetSession();

            return s.Query<FizickoObezbedjenje>()
                .Where(f => f.Id == id).Select(p => p).FirstOrDefault();
        }

        public FizickoObezbedjenjeView GetFizickoObezbedjenjeView(int id)
        {
            ISession s = DataLayer.GetSession();

            FizickoObezbedjenje f = s.Query<FizickoObezbedjenje>()
                .Where(fiz => fiz.Id == id).Select(p => p).FirstOrDefault();

            if (f == null) return new FizickoObezbedjenjeView();

            return new FizickoObezbedjenjeView(f);
        }

        public int AddFizickoObezbedjenje(FizickoObezbedjenje f)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                s.Save(f);

                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }

        public int RemoveFizickoObezbedjenje(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                FizickoObezbedjenje f = s.Load<FizickoObezbedjenje>(id);

                s.Delete(f);

                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception exc)
            {
                return -1;
            }

        }
        public int UpdateFizickoObezbedjenje(int id, FizickoObezbedjenje f)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                FizickoObezbedjenje fiz = s.Load<FizickoObezbedjenje>(id);

                s.Close();

                fiz = f;

                ISession s1 = DataLayer.GetSession();

                s1.Update(fiz);
                s1.Flush();
                s1.Close();

                return 1;
            }
            catch (Exception exc)
            {
                return -1;
            }
        }

        #endregion

        #region TehnickoLice

        public List<TehnickoLiceView> GetTehnicari()
        {
            List<TehnickoLiceView> lista = new List<TehnickoLiceView>();

            ISession s = DataLayer.GetSession();

            IEnumerable<TehnickoLice> f = s.Query<TehnickoLice>()
                                                .Select(p => p);

            foreach (TehnickoLice m in f)
            {
                lista.Add(new TehnickoLiceView(m));
            }

            return lista;
        }

        public TehnickoLice GetTehnickoLice(int id)
        {
            ISession s = DataLayer.GetSession();

            return s.Query<TehnickoLice>()
                .Where(t => t.Id == id).Select(p => p).FirstOrDefault();
        }

        public TehnickoLiceView GetTehnickoLiceView(int id)
        {
            ISession s = DataLayer.GetSession();

            TehnickoLice t = s.Query<TehnickoLice>()
                .Where(v => v.Id == id).Select(p => p).FirstOrDefault();

            if (t == null) return new TehnickoLiceView();

            return new TehnickoLiceView(t);
        }

        public int AddTehnickoLice(TehnickoLice t)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                s.Save(t);

                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }

        public int RemoveTehnickoLice(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                TehnickoLice t = s.Load<TehnickoLice>(id);

                s.Delete(t);

                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception exc)
            {
                return -1;
            }

        }
        public int UpdateTehnickoLice(int id, TehnickoLice t)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                TehnickoLice teh = s.Load<TehnickoLice>(id);

                s.Close();

                teh = t;

                ISession s1 = DataLayer.GetSession();

                s1.Update(teh);
                s1.Flush();
                s1.Close();

                return 1;
            }
            catch (Exception exc)
            {
                return -1;
            }
        }

        #endregion

        #endregion

        #region Alarmi

        #region DetektorPokreta

        public List<DetektorPokretaView> GetDetektore()
        {
            List<DetektorPokretaView> lista = new List<DetektorPokretaView>();

            ISession s = DataLayer.GetSession();

            IEnumerable<DetektorPokreta> f = s.Query<DetektorPokreta>()
                                                .Select(p => p);

            foreach (DetektorPokreta m in f)
            {
                lista.Add(new DetektorPokretaView(m));
            }

            return lista;
        }

        public DetektorPokreta GetDetektor(int id)
        {
            ISession s = DataLayer.GetSession();

            return s.Query<DetektorPokreta>()
                .Where(d => d.Id == id).Select(p => p).FirstOrDefault();
        }

        public DetektorPokretaView GetDetektorPokretaView(int id)
        {
            ISession s = DataLayer.GetSession();

            DetektorPokreta d = s.Query<DetektorPokreta>()
                .Where(x => x.Id == id).Select(p => p).FirstOrDefault();

            if (d == null) return new DetektorPokretaView();

            return new DetektorPokretaView(d);
        }

        public int AddDetektorPokreta(DetektorPokreta d)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                s.Save(d);

                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }

        public int RemoveDetektorPokreta(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                DetektorPokreta d = s.Load<DetektorPokreta>(id);

                s.Delete(d);

                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception exc)
            {
                return -1;
            }

        }
        public int UpdateDetektorPokreta(int id, DetektorPokreta m)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                DetektorPokreta d = s.Load<DetektorPokreta>(id);

                s.Close();

                d = m;

                ISession s1 = DataLayer.GetSession();

                s1.Update(d);
                s1.Flush();
                s1.Close();

                return 1;
            }
            catch (Exception exc)
            {
                return -1;
            }
        }

        #endregion

        #region UltrazvucniAlarm

        public List<UltrazvucniAlarmView> GetUltrazvucneAlarme()
        {
            List<UltrazvucniAlarmView> lista = new List<UltrazvucniAlarmView>();

            ISession s = DataLayer.GetSession();

            IEnumerable<UltrazvucniAlarm> f = s.Query<UltrazvucniAlarm>()
                                                .Select(p => p);

            foreach (UltrazvucniAlarm m in f)
            {
                lista.Add(new UltrazvucniAlarmView(m));
            }

            return lista;
        }

        public UltrazvucniAlarm GetUltrazvucniAlarm(int id)
        {
            ISession s = DataLayer.GetSession();

            return s.Query<UltrazvucniAlarm>()
                .Where(v => v.Id == id).Select(p => p).FirstOrDefault();
        }

        public UltrazvucniAlarmView GetUltrazvucniAlarmView(int id)
        {
            ISession s = DataLayer.GetSession();

            UltrazvucniAlarm a = s.Query<UltrazvucniAlarm>()
                .Where(v => v.Id == id).Select(p => p).FirstOrDefault();

            if (a == null) return new UltrazvucniAlarmView();

            return new UltrazvucniAlarmView(a);
        }

        public int AddUltrazvucniAlarm(UltrazvucniAlarm a)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                s.Save(a);

                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }

        public int RemoveUltrazvucniAlarm(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                UltrazvucniAlarm a = s.Load<UltrazvucniAlarm>(id);

                s.Delete(a);

                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception exc)
            {
                return -1;
            }

        }
        public int UpdateUltrazvucniAlarm(int id, UltrazvucniAlarm a)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                UltrazvucniAlarm alarm = s.Load<UltrazvucniAlarm>(id);

                s.Close();

                alarm = a;

                ISession s1 = DataLayer.GetSession();

                s1.Update(alarm);
                s1.Flush();
                s1.Close();

                return 1;
            }
            catch (Exception exc)
            {
                return -1;
            }
        }

        #endregion

        #region ToplotniOdraz

        public List<ToplotniOdrazView> GetToplotneOdraze()
        {
            List<ToplotniOdrazView> lista = new List<ToplotniOdrazView>();

            ISession s = DataLayer.GetSession();

            IEnumerable<ToplotniOdraz> f = s.Query<ToplotniOdraz>()
                                                .Select(p => p);

            foreach (ToplotniOdraz m in f)
            {
                lista.Add(new ToplotniOdrazView(m));
            }

            return lista;
        }

        public ToplotniOdraz GetToplotniOdraz(int id)
        {
            ISession s = DataLayer.GetSession();

            return s.Query<ToplotniOdraz>()
                .Where(v => v.Id == id).Select(p => p).FirstOrDefault();
        }

        public ToplotniOdrazView GetToplotniOdrazView(int id)
        {
            ISession s = DataLayer.GetSession();

            ToplotniOdraz a = s.Query<ToplotniOdraz>()
                .Where(v => v.Id == id).Select(p => p).FirstOrDefault();

            if (a == null) return new ToplotniOdrazView();

            return new ToplotniOdrazView(a);
        }

        public int AddToplotniOdraz(ToplotniOdraz a)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                s.Save(a);

                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }

        public int RemoveToplotniOdraz(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ToplotniOdraz a = s.Load<ToplotniOdraz>(id);

                s.Delete(a);

                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception exc)
            {
                return -1;
            }

        }
        public int UpdateToplotniOdraz(int id, ToplotniOdraz a)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ToplotniOdraz alarm = s.Load<ToplotniOdraz>(id);

                s.Close();

                alarm = a;

                ISession s1 = DataLayer.GetSession();

                s1.Update(alarm);
                s1.Flush();
                s1.Close();

                return 1;
            }
            catch (Exception exc)
            {
                return -1;
            }
        }

        #endregion

        #endregion

        #region Visevrednosni

        #region BorilackaVestina

        public List<BorilackaVestinaView> GetBorilackeVestine()
        {
            List<BorilackaVestinaView> lista = new List<BorilackaVestinaView>();

            ISession s = DataLayer.GetSession();

            IEnumerable<BorilackaVestina> f = s.Query<BorilackaVestina>()
                                                .Select(p => p);

            foreach (BorilackaVestina m in f)
            {
                lista.Add(new BorilackaVestinaView(m));
            }

            return lista;
        }

        public BorilackaVestina GetBorilackaVestina(int id)
        {
            ISession s = DataLayer.GetSession();

            return s.Query<BorilackaVestina>()
                .Where(d => d.Id == id).Select(p => p).FirstOrDefault();
        }

        public BorilackaVestinaView GetBorilackaVestinaView(int id)
        {
            ISession s = DataLayer.GetSession();

            BorilackaVestina b = s.Query<BorilackaVestina>()
                .Where(x => x.Id == id).Select(p => p).FirstOrDefault();

            if ( b == null) return new BorilackaVestinaView();

            return new BorilackaVestinaView(b);
        }

        public int AddBorilackaVestina(BorilackaVestina b)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                s.Save(b);

                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }

        public int RemoveBorilackaVestina(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                BorilackaVestina b = s.Load<BorilackaVestina>(id);

                s.Delete(b);

                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception exc)
            {
                return -1;
            }

        }
        public int UpdateBorilackaVestina(int id, BorilackaVestina m)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                BorilackaVestina b = s.Load<BorilackaVestina>(id);

                s.Close();

                b = m;

                ISession s1 = DataLayer.GetSession();

                s1.Update(b);
                s1.Flush();
                s1.Close();

                return 1;
            }
            catch (Exception exc)
            {
                return -1;
            }
        }

        #endregion

        #region GradMenadzer

        public List<GradMenadzerView> GetGradoveSvihMenadzera()
        {
            List<GradMenadzerView> lista = new List<GradMenadzerView>();

            ISession s = DataLayer.GetSession();

            IEnumerable<GradMenadzer> f = s.Query<GradMenadzer>()
                                                .Select(p => p);

            foreach (GradMenadzer m in f)
            {
                lista.Add(new GradMenadzerView(m));
            }

            return lista;
        }

        public GradMenadzer GetGradMenadzer(int id)
        {
            ISession s = DataLayer.GetSession();

            return s.Query<GradMenadzer>()
                .Where(d => d.Id == id).Select(p => p).FirstOrDefault();
        }

        public GradMenadzerView GetGradMenadzerView(int id)
        {
            ISession s = DataLayer.GetSession();

            GradMenadzer gm = s.Query<GradMenadzer>()
                .Where(x => x.Id == id).Select(p => p).FirstOrDefault();

            if (gm == null) return new GradMenadzerView();

            return new GradMenadzerView(gm);
        }

        public int AddGradMenadzer(GradMenadzer gm)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                s.Save(gm);

                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }

        public int RemoveGradMenadzer(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                GradMenadzer gm = s.Load<GradMenadzer>(id);

                s.Delete(gm);

                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception exc)
            {
                return -1;
            }

        }
        public int UpdateGradMenadzer(int id, GradMenadzer g)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                GradMenadzer gm = s.Load<GradMenadzer>(id);

                s.Close();

                gm = g;

                ISession s1 = DataLayer.GetSession();

                s1.Update(gm);
                s1.Flush();
                s1.Close();

                return 1;
            }
            catch (Exception exc)
            {
                return -1;
            }
        }

        #endregion

        #region GradCentar

        public List<GradCentarView> GetGradoveCentara()
        {
            List<GradCentarView> lista = new List<GradCentarView>();

            ISession s = DataLayer.GetSession();

            IEnumerable<GradCentar> f = s.Query<GradCentar>()
                                                .Select(p => p);

            foreach (GradCentar m in f)
            {
                lista.Add(new GradCentarView(m));
            }

            return lista;
        }

        public GradCentar GetGradCentar(int id)
        {
            ISession s = DataLayer.GetSession();

            return s.Query<GradCentar>()
                .Where(d => d.Id == id).Select(p => p).FirstOrDefault();
        }

        public GradCentarView GetGradCentarView(int id)
        {
            ISession s = DataLayer.GetSession();

            GradCentar g = s.Query<GradCentar>()
                .Where(x => x.Id == id).Select(p => p).FirstOrDefault();

            if (g == null) return new GradCentarView();

            return new GradCentarView(g);
        }

        public int AddGradCentar(GradCentar g)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                s.Save(g);

                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }

        public int RemoveGradCentar(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                GradCentar g = s.Load<GradCentar>(id);

                s.Delete(g);

                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception exc)
            {
                return -1;
            }

        }
        public int UpdateGradCentar(int id, GradCentar g)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                GradCentar gc = s.Load<GradCentar>(id);

                s.Close();

                gc = g;

                ISession s1 = DataLayer.GetSession();

                s1.Update(gc);
                s1.Flush();
                s1.Close();

                return 1;
            }
            catch (Exception exc)
            {
                return -1;
            }
        }

        #endregion

        #region StrucnaSprema

        public List<StrucnaSpremaView> GetStrucneSpreme()
        {
            List<StrucnaSpremaView> lista = new List<StrucnaSpremaView>();

            ISession s = DataLayer.GetSession();

            IEnumerable<StrucnaSprema> f = s.Query<StrucnaSprema>()
                                                .Select(p => p);

            foreach (StrucnaSprema m in f)
            {
                lista.Add(new StrucnaSpremaView(m));
            }

            return lista;
        }

        public StrucnaSprema GetStrucnaSprema(int id)
        {
            ISession s = DataLayer.GetSession();

            return s.Query<StrucnaSprema>()
                .Where(d => d.Id == id).Select(p => p).FirstOrDefault();
        }

        public StrucnaSpremaView GetStrucnaSpremaView(int id)
        {
            ISession s = DataLayer.GetSession();

            StrucnaSprema ss = s.Query<StrucnaSprema>()
                .Where(x => x.Id == id).Select(p => p).FirstOrDefault();

            if (ss == null) return new StrucnaSpremaView();

            return new StrucnaSpremaView(ss);
        }

        public int AddStrucnaSprema(StrucnaSprema ss)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                s.Save(ss);

                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }

        public int RemoveStrucnaSprema(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                StrucnaSprema ss = s.Load<StrucnaSprema>(id);

                s.Delete(ss);

                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception exc)
            {
                return -1;
            }

        }
        public int UpdateStrucnaSprema(int id, StrucnaSprema str)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                StrucnaSprema ss = s.Load<StrucnaSprema>(id);

                s.Close();

                ss = str;

                ISession s1 = DataLayer.GetSession();

                s1.Update(ss);
                s1.Flush();
                s1.Close();

                return 1;
            }
            catch (Exception exc)
            {
                return -1;
            }
        }

        #endregion

        #region OblastTehnike

        public List<OblastTehnikeView> GetOblastiTehnike()
        {
            List<OblastTehnikeView> lista = new List<OblastTehnikeView>();

            ISession s = DataLayer.GetSession();

            IEnumerable<OblastTehnike> f = s.Query<OblastTehnike>()
                                                .Select(p => p);

            foreach (OblastTehnike m in f)
            {
                lista.Add(new OblastTehnikeView(m));
            }

            return lista;
        }

        public OblastTehnike GetOblastTehnike(int id)
        {
            ISession s = DataLayer.GetSession();

            return s.Query<OblastTehnike>()
                .Where(d => d.Id == id).Select(p => p).FirstOrDefault();
        }

        public OblastTehnikeView GetOblastTehnikeView(int id)
        {
            ISession s = DataLayer.GetSession();

            OblastTehnike ot = s.Query<OblastTehnike>()
                .Where(x => x.Id == id).Select(p => p).FirstOrDefault();

            if (ot == null) return new OblastTehnikeView();

            return new OblastTehnikeView(ot);
        }

        public int AddOblastTehnike(OblastTehnike ot)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                s.Save(ot);

                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }

        public int RemoveOblastTehnike(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                OblastTehnike ot = s.Load<OblastTehnike>(id);

                s.Delete(ot);

                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception exc)
            {
                return -1;
            }

        }
        public int UpdateOblastTehnike(int id, OblastTehnike obl)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                OblastTehnike ot = s.Load<OblastTehnike>(id);

                s.Close();

                ot = obl;

                ISession s1 = DataLayer.GetSession();

                s1.Update(ot);
                s1.Flush();
                s1.Close();

                return 1;
            }
            catch (Exception exc)
            {
                return -1;
            }
        }

        #endregion

        #region BrojTelefona

        public List<BrojTelefonaView> GetBrojeveTelefona()
        {
            List<BrojTelefonaView> lista = new List<BrojTelefonaView>();

            ISession s = DataLayer.GetSession();

            IEnumerable<BrojTelefona> f = s.Query<BrojTelefona>()
                                                .Select(p => p);

            foreach (BrojTelefona m in f)
            {
                lista.Add(new BrojTelefonaView(m));
            }

            return lista;
        }

        public BrojTelefona GetBrojTelefona(int id)
        {
            ISession s = DataLayer.GetSession();

            return s.Query<BrojTelefona>()
                .Where(b => b.Id == id).Select(p => p).FirstOrDefault();
        }

        public BrojTelefonaView GetBrojTelefonaView(int id)
        {
            ISession s = DataLayer.GetSession();

            BrojTelefona b = s.Query<BrojTelefona>()
                .Where(x => x.Id == id).Select(p => p).FirstOrDefault();

            if (b == null) return new BrojTelefonaView();

            return new BrojTelefonaView(b);
        }

        public int AddBrojTelefona(BrojTelefona b)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                s.Save(b);

                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }

        public int RemoveBrojTelefona(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                BrojTelefona b = s.Load<BrojTelefona>(id);

                s.Delete(b);

                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception exc)
            {
                return -1;
            }

        }
        public int UpdateBrojTelefona(int id, BrojTelefona br)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                BrojTelefona b = s.Load<BrojTelefona>(id);

                s.Close();

                b = br;

                ISession s1 = DataLayer.GetSession();

                s1.Update(b);
                s1.Flush();
                s1.Close();

                return 1;
            }
            catch (Exception exc)
            {
                return -1;
            }
        }

        #endregion

        #region KontaktTelefon

        public List<KontaktTelefonView> GetKontaktTelefone()
        {
            List<KontaktTelefonView> lista = new List<KontaktTelefonView>();

            ISession s = DataLayer.GetSession();

            IEnumerable<KontaktTelefon> f = s.Query<KontaktTelefon>()
                                                .Select(p => p);

            foreach (KontaktTelefon m in f)
            {
                lista.Add(new KontaktTelefonView(m));
            }

            return lista;
        }

        public KontaktTelefon GetKontaktTelefon(int id)
        {
            ISession s = DataLayer.GetSession();

            return s.Query<KontaktTelefon>()
                .Where(b => b.Id == id).Select(p => p).FirstOrDefault();
        }

        public KontaktTelefonView GetKontaktTelefonView(int id)
        {
            ISession s = DataLayer.GetSession();

            KontaktTelefon b = s.Query<KontaktTelefon>()
                .Where(x => x.Id == id).Select(p => p).FirstOrDefault();

            if (b == null) return new KontaktTelefonView();

            return new KontaktTelefonView(b);
        }

        public int AddKontaktTelefon(KontaktTelefon b)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                s.Save(b);

                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }

        public int RemoveKontaktTelefon(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                KontaktTelefon b = s.Load<KontaktTelefon>(id);

                s.Delete(b);

                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception exc)
            {
                return -1;
            }

        }
        public int UpdateKontaktTelefon(int id, KontaktTelefon br)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                KontaktTelefon b = s.Load<KontaktTelefon>(id);

                s.Close();

                b = br;

                ISession s1 = DataLayer.GetSession();

                s1.Update(b);
                s1.Flush();
                s1.Close();

                return 1;
            }
            catch (Exception exc)
            {
                return -1;
            }
        }

        #endregion

        #endregion

        #region Ekipa

        public List<EkipaView> GetEkipe()
        {
            List<EkipaView> lista = new List<EkipaView>();

            ISession s = DataLayer.GetSession();

            IEnumerable<Ekipa> f = s.Query<Ekipa>()
                                                .Select(p => p);

            foreach (Ekipa m in f)
            {
                lista.Add(new EkipaView(m));
            }

            return lista;
        }

        public Ekipa GetEkipa(int id)
        {
            ISession s = DataLayer.GetSession();

            return s.Query<Ekipa>()
                .Where(d => d.Id == id).Select(p => p).FirstOrDefault();
        }

        public EkipaView GetEkipaView(int id)
        {
            ISession s = DataLayer.GetSession();

            Ekipa e = s.Query<Ekipa>()
                .Where(x => x.Id == id).Select(p => p).FirstOrDefault();

            if (e == null) return new EkipaView();

            return new EkipaView(e);
        }

        public int AddEkipa(Ekipa e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                s.Save(e);

                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }

        public int RemoveEkipa(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Ekipa e = s.Load<Ekipa>(id);

                s.Delete(e);

                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception exc)
            {
                return -1;
            }

        }
        public int UpdateEkipa(int id, Ekipa ek)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Ekipa e = s.Load<Ekipa>(id);

                s.Close();

                e = ek;

                ISession s1 = DataLayer.GetSession();

                s1.Update(e);
                s1.Flush();
                s1.Close();

                return 1;
            }
            catch (Exception exc)
            {
                return -1;
            }
        }

        #endregion

        #region Objekat

        public List<ObjekatView> GetObjekte()
        {
            List<ObjekatView> lista = new List<ObjekatView>();

            ISession s = DataLayer.GetSession();

            IEnumerable<Objekat> f = s.Query<Objekat>()
                                                .Select(p => p);

            foreach (Objekat m in f)
            {
                lista.Add(new ObjekatView(m));
            }

            return lista;
        }

        public Objekat GetObjekat(int id)
        {
            ISession s = DataLayer.GetSession();

            return s.Query<Objekat>()
                .Where(d => d.Id == id).Select(p => p).FirstOrDefault();
        }

        public ObjekatView GetObjekatView(int id)
        {
            ISession s = DataLayer.GetSession();

            Objekat o = s.Query<Objekat>()
                .Where(x => x.Id == id).Select(p => p).FirstOrDefault();

            if (o == null) return new ObjekatView();

            return new ObjekatView(o);
        }

        public int AddObjekat(Objekat o)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                s.Save(o);

                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }

        public int RemoveObjekat(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Objekat o = s.Load<Objekat>(id);

                s.Delete(o);

                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception exc)
            {
                return -1;
            }

        }
        public int UpdateObjekat(int id, Objekat ob)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Objekat o = s.Load<Objekat>(id);

                s.Close();

                o = ob;

                ISession s1 = DataLayer.GetSession();

                s1.Update(o);
                s1.Flush();
                s1.Close();

                return 1;
            }
            catch (Exception exc)
            {
                return -1;
            }
        }

        #endregion

        #region RegionalniCentar

        public List<RegionalniCentarView> GetRegionalneCentre()
        {
            List<RegionalniCentarView> lista = new List<RegionalniCentarView>();

            ISession s = DataLayer.GetSession();

            IEnumerable<RegionalniCentar> f = s.Query<RegionalniCentar>()
                                                .Select(p => p);

            foreach (RegionalniCentar m in f)
            {
                lista.Add(new RegionalniCentarView(m));
            }

            return lista;
        }

        public RegionalniCentar GetRegionalniCentar(int id)
        {
            ISession s = DataLayer.GetSession();

            return s.Query<RegionalniCentar>()
                .Where(d => d.Id == id).Select(p => p).FirstOrDefault();
        }

        public RegionalniCentarView GetRegionalniCentarView(int id)
        {
            ISession s = DataLayer.GetSession();

            RegionalniCentar r = s.Query<RegionalniCentar>()
                .Where(x => x.Id == id).Select(p => p).FirstOrDefault();

            if (r == null) return new RegionalniCentarView();

            return new RegionalniCentarView(r);
        }

        public int AddRegionalniCentar(RegionalniCentar r)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                s.Save(r);

                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }

        public int RemoveRegionalniCentar(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                RegionalniCentar r = s.Load<RegionalniCentar>(id);

                s.Delete(r);

                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception exc)
            {
                return -1;
            }

        }
        public int UpdateRegionalniCentar(int id, RegionalniCentar rc)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                RegionalniCentar r = s.Load<RegionalniCentar>(id);

                s.Close();

                r = rc;

                ISession s1 = DataLayer.GetSession();

                s1.Update(r);
                s1.Flush();
                s1.Close();

                return 1;
            }
            catch (Exception exc)
            {
                return -1;
            }
        }

        #endregion

        #region Smena

        public List<SmenaView> GetSmene()
        {
            List<SmenaView> lista = new List<SmenaView>();

            ISession s = DataLayer.GetSession();

            IEnumerable<Smena> f = s.Query<Smena>()
                                                .Select(p => p);

            foreach (Smena m in f)
            {
                lista.Add(new SmenaView(m));
            }

            return lista;
        }

        public Smena GetSmena(int id)
        {
            ISession s = DataLayer.GetSession();

            return s.Query<Smena>()
                .Where(d => d.Id == id).Select(p => p).FirstOrDefault();
        }

        public SmenaView GetSmenaView(int id)
        {
            ISession s = DataLayer.GetSession();

            Smena sm = s.Query<Smena>()
                .Where(x => x.Id == id).Select(p => p).FirstOrDefault();

            if (sm == null) return new SmenaView();

            return new SmenaView(sm);
        }

        public int AddSmena(Smena sm)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                s.Save(sm);

                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }

        public int RemoveSmena(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Smena sm = s.Load<Smena>(id);

                s.Delete(sm);

                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception exc)
            {
                return -1;
            }

        }
        public int UpdateSmena(int id, Smena smena)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Smena sm = s.Load<Smena>(id);

                s.Close();

                sm = smena;

                ISession s1 = DataLayer.GetSession();

                s1.Update(sm);
                s1.Flush();
                s1.Close();

                return 1;
            }
            catch (Exception exc)
            {
                return -1;
            }
        }

        #endregion

        #region Vozilo

        public List<VoziloView> GetVozila()
        {
            List<VoziloView> lista = new List<VoziloView>();

            ISession s = DataLayer.GetSession();

            IEnumerable<Vozilo> f = s.Query<Vozilo>()
                                                .Select(p => p);

            foreach (Vozilo m in f)
            {
                lista.Add(new VoziloView(m));
            }

            return lista;
        }

        public Vozilo GetVozilo(int id)
        {
            ISession s = DataLayer.GetSession();

            return s.Query<Vozilo>()
                .Where(d => d.Id == id).Select(p => p).FirstOrDefault();
        }

        public VoziloView GetVoziloView(int id)
        {
            ISession s = DataLayer.GetSession();

            Vozilo v = s.Query<Vozilo>()
                .Where(x => x.Id == id).Select(p => p).FirstOrDefault();

            if (v == null) return new VoziloView();

            return new VoziloView(v);
        }

        public int AddVozilo(Vozilo v)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                s.Save(v);

                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }

        public int RemoveVozilo(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Vozilo v = s.Load<Vozilo>(id);

                s.Delete(v);

                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception exc)
            {
                return -1;
            }

        }
        public int UpdateVozilo(int id, Vozilo vozilo)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Vozilo v = s.Load<Vozilo>(id);

                s.Close();

                v = vozilo;

                ISession s1 = DataLayer.GetSession();

                s1.Update(v);
                s1.Flush();
                s1.Close();

                return 1;
            }
            catch (Exception exc)
            {
                return -1;
            }
        }

        #endregion
    }
}
