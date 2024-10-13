using FluentNHibernate.Mapping;
using SBP_Projekat.Entiteti;

namespace SBP_projekat.Mapiranja
{
    class RegionalniCentarMapiranje : ClassMap<RegionalniCentar>
    {
        public RegionalniCentarMapiranje()
        {
            Table("REGIONALNI_CENTAR");
            Id(x => x.Id, "Id").GeneratedBy.TriggerIdentity().UnsavedValue(-1);

            Map(x => x.Adresa, "Adresa");

            HasMany(x => x.ListaJeZaduzen).KeyColumn("IdCentra").LazyLoad().Cascade.All().Inverse();
            HasManyToMany(x => x.Menadzeri).Table("JE_ZADUZEN").ParentKeyColumn("IdCentra").ChildKeyColumn("IdZaposlenog").LazyLoad().Cascade.All();

            HasMany(x => x.Telefoni).KeyColumn("IdCentra").LazyLoad().Cascade.All().Inverse();
            HasMany(x => x.Gradovi).KeyColumn("IdCentra").LazyLoad().Cascade.All().Inverse();
            HasMany(x => x.VozilaCentra).KeyColumn("IdCentra").LazyLoad().Cascade.All().Inverse();
        }
    }
}
