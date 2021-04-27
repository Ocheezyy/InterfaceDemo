using System;
using System.Collections.Generic;
using ConsoleUI.ComputerControllers;
using ConsoleUI.Interfaces;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            var controllers = new List<IComputerController>();

            var keyboard = new Keyboard();
            var gameController = new GameController();
            var batterController = new BatteryPoweredGameController();

            controllers.Add(keyboard);
            controllers.Add(gameController);

            foreach (var controller in controllers)
            {
                
            }


            Console.ReadLine();
        }
    }
}
