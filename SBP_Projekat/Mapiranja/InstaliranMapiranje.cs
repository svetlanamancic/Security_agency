using FluentNHibernate.Mapping;
using SBP_Projekat.Entiteti;

namespace SBP_Projekat.Mapiranja
{
    class InstaliranMapiranje : ClassMap<Instaliran>
    {
        public InstaliranMapiranje()
        {

            //Mapiranje tabele
            Table("INSTALIRAN");

            //mapiranje primarnog kljuca
            Id(x => x.Id, "Id").GeneratedBy.TriggerIdentity().UnsavedValue(-1);

            //mapiranje svojstava.
            Map(x => x.Datum, "Datum");

            //mapiranje veza
            References(x => x.UObjektu).Column("IdObjekta");
            References(x => x.InstaliranAlarm).Column("IdAlarma");

        }


    }
}
