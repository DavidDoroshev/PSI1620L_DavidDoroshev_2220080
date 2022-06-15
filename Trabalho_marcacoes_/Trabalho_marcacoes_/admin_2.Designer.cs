
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
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.especialidade_mos = new System.Windows.Forms.ListView();
            this.profissao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.especialidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.cp_mos.Location = new System.Drawing.Point(12, 25);
            this.cp_mos.MultiSelect = false;
            this.cp_mos.Name = "cp_mos";
            this.cp_mos.Size = new System.Drawing.Size(356, 144);
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
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Código Postal:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(409, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Especialidades:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 274);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Pag anterior";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 175);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Apagar CP";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(93, 175);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "Adicionar CP";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(412, 175);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(109, 42);
            this.button4.TabIndex = 17;
            this.button4.Text = "Apagar Especialidade";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(537, 175);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(109, 42);
            this.button5.TabIndex = 18;
            this.button5.Text = "Adicionar especialidade";
            this.button5.UseVisualStyleBackColor = true;
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
            this.especialidade_mos.Location = new System.Drawing.Point(412, 25);
            this.especialidade_mos.MultiSelect = false;
            this.especialidade_mos.Name = "especialidade_mos";
            this.especialidade_mos.Size = new System.Drawing.Size(356, 144);
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
            // admin_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 309);
            this.Controls.Add(this.especialidade_mos);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cp_mos);
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ListView especialidade_mos;
        private System.Windows.Forms.ColumnHeader profissao;
        private System.Windows.Forms.ColumnHeader especialidade;
    }
}