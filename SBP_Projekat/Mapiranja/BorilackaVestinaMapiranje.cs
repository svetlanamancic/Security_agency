using FluentNHibernate.Mapping;


namespace SBP_Projekat.Mapiranja
{
    class BorilackaVestinaMapiranje : ClassMap<Entiteti.BorilackaVestina>
    {
        public BorilackaVestinaMapiranje()
        {
            Table("BORILACKA_VESTINA");

            Id(x => x.Id).GeneratedBy.TriggerIdentity().UnsavedValue(-1);

            Map(x => x.Vestina, "BorilackaVestina");

            References(x => x.FizOb).Column("IdZaposlenog");
        }


    }
}
