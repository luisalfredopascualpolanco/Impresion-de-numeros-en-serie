using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto9._8
{
    class Program
    {
        static void Main(string[] args)
        {
            int vuelta = 0;
            int numero = 11;
            while (vuelta < 25)
            {
                Console.WriteLine(numero);
                numero = numero + 11;
                vuelta++;
            }
            Console.ReadKey();
        }
    }
}
