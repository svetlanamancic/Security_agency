using FluentNHibernate.Mapping;
using SBP_Projekat.Entiteti;

namespace SBP_Projekat.Mapiranja
{
    class BrojTelefonaMapiranje : ClassMap<BrojTelefona>
    {
        public BrojTelefonaMapiranje()
        {
            Table("BROJ_TELEFONA");

            Id(x => x.Id, "Id").GeneratedBy.TriggerIdentity().UnsavedValue(-1);

            Map(x => x.BrTel, "BrojTelefona");

            References(x => x.Centar).Column("IdCentra");
        }
    }
}
