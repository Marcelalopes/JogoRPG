using JogoRPG.src.Entities;

Knigth arus = new Knigth("Arus", 23, "Knigth", 10, 4);
Wizard topapa = new Wizard("Topapa", 11, "Black Wizard",10,6);


Console.WriteLine(arus.Attack(arus.PowerAttack1));
topapa.TotalHeart1 = topapa.Hearth1 - arus.PowerAttack1;
Console.WriteLine(topapa.Name1 +" tem "+(topapa.TotalHeart1)+" vida(s)");
