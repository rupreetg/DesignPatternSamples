
namespace AbstractPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            NYPizzaFactory factory = new NYPizzaFactory();
            NYPizzaStore store = new NYPizzaStore(factory);
            store.OrderPizza("cheese");
        }
    }
}
