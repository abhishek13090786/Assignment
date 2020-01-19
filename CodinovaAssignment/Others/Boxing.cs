using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Others
{
    public class Boxing
    {
        static public void Main()
        {

            int num = 23;

            // boxing 
            object obj = num;

            // unboxing 
            int i = (int)obj;

            // Display result 
            Console.WriteLine("Value of ob object is : " + obj);
            Console.WriteLine("Value of i is : " + i);
        }
    }
}