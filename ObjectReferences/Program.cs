namespace ObjectReferences
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Elephant[] elephants = new Elephant[7] { 
              new Elephant(){ Name = "Lloyd", EarSize = 33},
              new Elephant(){ Name = "Lucinda", EarSize = 133},
              new Elephant(){ Name = "Larry", EarSize = 3335},
              new Elephant(){ Name = "Lucille", EarSize = 3443},
              new Elephant(){ Name = "Lars", EarSize = 565},
              new Elephant(){ Name = "Linda", EarSize = 44},
              new Elephant(){ Name = "Humphrey", EarSize = 23},
            };

            Elephant biggestEars = elephants[0];
            for (int i = 1;i < elephants.Length; i++)
            {
                Console.WriteLine("Iteration #" + i);

                if (elephants[i].EarSize > biggestEars.EarSize)
                {
                    biggestEars = elephants[i];
                }
            }
            Console.WriteLine(biggestEars.EarSize.ToString());


            Elephant lucinda = new Elephant() { Name ="Lucinda", EarSize = 33};
            Elephant lloyd = new Elephant() { Name = "Lloyd", EarSize = 45 };

            Console.WriteLine("Press 1 for Lloyd, 2 for Lucinda, 3 tp Swap ");

            while (true)
            {
                char input = Console.ReadKey(true).KeyChar;
                Console.WriteLine("You pressed " + input);
                if (input == '1')
                {
                    Console.WriteLine("Calling lloyd.WhoAmI()");
                    lloyd.WhoAmI();
                } else if (input == '2')
                {
                    Console.WriteLine("Calling lucinda.WhoAmI()");
                    lucinda.WhoAmI();
                } else if (input == '3') {
                    Elephant holder;
                    holder = lloyd;
                    lloyd = lucinda;
                    lucinda = holder;
                    Console.WriteLine("Refereces have been swapped.");
                }
                else if (input == '4') {
                    lloyd = lucinda;
                    lloyd.EarSize = 4312;
                    lloyd.WhoAmI();
                }
                else if (input == '5') {
                    lucinda.SpeakTo(lloyd, "Hi, Lloyd!");

                }
                else { return; }

                Console.WriteLine();
            }
        }
    }
    class Elephant
    {
        public int EarSize;
        public string Name;
        public void WhoAmI() {

            Console.WriteLine("My name is " + Name + ".");
            Console.WriteLine("My ears are " + EarSize + " inches tall.");
        }
        public void HearMessage(string message, Elephant whoSaidIt) {
            Console.WriteLine(Name + " heard a message");
            Console.WriteLine(whoSaidIt.Name + " said this: " + message);
        }
        public void SpeakTo(Elephant whoToTalkTo, string message) {
            whoToTalkTo.HearMessage(message, this);
        }
    }
}