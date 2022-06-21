
namespace Trabalho_marcacoes_
{
    partial class admin_2
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
            this.cp_mos = new System.Windows.Forms.ListView();
            this.cp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.distrito = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.conselho = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cp_adicionar = new System.Windows.Forms.Button();
            this.especialidade_mos = new System.Windows.Forms.ListView();
            this.profissao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.especialidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.add_espe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cp_mos
            // 
            this.cp_mos.BackColor = System.Drawing.SystemColors.Menu;
            this.cp_mos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cp_mos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cp,
            this.distrito,
            this.conselho});
            this.cp_mos.FullRowSelect = true;
            this.cp_mos.HideSelection = false;
            this.cp_mos.Location = new System.Drawing.Point(16, 31);
            this.cp_mos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cp_mos.MultiSelect = false;
            this.cp_mos.Name = "cp_mos";
            this.cp_mos.Size = new System.Drawing.Size(475, 177);
            this.cp_mos.TabIndex = 10;
            this.cp_mos.UseCompatibleStateImageBehavior = false;
            this.cp_mos.View = System.Windows.Forms.View.Details;
            // 
            // cp
            // 
            this.cp.Text = "Código Postal";
            this.cp.Width = 100;
            // 
            // distrito
            // 
            this.distrito.Text = "Distrito";
            this.distrito.Width = 100;
            // 
            // conselho
            // 
            this.conselho.Text = "Conselho";
            this.conselho.Width = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Código Postal:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(545, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Especialidades:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 337);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 28);
            this.button1.TabIndex = 14;
            this.button1.Text = "Pag anterior";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // cp_adicionar
            // 
            this.cp_adicionar.Location = new System.Drawing.Point(16, 204);
            this.cp_adicionar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cp_adicionar.Name = "cp_adicionar";
            this.cp_adicionar.Size = new System.Drawing.Size(112, 28);
            this.cp_adicionar.TabIndex = 16;
            this.cp_adicionar.Text = "Adicionar CP";
            this.cp_adicionar.UseVisualStyleBackColor = true;
            this.cp_adicionar.Click += new System.EventHandler(this.cp_adicionar_Click);
            // 
            // especialidade_mos
            // 
            this.especialidade_mos.BackColor = System.Drawing.SystemColors.Menu;
            this.especialidade_mos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.especialidade_mos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.profissao,
            this.especialidade});
            this.especialidade_mos.FullRowSelect = true;
            this.especialidade_mos.HideSelection = false;
            this.especialidade_mos.Location = new System.Drawing.Point(549, 31);
            this.especialidade_mos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.especialidade_mos.MultiSelect = false;
            this.especialidade_mos.Name = "especialidade_mos";
            this.especialidade_mos.Size = new System.Drawing.Size(475, 177);
            this.especialidade_mos.TabIndex = 19;
            this.especialidade_mos.UseCompatibleStateImageBehavior = false;
            this.especialidade_mos.View = System.Windows.Forms.View.Details;
            // 
            // profissao
            // 
            this.profissao.Text = "Profissao";
            this.profissao.Width = 150;
            // 
            // especialidade
            // 
            this.especialidade.Text = "Especialidade";
            this.especialidade.Width = 150;
            // 
            // add_espe
            // 
            this.add_espe.Location = new System.Drawing.Point(548, 192);
            this.add_espe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.add_espe.Name = "add_espe";
            this.add_espe.Size = new System.Drawing.Size(145, 52);
            this.add_espe.TabIndex = 21;
            this.add_espe.Text = "Adicionar Especialidade";
            this.add_espe.UseVisualStyleBackColor = true;
            this.add_espe.Click += new System.EventHandler(this.add_espe_Click);
            // 
            // admin_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 380);
            this.Controls.Add(this.add_espe);
            this.Controls.Add(this.especialidade_mos);
            this.Controls.Add(this.cp_adicionar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cp_mos);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "admin_2";
            this.Text = "admin_2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView cp_mos;
        private System.Windows.Forms.ColumnHeader distrito;
        private System.Windows.Forms.ColumnHeader conselho;
        private System.Windows.Forms.ColumnHeader cp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button cp_adicionar;
        private System.Windows.Forms.ListView especialidade_mos;
        private System.Windows.Forms.ColumnHeader profissao;
        private System.Windows.Forms.ColumnHeader especialidade;
        private System.Windows.Forms.Button add_espe;
    }
}