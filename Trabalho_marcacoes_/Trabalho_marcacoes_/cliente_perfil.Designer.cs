
namespace Trabalho_marcacoes_
{
    partial class cliente_perfil
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
            this.label4 = new System.Windows.Forms.Label();
            this.apagar_cliente = new System.Windows.Forms.Button();
            this.pass_alterar = new System.Windows.Forms.TextBox();
            this.nome_utilizador = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.Voltar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(232, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apagar conta :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(232, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mudar Passe:";
            // 
            // apagar_cliente
            // 
            this.apagar_cliente.Location = new System.Drawing.Point(122, 107);
            this.apagar_cliente.Name = "apagar_cliente";
            this.apagar_cliente.Size = new System.Drawing.Size(75, 33);
            this.apagar_cliente.TabIndex = 4;
            this.apagar_cliente.Text = "Apagar!!";
            this.apagar_cliente.UseVisualStyleBackColor = true;
            // 
            // pass_alterar
            // 
            this.pass_alterar.Location = new System.Drawing.Point(333, 115);
            this.pass_alterar.Name = "pass_alterar";
            this.pass_alterar.Size = new System.Drawing.Size(100, 22);
            this.pass_alterar.TabIndex = 5;
            // 
            // nome_utilizador
            // 
            this.nome_utilizador.Location = new System.Drawing.Point(70, 22);
            this.nome_utilizador.Name = "nome_utilizador";
            this.nome_utilizador.Size = new System.Drawing.Size(100, 22);
            this.nome_utilizador.TabIndex = 6;
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(333, 22);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(100, 22);
            this.pass.TabIndex = 7;
            // 
            // Voltar
            // 
            this.Voltar.Location = new System.Drawing.Point(18, 226);
            this.Voltar.Name = "Voltar";
            this.Voltar.Size = new System.Drawing.Size(98, 38);
            this.Voltar.TabIndex = 8;
            this.Voltar.Text = "voltar";
            this.Voltar.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(333, 169);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Salvar pass";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // cliente_perfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 276);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Voltar);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.nome_utilizador);
            this.Controls.Add(this.pass_alterar);
            this.Controls.Add(this.apagar_cliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "cliente_perfil";
            this.ShowIcon = false;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button apagar_cliente;
        private System.Windows.Forms.TextBox pass_alterar;
        private System.Windows.Forms.TextBox nome_utilizador;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.Button Voltar;
        private System.Windows.Forms.Button button3;
    }
}