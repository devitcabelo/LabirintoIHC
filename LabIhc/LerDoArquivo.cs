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
        StreamReader sr = new StreamReader(@"labirinto.txt");
        List<string[]> labirintos = new List<string[]>();
        public string[] getTexto()
        {
            string linha = "";
            for (int i = 0; linha != null; i++)
            {
                labirintos.Add(new string[10]);
                linha = sr.ReadLine();
                for (int j = 0; linha != null && !linha.Equals("-"); j++)
                {
                    labirintos[i][j] = linha;
                    linha = sr.ReadLine();
                }
            }

            Random num = new Random();
//           int labNum = num.Next(0, 2);
            return labirintos[0];
        }
    }
}

