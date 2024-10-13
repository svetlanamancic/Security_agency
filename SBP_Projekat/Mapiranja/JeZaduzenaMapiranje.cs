using FluentNHibernate.Mapping;
using SBP_Projekat.Entiteti;

namespace SBP_Projekat.Mapiranja
{
    class JeZaduzenaMapiranje : ClassMap<JeZaduzena>
    {
        public JeZaduzenaMapiranje()
        {
            Table("JE_ZADUZENA");

            Id(x => x.Id, "Id").GeneratedBy.TriggerIdentity().UnsavedValue(-1);

            References(x => x.ZaduzenaZaObjekat).Column("IdObjekta");
            References(x => x.ZaduzenaEkipa).Column("IdEkipe");
        }
    }
}
