using DecoratorPattern.Extensions;
using DecoratorPattern.Interfaces;
using DecoratorPattern.Pizzas;

var margherita = new Margartia();
Console.WriteLine(Print(margherita));

var margheritaWithCheese = new Margartia().AddCheese();
Console.WriteLine(Print(margheritaWithCheese));

var margheritaWithCheeseAndMushrooms = new Margartia().AddCheese().AddMushrooms();
Console.WriteLine(Print(margheritaWithCheeseAndMushrooms));

var sicilian = new Sicilian();
Console.WriteLine(Print(margheritaWithCheeseAndMushrooms));

var sicilianWithDoubleOlives = new Sicilian().AddOlives().AddOlives();
Console.WriteLine(Print(sicilianWithDoubleOlives));

var sicilianWithMushroomAndDoubleCheese = new Sicilian().AddMushrooms().AddCheese().AddCheese();
Console.WriteLine(Print(sicilianWithMushroomAndDoubleCheese));

var pepperoni = new Pepperoni();
Console.WriteLine(Print(pepperoni));

var pepperoniWithDoubleCheese = new Sicilian().AddCheese().AddCheese();
Console.WriteLine(Print(pepperoniWithDoubleCheese));

var pepperoniWithWithMushroom = new Sicilian().AddMushrooms();
Console.WriteLine(Print(pepperoniWithWithMushroom));

var customVegetarianPizza = new SimplePizza().AddOlives().AddMushrooms();
Console.WriteLine(Print(customVegetarianPizza));

static string Print(IPizza pizza) => $"Cost:{pizza.Cost} - Ingredients: {string.Join(" ,", pizza.Ingredients)}.";