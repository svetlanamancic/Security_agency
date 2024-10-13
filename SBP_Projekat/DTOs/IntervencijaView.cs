using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SBP_Projekat.Entiteti;

namespace SBP_Projekat.DTOs
{
    public class IntervencijaView
    {
        public int Id { get; set; }
        public String OpisTipa { get; set; }
        public DateTime Datum { get; set; }
        public DateTime Vreme { get; set; }
        public ObjekatView Objektic { get; set; }
        public EkipaView Ekipica { get; set; }
    
        public IntervencijaView()
        {

        }

        public IntervencijaView(VrsiIntervenciju y)
        {
            this.Id = y.Id;
            this.OpisTipa = y.OpisTipa;
            this.Datum = y.Datum;
            this.Vreme = y.Vreme;
            this.Objektic = new ObjekatView(y.UObjektu);
            this.Ekipica = new EkipaView(y.VrsiEkipa);
        }
 
    }
}

