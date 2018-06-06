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
    public partial class LabirintoGame : Form
    {
        public List<No> nos;
        public int veioDe = 0, pesoTotal = 0;
        public List<Celula> adjs;
        public No atual;
        Labirinto lab = new Labirinto();
        LabirintoParaGrafo labParaGrafo;
        public int final;
        Timer relogio = new Timer();

        public LabirintoGame(bool timeattack,int  dificuldade)
        {
            InitializeComponent();
            lab.labirintoDoArquivo(dificuldade);
            labParaGrafo = new LabirintoParaGrafo(lab.getLabirinto());
            adjs = labParaGrafo.grafo.adjacentes(0);
            nos = labParaGrafo.nos;
            atual = nos[0];
            pictureBox1.Image = Image.FromFile(atual.image);
            travaBotoes();
            atualizaLabel();
            final = labParaGrafo.grafo.final;
            labelFinal.Text = "Vértice Final: " + final;
            labelVerticeAtual.Text = "Vértice Atual: 0";

        }
            public LabirintoGame(bool timeattack, int timer, int dificuldade)
        {
            InitializeComponent();

            relogio.Interval = 1000; // 1000 ms = 1s
            int tempo = timer;

            if (timeattack)
            {
                Time.Show();
                pictureBox2.Show();
                relogio.Tick += delegate
                {
                    tempo -= 1;
                    Time.Text = tempo.ToString();
                    if (tempo == 0)
                    {
                        relogio.Stop();
                        MessageBox.Show("Você perdeu.");
                        this.Close();
                    }
                };
                relogio.Start();
            }


            lab.labirintoDoArquivo(dificuldade);
            labParaGrafo = new LabirintoParaGrafo(lab.getLabirinto());
            adjs = labParaGrafo.grafo.adjacentes(0);
            nos = labParaGrafo.nos;
            atual = nos[0];            
            pictureBox1.Image = Image.FromFile(atual.image);
            travaBotoes();
            atualizaLabel();
            final = labParaGrafo.grafo.final;
            labelFinal.Text = "Vértice Final: " + final;
            labelVerticeAtual.Text = "Vértice Atual: 0";


        }
        
        public void atualizaVeioDe()
        {
            labelVeioDeBaixo.Text = "";
            labelVeioDeCima.Text = " ";
            labelVeioDeEsq.Text = " ";
            labelVeioDir.Text = " ";
            if(veioDe == 1)
            {
                labelVeioDeEsq.Text = "Você veio daqui";
            }
            else if (veioDe == 2)
            {
                labelVeioDeBaixo.Text = "Você veio daqui";
            }
            else if (veioDe == 3)
            {
                labelVeioDir.Text = "Você veio daqui";
            }
            else if (veioDe == 4)
            {
                labelVeioDeCima.Text = "Você veio daqui";
            }
        }
        public void venceu(int vertice)
        {
            if(vertice == final)
            {
                relogio.Stop();
                DialogResult dr =  MessageBox.Show("Parabéns!!!! \nVocê terminou o labirinto, você deseja comparar o seu resultado com o melhor caminho?.","Parabéns",MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    double dj = labParaGrafo.grafo.Caminha(0);
                    MessageBox.Show("Você percorreu um caminho de distância " + pesoTotal+ "!\nO melhor caminho (utilizando o algoritmo de dijkstra) era de distância " + dj + ".\nSeu caminho foi " + ((dj / pesoTotal) * 100).ToString("F2") + " % do melhor caminho ", "Algoritmo de Dijkstra");
                    this.Close();
                }
                else
                {
                    this.Close();
                }
                          
            }

        }
        public void travaBotoes()
        {
            butBai.Enabled = true;
            butCima.Enabled = true;
            butDireita.Enabled = true;
            butEsq.Enabled = true;
            if (!atual.cima) butCima.Enabled = false;
            if (!atual.baix) butBai.Enabled = false;
            if (!atual.dire) butDireita.Enabled = false;
            if (!atual.esqu) butEsq.Enabled = false;
        }

        private void FecharJogo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butCima_Click(object sender, EventArgs e)
        {
            if (atual.cima)
            {
                veioDe = 2;
            }
            int aux = 1;
            if (atual.veioDe == 4)
            {
                pesoTotal += adjs[0].item.peso;
                atual = nos[adjs[0].item.vertice];
                adjs = labParaGrafo.grafo.adjacentes(adjs[0].item.vertice);
            }
            else
            {
                if (atual.esqu && atual.veioDe != 1) aux++;
                if (atual.baix && atual.veioDe != 2) aux++;
                if (atual.dire && atual.veioDe != 3) aux++;
                if (atual.cima)
                {
                    pesoTotal += adjs[aux].item.peso;
                    atual = nos[adjs[aux].item.vertice];
                    adjs = labParaGrafo.grafo.adjacentes(adjs[aux].item.vertice);
                }


            }


            pictureBox1.Image = Image.FromFile(atual.image);


            travaBotoes();
            atualizaLabel();
            atualizaVeioDe();
            venceu(atual.vertice);
            
        }

        private void butEsq_Click(object sender, EventArgs e)
        {
            if (atual.esqu)
            {
                veioDe = 3;
            }
            int aux = 1;
            if (atual.veioDe == 1)
            {
                pesoTotal += adjs[0].item.peso;
                atual = nos[adjs[0].item.vertice];
                adjs = labParaGrafo.grafo.adjacentes(adjs[0].item.vertice);
            }
            else
            {
                if (atual.esqu)
                {
                    pesoTotal += adjs[aux].item.peso;
                    atual = nos[adjs[aux].item.vertice];
                    adjs = labParaGrafo.grafo.adjacentes(adjs[aux].item.vertice);
                }
            }

            
            pictureBox1.Image = Image.FromFile(nos[atual.vertice].image);


            travaBotoes();
            atualizaLabel();
            atualizaVeioDe();
            venceu(atual.vertice);
            
        }

        private void butBai_Click(object sender, EventArgs e)
        {
            int aux = 1;
            if (atual.baix)
            {
                veioDe = 4;
            }
            if (atual.veioDe == 2)
            {
                pesoTotal += adjs[0].item.peso;
                atual = nos[adjs[0].item.vertice];
                adjs = labParaGrafo.grafo.adjacentes(adjs[0].item.vertice);
            }
            else
            {
                if (atual.esqu && atual.veioDe != 1) aux++;
                if (atual.baix)
                {
                    pesoTotal += adjs[aux].item.peso;
                    atual = nos[adjs[aux].item.vertice];
                    adjs = labParaGrafo.grafo.adjacentes(adjs[aux].item.vertice);
                }
            }
          
            
            pictureBox1.Image = Image.FromFile(nos[atual.vertice].image);


            travaBotoes();
            atualizaLabel();
            atualizaVeioDe();
            venceu(atual.vertice);
            
        }

        private void butDireita_Click(object sender, EventArgs e)
        {
            int aux = 1;
            if (atual.dire)
            {
                veioDe = 1;
            }
            if (atual.veioDe == 0)
            {
                pesoTotal += adjs[0].item.peso;
                atual = nos[adjs[0].item.vertice];
                adjs = labParaGrafo.grafo.adjacentes(adjs[0].item.vertice);
            }
            else
            {
                if (atual.veioDe == 3)
                {
                    pesoTotal += adjs[0].item.peso;
                    atual = nos[adjs[0].item.vertice];
                    adjs = labParaGrafo.grafo.adjacentes(adjs[0].item.vertice);
                }
                else
                {
                    if (atual.esqu && atual.veioDe != 1) aux++;
                    if (atual.baix && atual.veioDe != 2) aux++;
                    if (atual.dire)
                    {
                        pesoTotal += adjs[aux].item.peso;
                        atual = nos[adjs[aux].item.vertice];
                        adjs = labParaGrafo.grafo.adjacentes(adjs[aux].item.vertice);
                    }
                }
            }
            

            pictureBox1.Image = Image.FromFile(nos[atual.vertice].image);


            travaBotoes();
            atualizaLabel();
            atualizaVeioDe();
            venceu(atual.vertice);

        }

        private void butDireita_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void LabirintoGame_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    butCima_Click(sender, e);
                    break;
                case Keys.S:
                    butBai_Click(sender, e);
                    break;
                case Keys.D:
                    butDireita_Click(sender, e);
                    break;
                case Keys.A:
                    butEsq_Click(sender, e);
                    break;

            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void LabirintoGame_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public void atualizaLabel()
        {
            labelVerticeAtual.Text = "Vértice Atual: " + atual.vertice;
            int i = 0;
            if(atual.veioDe == 1)
            {
                label5.Text = "Vértice: " + adjs[i].item.vertice;
                label6.Text = "Distância: " + adjs[i].item.peso;
                i++;
            }
            else if (atual.veioDe == 2)
            {
                label7.Text = "Vértice: " + adjs[i].item.vertice;
                label8.Text = "Distância: " + adjs[i].item.peso;
                i++;
            }
            else if (atual.veioDe == 3)
            {
                label2.Text = "Vértice: " + adjs[i].item.vertice;
                label1.Text = "Distância: " + adjs[i].item.peso;
                i++;
            }
            else if (atual.veioDe == 4)
            {
                label3.Text = "Vértice: " + adjs[i].item.vertice;
                label4.Text = "Distância: " + adjs[i].item.peso;
                i++;
            }
            if (atual.esqu && atual.veioDe != 1)
            {
                label5.Text = "Vértice: " + adjs[i].item.vertice;
                label6.Text = "Distância: " + adjs[i].item.peso;
                i++;
            }
            else if(atual.veioDe != 1)
            {
                label5.Text = "";
                label6.Text = ""; 
            }
            if (atual.baix && atual.veioDe != 2)
            {
                label7.Text = "Vértice: " + adjs[i].item.vertice;
                label8.Text = "Distância: " + adjs[i].item.peso;
                i++;
            }
            else if (atual.veioDe != 2)
            {
                label7.Text = "";
                label8.Text = "";
            }
            if (atual.dire && atual.veioDe != 3)
            {
                label2.Text = "Vértice: " + adjs[i].item.vertice;
                label1.Text = "Distância: " + adjs[i].item.peso;
                i++;
            }
            else if (atual.veioDe != 3)
            {
                label2.Text = "";
                label1.Text = "";
            }
            if (atual.cima && atual.veioDe != 4)
            {
                label3.Text = "Vértice: " + adjs[i].item.vertice;
                label4.Text = "Distância: " + adjs[i].item.peso;
                i++;
            }
            else if (atual.veioDe != 4)
            {
                label3.Text = "";
                label4.Text = "";
            }
            labelPesoTot.Text = ("Distância Total: " + pesoTotal);

        }
    }
}
