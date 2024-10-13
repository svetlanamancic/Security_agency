using FluentNHibernate.Mapping;
using SBP_Projekat.Entiteti;

namespace SBP_Projekat.Mapiranja
{
    class DuziMapiranje : ClassMap<Duzi>
    {
        public DuziMapiranje()
        {
            //Mapiranje tabele
            Table("DUZI");

            //mapiranje primarnog kljuca
            Id(x => x.Id, "Id").GeneratedBy.TriggerIdentity().UnsavedValue(-1);

            //mapiranje svojstava.
            Map(x => x.Od, "Od");
            Map(x => x.Do, "Do");

            
            //mapiranje veza
            References(x => x.UzetoVozilo).Column("IdVozila");
            References(x => x.UzelaEkipa).Column("IdEkipe");
        }
    }
}
