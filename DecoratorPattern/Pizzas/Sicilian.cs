using DecoratorPattern.Interfaces;

namespace DecoratorPattern.Pizzas;
public class Sicilian : IPizza
{
    public decimal Cost { get; set; } = 7;
    public List<string> Ingredients { get; set; } = ["Tomato sauce", "Onions", "Anchovies", "Tomatoes"];
}
