using System;
using System.Collections.Generic;
using System.Text;

namespace Flower
{
    public class Flower
    {
        private string Name;
        private string Colour;
        private double Length;
        private string BloomTime;
        
        public string GetName()
        {
            return Name;
        }
        public void SetName(string value)
        {
            Name = value;
        }
        public string GetColour()
        {
            return Colour;
        }
        public void setColour(string value)
        {
            Colour = value;
        }
        public double GetLength()
        {
            return Length;
        }
        public void setLength(double value)
        {
            Length = value;
        }
        public string GetBloomTime()
        {
            return BloomTime;
        }
        public void setBloomTime(string value)
        {
            BloomTime = value;
        }

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
