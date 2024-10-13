using SBP_Projekat.Entiteti;

namespace SBP_Projekat.DTOs
{
    public class BrojTelefonaView
    {
        public int Id { get; set; }
        public string BrTel { get; set; }
       // public RegionalniCentarView Centar { get; set; }

        public BrojTelefonaView()
        {

        }
        public BrojTelefonaView(BrojTelefona b)
        {
            this.Id = b.Id;
            this.BrTel = b.BrTel;
            //this.Centar = new RegionalniCentarView(b.Centar);
        }
    }
}
