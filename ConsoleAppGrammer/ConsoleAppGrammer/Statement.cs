using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppGrammer
{
     class Statement
    {
       public static void Main()
        {
            string z = "";
            string message = "the answer is " + z;
            int maxHeight = 2300;
            string mes = "hi";
            bool boxChecked = true;
            Console.WriteLine("ha hah");
            OperratorExamples();
            Console.WriteLine("tab twice");

            TryAnIf();
            TrySomeLoops();
            TryAnIfElse();
        }

        private static void TrySomeLoops()
        {
            int count = 0;
            while (count < 10)
            {
                count = count + 1;
            }
            for (int i = 0; i < 5; i++)
            {
                count = count - 1;

            }
            Console.WriteLine("the answer is " + count);
        }

        private static void TryAnIfElse()
        {
            int x = 5;
            if (x == 10)
            {
                Console.WriteLine("x must be 10.");
            }
            else
            {
                Console.WriteLine("x isn't 10.");
            }
        }

        private static void TryAnIf()
        {
            int someValue = 4;
            string name = "bobobo";
            if (someValue == 3 && name == "jone")
            {
                Console.WriteLine("x is 3 and the name id jone");
            }
            Console.WriteLine(" this line runs no matter what.");
        }

        private static void OperratorExamples()
        {
            int width = 3;
            width++;

            int height = 2 + 3;
            int area = width * height;
            Console.WriteLine(area);

            string result = "the area";
            result = result + " is " + area;
            Console.WriteLine(result);

            bool truthValue = true;
            Console.WriteLine(truthValue);

        }
    }
}
