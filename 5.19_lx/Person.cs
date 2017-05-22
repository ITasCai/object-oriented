using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._19_lx
{
    class Person
    {
        private int age;

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                if (value<120&&value>0)
                {
                    age = value;
                }
                else
                {
                    throw new AggregateException("输入的年龄有误！");
                }
                
            }
        }
    }
}
