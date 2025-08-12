namespace SecondWeek.Entities
{
    public class Pizza
    {
        public virtual int Id { get; set; } 
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual decimal Price { get; set; }
    }
}
