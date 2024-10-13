using SBP_Projekat.Entiteti;

namespace SBP_Projekat.DTOs
{
    public class BorilackaVestinaView
    {
        public int Id { get; set; }
        public string Vestina { get; set; }
       // public FizickoObezbedjenjeView FizOb { get; set; }

        public BorilackaVestinaView()
        {

        }
        public BorilackaVestinaView(BorilackaVestina b)
        {
            this.Id = b.Id;
            this.Vestina = b.Vestina;
           // this.FizOb = new FizickoObezbedjenjeView(b.FizOb);
        }
    }
}
