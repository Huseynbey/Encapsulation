namespace encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class cls = new Class("678904", "Alex", "Foxtrot");
            cls.Article = "USB-hab";
            cls.Quantity = "6";
            cls.Price = 30;
            cls.CostCalculation(false);
        }
    }
}