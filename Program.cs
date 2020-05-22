using System;

namespace IntroductionToClasses_Homework
{
    public class Rocket 
    {
        private string _nameOfRocket;
        private string[] _astrounauts;
        private double _price;
        private double _height;
        private double _startingWeight;
        private bool ValidAstrounautCheck(string astrounaut)
        {
            for(int i = 0; i < astrounaut.Length; i++)
            {
                if (!(astrounaut[i] >= 'a' && astrounaut[i] <= 'z' ||
                      astrounaut[i] >= 'A' && astrounaut[i] <= 'Z' ||
                      astrounaut[i] == '.')) return false;
            }
            return true;
        }
        private bool ValidNameOfRocketCheck(string nameOfRocket)
        {
            for(int i = 0; i < nameOfRocket.Length; i++)
            {
                if (!(nameOfRocket[i] >= 'a' && nameOfRocket[i] <= 'z' ||
                     nameOfRocket[i] >= 'A' && nameOfRocket[i] <= 'Z' ||
                     nameOfRocket[i] == '.' || nameOfRocket[i] == '-')) return false;
            }
            return true;
        }
        Rocket()
        {
            _price = 0;
            _height = 0;
            _startingWeight = 0;
        }
        Rocket(string nameOfRocket, string[] astrounauts, double price, double height, double startingWeight)
        {
            _astrounauts = new string[astrounauts.Length - 1];
            for(int i = 0; i < astrounauts.Length; i++)
            {
                _astrounauts[i] = astrounauts[i];
                if (ValidAstrounautCheck(astrounauts[i])) _astrounauts[i] = "";
            }
            if (ValidNameOfRocketCheck(nameOfRocket)) nameOfRocket = "";
            else _nameOfRocket = nameOfRocket;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
