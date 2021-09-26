using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesEObjetos.Metodos
{
    class Out
    {
        static void Dividir(int x, int y, out int resultado, out int resto)
        {
            resultado = x / y;
            resto = x % y;
        }

        public static void Dividir()
        {
            Dividir(10, 3, out int resultado, out int resto);
            System.Console.WriteLine("{0} {1}", resultado, resto); // Escreve "3 1"
        }
    }
}
