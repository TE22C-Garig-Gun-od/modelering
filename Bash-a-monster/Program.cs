Player thePlayer = new Player();
Goomba theGoomba = new Goomba();


thePlayer.name = "Zero";

Console.WriteLine($"{thePlayer.name} has {thePlayer.Health} health");
Console.WriteLine($"{theGoomba.name} has {theGoomba.Health} health and {theGoomba.Size} size");

Console.WriteLine("SPECIAL MOVE: SWORD STYLE 100");
theGoomba.Health = 10;
 
Console.WriteLine($"{theGoomba.name} now has {theGoomba.Health} health");
Console.WriteLine("Press space to continue..");


Console.ReadKey();

    