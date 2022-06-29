
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(perfil_cliente));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.apagar_cliente = new System.Windows.Forms.Button();
            this.pass_alterar = new System.Windows.Forms.TextBox();
            this.nome_utilizador = new System.Windows.Forms.TextBox();
            this.Voltar = new System.Windows.Forms.Button();
            this.salvar_pass = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.codigo_alterar = new System.Windows.Forms.ComboBox();
            this.salvar_codigo = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textdistrito = new System.Windows.Forms.TextBox();
            this.textconselho = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pass_atual = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cp_mostrar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(459, 238);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apagar conta :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(322, 24);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mudar Passe:";
            // 
            // apagar_cliente
            // 
            this.apagar_cliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.apagar_cliente.Location = new System.Drawing.Point(540, 231);
            this.apagar_cliente.Margin = new System.Windows.Forms.Padding(2);
            this.apagar_cliente.Name = "apagar_cliente";
            this.apagar_cliente.Size = new System.Drawing.Size(75, 29);
            this.apagar_cliente.TabIndex = 4;
            this.apagar_cliente.Text = "Apagar!!";
            this.apagar_cliente.UseVisualStyleBackColor = true;
            this.apagar_cliente.Click += new System.EventHandler(this.apagar_cliente_Click);
            // 
            // pass_alterar
            // 
            this.pass_alterar.Location = new System.Drawing.Point(434, 21);
            this.pass_alterar.Margin = new System.Windows.Forms.Padding(2);
            this.pass_alterar.Name = "pass_alterar";
            this.pass_alterar.Size = new System.Drawing.Size(91, 20);
            this.pass_alterar.TabIndex = 5;
            // 
            // nome_utilizador
            // 
            this.nome_utilizador.Location = new System.Drawing.Point(49, 21);
            this.nome_utilizador.Margin = new System.Windows.Forms.Padding(2);
            this.nome_utilizador.Name = "nome_utilizador";
            this.nome_utilizador.Size = new System.Drawing.Size(76, 20);
            this.nome_utilizador.TabIndex = 6;
            // 
            // Voltar
            // 
            this.Voltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Voltar.Location = new System.Drawing.Point(14, 229);
            this.Voltar.Margin = new System.Windows.Forms.Padding(2);
            this.Voltar.Name = "Voltar";
            this.Voltar.Size = new System.Drawing.Size(74, 31);
            this.Voltar.TabIndex = 8;
            this.Voltar.Text = "Voltar";
            this.Voltar.UseVisualStyleBackColor = true;
            this.Voltar.Click += new System.EventHandler(this.Voltar_Click);
            // 
            // salvar_pass
            // 
            this.salvar_pass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.salvar_pass.Location = new System.Drawing.Point(540, 16);
            this.salvar_pass.Margin = new System.Windows.Forms.Padding(2);
            this.salvar_pass.Name = "salvar_pass";
            this.salvar_pass.Size = new System.Drawing.Size(75, 29);
            this.salvar_pass.TabIndex = 9;
            this.salvar_pass.Text = "Salvar pass";
            this.salvar_pass.UseVisualStyleBackColor = true;
            this.salvar_pass.Click += new System.EventHandler(this.but_salvar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 91);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Mudar Código Postal:";
            // 
            // codigo_alterar
            // 
            this.codigo_alterar.FormattingEnabled = true;
            this.codigo_alterar.Location = new System.Drawing.Point(123, 88);
            this.codigo_alterar.Name = "codigo_alterar";
            this.codigo_alterar.Size = new System.Drawing.Size(89, 21);
            this.codigo_alterar.TabIndex = 15;
            this.codigo_alterar.SelectedIndexChanged += new System.EventHandler(this.codigo_alterar_SelectedIndexChanged);
            // 
            // salvar_codigo
            // 
            this.salvar_codigo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.salvar_codigo.Location = new System.Drawing.Point(14, 150);
            this.salvar_codigo.Margin = new System.Windows.Forms.Padding(2);
            this.salvar_codigo.Name = "salvar_codigo";
            this.salvar_codigo.Size = new System.Drawing.Size(131, 28);
            this.salvar_codigo.TabIndex = 16;
            this.salvar_codigo.Text = "Salvar Código Postal";
            this.salvar_codigo.UseVisualStyleBackColor = true;
            this.salvar_codigo.Click += new System.EventHandler(this.salvar_codigo_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(399, 91);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Distrito:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(238, 91);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Conselho:";
            // 
            // textdistrito
            // 
            this.textdistrito.Location = new System.Drawing.Point(457, 88);
            this.textdistrito.Margin = new System.Windows.Forms.Padding(2);
            this.textdistrito.Name = "textdistrito";
            this.textdistrito.Size = new System.Drawing.Size(76, 20);
            this.textdistrito.TabIndex = 18;
            // 
            // textconselho
            // 
            this.textconselho.Location = new System.Drawing.Point(296, 88);
            this.textconselho.Margin = new System.Windows.Forms.Padding(2);
            this.textconselho.Name = "textconselho";
            this.textconselho.Size = new System.Drawing.Size(76, 20);
            this.textconselho.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Pass:";
            // 
            // pass_atual
            // 
            this.pass_atual.Location = new System.Drawing.Point(49, 40);
            this.pass_atual.Margin = new System.Windows.Forms.Padding(2);
            this.pass_atual.Name = "pass_atual";
            this.pass_atual.Size = new System.Drawing.Size(76, 20);
            this.pass_atual.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 58);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "CP:";
            // 
            // cp_mostrar
            // 
            this.cp_mostrar.Location = new System.Drawing.Point(49, 58);
            this.cp_mostrar.Margin = new System.Windows.Forms.Padding(2);
            this.cp_mostrar.Name = "cp_mostrar";
            this.cp_mostrar.Size = new System.Drawing.Size(76, 20);
            this.cp_mostrar.TabIndex = 24;
            // 
            // perfil_cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 277);
            this.Controls.Add(this.cp_mostrar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pass_atual);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textdistrito);
            this.Controls.Add(this.textconselho);
            this.Controls.Add(this.salvar_codigo);
            this.Controls.Add(this.codigo_alterar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.salvar_pass);
            this.Controls.Add(this.Voltar);
            this.Controls.Add(this.nome_utilizador);
            this.Controls.Add(this.pass_alterar);
            this.Controls.Add(this.apagar_cliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "perfil_cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Perfil Cliente";
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
        private System.Windows.Forms.Button salvar_pass;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox codigo_alterar;
        private System.Windows.Forms.Button salvar_codigo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textdistrito;
        private System.Windows.Forms.TextBox textconselho;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pass_atual;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox cp_mostrar;
    }
}