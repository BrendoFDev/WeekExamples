using FirstWeekExemples.Entities;

Pizza pizza = new PizzaPortuguesa();
pizza.Name = "Pizza Portuguesa";
pizza.Description = "Pizza com ovo, cebola, presunto e azeitona";
pizza.Price = 29.99M;

string[] ingredientesArray = new string[]
{
    "Ovo",
    "Cebola",
    "Presunto",
    "Azeitona"
};

pizza.Ingredients.AddRange(ingredientesArray);

pizza.GetDetails();
pizza.ShowIngredients(pizza.Ingredients);

Thread.Sleep(5000); // Pausa de 5 segundos para visualizar a saída antes de fechar o console
