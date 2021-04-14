using System;
using System.Collections.Generic;
using System.Text;

namespace PreworkBootcamp
{

    public class Numbers
    {
        public static Numbers number = new Numbers();
        
        //    int a = 5;


        public int Integer(int a, int b)
        {
 
            int c = a + b;
            return c;
        }

        public double Double(double d, double e, double f)
        {

            double g = (d+e)/f;
            return g;
        }

        public decimal Decimal(decimal x, decimal y)
        {
            decimal z = x / y;
            return z;
        }
    }
}
