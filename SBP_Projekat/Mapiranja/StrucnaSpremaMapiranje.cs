using FluentNHibernate.Mapping;
using SBP_Projekat.Entiteti;

namespace SBP_Projekat.Mapiranja
{
    class StrucnaSpremaMapiranje:ClassMap<StrucnaSprema>
    {
        public StrucnaSpremaMapiranje()
        {
            Table("STRUCNA_SPREMA");

            Id(x => x.Id, "Id").GeneratedBy.TriggerIdentity().UnsavedValue(-1);

            Map(x => x.StrucnaSpremaTehnicara, "StrucnaSprema");

            References(x => x.TehLice).Column("IdZaposlenog");
        }
    }
}
