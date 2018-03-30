using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labirinto
{
    public class Lista
    {
        private Celula Primeiro, ultimo, pos;
        public Lista()
        {
            this.Primeiro = new Celula();
            this.pos = this.Primeiro;
            this.ultimo = this.Primeiro;
            this.Primeiro.prox = null;
        }
        public No pesquisa(No chave)
        {
            if (this.vazia() || chave == null) return null;
            Celula aux = this.Primeiro;
            while (aux.prox != null)
            {
                if (aux.prox.item.equals(chave))
                    return aux.prox.item;
                aux = aux.prox;
            }
            return null;
        }
        public void insere(No x)
        {
            this.ultimo.prox = new Celula();
            this.ultimo = this.ultimo.prox;
            this.ultimo.item = x;
            this.ultimo.prox = null;
        }
        public No retira(No chave)
        {
            if (this.vazia() || (chave == null))
                throw new Exception
                ("Erro : Lista vazia ou chave invalida");
            Celula aux = this.Primeiro;
            while (aux.prox != null && !aux.prox.item.equals(chave))
                aux = aux.prox;
            if (aux.prox == null) return null; //não encontrada
            Celula q = aux.prox;
            No item = q.item;
            aux.prox = q.prox;
            if (aux.prox == null)
                this.ultimo = aux;
            return item;
        }
        public No retiraPrimeiro()
        {
            if (this.vazia()) throw new Exception
        ("Erro : Lista vazia");
            Celula aux = this.Primeiro;
            Celula q = aux.prox;
            No item = q.item; aux.prox = q.prox;
            if (aux.prox == null) this.ultimo = aux; return item;
        }
        public No primeiro()
        {
            this.pos = Primeiro;
            return proximo();
        }
        public No proximo()
        {
            this.pos = this.pos.prox;
            if (this.pos == null) return null;
            else return this.pos.item;
        }
        public bool vazia()
        {
            return (this.Primeiro == this.ultimo);
        }

        public No RetornaNo()
        {
            Celula aux = Primeiro.prox;
            Console.WriteLine("\nQual caminho você deseja ir?");
            int j = 1;
            while (aux != null)
            {
                Console.WriteLine(j + " - Nó: " + aux.item.vertice + " ; Custo: " + aux.item.peso + "\n");
                aux = aux.prox;
                j++;
            }
            aux = Primeiro;
            int opçao = -100;
            do
            {
                if (opçao != -100) Console.WriteLine("Opção inválida!!!");
                Console.Write("Opção: ");
                opçao = int.Parse(Console.ReadLine());
            }while ( ( opçao > j - 1 ) || (opçao < 1) );
            for(int i = 0; i < opçao; i++){
                aux = aux.prox;
            }
            return aux.item;
        }

        public override string ToString()
        {
            string lista = "";
            Celula aux = Primeiro;
            while ((aux = aux.prox) != null)
            {
                lista += aux.item.vertice.ToString()  + " - peso: " + aux.item.peso.ToString() + "\n";
            }
            return lista;
        }
    }

}
