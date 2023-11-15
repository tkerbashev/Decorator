using Decorator;

Console.Title = "Decorator";
Console.WriteLine( "Decorator Structural Design Pattern example" );
Console.WriteLine();

var comeHomeByBus = new ComeHomeByBus();
var comeHomeByCar = new ComeHomeByCar();

var grosseriesDecorator = new ComeHomeBuyGrosseries(comeHomeByCar);
Console.WriteLine( grosseriesDecorator.Describe );

Console.WriteLine();

var drinksDecorator = new ComeHomeHaveDringWithFriends( comeHomeByBus );
Console.WriteLine( drinksDecorator.Describe );

