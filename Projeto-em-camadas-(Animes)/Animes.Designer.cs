
namespace Projeto_em_camadas__Animes_
{
    partial class Animes
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TBnomeA = new System.Windows.Forms.TextBox();
            this.TBquantep = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TBdiretor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.DTGanimes = new System.Windows.Forms.DataGridView();
            this.Bregistrar = new System.Windows.Forms.Button();
            this.Bvoltar = new System.Windows.Forms.Button();
            this.TBidAnimes = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DTGanimes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registro de Animes:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome:";
            // 
            // TBnomeA
            // 
            this.TBnomeA.Location = new System.Drawing.Point(62, 43);
            this.TBnomeA.Name = "TBnomeA";
            this.TBnomeA.Size = new System.Drawing.Size(198, 23);
            this.TBnomeA.TabIndex = 2;
            // 
            // TBquantep
            // 
            this.TBquantep.Location = new System.Drawing.Point(160, 89);
            this.TBquantep.Name = "TBquantep";
            this.TBquantep.Size = new System.Drawing.Size(100, 23);
            this.TBquantep.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Quantidade de Episodios:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Diretor:";
            // 
            // TBdiretor
            // 
            this.TBdiretor.Location = new System.Drawing.Point(62, 126);
            this.TBdiretor.Name = "TBdiretor";
            this.TBdiretor.Size = new System.Drawing.Size(198, 23);
            this.TBdiretor.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "sinopse:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(62, 203);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(198, 129);
            this.textBox1.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Estudio:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(62, 164);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(198, 23);
            this.textBox2.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(288, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "Animes Registrados";
            // 
            // DTGanimes
            // 
            this.DTGanimes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGanimes.Location = new System.Drawing.Point(288, 37);
            this.DTGanimes.Name = "DTGanimes";
            this.DTGanimes.RowTemplate.Height = 25;
            this.DTGanimes.Size = new System.Drawing.Size(500, 401);
            this.DTGanimes.TabIndex = 12;
            // 
            // Bregistrar
            // 
            this.Bregistrar.Location = new System.Drawing.Point(175, 338);
            this.Bregistrar.Name = "Bregistrar";
            this.Bregistrar.Size = new System.Drawing.Size(85, 28);
            this.Bregistrar.TabIndex = 13;
            this.Bregistrar.Text = "CONFIRMAR";
            this.Bregistrar.UseVisualStyleBackColor = true;
            this.Bregistrar.Click += new System.EventHandler(this.Bregistrar_Click);
            // 
            // Bvoltar
            // 
            this.Bvoltar.Location = new System.Drawing.Point(13, 402);
            this.Bvoltar.Name = "Bvoltar";
            this.Bvoltar.Size = new System.Drawing.Size(85, 35);
            this.Bvoltar.TabIndex = 14;
            this.Bvoltar.Text = "Inicio";
            this.Bvoltar.UseVisualStyleBackColor = true;
            // 
            // TBidAnimes
            // 
            this.TBidAnimes.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.TBidAnimes.Location = new System.Drawing.Point(131, 10);
            this.TBidAnimes.Name = "TBidAnimes";
            this.TBidAnimes.Size = new System.Drawing.Size(100, 23);
            this.TBidAnimes.TabIndex = 15;
            // 
            // Animes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TBidAnimes);
            this.Controls.Add(this.Bvoltar);
            this.Controls.Add(this.Bregistrar);
            this.Controls.Add(this.DTGanimes);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TBdiretor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TBquantep);
            this.Controls.Add(this.TBnomeA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Animes";
            this.Text = "Animes";
            ((System.ComponentModel.ISupportInitialize)(this.DTGanimes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBnomeA;
        private System.Windows.Forms.TextBox TBquantep;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TBdiretor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView DTGanimes;
        private System.Windows.Forms.Button Bregistrar;
        private System.Windows.Forms.Button Bvoltar;
        private System.Windows.Forms.TextBox TBidAnimes;
    }
}