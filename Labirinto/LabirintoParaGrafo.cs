using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labirinto
{
    class LabirintoParaGrafo
    {
        public int vertices { get; set; }
        public Grafo grafo { get; set; }
        private int verticeNovo = 0;

        public LabirintoParaGrafo(string[] labirinto)
        {
            int i = 1, j = 1;
            contaVertices(labirinto);
            grafo = new Grafo(vertices);
            criaVertice(i , j, labirinto, 0, 0, 0);
        }

        void criaVertice(int i, int j, string[] labirinto, int veioDe, int vertice, int peso) //veioDe = 1: esquerda, veioDe = 2: baixo, veioDe = 3: direita, veioDe = 4: cima
        {
            int esq = 0, bai = 0, dir = 0, cim = 0;
            if(veioDe == 1)
            {
                bai = verBaixo(i, j, labirinto);
                dir = verDir(i, j, labirinto);
                cim = verCima(i, j, labirinto);
                if((bai + dir + cim) != 1)
                {
                    grafo.insereAresta(vertice, verticeNovo, peso);
                    peso = 0;
                    buscaVerticeVindoDaEsq(i, j, labirinto, bai, dir, cim, vertice, peso, 1);

                }
                else
                {
                    buscaVerticeVindoDaEsq(i, j, labirinto, bai, dir, cim, vertice, peso, 0);
                }
            }
            else if (veioDe == 2)
            {
                dir = verDir(i, j, labirinto);
                cim = verCima(i, j, labirinto);
                esq = verEsq(i, j, labirinto);
                if ((dir + cim + esq) != 1)
                {
                    grafo.insereAresta(vertice, verticeNovo, peso);
                    peso = 0;
                    buscaVerticeVindoDeBaixo(i, j, labirinto, dir, cim, esq, vertice, peso, 1);
                }
                else
                {
                    buscaVerticeVindoDeBaixo(i, j, labirinto, dir, cim, esq, vertice, peso, 0);
                }
            }
            else if (veioDe == 3)
            {
                cim = verCima(i, j, labirinto);
                esq = verEsq(i, j, labirinto);
                bai = verBaixo(i, j, labirinto);
                if ((cim + esq + bai) != 1)
                {
                    grafo.insereAresta(vertice, verticeNovo, peso);
                    peso = 0;
                    buscaVerticeVindoDaDir(i,j, labirinto, cim, esq, bai, vertice, peso, 1);
                }
                else
                {
                    buscaVerticeVindoDaDir(i,j, labirinto, cim, esq, bai, vertice, peso, 0);
                }
            }
            else if (veioDe == 4)
            {
                esq = verEsq(i, j, labirinto);
                bai = verBaixo(i, j, labirinto);
                dir = verDir(i, j, labirinto);

                if ((esq + bai + dir) != 1)
                {
                    grafo.insereAresta(vertice, verticeNovo, peso);
                    peso = 0;
                    buscaVerticeVindoDeCima(i, j, labirinto, esq, bai, dir, vertice, peso, 1);
                }
                else
                {
                    buscaVerticeVindoDeCima(i, j, labirinto, esq, bai, dir, vertice, peso, 0);
                }
            }
            else
            {
                bai = verBaixo(i, j, labirinto);
                dir = verDir(i, j, labirinto);
                buscaVertice(i, j, labirinto, bai, dir, vertice, peso);
            }
        }

        public void buscaVertice(int i, int j, string[] labirinto, int bai, int dir, int vertice, int peso)
        {
            verticeNovo++;
            peso = 0;

            if (bai == 1)
            {
                criaVertice(i + 1 , j, labirinto, 4, vertice, peso + 1);
            }
            if (dir == 1)
            {
                criaVertice(i ,j + 1, labirinto, 1, vertice, peso + 1);
            }
        }

        public void buscaVerticeVindoDaEsq(int i, int j, string[] labirinto, int bai, int dir, int cim, int vertice, int peso, int somaVertice)
        {
            if (somaVertice == 1)
            {
                vertice = verticeNovo;
                verticeNovo++;
                somaVertice = 0;
            }
            if (bai == 1)
            {
                criaVertice(i + 1 ,j , labirinto, 4, vertice + somaVertice, peso + 1);
            }
            if (dir == 1)
            {
                criaVertice(i, j + 1, labirinto, 1, vertice + somaVertice, peso + 1);
            }
            if (cim == 1)
            {
                criaVertice(i - 1, j, labirinto, 2, vertice + somaVertice, peso + 1);
            }
        }

        public void buscaVerticeVindoDeBaixo(int i, int j, string[] labirinto, int dir, int cim, int esq, int vertice, int peso, int somaVertice)
        {
            if (somaVertice == 1)
            {
                vertice = verticeNovo;
                verticeNovo++;
                somaVertice = 0;
            }
            if (dir == 1)
            {
                criaVertice(i, j + 1, labirinto, 1, vertice + somaVertice, peso + 1);
            }
            if (cim == 1)
            {
                criaVertice(i - 1, j, labirinto, 2, vertice + somaVertice, peso + 1);
            }
            if (esq == 1)
            {
                criaVertice(i, j - 1, labirinto, 3, vertice + somaVertice, peso + 1);
            }
        }

        public void buscaVerticeVindoDaDir(int i, int j, string[] labirinto, int cim, int esq, int bai, int vertice, int peso, int somaVertice)
        {
            if (somaVertice == 1)
            {
                vertice = verticeNovo;
                verticeNovo++;
                somaVertice = 0;
            }
            if (cim == 1)
            {
                criaVertice(i - 1, j, labirinto, 2, vertice + somaVertice, peso + 1);
                
            }
            if (esq == 1)
            {
                criaVertice(i, j - 1, labirinto, 3, vertice + somaVertice, peso + 1);
            }
            if (bai == 1)
            {
                criaVertice(i + 1, j, labirinto, 4, vertice + somaVertice, peso + 1);
            }
        }

        public void buscaVerticeVindoDeCima(int i, int j, string[] labirinto, int esq, int bai, int dir, int vertice, int peso, int somaVertice)
        {
            if (somaVertice == 1)
            {
                vertice = verticeNovo;
                verticeNovo++;
                somaVertice = 0;
            }
            if (esq == 1)
            {
                criaVertice(i, j - 1, labirinto, 3, vertice + somaVertice, peso + 1);
            }
            if (bai == 1)
            {
                criaVertice(i + 1, j, labirinto, 4, vertice + somaVertice, peso + 1);
            }
            if (dir == 1)
            {
                criaVertice(i, j + 1, labirinto, 1, vertice + somaVertice, peso + 1);
            }
        }

        void contaVertices(string[] labirinto)
        {
            if (vertices == 0)
            {
                int caminho = 0;
                for (int i = 1; i < labirinto.Length - 1; i++)
                {
                    for (int j = 1; j < labirinto[i].Length - 1; j++)
                    {
                        if (labirinto[i][j].Equals('1'))
                        {
                            caminho = 0;

                            caminho += verEsq(i, j, labirinto);
                            caminho += verDir(i, j, labirinto);
                            caminho += verCima(i, j, labirinto);
                            caminho += verBaixo(i, j, labirinto);
                            if (caminho != 2) vertices++;
                        }
                    }
                }
            }
        }

        int verEsq(int i, int j, string[] labirinto)
        {
            if (labirinto[i][j - 1].Equals('1')) return 1;
            else return 0;
        }
        int verDir(int i, int j, string[] labirinto)
        {
            if (labirinto[i][j + 1].Equals('1')) return 1;
            else return 0;
        }
        int verCima(int i, int j, string[] labirinto)
        {
            if (labirinto[i-1][j].Equals('1')) return 1;
            else return 0;
        }
        int verBaixo(int i, int j, string[] labirinto)
        {
            if (labirinto[i+1][j].Equals('1')) return 1;
            else return 0;
        }
       
    }
}
