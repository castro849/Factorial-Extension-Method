using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Int64[] arr = new Int64[] {
                1,2,3,4,5,10,15,20,21,21,22,25,50,70,100,450,1000,5000
            };
            foreach (double i in arr)
            {
                Console.Out.WriteLine(String.Format("{0}! => {1}", i, i.Factorial().ToString()));
            }
            Console.ReadLine();
        }
    }
}
