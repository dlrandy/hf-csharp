﻿using AbilityScoreTester;
namespace PaintballGame
{
    public class ConstructorTest
    {
        public int i = 1;
        public ConstructorTest()
        {
            Console.WriteLine($"i is {i}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            new ConstructorTest();
            int numebrOfBalls = ReadInt(20, "Number Of Balls");
            int magazineSize = ReadInt(16, "Magazine Size");
            Console.Write($"Loaded [false]:");
            bool.TryParse(Console.ReadLine(), out bool isLoaded);
            PaintballGun gun = new PaintballGun(numebrOfBalls, magazineSize, isLoaded);
            while (true)
            {
                Console.WriteLine($"{gun.Balls} balls, {gun.ballsLoaded} loaded");
                if (gun.IsEmpty())
                {
                    Console.WriteLine("WARNING: You are run out of Ammo ");
                }
                Console.WriteLine("Space to shoot, r to reload, + to add ammo, q to quit");
                char key = Console.ReadKey(true).KeyChar;
                if (key == ' ') Console.WriteLine($"Shooting returned {gun.Shoot()}");
                else if (key == 'r') gun.Reload();
                else if (key == '+') gun.Balls = gun.Balls + gun.MagazineSize;
                else if (key == 'q') return;

            }
        }
        static int ReadInt(int lastUsedValue, string prompt)
        {
            Console.Write(prompt + " [" + lastUsedValue + "]: ");
            string line = Console.ReadLine();
            if (int.TryParse(line, out int value))
            {
                Console.WriteLine("  using value " + value);
                return value;
            }
            else
            {
                Console.WriteLine("  using default value " + lastUsedValue);
                return lastUsedValue;
            }
        }
    }
}