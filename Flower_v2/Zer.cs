using System;
using System.Collections.Generic;
using System.Text;



namespace Flower
{
    class Zer
    {
        private static int FlowerCount;
        private string Name;
        private Flower[] Flowers;

        public static int GetFlowerCount()
        {
            return FlowerCount;
        }
        public static void SetFlowerCount(int value)
        {
            FlowerCount = value;
        }
        public string GetName()
        {
            return Name;
        }
        public void SetName(string value)
        {
            Name = value;
        }
        public Flower[] GetFlowers()
        {
            return Flowers;
        }
        public void SetFlowers(Flower[] value)
        {
            Flowers = value;
        }

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
                names += $"(Name: {flowers[i].GetName()}, Colour: {flowers[i].GetColour()}, Length: {flowers[i].GetLength()}, Bloom time: {flowers[i].GetBloomTime()}),\n";
            }
            return names;
        }

    }


}
