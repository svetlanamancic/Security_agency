using FluentNHibernate.Mapping;
using SBP_Projekat.Entiteti;


namespace SBP_Projekat.Mapiranja
{
    public class AlarmMapiranje : ClassMap<Alarm>

    {
        public AlarmMapiranje()
        {
            Table("ALARM");

            DiscriminateSubClassesOnColumn("TipAlarma");

            Id(x => x.Id, "Id").GeneratedBy.TriggerIdentity().UnsavedValue(-1);

            Map(x => x.GodinaProizvodnje, "GodinaProizvodnje");
            Map(x => x.Proizvodjac, "Proizvodjac");

            HasMany(x => x.ListaZaduzenZa).KeyColumn("IdAlarma").LazyLoad().Cascade.All().Inverse();
            HasManyToMany(x => x.TehnickaLica).Table("ZADUZEN_ZA").ParentKeyColumn("IdAlarma").ChildKeyColumn("IdZaposlenog").LazyLoad();
            
            HasMany(x => x.ListaInstaliran).KeyColumn("IdAlarma").LazyLoad().Cascade.All().Inverse();
            HasManyToMany(x => x.Objekti).Table("INSTALIRAN").ParentKeyColumn("IdAlarma").ChildKeyColumn("IdObjekta").LazyLoad();

        }
    }

    class DetektorPokretaMapiranja : SubclassMap<DetektorPokreta>
    {
        public DetektorPokretaMapiranja()
        {
            DiscriminatorValue("Detektor pokreta");

            Map(x => x.Osetljivost, "Osetljivost");
        }
    }

    class UltrazvucniAlarmMapiranja : SubclassMap<UltrazvucniAlarm>
    {
        public UltrazvucniAlarmMapiranja()
        {
            DiscriminatorValue("Ultrazvucni alarm");

            Map(x => x.Od, "OdOpseg");
            Map(x => x.Do, "DoOpseg");
        }
    }

    class ToplotniOdrazMapiranja : SubclassMap<ToplotniOdraz>
    {
        public ToplotniOdrazMapiranja()
        {
            DiscriminatorValue("Toplotni odraz");

            Map(x => x.HorizontalnaRezolucija, "HorRezolucija");
            Map(x => x.VertikalnaRezolucija, "VerRezolucija");
        }
    }


}
