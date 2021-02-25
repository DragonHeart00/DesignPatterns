using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.factory
{
    public class Divide : ICalculate
    {
        public void Calculate(double a, double b)
        {
            Console.WriteLine("a/b is {0}", a/b);
        }
    }
}
