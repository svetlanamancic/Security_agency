using FluentNHibernate.Mapping;
using SBP_Projekat.Entiteti;

namespace SBP_Projekat.Mapiranja
{
    class JeZaduzenMapiranje : ClassMap<JeZaduzen>
    {
        public JeZaduzenMapiranje()
        {
            Table("JE_ZADUZEN");

            Id(x => x.Id, "Id").GeneratedBy.TriggerIdentity().UnsavedValue(-1);

            Map(x => x.ZaduzenOd, "ZaduzenOd");
            Map(x => x.ZaduzenDo, "ZaduzenDo");

            References(x => x.MenadzerCentra).Column("IdZaposlenog");
            References(x => x.Centar).Column("IdCentra");


        }
    }
}
