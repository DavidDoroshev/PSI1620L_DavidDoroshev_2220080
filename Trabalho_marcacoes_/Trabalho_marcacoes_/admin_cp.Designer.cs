
namespace Trabalho_marcacoes_
{
    partial class admin_cp
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
            this.label3 = new System.Windows.Forms.Label();
            this.voltar = new System.Windows.Forms.Button();
            this.guardar_cp = new System.Windows.Forms.Button();
            this.conselho = new System.Windows.Forms.TextBox();
            this.distrito = new System.Windows.Forms.TextBox();
            this.cp_guardar = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Conselho:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Distrito";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(460, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Código Postal";
            // 
            // voltar
            // 
            this.voltar.Location = new System.Drawing.Point(16, 110);
            this.voltar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.voltar.Name = "voltar";
            this.voltar.Size = new System.Drawing.Size(100, 46);
            this.voltar.TabIndex = 3;
            this.voltar.Text = "Voltar";
            this.voltar.UseVisualStyleBackColor = true;
            this.voltar.Click += new System.EventHandler(this.voltar_Click);
            // 
            // guardar_cp
            // 
            this.guardar_cp.Location = new System.Drawing.Point(535, 110);
            this.guardar_cp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guardar_cp.Name = "guardar_cp";
            this.guardar_cp.Size = new System.Drawing.Size(100, 46);
            this.guardar_cp.TabIndex = 4;
            this.guardar_cp.Text = "Guardar ";
            this.guardar_cp.UseVisualStyleBackColor = true;
            this.guardar_cp.Click += new System.EventHandler(this.guardar_cp_Click);
            // 
            // conselho
            // 
            this.conselho.Location = new System.Drawing.Point(87, 15);
            this.conselho.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.conselho.Name = "conselho";
            this.conselho.Size = new System.Drawing.Size(132, 22);
            this.conselho.TabIndex = 5;
            // 
            // distrito
            // 
            this.distrito.Location = new System.Drawing.Point(291, 15);
            this.distrito.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.distrito.Name = "distrito";
            this.distrito.Size = new System.Drawing.Size(132, 22);
            this.distrito.TabIndex = 6;
            // 
            // cp_guardar
            // 
            this.cp_guardar.Location = new System.Drawing.Point(565, 18);
            this.cp_guardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cp_guardar.Mask = "0000-999";
            this.cp_guardar.Name = "cp_guardar";
            this.cp_guardar.Size = new System.Drawing.Size(68, 22);
            this.cp_guardar.TabIndex = 7;
            // 
            // admin_cp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 185);
            this.Controls.Add(this.cp_guardar);
            this.Controls.Add(this.distrito);
            this.Controls.Add(this.conselho);
            this.Controls.Add(this.guardar_cp);
            this.Controls.Add(this.voltar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "admin_cp";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "admin_cp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button voltar;
        private System.Windows.Forms.Button guardar_cp;
        private System.Windows.Forms.TextBox conselho;
        private System.Windows.Forms.TextBox distrito;
        private System.Windows.Forms.MaskedTextBox cp_guardar;
    }
}