
namespace AbstractPattern
{
    public class PizzaFactory
    {
        public virtual Pizza CreatePizza(string pizzaType)
        {
            switch (pizzaType)
            {
                case "cheese":
                    return null;
                case "pepproni":
                    return null;
                default:
                    return null; 
            }
            
        }
    }
}