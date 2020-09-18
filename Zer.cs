using System;
using System.Collections.Generic;
using System.Text;



namespace Flower
{
    class Zer
    {
        public static int FlowerCount { get; set; }
        public string Name { get; set; }
        public Flower[] Flowers { get; set; } = null;

        public Zer(string name)
        {
            Name = name;
            Flowers = new Flower[FlowerCount];
        }

        public void AddFlower(Flower flower)
        {
            bool full = true;
            for (int i = 0; i < Flowers.Length; i++)
            {
                if (Flowers[i] == null)
                {
                    Flowers[i] = flower;
                    full = false;
                    break;
                }
            }

            if (full)
            {
                Console.WriteLine("your bouquet is full");
            }
        }

        public override string ToString()
        {
            return $"Name: {Name}\nNumber of Flowers: {FlowerCount}\nBouquet contents: {Flowers.GetListOFlowers()} ";
        }

    }
    public static class ZerExtensions
    {
        public static string GetListOFlowers(this Flower[] flowers)
        {
            string names = "";
            for (int i = 0; i < flowers.Length; i++)
            {
                names += $"(Name: {flowers[i].Name}, Colour: {flowers[i].Colour}, Length: {flowers[i].Length}, Bloom time: {flowers[i].BloomTime}),\n";
            }
            return names;
        }

    }


}
