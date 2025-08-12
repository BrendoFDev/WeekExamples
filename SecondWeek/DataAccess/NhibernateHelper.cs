using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using SecondWeek.DataAccess.Mapping;

namespace SecondWeek.DataAccess
{
    public class NhibernateHelper
    {
        private  ISessionFactory? _sessionFactory;

        public  ISessionFactory CreateSessionFactory()
        {
            var cfg = Fluently.Configure()
                  .Database(PostgreSQLConfiguration.Standard
                      .ConnectionString("Server=localhost;Port=5432;Database=WeekExample;User Id=postgres;Password=softlog;"))
                      .Mappings(m => m.FluentMappings.AddFromAssemblyOf<PizzaMapping>())
                      .BuildConfiguration();

          /*  new SchemaExport(cfg).Create(useStdOut: true, execute: true);*/

            return cfg.BuildSessionFactory();
        }

        public ISession OpenSession()
        {
            if (_sessionFactory == null)
            {
                _sessionFactory = CreateSessionFactory();
            }
            return _sessionFactory.OpenSession();
        }

    }
}
