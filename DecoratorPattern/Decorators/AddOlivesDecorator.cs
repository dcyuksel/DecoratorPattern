using DecoratorPattern.Interfaces;

namespace DecoratorPattern.Decorators;
public class AddOlivesDecorator(IPizza pizza) : IPizza
{
    public decimal Cost { get; set; } = pizza.Cost + 0.55m;
    public List<string> Ingredients { get; set; } = [.. pizza.Ingredients, "Extra olives"];
}
