using FluentNHibernate.Mapping;

namespace SBP_Projekat.Mapiranja
{
    class EkipaMapiranje : ClassMap<Entiteti.Ekipa>
    {
        public EkipaMapiranje()
        {
            // mapiranje tabele
            Table("EKIPA");

            // mapiranje primary key
            Id(x => x.Id, "Id").GeneratedBy.TriggerIdentity().UnsavedValue(-1);

            References(x => x.Vodja, "IdVodje");

            HasMany(x => x.ClanoviEkipe).KeyColumn("IdEkipe").LazyLoad();

            HasMany(x => x.ListaDuzi).KeyColumn("IdEkipe").LazyLoad().Cascade.All().Inverse();
            HasManyToMany(x => x.Vozila).Table("DUZI").ParentKeyColumn("IdEkipe").ChildKeyColumn("IdVozila").LazyLoad().Cascade.All();

            HasMany(x => x.ListaRadi).KeyColumn("IdEkipe").LazyLoad().Cascade.All().Inverse();
            HasManyToMany(x => x.Smene).Table("RADI").ParentKeyColumn("IdEkipe").ChildKeyColumn("IdSmene").LazyLoad().Cascade.All();

            HasMany(x => x.ListaJeZaduzena).KeyColumn("IdEkipe").LazyLoad().Cascade.All().Inverse();
            HasManyToMany(x => x.Objekti).Table("JE_ZADUZENA").ParentKeyColumn("IdEkipe").ChildKeyColumn("IdObjekta").LazyLoad().Cascade.All();

            HasMany(x => x.ListaIntervencije).KeyColumn("IdEkipe").LazyLoad().Cascade.All().Inverse();
            HasManyToMany(x => x.IntervencijeUObjektima).Table("VRSI_INTERVENCIJU").ParentKeyColumn("IdEkipe").ChildKeyColumn("IdObjekta").LazyLoad().Cascade.All();


        }
    }
}
