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
            //car.OilMeter = 10;
            //car.GetYou();
            //car.GetYou(60);

            #region 获取索引器的值
            //通过对象的名称[index]来获取数组当中的元素
            Car c1 = new Car();
            string first = c1[0];
            string second = c1[1];
            string three = c1[2];
            Console.WriteLine("汽车的类型："+first+","+second+","+three);


            #endregion


            Console.ReadKey();
               
        }
    }
}
