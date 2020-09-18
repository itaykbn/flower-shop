using System;

namespace Flower
{
    class Program
    {
        static void Main(string[] args)
        {
            Zer[] bouquets = GetInfoFromClient();

            Console.WriteLine("");
            Console.WriteLine("the bouquets are: \n");
            Console.WriteLine("");
            Console.WriteLine("----Zer 1----\n" + bouquets[0].ToString());
            Console.WriteLine("");
            Console.WriteLine("----Zer 2----\n" + bouquets[1].ToString());
            Console.WriteLine("");

            PrintMaxZer(bouquets[0]);

            Console.WriteLine("");

            PrintMaxZer(bouquets[1]);
        }

        static Zer[] GetInfoFromClient()
        {
            Zer[] bouquets = new Zer[2];
            Console.WriteLine("enter bouquet length");
            int zerCount = ConfirmInt(Console.ReadLine());

            Console.WriteLine("");

            Zer.FlowerCount = zerCount;

            Zer zer1 = new Zer("for her");
            Zer zer2 = new Zer("for him");

            Console.WriteLine("----Zer 1----");
            AddToZer(zer1);

            Console.WriteLine("");

            Console.WriteLine("----Zer 2----");
            AddToZer(zer2);

            bouquets[0] = zer1;
            bouquets[1] = zer2;

            return bouquets;
        }

        private static void AddToZer(Zer zer)
        {
            for (int i = 0; i < Zer.FlowerCount; i++)
            {
                Console.WriteLine("describe your flower\n");

                Console.WriteLine("enter name: \n");
                string name = Console.ReadLine();

                Console.WriteLine("enter length: \n");
                double length = ConfirmDouble(Console.ReadLine());

                Console.WriteLine("enter colour: \n");
                string colour = Console.ReadLine();

                Console.WriteLine("enter bloom time: \n");
                string bloomTime = Console.ReadLine();

                zer.AddFlower(new Flower(name, colour, length, bloomTime));
            }
        }

        //would have been nice to do with generics but int and double are not interfaces
        private static int ConfirmInt(string str)
        {
            bool flag = int.TryParse(str, out int result);
            while (!flag)
            {
                Console.WriteLine("input not a number");
                str = Console.ReadLine();
                flag = int.TryParse(str, out result);
            }
            return result;
        }

        private static double ConfirmDouble(string str)
        {
            bool flag = double.TryParse(str, out double result);
            while (!flag)
            {
                Console.WriteLine("input not a number");
                str = Console.ReadLine();
                flag = double.TryParse(str, out result);

            }
            return result;
        }

        //maximal value means the highest but there are more than one.
        //maximun vakue means the highest value and all the other values are lower than him.
        //like in maths
        private static void PrintMaxZer(Zer zer)
        {
            string maxType = "the maximum flower";
            Flower maxLength = zer.Flowers[0];
            foreach (var flower in zer.Flowers)
            {
                if (flower.Length > maxLength.Length)
                {
                    maxLength = flower;
                }
                if (flower.Length == maxLength.Length && maxLength != flower)
                {
                    maxType = "the maximal flower";
                }
            }

            Console.WriteLine($"{maxType} of length : {maxLength.ToString()} ");


        }

    }
}









