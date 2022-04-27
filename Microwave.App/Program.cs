using System;
using Microwave.Classes.Boundary;
using Microwave.Classes.Controllers;
using Microwave.Classes.Interfaces;

namespace Microwave.App
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Button startCancelButton = new Button();
            Button powerButton = new Button();
            Button timeButton = new Button();
            Button subtractTimeButton = new Button();

            Door door = new Door();

            Output output = new Output();

            Display display = new Display(output);

            PowerTube powerTube = new PowerTube(output, IPowerTube.PowerSupplyEnum.watt700);

            Light light = new Light(output);

            Buzzer buzzer= new Buzzer(output);

            Microwave.Classes.Boundary.Timer timer = new Timer();

            CookController cooker = new CookController(timer, display, powerTube);

            UserInterface ui = new UserInterface(powerButton, timeButton, startCancelButton, subtractTimeButton, door, display, light, buzzer, cooker);

            // Finish the double association
            cooker.UI = ui;

            // Simulate a simple sequence

            powerButton.Press();

            timeButton.Press();

            startCancelButton.Press();

            // Test of adding 20 seconds.
            timeButton.Press();

            // Test of substracting 20 seconds: Comment in, to emulate to pushes to subtract.
            //subtractTimeButton.Press();
            //subtractTimeButton.Press();

            // The simple sequence should now run

            System.Console.WriteLine("When you press enter, the program will stop");
            // Wait for input

            System.Console.ReadLine();
        }
    }
}
