using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesEObjetos.Metodos
{
    class Ref
    {
        static void Inverter(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        public static void Inverter()
        {
            int i = 1, j = 2;
            Inverter(ref i, ref j);
            Console.WriteLine($"{i} {j}"); //Escreve "2 1"
        }
    }
}
