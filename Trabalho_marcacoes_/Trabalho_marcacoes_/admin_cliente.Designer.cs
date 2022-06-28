
namespace Trabalho_marcacoes_
{
    partial class admin_cliente
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
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textdistrito = new System.Windows.Forms.TextBox();
            this.textconselho = new System.Windows.Forms.TextBox();
            this.codigo_guardar = new System.Windows.Forms.ComboBox();
            this.voltar_iniciar = new System.Windows.Forms.Button();
            this.guardar_cliente = new System.Windows.Forms.Button();
            this.password_guardar = new System.Windows.Forms.TextBox();
            this.nome_guardar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(444, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 24;
            this.label5.Text = "Distrito:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "Conselho:";
            // 
            // textdistrito
            // 
            this.textdistrito.Location = new System.Drawing.Point(505, 79);
            this.textdistrito.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textdistrito.Name = "textdistrito";
            this.textdistrito.Size = new System.Drawing.Size(100, 22);
            this.textdistrito.TabIndex = 22;
            this.textdistrito.TextChanged += new System.EventHandler(this.textdistrito_TextChanged);
            // 
            // textconselho
            // 
            this.textconselho.Location = new System.Drawing.Point(323, 79);
            this.textconselho.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textconselho.Name = "textconselho";
            this.textconselho.Size = new System.Drawing.Size(100, 22);
            this.textconselho.TabIndex = 21;
            this.textconselho.TextChanged += new System.EventHandler(this.textconselho_TextChanged);
            // 
            // codigo_guardar
            // 
            this.codigo_guardar.FormattingEnabled = true;
            this.codigo_guardar.Location = new System.Drawing.Point(119, 80);
            this.codigo_guardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.codigo_guardar.Name = "codigo_guardar";
            this.codigo_guardar.Size = new System.Drawing.Size(121, 24);
            this.codigo_guardar.TabIndex = 20;
            this.codigo_guardar.SelectedIndexChanged += new System.EventHandler(this.codigo_guardar_SelectedIndexChanged);
            // 
            // voltar_iniciar
            // 
            this.voltar_iniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.voltar_iniciar.Location = new System.Drawing.Point(24, 159);
            this.voltar_iniciar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.voltar_iniciar.Name = "voltar_iniciar";
            this.voltar_iniciar.Size = new System.Drawing.Size(173, 54);
            this.voltar_iniciar.TabIndex = 19;
            this.voltar_iniciar.Text = "Voltar";
            this.voltar_iniciar.UseVisualStyleBackColor = true;
            this.voltar_iniciar.Click += new System.EventHandler(this.voltar_iniciar_Click);
            // 
            // guardar_cliente
            // 
            this.guardar_cliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guardar_cliente.Location = new System.Drawing.Point(432, 159);
            this.guardar_cliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guardar_cliente.Name = "guardar_cliente";
            this.guardar_cliente.Size = new System.Drawing.Size(173, 54);
            this.guardar_cliente.TabIndex = 18;
            this.guardar_cliente.Text = "Guardar";
            this.guardar_cliente.UseVisualStyleBackColor = true;
            this.guardar_cliente.Click += new System.EventHandler(this.guardar_cliente_Click);
            // 
            // password_guardar
            // 
            this.password_guardar.Location = new System.Drawing.Point(504, 21);
            this.password_guardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.password_guardar.Name = "password_guardar";
            this.password_guardar.Size = new System.Drawing.Size(100, 22);
            this.password_guardar.TabIndex = 17;
            // 
            // nome_guardar
            // 
            this.nome_guardar.Location = new System.Drawing.Point(84, 17);
            this.nome_guardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nome_guardar.Name = "nome_guardar";
            this.nome_guardar.Size = new System.Drawing.Size(100, 22);
            this.nome_guardar.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(425, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Codigo Postal:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nome:";
            // 
            // admin_cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 239);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textdistrito);
            this.Controls.Add(this.textconselho);
            this.Controls.Add(this.codigo_guardar);
            this.Controls.Add(this.voltar_iniciar);
            this.Controls.Add(this.guardar_cliente);
            this.Controls.Add(this.password_guardar);
            this.Controls.Add(this.nome_guardar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "admin_cliente";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "admin_cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textdistrito;
        private System.Windows.Forms.TextBox textconselho;
        private System.Windows.Forms.ComboBox codigo_guardar;
        private System.Windows.Forms.Button voltar_iniciar;
        private System.Windows.Forms.Button guardar_cliente;
        private System.Windows.Forms.TextBox password_guardar;
        private System.Windows.Forms.TextBox nome_guardar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}