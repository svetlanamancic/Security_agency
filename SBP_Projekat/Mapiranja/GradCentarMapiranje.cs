using FluentNHibernate.Mapping;
using SBP_Projekat.Entiteti;

namespace SBP_Projekat.Mapiranja
{
    class GradCentarMapiranje : ClassMap<GradCentar>
    {
        public GradCentarMapiranje()
        {
            Table("GRAD_CENTAR");

            Id(x => x.Id, "Id").GeneratedBy.TriggerIdentity().UnsavedValue(-1);

            Map(x => x.Grad).Column("Grad");

            References(x => x.Centar).Column("IdCentra");
        }
    }
}
