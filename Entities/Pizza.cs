namespace FirstWeekExemples.Entities
{
    public abstract class Pizza
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public List<string> Ingredients { get; set; } = new List<string>() {"Massa sovada eu acho", "Extrato de tomate", "Queijo", "Oregano"};

        public virtual void ShowIngredients(List<string> ingredients)
        {
            foreach(string ingredient in ingredients)
            {
                Console.WriteLine($"- {ingredient}");
            }
        }

        public abstract void GetDetails();
    }
}
