using FluentNHibernate.Mapping;


namespace SBP_Projekat.Mapiranja
{
    class GradMenadzerMapiranje : ClassMap<Entiteti.GradMenadzer>
    {
        public GradMenadzerMapiranje()
        {
            Table("GRAD_MENADZER");

            Id(x => x.Id).GeneratedBy.TriggerIdentity().UnsavedValue(-1);

            Map(x => x.Grad, "GradMenadzer");

            References(x => x.MenadzerGrada).Column("IdZaposlenog");
        }
    }
}
