﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCD
{
    class Program
    {
        private static int majorVersion = 1;
        private static int minorVersion = 8;
        static void Main(string[] args)
        {
            string versionNumber = majorVersion.ToString() + "." + minorVersion.ToString();
            string message = "Hello CD! test This program is version number";
            Console.WriteLine(message + " " + versionNumber);
            Console.WriteLine(message + "   i am in office----See you ------ okay tested ");
            Console.WriteLine("Press any key to exit.");
            Console.ReadLine();
        }
    }
}
