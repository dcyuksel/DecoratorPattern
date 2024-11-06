using DecoratorPattern.Interfaces;

namespace DecoratorPattern.Decorators;
public class AddCheeseDecorator(IPizza pizza) : IPizza
{
    public decimal Cost { get; set; } = pizza.Cost + 0.5m;
    public List<string> Ingredients { get; set; } = [.. pizza.Ingredients, "Extra cheese"];
}
