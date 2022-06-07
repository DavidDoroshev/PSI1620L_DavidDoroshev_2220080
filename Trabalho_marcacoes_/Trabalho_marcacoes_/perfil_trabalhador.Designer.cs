
namespace Trabalho_marcacoes_
{
    partial class perfil_trabalhador
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
            this.but_salvar = new System.Windows.Forms.Button();
            this.Voltar = new System.Windows.Forms.Button();
            this.nome_trabalhador = new System.Windows.Forms.TextBox();
            this.pass_alterar = new System.Windows.Forms.TextBox();
            this.apagar_trabalhador = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // but_salvar
            // 
            this.but_salvar.Location = new System.Drawing.Point(395, 88);
            this.but_salvar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.but_salvar.Name = "but_salvar";
            this.but_salvar.Size = new System.Drawing.Size(100, 36);
            this.but_salvar.TabIndex = 17;
            this.but_salvar.Text = "Salvar pass";
            this.but_salvar.UseVisualStyleBackColor = true;
            this.but_salvar.Click += new System.EventHandler(this.but_salvar_Click);
            // 
            // Voltar
            // 
            this.Voltar.Location = new System.Drawing.Point(17, 179);
            this.Voltar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Voltar.Name = "Voltar";
            this.Voltar.Size = new System.Drawing.Size(99, 38);
            this.Voltar.TabIndex = 16;
            this.Voltar.Text = "Voltar";
            this.Voltar.UseVisualStyleBackColor = true;
            // 
            // nome_trabalhador
            // 
            this.nome_trabalhador.Location = new System.Drawing.Point(68, 15);
            this.nome_trabalhador.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nome_trabalhador.Name = "nome_trabalhador";
            this.nome_trabalhador.Size = new System.Drawing.Size(100, 22);
            this.nome_trabalhador.TabIndex = 15;
            // 
            // pass_alterar
            // 
            this.pass_alterar.Location = new System.Drawing.Point(395, 18);
            this.pass_alterar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pass_alterar.Name = "pass_alterar";
            this.pass_alterar.Size = new System.Drawing.Size(100, 22);
            this.pass_alterar.TabIndex = 14;
            // 
            // apagar_trabalhador
            // 
            this.apagar_trabalhador.Location = new System.Drawing.Point(121, 97);
            this.apagar_trabalhador.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.apagar_trabalhador.Name = "apagar_trabalhador";
            this.apagar_trabalhador.Size = new System.Drawing.Size(100, 36);
            this.apagar_trabalhador.TabIndex = 13;
            this.apagar_trabalhador.Text = "Apagar!!";
            this.apagar_trabalhador.UseVisualStyleBackColor = true;
            this.apagar_trabalhador.Click += new System.EventHandler(this.apagar_trabalhador_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(294, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Mudar Passe:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Apagar conta :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nome:";
            // 
            // perfil_trabalhador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 242);
            this.Controls.Add(this.but_salvar);
            this.Controls.Add(this.Voltar);
            this.Controls.Add(this.nome_trabalhador);
            this.Controls.Add(this.pass_alterar);
            this.Controls.Add(this.apagar_trabalhador);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "perfil_trabalhador";
            this.Text = "perfil_trabalhador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button but_salvar;
        private System.Windows.Forms.Button Voltar;
        private System.Windows.Forms.TextBox nome_trabalhador;
        private System.Windows.Forms.TextBox pass_alterar;
        private System.Windows.Forms.Button apagar_trabalhador;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}