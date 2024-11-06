using DecoratorPattern.Interfaces;

namespace DecoratorPattern.Pizzas;
public class Pepperoni : IPizza
{
    public decimal Cost { get; set; } = 7.5m;
    public List<string> Ingredients { get; set; } = ["Tomato sauce", "Cheese", "Pepperoni"];
}
