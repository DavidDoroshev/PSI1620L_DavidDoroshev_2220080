
namespace Trabalho_marcacoes_
{
    partial class marcacoes_trabalhador
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
            this.mostrar = new System.Windows.Forms.ListView();
            this.nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hora = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.voltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mostrar
            // 
            this.mostrar.BackColor = System.Drawing.SystemColors.Menu;
            this.mostrar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mostrar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nome,
            this.dia,
            this.hora});
            this.mostrar.FullRowSelect = true;
            this.mostrar.HideSelection = false;
            this.mostrar.Location = new System.Drawing.Point(36, 15);
            this.mostrar.Margin = new System.Windows.Forms.Padding(4);
            this.mostrar.MultiSelect = false;
            this.mostrar.Name = "mostrar";
            this.mostrar.Size = new System.Drawing.Size(673, 297);
            this.mostrar.TabIndex = 16;
            this.mostrar.UseCompatibleStateImageBehavior = false;
            this.mostrar.View = System.Windows.Forms.View.Details;
            // 
            // nome
            // 
            this.nome.Text = "Cliente";
            this.nome.Width = 165;
            // 
            // dia
            // 
            this.dia.Text = "Dia";
            this.dia.Width = 136;
            // 
            // hora
            // 
            this.hora.Text = "Hora";
            this.hora.Width = 204;
            // 
            // voltar
            // 
            this.voltar.Location = new System.Drawing.Point(287, 319);
            this.voltar.Margin = new System.Windows.Forms.Padding(4);
            this.voltar.Name = "voltar";
            this.voltar.Size = new System.Drawing.Size(160, 58);
            this.voltar.TabIndex = 17;
            this.voltar.Text = "Voltar";
            this.voltar.UseVisualStyleBackColor = true;
            this.voltar.Click += new System.EventHandler(this.voltar_Click);
            // 
            // marcacoes_trabalhador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 386);
            this.Controls.Add(this.voltar);
            this.Controls.Add(this.mostrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "marcacoes_trabalhador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "marcacoes_trabalhador";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView mostrar;
        private System.Windows.Forms.ColumnHeader nome;
        private System.Windows.Forms.ColumnHeader dia;
        private System.Windows.Forms.ColumnHeader hora;
        private System.Windows.Forms.Button voltar;
    }
}