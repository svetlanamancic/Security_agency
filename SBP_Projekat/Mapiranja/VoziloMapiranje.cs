using FluentNHibernate.Mapping;

namespace SBP_Projekat.Mapiranja
{
    class VoziloMapiranje : ClassMap<Entiteti.Vozilo>
    {
        public VoziloMapiranje()
        {
            // mapiranje tabele
            Table("VOZILO");

            // mapiranje primary key
            Id(x => x.Id, "Id").GeneratedBy.TriggerIdentity().UnsavedValue(-1);

            // mapiranje svojstava
            Map(x => x.RegistarskaOznaka, "RegistarskaOznaka");
            Map(x => x.Boja, "Boja");
            Map(x => x.Tip, "Tip");
            Map(x => x.Model, "Model");
            Map(x => x.Proizvodjac, "Proizvodjac");

            References(x => x.PripadaCentru).Column("IdCentra");

            HasMany(x => x.ListaDuzi).KeyColumn("IdVozila").LazyLoad().Cascade.All().Inverse();
            HasManyToMany(x => x.Ekipe).Table("DUZI").ParentKeyColumn("IdVozila").ChildKeyColumn("IdEkipe").LazyLoad().Cascade.All();
        }
    }
}
