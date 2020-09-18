using System;
using System.Collections.Generic;
using System.Text;

namespace Flower
{
    public class Flower
    {
        public string Name { get; set; }
        public string Colour { get; set; }
        public double Length { get; set; }
        public string BloomTime { get; set; }

        // parametrized constructor 
        public Flower(string name, string colour, double length, string bloomTime)
        {
            Name = name;
            Colour = colour;
            Length = length;
            BloomTime = bloomTime;

        }

        // copy constructor 
        public Flower(Flower flower)
        {
            Name = flower.Name;
            Colour = flower.Colour;
            Length = flower.Length;
            BloomTime = flower.BloomTime;
        }

        public bool Equals(Flower flower)
        {

            bool nameProperty = Name == flower.Name;
            bool colourProperty = Colour == flower.Colour;
            bool lengthProperty = Length == flower.Length;
            bool bloomTimeProperty = BloomTime == flower.BloomTime;

            bool equal = nameProperty & colourProperty & lengthProperty & bloomTimeProperty;

            return equal;
        }

        public override string ToString()
        {
            return $"(Name: {Name}, Colour: {Colour}, Length: {Length}, Bloom time: {BloomTime}),\n";
        }
    }
}
