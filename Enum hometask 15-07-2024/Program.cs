using Enum_hometask_15_07_2024;
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Choose an action:");
        Console.WriteLine("1. Create and fill a weapon");
        Console.WriteLine("2. Fire the weapon");
        Console.WriteLine("3. Check next bullet");

        Weapon weapon = null;

        while (true)
        {
            var input = Console.ReadKey(intercept: true);
            Console.Clear();

            switch (input.KeyChar)
            {
                case '1':
                    weapon = new Weapon(BulletType.mm7_62, 10);
                    weapon.Fill();
                    break;
                case '2':
                    if (weapon != null)
                    {
                        weapon.Fire();
                    }
                    else
                    {
                        Console.WriteLine("No weapon created yet!");
                    }
                    break;
                case '3':
                    if (weapon != null)
                    {
                        weapon.PullTrigger();
                    }
                    else
                    {
                        Console.WriteLine("No weapon created yet!");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid option! Choose 1, 2 or 3.");
                    break;
            }

            Console.WriteLine("Choose an action:");
            Console.WriteLine("1. Create and fill a weapon");
            Console.WriteLine("2. Fire the weapon");
            Console.WriteLine("3. Check next bullet");
        }
    }
}