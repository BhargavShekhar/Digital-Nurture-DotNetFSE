using System;

namespace CommandPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create receiver
            Light livingRoomLight = new Light("living room");

            // Create concrete commands
            ICommand lightOn = new LightOnCommand(livingRoomLight);
            ICommand lightOff = new LightOffCommand(livingRoomLight);

            // Create invoker
            RemoteControl remoteControl = new RemoteControl();

            // Set and execute the ON command
            Console.WriteLine("Executing Light ON command:");
            remoteControl.SetCommand(lightOn);
            remoteControl.PressButton();

            Console.WriteLine();

            // Set and execute the OFF command
            Console.WriteLine("Executing Light OFF command:");
            remoteControl.SetCommand(lightOff);
            remoteControl.PressButton();

            Console.WriteLine();

            // Create another light and commands
            Light bedroomLight = new Light("bedroom");
            ICommand bedroomLightOn = new LightOnCommand(bedroomLight);
            ICommand bedroomLightOff = new LightOffCommand(bedroomLight);

            Console.WriteLine("Executing Bedroom Light ON command:");
            remoteControl.SetCommand(bedroomLightOn);
            remoteControl.PressButton();

            Console.WriteLine();

            Console.WriteLine("Executing Bedroom Light OFF command:");
            remoteControl.SetCommand(bedroomLightOff);
            remoteControl.PressButton();
        }
    }
}
