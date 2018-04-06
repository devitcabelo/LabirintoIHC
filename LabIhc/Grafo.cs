using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabIhc
{
    public class Grafo
    {
        public Lista[] adj;
        
        public int inicial;
        public int final;
        public int numVertices;
        int pesoTotal = 0;

        public Grafo(int numVertices)
        {
            this.adj = new Lista[numVertices];
            this.numVertices = numVertices;
            for (int i = 0; i < this.numVertices; i++)
                this.adj[i] = new Lista();
            this.inicial = 0;
            Random num = new Random();
            this.final = num.Next(1, numVertices);
            
        }
        public List<Celula> adjacentes(int vertice)
        {
            List<Celula> adjs = adj[vertice].RetornaNos();
            return adjs;
        }
        public void insereAresta(int v1, int v2, int peso,int cim, int dir, int bai, int esq,int veioDe)
        {
            No item = new No(v2, peso, 0, 0, 0, 0, veioDe);
            this.adj[v1].insere(item);
            No item2 = new No(v1, peso, 0, 0, 0, 0,veioDe);
            this.adj[v2].insere(item2);
        }
        public bool existeAresta(int v1, int v2)
        {
            No item = new No(v2, 0,0,0,0,0,0);
            return (this.adj[v1].pesquisa(item) != null);
        }
        public bool listaAdjVazia(int v)
        {
            return this.adj[v].vazia();
        }
        public Aresta primeiroListaAdj(int v)
        {
            // Retorna a primeira aresta que o vértice v participa ou
            // null se a lista de adjacência de v for vazia
            No item = (No)this.adj[v].primeiro();
            return item != null ? new Aresta(v, item.vertice, item.peso) : null;
        }
        public Aresta proxAdj(int v)
        {
            // Retorna a próxima aresta que o vértice v participa ou
            //null se a lista de adjacência de v estiver no fim
            No item = (No)this.adj[v].proximo();
            return item != null ? new Aresta(v, item.vertice, item.peso) : null;
        }
        public double Caminha(int vertice)
        {
            Dijkstra dj = new Dijkstra(this);
            dj.obterArvoreCMC(inicial);

//               Console.WriteLine("\n---------------------------------------------------");
//                Console.WriteLine("Você está no vértice: " + vertice);
//                Console.WriteLine("Final: " + final);
//                Console.WriteLine("Custo atual: " + pesoTotal);
//                No proxVertice = adj[vertice].RetornaNos();
//                pesoTotal += proxVertice.peso;
//                Caminha(proxVertice.vertice);

//                Console.WriteLine("\nVocê terminou o labirinto!!!!!");
//               Console.WriteLine("O custo do seu caminho foi: " + pesoTotal);
                return dj.peso(final);

        }
        public void imprimeGrafo()
        {
            int i = 0;
            foreach (Lista reg in adj)
            {
                Console.WriteLine("Elementos ligados a: " + i);
                Console.WriteLine(reg.ToString());
                i++;

            }
        }
    }
}

