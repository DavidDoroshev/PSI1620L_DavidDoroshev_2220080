
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cliente_mostrar = new System.Windows.Forms.ComboBox();
            this.trabalhador_nome = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.verificar_hora = new System.Windows.Forms.MaskedTextBox();
            this.especialidade = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.voltar = new System.Windows.Forms.Button();
            this.guardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(29, 154);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // cliente_mostrar
            // 
            this.cliente_mostrar.FormattingEnabled = true;
            this.cliente_mostrar.Location = new System.Drawing.Point(87, 26);
            this.cliente_mostrar.Name = "cliente_mostrar";
            this.cliente_mostrar.Size = new System.Drawing.Size(121, 24);
            this.cliente_mostrar.TabIndex = 2;
            this.cliente_mostrar.SelectedIndexChanged += new System.EventHandler(this.cliente_mostrar_SelectedIndexChanged);
            // 
            // trabalhador_nome
            // 
            this.trabalhador_nome.FormattingEnabled = true;
            this.trabalhador_nome.Location = new System.Drawing.Point(515, 23);
            this.trabalhador_nome.Name = "trabalhador_nome";
            this.trabalhador_nome.Size = new System.Drawing.Size(121, 24);
            this.trabalhador_nome.TabIndex = 3;
            this.trabalhador_nome.SelectedIndexChanged += new System.EventHandler(this.trabalhador_nome_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(419, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Trabalhador:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Hora:";
            // 
            // verificar_hora
            // 
            this.verificar_hora.Location = new System.Drawing.Point(84, 95);
            this.verificar_hora.Mask = "00:00";
            this.verificar_hora.Name = "verificar_hora";
            this.verificar_hora.Size = new System.Drawing.Size(42, 22);
            this.verificar_hora.TabIndex = 7;
            this.verificar_hora.ValidatingType = typeof(System.DateTime);
            // 
            // especialidade
            // 
            this.especialidade.Location = new System.Drawing.Point(525, 95);
            this.especialidade.Name = "especialidade";
            this.especialidade.Size = new System.Drawing.Size(100, 22);
            this.especialidade.TabIndex = 8;
            this.especialidade.TextChanged += new System.EventHandler(this.especialidade_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(419, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Especialidade:";
            // 
            // voltar
            // 
            this.voltar.Location = new System.Drawing.Point(12, 233);
            this.voltar.Name = "voltar";
            this.voltar.Size = new System.Drawing.Size(125, 29);
            this.voltar.TabIndex = 10;
            this.voltar.Text = "Voltar";
            this.voltar.UseVisualStyleBackColor = true;
            // 
            // guardar
            // 
            this.guardar.Location = new System.Drawing.Point(511, 233);
            this.guardar.Name = "guardar";
            this.guardar.Size = new System.Drawing.Size(125, 29);
            this.guardar.TabIndex = 11;
            this.guardar.Text = "Guardar";
            this.guardar.UseVisualStyleBackColor = true;
            // 
            // admin_marcar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 274);
            this.Controls.Add(this.guardar);
            this.Controls.Add(this.voltar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.especialidade);
            this.Controls.Add(this.verificar_hora);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trabalhador_nome);
            this.Controls.Add(this.cliente_mostrar);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "admin_marcar";
            this.Text = "admin_marcar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cliente_mostrar;
        private System.Windows.Forms.ComboBox trabalhador_nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox verificar_hora;
        private System.Windows.Forms.TextBox especialidade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button voltar;
        private System.Windows.Forms.Button guardar;
    }
}