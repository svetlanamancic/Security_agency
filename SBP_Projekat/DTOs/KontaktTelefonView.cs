using SBP_Projekat.Entiteti;

namespace SBP_Projekat.DTOs
{
    public class KontaktTelefonView
    {
        public int Id { get; set; }
        public string Telefon { get; set; }
        //public ObjekatView Objekat { get; set; }

        public KontaktTelefonView()
        {

        }

        public KontaktTelefonView(KontaktTelefon k)
        {
            this.Id = k.Id;
            this.Telefon = k.Telefon;
            //this.Objekat = new ObjekatView(k.IdObjekta);
        }
    }
}
