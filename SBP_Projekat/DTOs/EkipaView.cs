using SBP_Projekat.Entiteti;

namespace SBP_Projekat.DTOs
{
    public class EkipaView
    {
        public int Id { get; set; }
        public FizickoObezbedjenjeView Vodja { get; set; }
        public int BrojObjekata { get; set; }
       // public IList<ObjekatView> Objekti { get; set; } //???? da li broj objekata ili sve objekte da izlistamo?????
        //public IList<FizickoObezbedjenjeView> ClanoviEkipe { get; set; }

        public EkipaView()
        {

        }
        public EkipaView(Ekipa e)
        {
            this.Id = e.Id;
            this.Vodja = new FizickoObezbedjenjeView(e.Vodja);
            this.BrojObjekata = e.Objekti.Count;
           /* this.Objekti = new List<ObjekatView>(); //OVA VARIJANTA SE KORISTI AKO RESIMO DA IMAMO LISTU SVIH OBJEKATA
            foreach (Objekat o in e.Objekti)
            {
                this.Objekti.Add(new ObjekatView(o));
            }
            this.ClanoviEkipe = new List<FizickoObezbedjenjeView>();
            foreach (FizickoObezbedjenje z in e.ClanoviEkipe)
            {
                this.ClanoviEkipe.Add(new FizickoObezbedjenjeView(z));//trebalo bi da je ovo dobro, pitanje samo da li kod zaposlenih u zavisnosti od
                //toga kog je tipa zaposleni odnosno koju poziciju ima treba da se pamte neke druge informacije u view
            }*/
        }

        public override string ToString()
        {
            string a = Id + " " + Vodja;
            return a;
        }
    }
}
