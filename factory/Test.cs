using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.factory
{
    class Test
    {
        static void Main()
        {

            Console.WriteLine("Enter first Number");
            string input = Console.ReadLine();
            double num1, num2;
            bool result = Double.TryParse(input, out num1);
            if (!result)
            {
                Console.WriteLine("Please enter a number");
                return;
            }
            Console.WriteLine("Enter second Number");
            result = Double.TryParse(Console.ReadLine(), out num2);
            if (!result)
            {
                Console.WriteLine("Please enter a number");
                return;
            }

            Console.WriteLine("Enter Add, Subtract or Divide");
            CalculateFactory factory = new CalculateFactory();
            ICalculate obj = factory.GetCaCalculate(Console.ReadLine());
            obj.Calculate(num1,num2);
            //run it again 
            Main();


            // design patterns basic rule: Always program to an interface
            //Define an interface for creating an object, but let subclasses decide which class to in instantiate 

        }
    }
}
