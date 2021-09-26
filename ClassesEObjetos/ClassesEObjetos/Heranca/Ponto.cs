using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesEObjetos.Heranca
{
    class Ponto
    {
        public int x;
        public int y;

        private int distancia;

        public Ponto(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        protected void CalcularDistancia()
        {
            //Faz alguma coisa...
        }

        private void CalcularDistancia2()
        {
            //Faz alguma coisa...
        }

        public virtual void CalcularDistancia3()
        {
            //Faz alguma coisa...
        }
    }
}
