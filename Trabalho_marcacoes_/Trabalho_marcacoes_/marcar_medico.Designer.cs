
namespace Trabalho_marcacoes_
{
    partial class marcar_medico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(marcar_medico));
            this.hora_guardar = new System.Windows.Forms.MaskedTextBox();
            this.codigo_pesquisar = new System.Windows.Forms.ComboBox();
            this.mostrar_medico = new System.Windows.Forms.ListView();
            this.nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.especialidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dia_guardar = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.voltar = new System.Windows.Forms.Button();
            this.marcar_guardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hora_guardar
            // 
            this.hora_guardar.Location = new System.Drawing.Point(337, 219);
            this.hora_guardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hora_guardar.Mask = "00:00:00";
            this.hora_guardar.Name = "hora_guardar";
            this.hora_guardar.Size = new System.Drawing.Size(56, 22);
            this.hora_guardar.TabIndex = 17;
            this.hora_guardar.ValidatingType = typeof(System.DateTime);
            // 
            // codigo_pesquisar
            // 
            this.codigo_pesquisar.FormattingEnabled = true;
            this.codigo_pesquisar.Location = new System.Drawing.Point(143, 222);
            this.codigo_pesquisar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.codigo_pesquisar.Name = "codigo_pesquisar";
            this.codigo_pesquisar.Size = new System.Drawing.Size(121, 24);
            this.codigo_pesquisar.TabIndex = 16;
            // 
            // mostrar_medico
            // 
            this.mostrar_medico.BackColor = System.Drawing.SystemColors.Menu;
            this.mostrar_medico.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mostrar_medico.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nome,
            this.especialidade,
            this.cp});
            this.mostrar_medico.FullRowSelect = true;
            this.mostrar_medico.HideSelection = false;
            this.mostrar_medico.Location = new System.Drawing.Point(39, 15);
            this.mostrar_medico.Margin = new System.Windows.Forms.Padding(4);
            this.mostrar_medico.MultiSelect = false;
            this.mostrar_medico.Name = "mostrar_medico";
            this.mostrar_medico.Size = new System.Drawing.Size(1000, 177);
            this.mostrar_medico.TabIndex = 15;
            this.mostrar_medico.UseCompatibleStateImageBehavior = false;
            this.mostrar_medico.View = System.Windows.Forms.View.Details;
            this.mostrar_medico.SelectedIndexChanged += new System.EventHandler(this.mostrar_medico_SelectedIndexChanged);
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
            // dia_guardar
            // 
            this.dia_guardar.Location = new System.Drawing.Point(551, 217);
            this.dia_guardar.Margin = new System.Windows.Forms.Padding(4);
            this.dia_guardar.Name = "dia_guardar";
            this.dia_guardar.Size = new System.Drawing.Size(235, 22);
            this.dia_guardar.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(517, 217);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Dia:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(291, 222);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Horas:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 222);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Codigo-Postal:";
            // 
            // voltar
            // 
            this.voltar.Location = new System.Drawing.Point(39, 347);
            this.voltar.Name = "voltar";
            this.voltar.Size = new System.Drawing.Size(129, 49);
            this.voltar.TabIndex = 18;
            this.voltar.Text = "Voltar";
            this.voltar.UseVisualStyleBackColor = true;
            this.voltar.Click += new System.EventHandler(this.voltar_Click);
            // 
            // marcar_guardar
            // 
            this.marcar_guardar.Location = new System.Drawing.Point(910, 347);
            this.marcar_guardar.Name = "marcar_guardar";
            this.marcar_guardar.Size = new System.Drawing.Size(129, 49);
            this.marcar_guardar.TabIndex = 19;
            this.marcar_guardar.Text = "MARCAR";
            this.marcar_guardar.UseVisualStyleBackColor = true;
            this.marcar_guardar.Click += new System.EventHandler(this.marcar_guardar_Click);
            // 
            // marcar_medico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 423);
            this.Controls.Add(this.marcar_guardar);
            this.Controls.Add(this.voltar);
            this.Controls.Add(this.hora_guardar);
            this.Controls.Add(this.codigo_pesquisar);
            this.Controls.Add(this.mostrar_medico);
            this.Controls.Add(this.dia_guardar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "marcar_medico";
            this.Text = "Marcar Medico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox hora_guardar;
        private System.Windows.Forms.ComboBox codigo_pesquisar;
        private System.Windows.Forms.ListView mostrar_medico;
        private System.Windows.Forms.ColumnHeader nome;
        private System.Windows.Forms.ColumnHeader especialidade;
        private System.Windows.Forms.ColumnHeader cp;
        private System.Windows.Forms.DateTimePicker dia_guardar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button voltar;
        private System.Windows.Forms.Button marcar_guardar;
    }
}