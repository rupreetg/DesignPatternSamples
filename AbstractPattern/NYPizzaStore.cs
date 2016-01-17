
namespace AbstractPattern
{
    public class NYPizzaStore : PizzaStore
    {
        public NYPizzaStore(PizzaFactory _factory) : base(_factory)
        {
            factory = _factory;
        }
        protected override Pizza CreatePizza(string pizzaType)
        {
            return factory.CreatePizza(pizzaType);
        }
    }
}
