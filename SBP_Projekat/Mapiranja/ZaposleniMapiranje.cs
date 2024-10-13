using FluentNHibernate.Mapping;

namespace SBP_Projekat.Mapiranja
{
    class ZaposleniMapiranje:ClassMap<Entiteti.Zaposleni>
    {
        public ZaposleniMapiranje()
        {
            Table("ZAPOSLENI");

            //mapiranje podklasa
            DiscriminateSubClassesOnColumn("Pozicija");

            Id(x => x.Id, "Id").GeneratedBy.TriggerIdentity().UnsavedValue(-1);

            //mapiranje svojstava
            Map(x=>x.JMBG,"JMBG");
            Map(x=>x.Ime,"Ime");
            Map(x=>x.Prezime,"Prezime");
            Map(x => x.DatRodj, "DatRodj");
            Map(x=>x.Pol,"Pol");


        }
    }
    class MenadzerMapiranje:SubclassMap<Entiteti.Menadzer>
    {
        public MenadzerMapiranje()
        {
            DiscriminatorValue("Menadzer");

            HasMany(x => x.Gradovi).KeyColumn("IdZaposlenog").LazyLoad().Cascade.All().Inverse();
            HasMany(x => x.ListaJeZaduzen).KeyColumn("IdZaposlenog").LazyLoad().Cascade.All().Inverse();
            HasManyToMany(x => x.ListaCentara).Table("JE_ZADUZEN").ParentKeyColumn("IdZaposlenog").ChildKeyColumn("IdCentra").LazyLoad().Cascade.All();
        }
    }
    class FizickoObezbedjenjeMapiranje : SubclassMap<Entiteti.FizickoObezbedjenje>
    {
        public FizickoObezbedjenjeMapiranje()
        {
            DiscriminatorValue("Fizicko obezbedjenje");
            References(x => x.PripadaEkipi).Column("IdEkipe");

            HasMany(x => x.BorilackeVestine).KeyColumn("IdZaposlenog").LazyLoad().Cascade.All().Inverse();
        }
    }
    class TehnickoLiceMapiranje: SubclassMap<Entiteti.TehnickoLice>
    {
        public TehnickoLiceMapiranje()
        {
            DiscriminatorValue("Tehnicko lice");

            HasMany(x => x.StrucneSpreme).KeyColumn("IdZaposlenog").LazyLoad().Cascade.All().Inverse();
            HasMany(x => x.OblastiTehnike).KeyColumn("IdZaposlenog").LazyLoad().Cascade.All().Inverse();
            HasMany(x => x.ListaZaduzenja).KeyColumn("IdZaposlenog").LazyLoad().Cascade.All().Inverse();
            HasManyToMany(x => x.ListaAlarma).Table("ZADUZEN_ZA").ParentKeyColumn("IdZaposlenog").ChildKeyColumn("IdAlarma").LazyLoad().Cascade.All();
        }
    }
}
