namespace HiLo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random(1);
            Random seededRandom = new Random(1);
            Console.Write("The first 20 numbers will be: ");
            for (int i = 0; i < 10; i++)
                Console.Write($"{seededRandom.Next(1,6)},{random.Next(1,6)} ");
            Console.WriteLine("Welcome to HiLo!");
            Console.WriteLine($"Guess numbers between 1 and {HiLoGame.MAXIMUM}");
            HiLoGame.Hint();
            while (HiLoGame.GetPot() > 0) {
                Console.WriteLine("Press h for higher, l for lower, ? to buy a hint,  ");
                Console.WriteLine($"or any other key to quit with {HiLoGame.GetPot()}.");
                char key = Console.ReadKey(true).KeyChar;
                if (key == 'h') HiLoGame.Guess(true);
                else if (key == 'l') HiLoGame.Guess(false);
                else if (key == '?')
                {
                    HiLoGame.Hint();
                }
                else return;

            }
            Console.WriteLine("The pot is empty.Bye!");

        }
    }
}