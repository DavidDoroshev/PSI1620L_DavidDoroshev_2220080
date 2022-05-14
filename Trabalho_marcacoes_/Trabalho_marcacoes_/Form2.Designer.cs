
namespace Trabalho_marcacoes_
{
    partial class Form2
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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Codigo Postal:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(441, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password:";
            // 
            // nome_guardar
            // 
            this.nome_guardar.Location = new System.Drawing.Point(94, 48);
            this.nome_guardar.Name = "nome_guardar";
            this.nome_guardar.Size = new System.Drawing.Size(100, 22);
            this.nome_guardar.TabIndex = 4;

            // 
            // password_guardar
            // 
            this.password_guardar.Location = new System.Drawing.Point(520, 51);
            this.password_guardar.Name = "password_guardar";
            this.password_guardar.Size = new System.Drawing.Size(100, 22);
            this.password_guardar.TabIndex = 5;

            // 
            // guardar_cliente
            // 
            this.guardar_cliente.Location = new System.Drawing.Point(520, 373);
            this.guardar_cliente.Name = "guardar_cliente";
            this.guardar_cliente.Size = new System.Drawing.Size(174, 54);
            this.guardar_cliente.TabIndex = 6;
            this.guardar_cliente.Text = "Guardar";
            this.guardar_cliente.UseVisualStyleBackColor = true;
            this.guardar_cliente.Click += new System.EventHandler(this.guardar_cliente_Click);
            // 
            // voltar_iniciar
            // 
            this.voltar_iniciar.Location = new System.Drawing.Point(66, 373);
            this.voltar_iniciar.Name = "voltar_iniciar";
            this.voltar_iniciar.Size = new System.Drawing.Size(174, 54);
            this.voltar_iniciar.TabIndex = 7;
            this.voltar_iniciar.Text = "Voltar";
            this.voltar_iniciar.UseVisualStyleBackColor = true;
            this.voltar_iniciar.Click += new System.EventHandler(this.voltar_iniciar_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(134, 197);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.voltar_iniciar);
            this.Controls.Add(this.guardar_cliente);
            this.Controls.Add(this.password_guardar);
            this.Controls.Add(this.nome_guardar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
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
    }
}