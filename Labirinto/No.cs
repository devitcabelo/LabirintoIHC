using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labirinto
{
    public class No
    {
        public int vertice, peso;
        public No(int v, int p)
        {
            this.vertice = v;
            this.peso = p;
        }
        public bool equals(No obj)
        {
            No item = (No)obj;
            return (this.vertice == item.vertice);
        }
    }

}
