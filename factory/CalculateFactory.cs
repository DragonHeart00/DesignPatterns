using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.factory
{
    public class CalculateFactory
    {
        public ICalculate GetCaCalculate(string type)
        {
            ICalculate obj = null;


            if (type.ToLower().Equals("add"))
            {
                obj = new Add();
            }

            else if (type.ToLower().Equals("subtract"))
            {
                obj = new Subtract();
            }

            else if (type.ToLower().Equals("divide"))
            {
                obj = new Divide();
            }
            else
            {
                Console.WriteLine("We don't do that");
            }

            return obj;

        }
    }
}
