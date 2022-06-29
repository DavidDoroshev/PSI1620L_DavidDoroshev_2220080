
namespace Trabalho_marcacoes_
{
    partial class marcacoes_cliente
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
            this.apagar = new System.Windows.Forms.Button();
            this.mostrar_teste = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // voltar
            // 
            this.voltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.voltar.Location = new System.Drawing.Point(222, 298);
            this.voltar.Margin = new System.Windows.Forms.Padding(2);
            this.voltar.Name = "voltar";
            this.voltar.Size = new System.Drawing.Size(115, 38);
            this.voltar.TabIndex = 1;
            this.voltar.Text = "Voltar";
            this.voltar.UseVisualStyleBackColor = true;
            this.voltar.Click += new System.EventHandler(this.voltar_Click);
            // 
            // apagar
            // 
            this.apagar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.apagar.Location = new System.Drawing.Point(500, 289);
            this.apagar.Margin = new System.Windows.Forms.Padding(2);
            this.apagar.Name = "apagar";
            this.apagar.Size = new System.Drawing.Size(75, 47);
            this.apagar.TabIndex = 18;
            this.apagar.Text = "Apagar";
            this.apagar.UseVisualStyleBackColor = true;
            this.apagar.Click += new System.EventHandler(this.apagar_Click);
            // 
            // mostrar_teste
            // 
            this.mostrar_teste.BackColor = System.Drawing.SystemColors.Menu;
            this.mostrar_teste.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mostrar_teste.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.mostrar_teste.FullRowSelect = true;
            this.mostrar_teste.HideSelection = false;
            this.mostrar_teste.Location = new System.Drawing.Point(12, 12);
            this.mostrar_teste.MultiSelect = false;
            this.mostrar_teste.Name = "mostrar_teste";
            this.mostrar_teste.Size = new System.Drawing.Size(569, 225);
            this.mostrar_teste.TabIndex = 19;
            this.mostrar_teste.UseCompatibleStateImageBehavior = false;
            this.mostrar_teste.View = System.Windows.Forms.View.Details;
            this.mostrar_teste.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.mostrar_teste_ColumnWidthChanging);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "id";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nome - trabalhador";
            this.columnHeader1.Width = 135;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Especialidade";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Tag = "";
            this.columnHeader3.Text = "Dia";
            this.columnHeader3.Width = 105;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Tag = "";
            this.columnHeader4.Text = "Hora";
            this.columnHeader4.Width = 70;
            // 
            // marcacoes_cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 366);
            this.Controls.Add(this.mostrar_teste);
            this.Controls.Add(this.apagar);
            this.Controls.Add(this.voltar);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "marcacoes_cliente";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marcações";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button voltar;
        private System.Windows.Forms.Button apagar;
        private System.Windows.Forms.ListView mostrar_teste;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}