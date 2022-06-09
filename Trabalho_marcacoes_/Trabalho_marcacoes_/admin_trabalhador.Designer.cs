
namespace Trabalho_marcacoes_
{
    partial class admin_trabalhador
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
            this.textdistrito = new System.Windows.Forms.TextBox();
            this.textconselho = new System.Windows.Forms.TextBox();
            this.especialidade_select = new System.Windows.Forms.ComboBox();
            this.profissao_select = new System.Windows.Forms.ComboBox();
            this.guardar_button = new System.Windows.Forms.Button();
            this.codigo_postal_trabalhador = new System.Windows.Forms.ComboBox();
            this.nome_trabalhador = new System.Windows.Forms.TextBox();
            this.password_trabalhador = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.voltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textdistrito
            // 
            this.textdistrito.Location = new System.Drawing.Point(344, 94);
            this.textdistrito.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textdistrito.Name = "textdistrito";
            this.textdistrito.Size = new System.Drawing.Size(100, 22);
            this.textdistrito.TabIndex = 36;
            // 
            // textconselho
            // 
            this.textconselho.Location = new System.Drawing.Point(536, 93);
            this.textconselho.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textconselho.Name = "textconselho";
            this.textconselho.Size = new System.Drawing.Size(100, 22);
            this.textconselho.TabIndex = 35;
            // 
            // especialidade_select
            // 
            this.especialidade_select.FormattingEnabled = true;
            this.especialidade_select.Location = new System.Drawing.Point(456, 173);
            this.especialidade_select.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.especialidade_select.Name = "especialidade_select";
            this.especialidade_select.Size = new System.Drawing.Size(121, 24);
            this.especialidade_select.TabIndex = 34;
            // 
            // profissao_select
            // 
            this.profissao_select.FormattingEnabled = true;
            this.profissao_select.Location = new System.Drawing.Point(86, 177);
            this.profissao_select.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.profissao_select.Name = "profissao_select";
            this.profissao_select.Size = new System.Drawing.Size(121, 24);
            this.profissao_select.TabIndex = 33;
            this.profissao_select.SelectedIndexChanged += new System.EventHandler(this.profissao_select_SelectedIndexChanged);
            // 
            // guardar_button
            // 
            this.guardar_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guardar_button.Location = new System.Drawing.Point(472, 293);
            this.guardar_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guardar_button.Name = "guardar_button";
            this.guardar_button.Size = new System.Drawing.Size(164, 57);
            this.guardar_button.TabIndex = 32;
            this.guardar_button.Text = "Guardar";
            this.guardar_button.UseVisualStyleBackColor = true;
            this.guardar_button.Click += new System.EventHandler(this.guardar_button_Click);
            // 
            // codigo_postal_trabalhador
            // 
            this.codigo_postal_trabalhador.FormattingEnabled = true;
            this.codigo_postal_trabalhador.Location = new System.Drawing.Point(116, 95);
            this.codigo_postal_trabalhador.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.codigo_postal_trabalhador.Name = "codigo_postal_trabalhador";
            this.codigo_postal_trabalhador.Size = new System.Drawing.Size(121, 24);
            this.codigo_postal_trabalhador.TabIndex = 30;
            this.codigo_postal_trabalhador.SelectedIndexChanged += new System.EventHandler(this.codigo_postal_trabalhador_SelectedIndexChanged);
            // 
            // nome_trabalhador
            // 
            this.nome_trabalhador.Location = new System.Drawing.Point(65, 27);
            this.nome_trabalhador.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nome_trabalhador.Name = "nome_trabalhador";
            this.nome_trabalhador.Size = new System.Drawing.Size(100, 22);
            this.nome_trabalhador.TabIndex = 29;
            // 
            // password_trabalhador
            // 
            this.password_trabalhador.Location = new System.Drawing.Point(281, 27);
            this.password_trabalhador.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.password_trabalhador.Name = "password_trabalhador";
            this.password_trabalhador.Size = new System.Drawing.Size(100, 22);
            this.password_trabalhador.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(350, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 17);
            this.label7.TabIndex = 27;
            this.label7.Text = "Especialidade:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(202, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 17);
            this.label6.TabIndex = 26;
            this.label6.Text = "Password:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(458, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 17);
            this.label5.TabIndex = 25;
            this.label5.Text = "Conselho:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 24;
            this.label4.Text = "Profissão:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Código-Postal:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(282, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Distrito:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Nome:";
            // 
            // voltar
            // 
            this.voltar.Location = new System.Drawing.Point(12, 293);
            this.voltar.Name = "voltar";
            this.voltar.Size = new System.Drawing.Size(164, 57);
            this.voltar.TabIndex = 37;
            this.voltar.Text = "Voltar";
            this.voltar.UseVisualStyleBackColor = true;
            this.voltar.Click += new System.EventHandler(this.voltar_Click);
            // 
            // admin_trabalhador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 362);
            this.Controls.Add(this.voltar);
            this.Controls.Add(this.textdistrito);
            this.Controls.Add(this.textconselho);
            this.Controls.Add(this.especialidade_select);
            this.Controls.Add(this.profissao_select);
            this.Controls.Add(this.guardar_button);
            this.Controls.Add(this.codigo_postal_trabalhador);
            this.Controls.Add(this.nome_trabalhador);
            this.Controls.Add(this.password_trabalhador);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "admin_trabalhador";
            this.ShowIcon = false;
            this.Text = "admin_trabalhador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textdistrito;
        private System.Windows.Forms.TextBox textconselho;
        private System.Windows.Forms.ComboBox especialidade_select;
        private System.Windows.Forms.ComboBox profissao_select;
        private System.Windows.Forms.Button guardar_button;
        private System.Windows.Forms.ComboBox codigo_postal_trabalhador;
        private System.Windows.Forms.TextBox nome_trabalhador;
        private System.Windows.Forms.TextBox password_trabalhador;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button voltar;
    }
}