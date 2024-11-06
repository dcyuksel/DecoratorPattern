using DecoratorPattern.Decorators;
using DecoratorPattern.Interfaces;

namespace DecoratorPattern.Extensions;
public static class DecoratorExtensions
{
    public static IPizza AddCheese(this IPizza pizza)
    {
        return new AddCheeseDecorator(pizza);
    }

    public static IPizza AddMushrooms(this IPizza pizza)
    {
        return new AddMushroomsDecorator(pizza);
    }

    public static IPizza AddOlives(this IPizza pizza)
    {
        return new AddOlivesDecorator(pizza);
    }
}
