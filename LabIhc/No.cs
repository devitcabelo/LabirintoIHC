using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabIhc
{
    public class No
    {
        public string image;
        public int vertice, peso,veioDe;
        public bool cima, baix, dire, esqu;
        public No(int v, int p, int cim, int dir, int bai, int esq, int veioDe)
        {
            cima = (cim == 1);
            dire = (dir == 1);
            esqu = (esq == 1);
            baix = (bai == 1);
            this.vertice = v;
            this.peso = p;
            this.veioDe = veioDe;
            imagens(cima, dire, esqu, baix);
            
        }
        public bool equals(No obj)
        {
            No item = (No)obj;
            return (this.vertice == item.vertice);
        }
        public void imagens(bool cima, bool dire, bool esqu, bool baix)
        {
            if (cima && dire && esqu && baix)
            {
                image = "S.png";
            }
            else if (cima && dire && esqu)
            {
                image = "ECD.png";
            }
            else if (cima && dire && baix)
            {
                image = "BDC.png";
            }
            else if (cima && baix && esqu)
            {
                image = "CEB.png";
            }
            else if (baix && dire && esqu)
            {
                image = "EBD.png";
            }
            else if (cima)
            {
                image = "C.png";
            }
            else if (dire)
            {
                image = "D.png";
            }
            else if (baix)
            {
                image = "B.png";
            }
            else if (esqu)
            {
                image = "E.png";
            }
        }
        
    }

}
