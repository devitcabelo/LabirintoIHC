using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LabIhc
{
    class LerDoArquivo
    {
        StreamReader sr;
        string[] labirinto;
        public LerDoArquivo()
        {
            sr = new StreamReader(@"labirinto.txt");
        }

        public string[] getTexto(int dificuldade)
        {
            labirinto = new string[10 + (dificuldade * 8)];
            string linha = "";
            int count = 0;
            int j = 0;
            linha = sr.ReadLine();           
            for (int i = 0; linha != null && count <= dificuldade; i++)
            {
                if (linha.Equals("-"))
                {
                    count++;
                    linha = sr.ReadLine();
                }
                if(count == dificuldade)
                {
                    labirinto[j] = linha;
                    j++;
                    
                }
                linha = sr.ReadLine();
            }
                
            Random num = new Random();
//           int labNum = num.Next(0, 2);
            return labirinto;
        }
    }
}

