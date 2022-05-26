using JogoRPG.src.Entities;

Knigth arus = new Knigth("Arus", 23, "Knigth");
Wizard jenica = new Wizard("Jenica", 30, "White Wizard");
Wizard topapa = new Wizard("Topapa", 11, "Black Wizard");
Ninja wedge = new Ninja("Wedge", 10, "Ninja");

Console.WriteLine(arus.ToString());
Console.WriteLine(arus.Attack());

Console.WriteLine(jenica.ToString());
Console.WriteLine(jenica.Attack(1));

Console.WriteLine(topapa.ToString());
Console.WriteLine(topapa.Attack(8));

Console.WriteLine(wedge.ToString());
Console.WriteLine(wedge.Attack());