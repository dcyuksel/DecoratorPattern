using DecoratorPattern.Interfaces;

namespace DecoratorPattern.Pizzas;
public class Margartia : IPizza
{
    public decimal Cost { get; set; } = 5.5m;
    public List<string> Ingredients { get; set; } = ["Tomato sauce", "Mozzarella", "Basil"];
}
