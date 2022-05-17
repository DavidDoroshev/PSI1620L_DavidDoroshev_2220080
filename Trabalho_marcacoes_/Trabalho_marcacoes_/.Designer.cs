
namespace Trabalho_marcacoes_
{
    partial class criar_conta
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
            this.nome_guardar = new System.Windows.Forms.TextBox();
            this.password_guardar = new System.Windows.Forms.TextBox();
            this.guardar_cliente = new System.Windows.Forms.Button();
            this.voltar_iniciar = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textconselho = new System.Windows.Forms.TextBox();
            this.textdistrito = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Codigo Postal:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(496, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password:";
            // 
            // nome_guardar
            // 
            this.nome_guardar.Location = new System.Drawing.Point(105, 60);
            this.nome_guardar.Name = "nome_guardar";
            this.nome_guardar.Size = new System.Drawing.Size(112, 26);
            this.nome_guardar.TabIndex = 4;
            // 
            // password_guardar
            // 
            this.password_guardar.Location = new System.Drawing.Point(585, 63);
            this.password_guardar.Name = "password_guardar";
            this.password_guardar.Size = new System.Drawing.Size(112, 26);
            this.password_guardar.TabIndex = 5;
            // 
            // guardar_cliente
            // 
            this.guardar_cliente.Location = new System.Drawing.Point(585, 466);
            this.guardar_cliente.Name = "guardar_cliente";
            this.guardar_cliente.Size = new System.Drawing.Size(195, 68);
            this.guardar_cliente.TabIndex = 6;
            this.guardar_cliente.Text = "Guardar";
            this.guardar_cliente.UseVisualStyleBackColor = true;
            this.guardar_cliente.Click += new System.EventHandler(this.guardar_cliente_Click);
            // 
            // voltar_iniciar
            // 
            this.voltar_iniciar.Location = new System.Drawing.Point(75, 466);
            this.voltar_iniciar.Name = "voltar_iniciar";
            this.voltar_iniciar.Size = new System.Drawing.Size(195, 68);
            this.voltar_iniciar.TabIndex = 7;
            this.voltar_iniciar.Text = "Voltar";
            this.voltar_iniciar.UseVisualStyleBackColor = true;
            this.voltar_iniciar.Click += new System.EventHandler(this.voltar_iniciar_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(150, 246);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(136, 28);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textconselho
            // 
            this.textconselho.Location = new System.Drawing.Point(380, 245);
            this.textconselho.Name = "textconselho";
            this.textconselho.Size = new System.Drawing.Size(112, 26);
            this.textconselho.TabIndex = 9;
            this.textconselho.TextChanged += new System.EventHandler(this.textconselho_TextChanged);
            // 
            // textdistrito
            // 
            this.textdistrito.Location = new System.Drawing.Point(585, 245);
            this.textdistrito.Name = "textdistrito";
            this.textdistrito.Size = new System.Drawing.Size(112, 26);
            this.textdistrito.TabIndex = 10;
            this.textdistrito.TextChanged += new System.EventHandler(this.textdistrito_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(294, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Conselho:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(516, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Distrito:";
            // 
            // criar_conta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 563);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textdistrito);
            this.Controls.Add(this.textconselho);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.voltar_iniciar);
            this.Controls.Add(this.guardar_cliente);
            this.Controls.Add(this.password_guardar);
            this.Controls.Add(this.nome_guardar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "criar_conta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Criar Conta ";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nome_guardar;
        private System.Windows.Forms.TextBox password_guardar;
        private System.Windows.Forms.Button guardar_cliente;
        private System.Windows.Forms.Button voltar_iniciar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textconselho;
        private System.Windows.Forms.TextBox textdistrito;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
    }
}