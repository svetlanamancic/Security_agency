using SBP_Projekat.Entiteti;
using FluentNHibernate.Mapping;

namespace SBP_projekat.Mapiranja
{
    class ObjekatMapiranje : ClassMap<Objekat>
    {
        public ObjekatMapiranje()
        {
            Table("OBJEKAT");

            Id(x => x.Id, "Id").GeneratedBy.TriggerIdentity().UnsavedValue(-1);

            Map(x => x.Adresa, "Adresa");
            Map(x => x.Tip, "Tip");
            Map(x => x.Povrsina, "Povrsina");

            HasMany(x => x.ListaObidjen).KeyColumn("IdObjekta").LazyLoad().Cascade.All().Inverse();
            HasManyToMany(x => x.Smene).Table("OBIDJEN").ParentKeyColumn("IdObjekta").ChildKeyColumn("IdSmene").LazyLoad().Cascade.All();

            HasMany(x => x.ListaJeZaduzena).KeyColumn("IdObjekta").LazyLoad().Cascade.All().Inverse();
            HasManyToMany(x => x.Ekipe).Table("JE_ZADUZENA").ParentKeyColumn("IdObjekta").ChildKeyColumn("IdEkipe").LazyLoad().Cascade.All();

            HasMany(x => x.ListaInstaliran).KeyColumn("IdObjekta").LazyLoad().Cascade.All().Inverse();
            HasManyToMany(x => x.Alarmi).Table("INSTALIRAN").ParentKeyColumn("IdObjekta").ChildKeyColumn("IdAlarma").LazyLoad().Cascade.All();

            HasMany(x => x.ListaIntervencije).KeyColumn("IdObjekta").LazyLoad().Cascade.All().Inverse();
            HasManyToMany(x => x.EkipeVrsileIntervenciju).Table("VRSI_INTERVENCIJU").ParentKeyColumn("IdObjekta").ChildKeyColumn("IdEkipe").LazyLoad().Cascade.All();

            HasMany(x => x.Telefoni).KeyColumn("IdObjekta").LazyLoad().Cascade.All().Inverse();
        }
    }
}
