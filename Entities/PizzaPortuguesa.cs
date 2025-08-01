
namespace FirstWeekExemples.Entities
{
    public class PizzaPortuguesa : Pizza
    {
        public override void ShowIngredients(List<string> ingredients)
        {
            // base serve para chamar o método ShowIngredients da classe Pai
            base.ShowIngredients(ingredients);

            // depois você consegue criar o comportamento específico da classe filha

        }
        public override void GetDetails()
        {
            Console.WriteLine("Pizza portuguesa");
        }
    }
}
