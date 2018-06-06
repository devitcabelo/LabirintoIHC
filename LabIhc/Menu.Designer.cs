namespace LabIhc
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.IniciarJogo = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btn_Tuto = new System.Windows.Forms.Button();
            this.TimeAttack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IniciarJogo
            // 
            this.IniciarJogo.Location = new System.Drawing.Point(58, 28);
            this.IniciarJogo.Name = "IniciarJogo";
            this.IniciarJogo.Size = new System.Drawing.Size(158, 48);
            this.IniciarJogo.TabIndex = 0;
            this.IniciarJogo.Text = "Iniciar Labirinto";
            this.IniciarJogo.UseVisualStyleBackColor = true;
            this.IniciarJogo.Click += new System.EventHandler(this.IniciarJogo_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(58, 190);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(158, 48);
            this.btnSair.TabIndex = 1;
            this.btnSair.Text = "Sair do jogo";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btn_Tuto
            // 
            this.btn_Tuto.Location = new System.Drawing.Point(58, 136);
            this.btn_Tuto.Name = "btn_Tuto";
            this.btn_Tuto.Size = new System.Drawing.Size(158, 48);
            this.btn_Tuto.TabIndex = 2;
            this.btn_Tuto.Text = "Tutorial";
            this.btn_Tuto.UseVisualStyleBackColor = true;
            this.btn_Tuto.Click += new System.EventHandler(this.btn_Tuto_Click);
            // 
            // TimeAttack
            // 
            this.TimeAttack.Location = new System.Drawing.Point(58, 82);
            this.TimeAttack.Name = "TimeAttack";
            this.TimeAttack.Size = new System.Drawing.Size(158, 48);
            this.TimeAttack.TabIndex = 3;
            this.TimeAttack.Text = "Iniciar Labirinto - TimeAttack";
            this.TimeAttack.UseVisualStyleBackColor = true;
            this.TimeAttack.Click += new System.EventHandler(this.button1_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.TimeAttack);
            this.Controls.Add(this.btn_Tuto);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.IniciarJogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.Text = "Labirinto de Dijkstra";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button IniciarJogo;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btn_Tuto;
        private System.Windows.Forms.Button TimeAttack;
    }
}

