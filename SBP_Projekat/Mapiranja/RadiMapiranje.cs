using FluentNHibernate.Mapping;
using SBP_Projekat.Entiteti;

namespace SBP_Projekat.Mapiranja
{
    class RadiMapiranje : ClassMap<Radi>
    {
        public RadiMapiranje()
        {
            Table("RADI");

            Id(x => x.Id, "Id").GeneratedBy.TriggerIdentity().UnsavedValue(-1);

            References(x => x.Ekipica).Column("IdEkipe");
            References(x => x.RadiUSmeni).Column("IdSmene");
        }
    }
}
