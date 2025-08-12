using NHibernate;
using SecondWeek.DataAccess;
using SecondWeek.Entities;
using System.Text.Json;
using System.Text.Json.Serialization;

public static class Program
{
    private static ISession session;
    public static void Main(string[] args)
    {
        NhibernateHelper helper = new NhibernateHelper();
        session = helper.OpenSession();

        var pizza = new Pizza
        {
            Name = "Portuguesa",
            Description = "Contém: queijo, orégano, extrato de tomate, presunto, ovo.",
            Price = 8.99m
        };

        // como podemos melhorar essa consulta??
        var pizzas = session.Query<Pizza>().ToList();

        // realmente é necessario buscar todos e verificar se existe?
        if (pizzas.Any(x=>x.Name.Equals(pizza.Name)))
        {
            Console.WriteLine("Pizza já existe no banco de dados.");
            Thread.Sleep(5000);
            return;
        }

            
        SavePizza(pizza);

        Thread.Sleep(5000);
    }


    public static void SavePizza(object obj)
    {
        using (var transaction = session.BeginTransaction())
        {
            try
            {
                session.Save(obj);
                transaction.Commit();
                Console.WriteLine("Registro salvo com sucesso.");
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                Console.WriteLine($"An error occurred: {ex.Message}");
                throw new Exception("Erro ao salvar o registro.", ex); 
            }
        }
    }
}



