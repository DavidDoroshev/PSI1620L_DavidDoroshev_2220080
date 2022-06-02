
namespace Trabalho_marcacoes_
{
    partial class ver_marcacoes
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
            this.voltar = new System.Windows.Forms.Button();
            this.mostrar = new System.Windows.Forms.ListView();
            this.nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.especialidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hora = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // voltar
            // 
            this.voltar.Location = new System.Drawing.Point(196, 290);
            this.voltar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.voltar.Name = "voltar";
            this.voltar.Size = new System.Drawing.Size(100, 31);
            this.voltar.TabIndex = 1;
            this.voltar.Text = "Voltar";
            this.voltar.UseVisualStyleBackColor = true;
            // 
            // mostrar
            // 
            this.mostrar.BackColor = System.Drawing.SystemColors.Menu;
            this.mostrar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mostrar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nome,
            this.especialidade,
            this.dia,
            this.hora});
            this.mostrar.FullRowSelect = true;
            this.mostrar.HideSelection = false;
            this.mostrar.Location = new System.Drawing.Point(9, 11);
            this.mostrar.MultiSelect = false;
            this.mostrar.Name = "mostrar";
            this.mostrar.Size = new System.Drawing.Size(526, 241);
            this.mostrar.TabIndex = 9;
            this.mostrar.UseCompatibleStateImageBehavior = false;
            this.mostrar.View = System.Windows.Forms.View.Details;
            // 
            // nome
            // 
            this.nome.Text = "Trabalhador";
            this.nome.Width = 150;
            // 
            // especialidade
            // 
            this.especialidade.Text = "Especialidade";
            this.especialidade.Width = 150;
            // 
            // dia
            // 
            this.dia.Text = "Dia";
            this.dia.Width = 150;
            // 
            // hora
            // 
            this.hora.Text = "Hora";
            this.hora.Width = 150;
            // 
            // ver_marcacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 366);
            this.Controls.Add(this.mostrar);
            this.Controls.Add(this.voltar);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ver_marcacoes";
            this.Text = "ver_marcacoes";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button voltar;
        private System.Windows.Forms.ListView mostrar;
        private System.Windows.Forms.ColumnHeader nome;
        private System.Windows.Forms.ColumnHeader especialidade;
        private System.Windows.Forms.ColumnHeader dia;
        private System.Windows.Forms.ColumnHeader hora;
    }
}