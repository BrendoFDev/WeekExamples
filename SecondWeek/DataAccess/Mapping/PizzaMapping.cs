using FluentNHibernate.Mapping;
using SecondWeek.Entities;

namespace SecondWeek.DataAccess.Mapping
{
    public class PizzaMapping : ClassMap<Pizza>
    {
        public PizzaMapping()
        {
            Table("Pizza");
            Id(x => x.Id).Column("id").GeneratedBy.Identity();
            Map(x => x.Name).Column("name").Not.Nullable();
            Map(x => x.Description).Column("description").Nullable();
            Map(x => x.Price).Column("price").Not.Nullable();
        }
    }
}
