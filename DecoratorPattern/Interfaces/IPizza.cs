namespace DecoratorPattern.Interfaces;
public interface IPizza
{
    decimal Cost { get; set; }
    List<string> Ingredients { get; set; }
}
