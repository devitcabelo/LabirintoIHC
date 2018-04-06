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
            this.SuspendLayout();
            // 
            // IniciarJogo
            // 
            this.IniciarJogo.Location = new System.Drawing.Point(58, 41);
            this.IniciarJogo.Name = "IniciarJogo";
            this.IniciarJogo.Size = new System.Drawing.Size(158, 48);
            this.IniciarJogo.TabIndex = 0;
            this.IniciarJogo.Text = "Iniciar Jogo";
            this.IniciarJogo.UseVisualStyleBackColor = true;
            this.IniciarJogo.Click += new System.EventHandler(this.IniciarJogo_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(58, 135);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(158, 48);
            this.btnSair.TabIndex = 1;
            this.btnSair.Text = "Sair do jogo";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.IniciarJogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button IniciarJogo;
        private System.Windows.Forms.Button btnSair;
    }
}

