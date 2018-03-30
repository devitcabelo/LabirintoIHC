using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labirinto
{
    class Labirinto
    {
        string[] labirinto;
        public void montaGrafo(){
            
        }

        public string[] getLabirinto()
        {
            return labirinto;
        }

        public void labirintoDoArquivo()
        {
            LerDoArquivo labirintoStr = new LerDoArquivo();
            labirinto = labirintoStr.getTexto();
        }
        public override string ToString()
        {
            string labirintoStr = "";
            foreach (string lab in labirinto) labirintoStr += lab + "\n";
            return labirintoStr;
        }
    }
}
