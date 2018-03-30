using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labirinto
{
    public class Aresta
    {
        public int v1, v2, peso;
        public Aresta(int v1, int v2, int peso)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.peso = peso;
        }
    }

}
