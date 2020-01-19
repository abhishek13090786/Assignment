using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Others
{
    public class Program
    {
        static void Main(string[] args)
        {
            Singleton s1 = Singleton.GetInstance;
            s1.PrintDetail("First");

            Singleton s2 = Singleton.GetInstance;
            s2.PrintDetail("Second");
            Console.ReadLine();
        }
    }
}