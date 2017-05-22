using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._19_lx
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Color = "red";
            // Console.WriteLine(car.Color);
            car.OilMeter = 10;
            car.GetYou();
            car.GetYou(60);


            Console.ReadKey();
               
        }
    }
}
