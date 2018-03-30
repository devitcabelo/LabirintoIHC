using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labirinto
{
    class Program
    {
        static void Main(string[] args)
        {
            Labirinto lab = new Labirinto();
            LabirintoParaGrafo labParaGrafo;
            Console.WriteLine("Bem vindo ao jogo de labirinto com grafos!");

            lab.labirintoDoArquivo();
            labParaGrafo = new LabirintoParaGrafo(lab.getLabirinto());
            labParaGrafo.grafo.Caminha(0);

            Console.WriteLine("Pressione uma tecla para imprimir o labirinto do txt usado...");

            Console.ReadKey();
            Console.WriteLine(lab.ToString());

            Console.WriteLine("Obs. O grafo parte da posição 1 e 1 do txt(sendo esta o início)");
            Console.WriteLine("e sempre que encontra uma ponta(o 1 atual só possui um lado com outro 1),");
            Console.WriteLine("uma bifurcação(o 1 atual possui 3 lados com número 1) ou");
            Console.WriteLine("um cruzamento(o 1 atual possui 4 lados com número 1)");
            Console.WriteLine("ele gera um vértice em sentido horário(caso o ultimo 1 verificado");
            Console.WriteLine("esteja a esquerda ele procura novos vertices abaixo do 1 atual,");
            Console.WriteLine("depois a direita do 1 atual e depois acima do 1 atual com o peso");
            Console.WriteLine("sendo a quantidade de 1 econtrados no caminho até o novo vértice.");

            Console.WriteLine("\nPressione uma tecla para imprimir o grafo criado a partir do txt...");
            Console.ReadKey();
            labParaGrafo.grafo.imprimeGrafo();

            Console.WriteLine("Pressione uma tecla para encerrar...");
            Console.ReadKey();
        }
    }
}
