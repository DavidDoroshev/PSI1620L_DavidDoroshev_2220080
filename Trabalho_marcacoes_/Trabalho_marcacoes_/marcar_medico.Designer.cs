
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
            this.horas_guardar = new System.Windows.Forms.MaskedTextBox();
            this.codigo_pesquisar = new System.Windows.Forms.ComboBox();
            this.mostrar_medico = new System.Windows.Forms.ListView();
            this.nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.especialidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.data_guardar = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // horas_guardar
            // 
            this.horas_guardar.Location = new System.Drawing.Point(253, 178);
            this.horas_guardar.Margin = new System.Windows.Forms.Padding(2);
            this.horas_guardar.Mask = "00:00:00";
            this.horas_guardar.Name = "horas_guardar";
            this.horas_guardar.Size = new System.Drawing.Size(43, 20);
            this.horas_guardar.TabIndex = 17;
            this.horas_guardar.ValidatingType = typeof(System.DateTime);
            // 
            // codigo_pesquisar
            // 
            this.codigo_pesquisar.FormattingEnabled = true;
            this.codigo_pesquisar.Location = new System.Drawing.Point(107, 180);
            this.codigo_pesquisar.Margin = new System.Windows.Forms.Padding(2);
            this.codigo_pesquisar.Name = "codigo_pesquisar";
            this.codigo_pesquisar.Size = new System.Drawing.Size(92, 21);
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
            this.mostrar_medico.Location = new System.Drawing.Point(29, 12);
            this.mostrar_medico.MultiSelect = false;
            this.mostrar_medico.Name = "mostrar_medico";
            this.mostrar_medico.Size = new System.Drawing.Size(750, 144);
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
            // data_guardar
            // 
            this.data_guardar.Location = new System.Drawing.Point(413, 176);
            this.data_guardar.Name = "data_guardar";
            this.data_guardar.Size = new System.Drawing.Size(200, 20);
            this.data_guardar.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(388, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Dia:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Horas:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Codigo-Postal:";
            // 
            // marcar_medico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 344);
            this.Controls.Add(this.horas_guardar);
            this.Controls.Add(this.codigo_pesquisar);
            this.Controls.Add(this.mostrar_medico);
            this.Controls.Add(this.data_guardar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "marcar_medico";
            this.Text = "Marcar Medico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox horas_guardar;
        private System.Windows.Forms.ComboBox codigo_pesquisar;
        private System.Windows.Forms.ListView mostrar_medico;
        private System.Windows.Forms.ColumnHeader nome;
        private System.Windows.Forms.ColumnHeader especialidade;
        private System.Windows.Forms.ColumnHeader cp;
        private System.Windows.Forms.DateTimePicker data_guardar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}