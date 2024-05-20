using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCD
{
    class Program
    {
        private static int majorVersion = 1;
        private static int minorVersion = 7;
        static void Main(string[] args)
        {
            string versionNumber = majorVersion.ToString() + "." + minorVersion.ToString();
            string message = "Hello CD! This program is version number";
            Console.WriteLine(message + " " + versionNumber);
            Console.WriteLine("Press any key to exit.");
            Console.ReadLine();
        }
    }
}
