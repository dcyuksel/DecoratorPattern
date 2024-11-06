using DecoratorPattern.Interfaces;

namespace DecoratorPattern.Decorators;
public class AddMushroomsDecorator(IPizza pizza) : IPizza
{
    public decimal Cost { get; set; } = pizza.Cost + 1;
    public List<string> Ingredients { get; set; } = [.. pizza.Ingredients, "Extra mushrooms"];
}
