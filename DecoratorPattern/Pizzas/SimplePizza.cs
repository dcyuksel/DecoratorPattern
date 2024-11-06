using DecoratorPattern.Interfaces;

namespace DecoratorPattern.Pizzas;
public class SimplePizza : IPizza
{
    public decimal Cost { get; set; } = 5;
    public List<string> Ingredients { get; set; } = ["Tomato sauce"];
}
