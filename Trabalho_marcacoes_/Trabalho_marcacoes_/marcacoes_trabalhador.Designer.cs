﻿
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
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hora = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.voltar = new System.Windows.Forms.Button();
            this.apagar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mostrar
            // 
            this.mostrar.BackColor = System.Drawing.SystemColors.Menu;
            this.mostrar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mostrar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.nome,
            this.dia,
            this.hora});
            this.mostrar.FullRowSelect = true;
            this.mostrar.HideSelection = false;
            this.mostrar.Location = new System.Drawing.Point(13, 15);
            this.mostrar.Margin = new System.Windows.Forms.Padding(4);
            this.mostrar.MultiSelect = false;
            this.mostrar.Name = "mostrar";
            this.mostrar.Size = new System.Drawing.Size(728, 297);
            this.mostrar.TabIndex = 16;
            this.mostrar.UseCompatibleStateImageBehavior = false;
            this.mostrar.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
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
            this.hora.Width = 150;
            // 
            // voltar
            // 
            this.voltar.Location = new System.Drawing.Point(292, 368);
            this.voltar.Margin = new System.Windows.Forms.Padding(4);
            this.voltar.Name = "voltar";
            this.voltar.Size = new System.Drawing.Size(160, 58);
            this.voltar.TabIndex = 17;
            this.voltar.Text = "Voltar";
            this.voltar.UseVisualStyleBackColor = true;
            this.voltar.Click += new System.EventHandler(this.voltar_Click);
            // 
            // apagar
            // 
            this.apagar.Location = new System.Drawing.Point(641, 368);
            this.apagar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.apagar.Name = "apagar";
            this.apagar.Size = new System.Drawing.Size(100, 58);
            this.apagar.TabIndex = 19;
            this.apagar.Text = "Apagar";
            this.apagar.UseVisualStyleBackColor = true;
            this.apagar.Click += new System.EventHandler(this.apagar_Click);
            // 
            // marcacoes_trabalhador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 437);
            this.Controls.Add(this.apagar);
            this.Controls.Add(this.voltar);
            this.Controls.Add(this.mostrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "marcacoes_trabalhador";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marcações";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView mostrar;
        private System.Windows.Forms.ColumnHeader nome;
        private System.Windows.Forms.ColumnHeader dia;
        private System.Windows.Forms.ColumnHeader hora;
        private System.Windows.Forms.Button voltar;
        private System.Windows.Forms.Button apagar;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}