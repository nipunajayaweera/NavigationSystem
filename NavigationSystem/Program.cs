using NavigationSystem.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavigationSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Navigator nav = new Navigator();
            bool isContinue = true;
            while (isContinue)
            {
                Console.WriteLine("Navigate type (defult Road) :");
                var navType = Console.ReadLine();
                if (navType.ToUpper() == "EXIT")
                {
                    isContinue = false;
                    break;
                }
                if (navType.ToUpper() == "W")
                {
                    nav.SetRouteStrategy(new Walk());
                }
                else
                {
                    nav.SetRouteStrategy(new Road());
                }
                Console.WriteLine($"Navigate: {nav.BuildRoute()}");
            }
        }
    }
}
