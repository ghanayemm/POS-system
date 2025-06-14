using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace test
{
    internal class Program
    {

        public static void  EnterTrainagleDaat(out int age )
        {
            Console.Write("enter your Age :");
            age = int.Parse(Console.ReadLine());

 

        }

        public static void CheckAge()
        {
            int Age;

            do
            {
                EnterTrainagleDaat( out Age);

            } while (Age < 18 || Age > 45);
          

        }

        public static void PrintResult()
        {
            CheckAge();

            Console.WriteLine($"  Age is between 18 and 45");
        }

        static void Main(string[] args)
        {
            

            PrintResult();

            Console.ReadKey();
        }
    }
}
