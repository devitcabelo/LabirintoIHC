using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labirinto
{
    public class Dijkstra
    {
        private int[] antecessor;
        private double[] p;
        private Grafo grafo;
        public Dijkstra(Grafo grafo)
        {
            this.grafo = grafo;
        }
        public void obterArvoreCMC(int raiz)
        {
            int n = this.grafo.numVertices;
            this.p = new double[n]; // peso dos vértices
            int[] vs = new int[n + 1]; // vértices
            this.antecessor = new int[n];
            for (int u = 0; u < n; u++)
            {
                this.antecessor[u] = -1;
                p[u] = double.MaxValue; // ∞
                vs[u + 1] = u; // Heap indireto a ser construído
            }
            p[raiz] = 0;
            FPHeapMinIndireto heap = new FPHeapMinIndireto(p, vs);
            heap.constroi();
            while (!heap.vazio())
            {
                int u = heap.retiraMin();
                if (!this.grafo.listaAdjVazia(u))
                {
                    Aresta adj = grafo.primeiroListaAdj(u);
                    while (adj != null)
                    {
                        int v = adj.v2;
                        if (this.p[v] > (this.p[u] + adj.peso))
                        {
                            antecessor[v] = u;
                            heap.diminuiChave(v, this.p[u] + adj.peso);
                        }
                        adj = grafo.proxAdj(u);
                    }
                }
            }
        }
        public int Antecessor(int u)
        {
            return this.antecessor[u];
        }
        public double peso(int u)
        {
            return this.p[u];
        }
        public void imprimeCaminho(int origem, int v)
        {
            if (origem == v)
                Console.WriteLine(origem);
            else if (this.antecessor[v] == -1)
            {
                Console.WriteLine("Nao existe caminho de " + origem + " ate " + v);
            }
            else {
                imprimeCaminho(origem, this.antecessor[v]);
                Console.WriteLine(v);
            }
        }
    }

}
