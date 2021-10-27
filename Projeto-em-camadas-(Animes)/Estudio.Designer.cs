
namespace Projeto_em_camadas__Animes_
{
    partial class Estudio
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
            this.TBnEstudio = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TBidEstudio = new System.Windows.Forms.TextBox();
            this.TBanosEstudios = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Bconfirmar = new System.Windows.Forms.Button();
            this.Bvoltar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.DTGestudios = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DTGestudios)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Regeistrar estudios:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome:";
            // 
            // TBnEstudio
            // 
            this.TBnEstudio.Location = new System.Drawing.Point(62, 41);
            this.TBnEstudio.Name = "TBnEstudio";
            this.TBnEstudio.Size = new System.Drawing.Size(131, 23);
            this.TBnEstudio.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(131, 86);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(62, 23);
            this.textBox1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Animes Produzidos:";
            // 
            // TBidEstudio
            // 
            this.TBidEstudio.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.TBidEstudio.Location = new System.Drawing.Point(128, 5);
            this.TBidEstudio.Name = "TBidEstudio";
            this.TBidEstudio.Size = new System.Drawing.Size(65, 23);
            this.TBidEstudio.TabIndex = 5;
            // 
            // TBanosEstudios
            // 
            this.TBanosEstudios.Location = new System.Drawing.Point(56, 132);
            this.TBanosEstudios.Name = "TBanosEstudios";
            this.TBanosEstudios.Size = new System.Drawing.Size(137, 23);
            this.TBanosEstudios.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Anos:";
            // 
            // Bconfirmar
            // 
            this.Bconfirmar.Location = new System.Drawing.Point(92, 161);
            this.Bconfirmar.Name = "Bconfirmar";
            this.Bconfirmar.Size = new System.Drawing.Size(101, 42);
            this.Bconfirmar.TabIndex = 8;
            this.Bconfirmar.Text = "CONFIRMAR";
            this.Bconfirmar.UseVisualStyleBackColor = true;
            // 
            // Bvoltar
            // 
            this.Bvoltar.Location = new System.Drawing.Point(12, 239);
            this.Bvoltar.Name = "Bvoltar";
            this.Bvoltar.Size = new System.Drawing.Size(75, 23);
            this.Bvoltar.TabIndex = 9;
            this.Bvoltar.Text = "Inicio";
            this.Bvoltar.UseVisualStyleBackColor = true;
            this.Bvoltar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(243, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ver Estudios";
            // 
            // DTGestudios
            // 
            this.DTGestudios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGestudios.Location = new System.Drawing.Point(243, 31);
            this.DTGestudios.Name = "DTGestudios";
            this.DTGestudios.RowTemplate.Height = 25;
            this.DTGestudios.Size = new System.Drawing.Size(545, 407);
            this.DTGestudios.TabIndex = 11;
            // 
            // Estudio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DTGestudios);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Bvoltar);
            this.Controls.Add(this.Bconfirmar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TBanosEstudios);
            this.Controls.Add(this.TBidEstudio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.TBnEstudio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Estudio";
            this.Text = "Estudio";
            ((System.ComponentModel.ISupportInitialize)(this.DTGestudios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBnEstudio;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBidEstudio;
        private System.Windows.Forms.TextBox TBanosEstudios;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Bconfirmar;
        private System.Windows.Forms.Button Bvoltar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView DTGestudios;
    }
}