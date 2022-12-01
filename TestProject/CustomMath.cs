using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public class CustomMath
    {
        public int x;
        public int y;
        public void SumX()
        {
            x += y;
        }
        public static int Sum(int x, int y)
        {
            return x + y;
        }
        public static double Divide(double a, double b)
        {
            if (b == 0) throw new DivideByZeroException();
            return a / b;
        }
    }
}
