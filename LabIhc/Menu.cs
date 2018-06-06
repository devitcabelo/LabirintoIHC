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
    public partial class Menu : Form
    {
        
        public Menu()
        {
            InitializeComponent();
        }

        private void IniciarJogo_Click(object sender, EventArgs e)
        {
            Dificuldades dificuldades = new Dificuldades(false);
            dificuldades.Show();

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Tuto_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\nUtilize das teclas WASD ou dos botões disponíveis para se movimentar no labirinto."
                + "\nO objetivo do labirinto é chegar ao vertice final, indicado no canto superior esquerdo, no menor caminho possível."
                + "\nA distância percorrida é indicada junto ao vértice final.", "Tutorial");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dificuldades dificuldades = new Dificuldades(true);
            dificuldades.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
