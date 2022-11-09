using Kapsul;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consoleapp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            kapsul alan = new kapsul();
            Console.WriteLine("eni gir");
            int eni = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("boyu gir");
            
            int boyu = Convert.ToInt32(Console.ReadLine());
            alan.BOY = boyu;
            alan.EN = eni;
            Console.WriteLine("Alan:" +alan.al());
            Console.ReadKey();

        }
    }
}
