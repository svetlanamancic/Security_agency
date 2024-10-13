using FluentNHibernate.Mapping;
using SBP_Projekat.Entiteti;

namespace SBP_Projekat.Mapiranja
{
    class VrsiIntervencijuMapiranje : ClassMap<VrsiIntervenciju>
    {
        public VrsiIntervencijuMapiranje()
        {
            Table("VRSI_INTERVENCIJU");

            Id(x => x.Id, "Id").GeneratedBy.TriggerIdentity().UnsavedValue(-1);

            Map(x => x.Datum, "Datum");
            Map(x => x.Vreme, "Vreme");
            Map(x => x.OpisTipa, "OpisTipa");

            References(x => x.VrsiEkipa).Column("IdEkipe");
            References(x => x.UObjektu).Column("IdObjekta");
        }
    }
}
