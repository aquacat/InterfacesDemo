using System;

namespace InterfacesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Elf legolas = new Elf("Legolas", 20);
            Console.WriteLine($"{legolas.Health}");
            Orc gral = new Orc("Gral", 15);
            Console.WriteLine($"{gral.Health}");
            while ((gral.Health > 0) && (legolas.Health > 0))
            {
                double Damage = legolas.Attack(gral.Armour);
                gral.TakeDamage(Damage);
                Console.WriteLine($"Gral's health: {gral.Health} Armour:{gral.Armour}");
                Damage = gral.Attack(legolas.Armour);
                legolas.TakeDamage(Damage);
                Console.WriteLine($"Legolas's health:{legolas.Health} Armour:{legolas.Armour}");

            }
            if (gral.Health > 0)
            {
                Console.WriteLine($"Gral Wins!");
            }
            else
            {
                Console.WriteLine($"Legolas Wins!");
            }
            

        }
    }
}