
namespace Projeto_em_camadas__Animes_
{
    partial class inicio
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
            this.BverAnimes = new System.Windows.Forms.Button();
            this.Bregistrar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ver/Registrar ANIMES:";
            // 
            // BverAnimes
            // 
            this.BverAnimes.Location = new System.Drawing.Point(211, 180);
            this.BverAnimes.Name = "BverAnimes";
            this.BverAnimes.Size = new System.Drawing.Size(75, 23);
            this.BverAnimes.TabIndex = 1;
            this.BverAnimes.Text = "IR";
            this.BverAnimes.UseVisualStyleBackColor = true;
            this.BverAnimes.Click += new System.EventHandler(this.BverAnimes_Click);
            // 
            // Bregistrar
            // 
            this.Bregistrar.Location = new System.Drawing.Point(479, 180);
            this.Bregistrar.Name = "Bregistrar";
            this.Bregistrar.Size = new System.Drawing.Size(75, 23);
            this.Bregistrar.TabIndex = 6;
            this.Bregistrar.Text = "IR";
            this.Bregistrar.UseVisualStyleBackColor = true;
            this.Bregistrar.Click += new System.EventHandler(this.Bregistrar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(443, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Registrar novos usuarios";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Bregistrar);
            this.Controls.Add(this.BverAnimes);
            this.Controls.Add(this.label1);
            this.Name = "inicio";
            this.Text = "inicio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BverAnimes;
        private System.Windows.Forms.Button Bregistrar;
        private System.Windows.Forms.Label label4;
    }
}