
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverLoadingExample
{
    internal class Math
    {
        public int toplama(int x , int y)
        {
            return x + y;
        }

        public double toplama (double x, double y) //overloading
        {
            return x + y;
        }


    }
}
