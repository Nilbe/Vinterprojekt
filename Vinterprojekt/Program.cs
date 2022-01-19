using System;

int P1HP = 100;

int P2HP = 100;

 
Console.WriteLine("P1 chose your name");
string name = Console.ReadLine();

Console.WriteLine("P2 now chose your name");
string name2 = Console.ReadLine();


Console.WriteLine(name + " HP: " + P1HP); 
Console.WriteLine(name2 + " HP: " + P2HP);
Console.WriteLine("Press Enter To Atack");
Console.ReadLine(); 


while (P1HP >= 0 && P2HP >= 0)
{
    Random generator = new Random();

    int damage = generator.Next(10, 30);
    int damage2 = generator.Next(10, 30);

    P1HP = P1HP-damage2;
    P2HP= P2HP-damage;

    Console.WriteLine(name + " HP: " + P1HP + ". Does " + damage + " points of damage on " + name2);
    Console.WriteLine(name2 + " HP: " + P2HP + ". Does " + damage2 + " points of damage on " + name);
    Console.WriteLine("Press Enter To Atack Again");

    Console.ReadLine();
}


if (P1HP <= 0 && P2HP <= 0)
{
    Console.WriteLine("DRAW, BOTH HAS DIED!!!");
}

else if (P1HP <= 0)
{
    Console.WriteLine("KO!!! " + name2 + " has beaten " + name + "!");
}
else if (P2HP <= 0)
{
    Console.WriteLine("KO!!! " + name + " has beaten " + name2 + "!");
}

Console.ReadLine(); 