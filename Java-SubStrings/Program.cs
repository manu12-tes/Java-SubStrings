using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Java_SubStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dame una cadena");
            String cadena = Console.ReadLine();
            Console.WriteLine("Dame posicion inicial");
            int inicio = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Dame posicion final");
            int final = Int32.Parse(Console.ReadLine());

            Console.WriteLine(cadena.Substring(inicio,final));

        }
    }
}
