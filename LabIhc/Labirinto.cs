using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabIhc
{
    class Labirinto
    {
        string[] labirinto;
        public void montaGrafo()
        {

        }

        public string[] getLabirinto()
        {
            return labirinto;
        }

        public void labirintoDoArquivo(int dificuldade)
        {
            LerDoArquivo labirintoStr = new LerDoArquivo();
            labirinto = labirintoStr.getTexto(dificuldade);
        }
        public override string ToString()
        {
            string labirintoStr = "";
            foreach (string lab in labirinto) labirintoStr += lab + "\n";
            return labirintoStr;
        }
    }
}
