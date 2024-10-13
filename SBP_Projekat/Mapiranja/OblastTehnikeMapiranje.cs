using FluentNHibernate.Mapping;


namespace SBP_Projekat.Mapiranja
{
    class OblastTehnikeMapiranje : ClassMap<Entiteti.OblastTehnike>
    {
        public OblastTehnikeMapiranje()
        {
            Table("OBLAST_TEHNIKE");

            Id(x => x.Id).GeneratedBy.TriggerIdentity().UnsavedValue(-1);

            Map(x => x.ObTeh, "OblastTehnike");

            References(x => x.TehLice).Column("IdZaposlenog");
        }
    }
}
