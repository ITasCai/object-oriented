using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._19_lx
{
    /// <summary>
    /// 汽车类
    /// </summary>
    class Car
    {  
        //颜色
        private string color;
        //重量
        private double weight;
        //价格
        private double price;
        //油箱
        private readonly int tank=100;
        //油表
        private int oilMeter;
        //最高时速
        private int speed;

        public string Color
        {
            get
            {
                return color;
            }

            set
            {
                color = value;
            }
        }

        public double Weight
        {
            get
            {
                return weight;
            }

            set
            {
                weight = value;
            }
        }

        public double Price
        {
            get
            {
                if (price>5000)
                {
                    price = 5000;
                }
                return price;
            }

            set
            {
                //判断输入的价格是否大于5000
                //if (value>5000)
                //{
                //    Price = 5000;
                //}
                //else
                //{
                //    price = value;
                //}
                price = value;

            }
        }

        public  int Tank
        {
            get
            {
                return tank;
            }
        }

        public int OilMeter
        {
            get
            {
                return oilMeter;
            }

            set
            {

                oilMeter = value;
            }
        }

        public int Speed
        {
            get
            {
                return speed;
            }

            set
            {
                speed = value;
            }
        }
        /// <summary>
        /// 加油
        /// </summary>
        public void GetYou() {
            Console.WriteLine("加油成功");
        }
        /// <summary>
        /// 加油重载
        /// </summary>
        /// <param name="you">加油量</param>
        public void GetYou(double you) {
            if (oilMeter +you>tank)
            {
                Console.WriteLine("加油失败,爆表了");
            }
            else
            {
                Console.WriteLine("一共加了{0}L,油表值为{1}",you,oilMeter+you);
                Console.WriteLine("加油成功");
            }
        }
    }
}
