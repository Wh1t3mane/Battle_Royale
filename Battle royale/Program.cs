using Battle_royale;
using System;
using System.Threading.Channels;
Game game = new Game();
game.Start();

/*
Enemy enemy = new Enemy();
Console.WriteLine("Enemy health: "+enemy.MaxHealth());

Fighter fighter = new Fighter();
Console.WriteLine("Fighter health: "+fighter.MaxHealth());

Knight knight = new Knight();
Console.WriteLine("Knight health: "+knight.MaxHealth());

Sorcerer sorcerer = new Sorcerer();
Console.WriteLine("Sorcerer health: " + sorcerer.MaxHealth());

Beast beast = new Beast();
Console.WriteLine("Beast health: "+beast.MaxHealth());

Console.WriteLine(fighter);*/

Enemy e1 = new Enemy();
e1.MaxHealth();
Console.WriteLine("E1 má: "+e1.Health()+"hp");
Enemy e2 = new Enemy();
e2.MaxHealth();
Console.WriteLine("E2 má: "+e2.Health()+"hp");
Enemy[] combatants = new Enemy[] { e1, e2 };
int combAlive = combatants.Length;
int round = 0;
/*FUNGUJE
while (combAlive > 1) {
    Console.WriteLine("-- " + round++ + " --");
    foreach (var c in combatants){
        var x = c.PickOpponent(combatants);
        Console.WriteLine("Napadne s: "+c.Attack()+"dmg");
        Console.WriteLine("Zbyde: "+c.Result()+"hp");
    }
    combAlive = 0;
    foreach (var c in combatants) {
        if (c.IsLive() == true) {
            combAlive++;
            Console.WriteLine("IsLive: "+c.IsLive());
        }
        else
        {
            Console.WriteLine("IsLive: "+c.IsLive());
        }
         
    }
}*/
/*
int e1Attack = 0;
int e2Attack = 0;
int e1Result = 0;
int e2Result = 0;
while (combAlive > 1) {
    Console.WriteLine("-- " + round++ + " --");
    foreach (var c in combatants)
    {
        
        if (c == e1)
        {
            e1Attack = c.Attack();
            Console.WriteLine("E1 napadne s: "+e1Attack+"dmg");
        }
        else if (c == e2)
        {
            e2Attack = c.Attack();
            //var x = c.PickOpponent(combatants);
            Console.WriteLine("E2 napadne s: "+e2Attack+"dmg");
            
        }

        e1Result = c.Result(e2Attack);
        e2Result = c.Result(e1Attack);
        Console.WriteLine("E1 zbyde: "+e1Result+"hp");
        Console.WriteLine("E2 zbyde: "+e2Result+"hp");
        
        
    }
    combAlive = 0;
    foreach (var c in combatants) {
        if (e1Result > 0 ) {
            combAlive++;
            bool e1IsAlive = c.IsLive();
            Console.WriteLine("E1 IsLive: "+e1IsAlive);
        }
        else if (e2Result > 0)
        {
            combAlive++;
            bool e2IsAlive = c.IsLive();
            Console.WriteLine("E2 IsLive: "+e2IsAlive);
        }

    }
}*/



