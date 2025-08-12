
namespace FirstWeek.Entities
{
    public class PizzaPortuguesa : Pizza
    {
        // sobreescrevendo o método ShowIngredients da classe Pai
        public override void ShowIngredients(List<string> ingredients)
        {
            Console.WriteLine("Ingredientes da Pizza Portuguesa:");
            // base serve para chamar o método ShowIngredients da classe Pai

            base.ShowIngredients(ingredients);

            // depois você consegue criar o comportamento específico da classe filha
        }

        //implementando o método GetDetails da classe abstrata Pai
    
    }
}
