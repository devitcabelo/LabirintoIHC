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
    public partial class Dificuldades : Form
    {
        bool timeattack;
        public Dificuldades(bool timeattack)
        {
            this.timeattack = timeattack;
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (timeattack)
            {
                LabirintoGame labirinto = new LabirintoGame(true, 20, 0);
                labirinto.Show();
            }
            else
            {
                LabirintoGame labirinto = new LabirintoGame(false, 0);
                labirinto.Show();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (timeattack)
            {
                LabirintoGame labirinto = new LabirintoGame(true, 30, 1);
                labirinto.Show();
            }
            else
            {
                LabirintoGame labirinto = new LabirintoGame(false, 1);
                labirinto.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (timeattack)
            {
                LabirintoGame labirinto = new LabirintoGame(true, 45, 2);
                labirinto.Show();
            }
            else
            {
                LabirintoGame labirinto = new LabirintoGame(false, 2);
                labirinto.Show();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
