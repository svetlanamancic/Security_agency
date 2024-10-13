using FluentNHibernate.Mapping;
using SBP_Projekat.Entiteti;

namespace SBP_Projekat.Mapiranja
{
    class KontaktTelefonMapiranje : ClassMap<KontaktTelefon>
    {
        public KontaktTelefonMapiranje()
        {
            Table("KONTAKT_TELEFON");

            Id(x => x.Id, "Id").GeneratedBy.TriggerIdentity().UnsavedValue(-1);

            Map(x => x.Telefon).Column("Telefon");

            References(x => x.IdObjekta).Column("IdObjekta");




        }
    }
}
