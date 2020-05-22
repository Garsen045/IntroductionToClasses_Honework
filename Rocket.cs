using System;
using System.Collections.Generic;
using System.Text;

namespace IntroductionToClasses_Homework
{
     partial class Rocket
     {
        private string _destination;
        Rocket(string destination)
        {
            _destination = destination;
        }
        public void InputDestination()
        {
            Console.WriteLine("Enter destination: ");
            _destination = Console.ReadLine();
        }
     }
}
