
namespace AbstractPattern
{
    public abstract class PizzaStore
    {
        protected PizzaFactory factory;
        public PizzaStore(PizzaFactory _factory) 
        {
            factory = _factory;
        }

        public Pizza OrderPizza(string pizzaType)
        {
            Pizza pizza = CreatePizza(pizzaType);
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Pack();

            return pizza;
        }

        protected abstract Pizza CreatePizza(string pizzaType);
    }
}
