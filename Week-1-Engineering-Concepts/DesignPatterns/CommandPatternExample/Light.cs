using System;

namespace CommandPatternExample
{
    public class Light
    {
        private string _location;

        public Light(string location)
        {
            _location = location;
        }

        public void TurnOn()
        {
            Console.WriteLine($"Turning the {_location} light on.");
        }

        public void TurnOff()
        {
            Console.WriteLine($"Turning the {_location} light off.");
        }
    }
}
