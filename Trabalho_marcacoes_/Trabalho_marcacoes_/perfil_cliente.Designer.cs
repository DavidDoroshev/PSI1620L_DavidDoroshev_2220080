
namespace Trabalho_marcacoes_
{
    partial class perfil_cliente
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.apagar_cliente = new System.Windows.Forms.Button();
            this.pass_alterar = new System.Windows.Forms.TextBox();
            this.nome_utilizador = new System.Windows.Forms.TextBox();
            this.Voltar = new System.Windows.Forms.Button();
            this.but_salvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apagar conta :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(295, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mudar Passe:";
            // 
            // apagar_cliente
            // 
            this.apagar_cliente.Location = new System.Drawing.Point(122, 104);
            this.apagar_cliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.apagar_cliente.Name = "apagar_cliente";
            this.apagar_cliente.Size = new System.Drawing.Size(100, 36);
            this.apagar_cliente.TabIndex = 4;
            this.apagar_cliente.Text = "Apagar!!";
            this.apagar_cliente.UseVisualStyleBackColor = true;
            this.apagar_cliente.Click += new System.EventHandler(this.apagar_cliente_Click);
            // 
            // pass_alterar
            // 
            this.pass_alterar.Location = new System.Drawing.Point(396, 25);
            this.pass_alterar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pass_alterar.Name = "pass_alterar";
            this.pass_alterar.Size = new System.Drawing.Size(100, 22);
            this.pass_alterar.TabIndex = 5;
            // 
            // nome_utilizador
            // 
            this.nome_utilizador.Location = new System.Drawing.Point(69, 22);
            this.nome_utilizador.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nome_utilizador.Name = "nome_utilizador";
            this.nome_utilizador.Size = new System.Drawing.Size(100, 22);
            this.nome_utilizador.TabIndex = 6;
            // 
            // Voltar
            // 
            this.Voltar.Location = new System.Drawing.Point(18, 186);
            this.Voltar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Voltar.Name = "Voltar";
            this.Voltar.Size = new System.Drawing.Size(99, 38);
            this.Voltar.TabIndex = 8;
            this.Voltar.Text = "Voltar";
            this.Voltar.UseVisualStyleBackColor = true;
            this.Voltar.Click += new System.EventHandler(this.Voltar_Click);
            // 
            // but_salvar
            // 
            this.but_salvar.Location = new System.Drawing.Point(396, 95);
            this.but_salvar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.but_salvar.Name = "but_salvar";
            this.but_salvar.Size = new System.Drawing.Size(100, 36);
            this.but_salvar.TabIndex = 9;
            this.but_salvar.Text = "Salvar pass";
            this.but_salvar.UseVisualStyleBackColor = true;
            this.but_salvar.Click += new System.EventHandler(this.but_salvar_Click);
            // 
            // perfil_cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 254);
            this.Controls.Add(this.but_salvar);
            this.Controls.Add(this.Voltar);
            this.Controls.Add(this.nome_utilizador);
            this.Controls.Add(this.pass_alterar);
            this.Controls.Add(this.apagar_cliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "perfil_cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button apagar_cliente;
        private System.Windows.Forms.TextBox pass_alterar;
        private System.Windows.Forms.TextBox nome_utilizador;
        private System.Windows.Forms.Button Voltar;
        private System.Windows.Forms.Button but_salvar;
    }
}