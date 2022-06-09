
namespace Trabalho_marcacoes_
{
    partial class admin_marcar
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
            this.cliente_mostrar = new System.Windows.Forms.ComboBox();
            this.trabalhador_nome = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.especialidade = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.voltar = new System.Windows.Forms.Button();
            this.guardar = new System.Windows.Forms.Button();
            this.hora_guardar = new System.Windows.Forms.MaskedTextBox();
            this.dia_guardar = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // cliente_mostrar
            // 
            this.cliente_mostrar.FormattingEnabled = true;
            this.cliente_mostrar.Location = new System.Drawing.Point(65, 21);
            this.cliente_mostrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cliente_mostrar.Name = "cliente_mostrar";
            this.cliente_mostrar.Size = new System.Drawing.Size(92, 21);
            this.cliente_mostrar.TabIndex = 2;
            this.cliente_mostrar.SelectedIndexChanged += new System.EventHandler(this.cliente_mostrar_SelectedIndexChanged);
            // 
            // trabalhador_nome
            // 
            this.trabalhador_nome.FormattingEnabled = true;
            this.trabalhador_nome.Location = new System.Drawing.Point(386, 19);
            this.trabalhador_nome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.trabalhador_nome.Name = "trabalhador_nome";
            this.trabalhador_nome.Size = new System.Drawing.Size(92, 21);
            this.trabalhador_nome.TabIndex = 3;
            this.trabalhador_nome.SelectedIndexChanged += new System.EventHandler(this.trabalhador_nome_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(314, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Trabalhador:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 77);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Hora:";
            // 
            // especialidade
            // 
            this.especialidade.Location = new System.Drawing.Point(394, 77);
            this.especialidade.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.especialidade.Name = "especialidade";
            this.especialidade.Size = new System.Drawing.Size(76, 20);
            this.especialidade.TabIndex = 8;
            this.especialidade.TextChanged += new System.EventHandler(this.especialidade_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(314, 81);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Especialidade:";
            // 
            // voltar
            // 
            this.voltar.Location = new System.Drawing.Point(9, 178);
            this.voltar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.voltar.Name = "voltar";
            this.voltar.Size = new System.Drawing.Size(94, 35);
            this.voltar.TabIndex = 10;
            this.voltar.Text = "Voltar";
            this.voltar.UseVisualStyleBackColor = true;
            // 
            // guardar
            // 
            this.guardar.Location = new System.Drawing.Point(383, 178);
            this.guardar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guardar.Name = "guardar";
            this.guardar.Size = new System.Drawing.Size(94, 35);
            this.guardar.TabIndex = 11;
            this.guardar.Text = "Guardar";
            this.guardar.UseVisualStyleBackColor = true;
            this.guardar.Click += new System.EventHandler(this.guardar_Click);
            // 
            // hora_guardar
            // 
            this.hora_guardar.Location = new System.Drawing.Point(65, 76);
            this.hora_guardar.Mask = "00:00";
            this.hora_guardar.Name = "hora_guardar";
            this.hora_guardar.Size = new System.Drawing.Size(32, 20);
            this.hora_guardar.TabIndex = 12;
            this.hora_guardar.ValidatingType = typeof(System.DateTime);
            // 
            // dia_guardar
            // 
            this.dia_guardar.Location = new System.Drawing.Point(23, 123);
            this.dia_guardar.MaxDate = new System.DateTime(2025, 12, 31, 0, 0, 0, 0);
            this.dia_guardar.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dia_guardar.Name = "dia_guardar";
            this.dia_guardar.Size = new System.Drawing.Size(200, 20);
            this.dia_guardar.TabIndex = 4;
            // 
            // admin_marcar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 223);
            this.Controls.Add(this.dia_guardar);
            this.Controls.Add(this.hora_guardar);
            this.Controls.Add(this.guardar);
            this.Controls.Add(this.voltar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.especialidade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trabalhador_nome);
            this.Controls.Add(this.cliente_mostrar);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "admin_marcar";
            this.Text = "admin_marcar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cliente_mostrar;
        private System.Windows.Forms.ComboBox trabalhador_nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox especialidade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button voltar;
        private System.Windows.Forms.Button guardar;
        private System.Windows.Forms.MaskedTextBox hora_guardar;
        private System.Windows.Forms.DateTimePicker dia_guardar;
    }
}