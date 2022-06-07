
namespace Trabalho_marcacoes_
{
    partial class marcar_estetica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(marcar_estetica));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Marcar = new System.Windows.Forms.Button();
            this.voltar = new System.Windows.Forms.Button();
            this.mostrar = new System.Windows.Forms.ListView();
            this.nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.especialidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.codigo_pesquisar = new System.Windows.Forms.ComboBox();
            this.horas_guardar = new System.Windows.Forms.MaskedTextBox();
            this.tempo_guardar = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 222);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Codigo-Postal:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(329, 222);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Horas:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(516, 217);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Dia:";
            // 
            // Marcar
            // 
            this.Marcar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Marcar.Location = new System.Drawing.Point(897, 353);
            this.Marcar.Margin = new System.Windows.Forms.Padding(4);
            this.Marcar.Name = "Marcar";
            this.Marcar.Size = new System.Drawing.Size(140, 53);
            this.Marcar.TabIndex = 6;
            this.Marcar.Text = "MARCAR";
            this.Marcar.UseVisualStyleBackColor = true;
            this.Marcar.Click += new System.EventHandler(this.Marcar_Click);
            // 
            // voltar
            // 
            this.voltar.Location = new System.Drawing.Point(37, 352);
            this.voltar.Margin = new System.Windows.Forms.Padding(4);
            this.voltar.Name = "voltar";
            this.voltar.Size = new System.Drawing.Size(140, 54);
            this.voltar.TabIndex = 7;
            this.voltar.Text = "Voltar";
            this.voltar.UseVisualStyleBackColor = true;
            this.voltar.Click += new System.EventHandler(this.voltar_Click);
            // 
            // mostrar
            // 
            this.mostrar.BackColor = System.Drawing.SystemColors.Menu;
            this.mostrar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mostrar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nome,
            this.especialidade,
            this.cp});
            this.mostrar.FullRowSelect = true;
            this.mostrar.HideSelection = false;
            this.mostrar.Location = new System.Drawing.Point(37, 15);
            this.mostrar.Margin = new System.Windows.Forms.Padding(4);
            this.mostrar.MultiSelect = false;
            this.mostrar.Name = "mostrar";
            this.mostrar.Size = new System.Drawing.Size(1000, 177);
            this.mostrar.TabIndex = 8;
            this.mostrar.UseCompatibleStateImageBehavior = false;
            this.mostrar.View = System.Windows.Forms.View.Details;
            this.mostrar.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.mostrar_ColumnWidthChanging);
            // 
            // nome
            // 
            this.nome.Text = "Nome";
            this.nome.Width = 250;
            // 
            // especialidade
            // 
            this.especialidade.Text = "Especialidade";
            this.especialidade.Width = 250;
            // 
            // cp
            // 
            this.cp.Text = "Código Postal";
            this.cp.Width = 250;
            // 
            // codigo_pesquisar
            // 
            this.codigo_pesquisar.FormattingEnabled = true;
            this.codigo_pesquisar.Location = new System.Drawing.Point(153, 222);
            this.codigo_pesquisar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.codigo_pesquisar.Name = "codigo_pesquisar";
            this.codigo_pesquisar.Size = new System.Drawing.Size(121, 24);
            this.codigo_pesquisar.TabIndex = 9;
            this.codigo_pesquisar.SelectedIndexChanged += new System.EventHandler(this.codigo_pesquisar_SelectedIndexChanged);
            // 
            // horas_guardar
            // 
            this.horas_guardar.Location = new System.Drawing.Point(376, 219);
            this.horas_guardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.horas_guardar.Mask = "00:00";
            this.horas_guardar.Name = "horas_guardar";
            this.horas_guardar.Size = new System.Drawing.Size(41, 22);
            this.horas_guardar.TabIndex = 10;
            this.horas_guardar.ValidatingType = typeof(System.DateTime);
            // 
            // tempo_guardar
            // 
            this.tempo_guardar.Location = new System.Drawing.Point(556, 217);
            this.tempo_guardar.Name = "tempo_guardar";
            this.tempo_guardar.Size = new System.Drawing.Size(200, 22);
            this.tempo_guardar.TabIndex = 11;
            this.tempo_guardar.Value = new System.DateTime(2022, 6, 6, 0, 0, 0, 0);
            // 
            // marcar_estetica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 420);
            this.Controls.Add(this.tempo_guardar);
            this.Controls.Add(this.horas_guardar);
            this.Controls.Add(this.codigo_pesquisar);
            this.Controls.Add(this.mostrar);
            this.Controls.Add(this.voltar);
            this.Controls.Add(this.Marcar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "marcar_estetica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Marcar;
        private System.Windows.Forms.Button voltar;
        private System.Windows.Forms.ListView mostrar;
        private System.Windows.Forms.ColumnHeader nome;
        private System.Windows.Forms.ColumnHeader especialidade;
        private System.Windows.Forms.ColumnHeader cp;
        private System.Windows.Forms.ComboBox codigo_pesquisar;
        private System.Windows.Forms.MaskedTextBox horas_guardar;
        private System.Windows.Forms.DateTimePicker tempo_guardar;
    }
}