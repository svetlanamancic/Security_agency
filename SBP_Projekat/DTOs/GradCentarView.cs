using SBP_Projekat.Entiteti;


namespace SBP_Projekat.DTOs
{
    public class GradCentarView
    {
        public int Id { get; set; }
        public string Grad { get; set; }
        //public RegionalniCentarView Centar { get; set; }

        public GradCentarView()
        {

        }
        public GradCentarView(GradCentar gc)
        {
            this.Id = gc.Id;
            this.Grad = gc.Grad;
            //this.Centar = new RegionalniCentarView(gc.Centar);
        }
    }
}
