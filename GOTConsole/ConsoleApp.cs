using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer;
using EntitiesLayer;

namespace GOTConsole
{
    class ConsoleApp
    {
        static void Main(string[] args)
        {
            BusinessManager manager = new BusinessManager();

            Console.WriteLine("Welcome to GOTConsole!");
            Console.WriteLine("1 - Show all houses");
            Console.WriteLine("2 - Show all big houses");
            Console.WriteLine("3 - Show all fights");
            Console.WriteLine("4 - Show characters with more than 3 of strength and more than 50 life points");
            Console.WriteLine("5 - Show all territories");

            string choix = Console.ReadLine();

            switch(choix)
            {
                case "1":
                    foreach (var e in manager.getAllHouses())
                        Console.WriteLine(e.ToString());
                    break;
                case "2":
                    foreach (var e in manager.getAllBigHouses())
                        Console.WriteLine(e.ToString());
                    break;
                case "3":
                    foreach (var e in manager.getAllFights())
                        Console.WriteLine(e.ToString());
                    break;
                case "4":
                    foreach (var e in manager.getStrongNMidLifeCharacters())
                        Console.WriteLine(e.ToString());
                    break;
                case "5":
                    foreach (var e in manager.getAllTerritories())
                        Console.WriteLine(e.ToString());
                    break;
            }
            Console.ReadKey(true);
        }
    }
}
