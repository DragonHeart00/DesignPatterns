using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.singelton
{
    class TestLogger
    {
        static void Main(string[] args)
        {
           

            Console.WriteLine("-----Singelton-----");
            //Logger obj1 = Logger.GetInstance();
            //Logger obj2 = Logger.GetInstance();
            Logger obj1 = Logger.Instance;
            Logger obj2 = Logger.Instance;
            Console.WriteLine(obj1.GetHashCode());
            Console.WriteLine(obj2.GetHashCode());

            Console.WriteLine("-----Non Singelton-----");
            Test obj3 = new Test();
            Test obj4 = new Test();
            Console.WriteLine(obj3.GetHashCode());
            Console.WriteLine(obj4.GetHashCode());

        }
    }


    class Test
    {

    }
}

/* Only create one instance of a class.
 * if we want a class to hav only one object, then we use the singleton pattern 
 */

/*
 * we need only one object of a class.
 * objects used for logging, device drivers for printers or registry setting need 
 * to have only one of a kind. if there are multipe obejcts we may encounter problems like 
 * incorrect program behavior, inconsistent results etc. 
 */