using System;

namespace IntroductionToClasses_Homework
{
    //1
    partial class Rocket 
    {
        //2
        private string _nameOfRocket;
        private string[] _astrounauts;
        private double _price;
        private double _height;
        private double _startingWeight;
        //5
        public static int amountOfRockets;
        public static string DateOfBuildingOfTheLastRocket;
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
        //7
        static Rocket()
        {
            amountOfRockets = 0;
            DateOfBuildingOfTheLastRocket = "";
        }
        Rocket()
        {
            _price = 0;
            _height = 0;
            _startingWeight = 0;
            amountOfRockets++;
            DateOfBuildingOfTheLastRocket = Convert.ToString(DateTime.Now);
        }
        //6
        Rocket(string nameOfRocket, string[] astrounauts, double price, double height, double startingWeight)
        {
            _astrounauts = new string[astrounauts.Length - 1];
            for(int i = 0; i < astrounauts.Length; i++)
            {
                _astrounauts[i] = "";
                if (ValidAstrounautCheck(astrounauts[i])) 
                    _astrounauts[i] = astrounauts[i];
            }

            if (ValidNameOfRocketCheck(nameOfRocket)) 
                _nameOfRocket = nameOfRocket;
            else _nameOfRocket = "";

            if (price < 0) 
                _price = 0;
            else _price = price;

            if (height < 0) 
                _height = 0;
            else _height = height;

            if (startingWeight < 0) 
                _startingWeight = 0;
            else _startingWeight = startingWeight;

            amountOfRockets++;
            DateOfBuildingOfTheLastRocket = Convert.ToString(DateTime.Now);
        }
        //3
        public void Input()
        {
            Console.WriteLine("Enter the name of rocket: ");
            _nameOfRocket = Console.ReadLine();
            if (ValidNameOfRocketCheck(_nameOfRocket)) 
                _nameOfRocket = "";

            Console.WriteLine("How many astrounauts there?");
            int amountOfAstrounauts = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the name of astrounauts: ");
            _astrounauts = new string[amountOfAstrounauts];
            for(int i = 0; i <= amountOfAstrounauts; i++)
            {
                Console.WriteLine("#{0}: ", i + 1);
                _astrounauts[i] = Console.ReadLine();
            }

            Console.WriteLine("Enter the price of rocket: ");
            _price = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the height of rocket: ");
            _height = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the starting weight: ");
            _startingWeight = double.Parse(Console.ReadLine());
        }
        public void Show()
        {
            Console.WriteLine($"Name of rocket: {_nameOfRocket}");
            Console.WriteLine("Astrounauts: ");
            for(int i = 0; i < _astrounauts.Length; i++)
            {
                Console.WriteLine($"Astrounaut #{i}: {_astrounauts[i]}");
            }
            Console.WriteLine($"Price of the rocket: {_price}");
            Console.WriteLine($"Height of the rocket: {_height}");
            Console.WriteLine($"Starting weight of the rocket: {_startingWeight}");
        }
        public bool IsItPossibleToBuildRocket(double budget)
        {
            return _price <= budget;
        }
        //4
        public void ChangeDifferenceBetweenStartingAndEndingMasses(double endingWeight, ref double difference)
        {
            difference = endingWeight - _startingWeight;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //8
            Rocket[] rockets = new Rocket[5];
        }
    }
}
