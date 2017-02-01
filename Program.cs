using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using FizzBuzz.F
namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.ReadLine();
            int j = 1;
            Fizz Fizz = new Fizz(ref j,100);
            Console.WriteLine("YAY");

            //String d = "qwdsad";
            Console.WriteLine( Fizz.ToString());
            Console.ReadLine();
            Console.WriteLine(j);
            Console.ReadLine();
        }
    }
}
