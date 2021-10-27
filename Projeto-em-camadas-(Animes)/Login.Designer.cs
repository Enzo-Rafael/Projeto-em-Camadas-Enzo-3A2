
namespace Projeto_em_camadas__Animes_
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TBliogin = new System.Windows.Forms.TextBox();
            this.TBsenha = new System.Windows.Forms.TextBox();
            this.Bconfirmar = new System.Windows.Forms.Button();
            this.Bregistrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BTsair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TBliogin
            // 
            this.TBliogin.Location = new System.Drawing.Point(276, 155);
            this.TBliogin.Name = "TBliogin";
            this.TBliogin.Size = new System.Drawing.Size(205, 23);
            this.TBliogin.TabIndex = 0;
            // 
            // TBsenha
            // 
            this.TBsenha.Location = new System.Drawing.Point(276, 204);
            this.TBsenha.Name = "TBsenha";
            this.TBsenha.Size = new System.Drawing.Size(205, 23);
            this.TBsenha.TabIndex = 1;
            // 
            // Bconfirmar
            // 
            this.Bconfirmar.Location = new System.Drawing.Point(285, 252);
            this.Bconfirmar.Name = "Bconfirmar";
            this.Bconfirmar.Size = new System.Drawing.Size(87, 29);
            this.Bconfirmar.TabIndex = 2;
            this.Bconfirmar.Text = "Confirmar";
            this.Bconfirmar.UseVisualStyleBackColor = true;
            this.Bconfirmar.Click += new System.EventHandler(this.Bconfirmar_Click);
            // 
            // Bregistrar
            // 
            this.Bregistrar.Location = new System.Drawing.Point(378, 252);
            this.Bregistrar.Name = "Bregistrar";
            this.Bregistrar.Size = new System.Drawing.Size(82, 29);
            this.Bregistrar.TabIndex = 3;
            this.Bregistrar.Text = "Registrar";
            this.Bregistrar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(231, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Senha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 80F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(210, -7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(323, 142);
            this.label3.TabIndex = 6;
            this.label3.Text = "Login";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // BTsair
            // 
            this.BTsair.Location = new System.Drawing.Point(329, 305);
            this.BTsair.Name = "BTsair";
            this.BTsair.Size = new System.Drawing.Size(87, 36);
            this.BTsair.TabIndex = 7;
            this.BTsair.Text = "Sair";
            this.BTsair.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTsair);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Bregistrar);
            this.Controls.Add(this.Bconfirmar);
            this.Controls.Add(this.TBsenha);
            this.Controls.Add(this.TBliogin);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBliogin;
        private System.Windows.Forms.TextBox TBsenha;
        private System.Windows.Forms.Button Bconfirmar;
        private System.Windows.Forms.Button Bregistrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BTsair;
    }
}

