using FluentNHibernate.Mapping;
using SBP_Projekat.Entiteti;

namespace SBP_Projekat.Mapiranja
{
    class ZaduzenZaMapiranje : ClassMap<ZaduzenZa>
    {
        public ZaduzenZaMapiranje()
        {
            Table("ZADUZEN_ZA");

            Id(x => x.Id, "Id").GeneratedBy.TriggerIdentity().UnsavedValue(-1);

            Map(x => x.Do, "Do");
            Map(x => x.Od, "Od");

            References(x => x.ZaduzenTehnicar).Column("IdZaposlenog");
            References(x => x.ZaAlarm).Column("IdAlarma");
        }
    }
}
