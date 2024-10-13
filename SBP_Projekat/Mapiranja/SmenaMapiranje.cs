using FluentNHibernate.Mapping;

namespace SBP_Projekat.Mapiranja
{
    class SmenaMapiranje : ClassMap<Entiteti.Smena>
    {
        public SmenaMapiranje()
        {
            // mapiranje tabele
            Table("SMENA");

            // mapiranje primary key
            Id(x => x.Id, "Id").GeneratedBy.TriggerIdentity().UnsavedValue(-1);

            // mapiranje svojstava
            Map(x => x.Pocetak, "POCETAK");
            Map(x => x.Kraj, "KRAJ");

            HasMany(x => x.ListaRadi).KeyColumn("IdSmene").LazyLoad().Cascade.All().Inverse();
            HasManyToMany(x => x.Ekipe).Table("RADI").ParentKeyColumn("IdSmene").ChildKeyColumn("IdEkipe").LazyLoad().Cascade.All();

            HasMany(x => x.ListaObidjen).KeyColumn("IdSmene").LazyLoad().Cascade.All().Inverse();
            HasManyToMany(x => x.Objekti).Table("OBIDJEN").ParentKeyColumn("IdSmene").ChildKeyColumn("IdObjekta").LazyLoad().Cascade.All();


        }
    }
}
