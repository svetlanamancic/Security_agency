using SBP_Projekat.Entiteti;

namespace SBP_Projekat.DTOs
{
    public class GradMenadzerView
    {
        public int Id { get; set; }
        public string Grad { get; set; }
        //public MenadzerView MenadzerGrada { get; set; }

        public GradMenadzerView()
        {

        }
        public GradMenadzerView(GradMenadzer gm)
        {
            this.Id = gm.Id;
            this.Grad = gm.Grad;
            //this.MenadzerGrada = new MenadzerView(gm.MenadzerGrada);
        }
    }
}
