using FluentNHibernate.Mapping;
using SBP_Projekat.Entiteti;

namespace SBP_Projekat.Mapiranja
{
    public class ObidjenMapiranje : ClassMap<Obidjen>
    {
        public ObidjenMapiranje()
        {
            Table("OBIDJEN");

            Id(x => x.Id, "Id").GeneratedBy.TriggerIdentity().UnsavedValue(-1);

            References(x => x.IdSmene).Column("IdSmene");
            References(x => x.IdObjekta).Column("IdObjekta");
        }

    }
}
