using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Security.Cryptography;


namespace test
{
    internal class Program
    {

       public static string Computehash(string input)
        {
            using(SHA256 sha256= SHA256.Create())
            {
                Byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));

                return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            }
        }
         
      

        static void Main(string[] args)
        {

            string name = "ghanayem";
            string hashdata = Computehash(name);

            string text = "hello";

            int hasecode = text.GetHashCode();

          

            Console.WriteLine($"{text} and {hasecode}");
            Console.WriteLine(hashdata);

            Console.ReadKey();
        }
    }
}
