
namespace Projeto_em_camadas__Animes_
{
    partial class Registrar
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
            this.TBregisemail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TBregisnome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TBregissenha = new System.Windows.Forms.TextBox();
            this.Bregiscomfirmar = new System.Windows.Forms.Button();
            this.Bvoltar = new System.Windows.Forms.Button();
            this.TBidUsuario = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registrar email:";
            // 
            // TBregisemail
            // 
            this.TBregisemail.Location = new System.Drawing.Point(11, 60);
            this.TBregisemail.Name = "TBregisemail";
            this.TBregisemail.Size = new System.Drawing.Size(219, 23);
            this.TBregisemail.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Registrar nome:";
            // 
            // TBregisnome
            // 
            this.TBregisnome.Location = new System.Drawing.Point(11, 109);
            this.TBregisnome.Name = "TBregisnome";
            this.TBregisnome.Size = new System.Drawing.Size(219, 23);
            this.TBregisnome.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Registrar senha:";
            // 
            // TBregissenha
            // 
            this.TBregissenha.Location = new System.Drawing.Point(11, 158);
            this.TBregissenha.Name = "TBregissenha";
            this.TBregissenha.Size = new System.Drawing.Size(219, 23);
            this.TBregissenha.TabIndex = 5;
            // 
            // Bregiscomfirmar
            // 
            this.Bregiscomfirmar.Location = new System.Drawing.Point(141, 187);
            this.Bregiscomfirmar.Name = "Bregiscomfirmar";
            this.Bregiscomfirmar.Size = new System.Drawing.Size(89, 31);
            this.Bregiscomfirmar.TabIndex = 6;
            this.Bregiscomfirmar.Text = "CONFIRMAR";
            this.Bregiscomfirmar.UseVisualStyleBackColor = true;
            // 
            // Bvoltar
            // 
            this.Bvoltar.Location = new System.Drawing.Point(11, 295);
            this.Bvoltar.Name = "Bvoltar";
            this.Bvoltar.Size = new System.Drawing.Size(89, 27);
            this.Bvoltar.TabIndex = 7;
            this.Bvoltar.Text = "Voltar";
            this.Bvoltar.UseVisualStyleBackColor = true;
            // 
            // TBidUsuario
            // 
            this.TBidUsuario.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.TBidUsuario.Location = new System.Drawing.Point(229, 12);
            this.TBidUsuario.Name = "TBidUsuario";
            this.TBidUsuario.Size = new System.Drawing.Size(100, 23);
            this.TBidUsuario.TabIndex = 8;
            // 
            // Registrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TBidUsuario);
            this.Controls.Add(this.Bvoltar);
            this.Controls.Add(this.Bregiscomfirmar);
            this.Controls.Add(this.TBregissenha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TBregisnome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TBregisemail);
            this.Controls.Add(this.label1);
            this.Name = "Registrar";
            this.Text = "Registrar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBregisemail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBregisnome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBregissenha;
        private System.Windows.Forms.Button Bregiscomfirmar;
        private System.Windows.Forms.Button Bvoltar;
        private System.Windows.Forms.TextBox TBidUsuario;
    }
}