using FirstWeek.Entities;
Pizza pizzaCalab = new PizzaCalabresa();
pizzaCalab.Name = "Pizza Calabresa";
pizzaCalab.Description = "Pizza com Calabresa, queijo e ketchup";
pizzaCalab.Price = 30;

string[] ingredientesArray = new string[]
{
    "Queijo",
    "cebola",
    "presunto",
    "Calabresa",
    "Alho"
};

pizzaCalab.Ingredients.AddRange(ingredientesArray);

Pizza pizzaPort = new PizzaPortuguesa();
pizzaPort.Name = "Pizza Portuguesa";
pizzaPort.Description = " Pizza com Presunto, Queijo, Ovo, Cebola e Azeitona";
pizzaPort.Price = 12;

ingredientesArray = new string[]
{
    "Queijo",
    "Cebola",
    "Presunto",
    "OvO",
    "Azeitona"
};
pizzaPort.Ingredients.AddRange(ingredientesArray);

List<Pizza> pizzas = new List<Pizza>()
{
    pizzaCalab,
    pizzaPort
};

List<Pizza> prices = pizzas.Where(x => x.Ingredients.Contains("Cebola")).ToList();
foreach (Pizza pizza in prices)
{
 
   pizza.GetDetails();
}
Thread.Sleep(10000);