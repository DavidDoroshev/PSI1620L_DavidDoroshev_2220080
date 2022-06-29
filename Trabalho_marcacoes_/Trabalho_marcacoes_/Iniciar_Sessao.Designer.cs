
namespace Trabalho_marcacoes_
{
    partial class Iniciar_Sessao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Iniciar_Sessao));
            this.entrar_menu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nome_entrar = new System.Windows.Forms.TextBox();
            this.password_entrar = new System.Windows.Forms.TextBox();
            this.voltar = new System.Windows.Forms.Button();
            this.ver = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // entrar_menu
            // 
            this.entrar_menu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.entrar_menu.Location = new System.Drawing.Point(324, 26);
            this.entrar_menu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.entrar_menu.Name = "entrar_menu";
            this.entrar_menu.Size = new System.Drawing.Size(128, 60);
            this.entrar_menu.TabIndex = 3;
            this.entrar_menu.Text = "Entrar";
            this.entrar_menu.UseVisualStyleBackColor = true;
            this.entrar_menu.Click += new System.EventHandler(this.entrar_menu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password:";
            // 
            // nome_entrar
            // 
            this.nome_entrar.Location = new System.Drawing.Point(118, 38);
            this.nome_entrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nome_entrar.Name = "nome_entrar";
            this.nome_entrar.Size = new System.Drawing.Size(76, 20);
            this.nome_entrar.TabIndex = 1;
            // 
            // password_entrar
            // 
            this.password_entrar.Location = new System.Drawing.Point(118, 119);
            this.password_entrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.password_entrar.Name = "password_entrar";
            this.password_entrar.Size = new System.Drawing.Size(76, 20);
            this.password_entrar.TabIndex = 2;
            // 
            // voltar
            // 
            this.voltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.voltar.Location = new System.Drawing.Point(339, 131);
            this.voltar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.voltar.Name = "voltar";
            this.voltar.Size = new System.Drawing.Size(91, 24);
            this.voltar.TabIndex = 4;
            this.voltar.Text = "Voltar";
            this.voltar.UseVisualStyleBackColor = true;
            this.voltar.Click += new System.EventHandler(this.voltar_Click);
            // 
            // ver
            // 
            this.ver.AutoSize = true;
            this.ver.Location = new System.Drawing.Point(199, 122);
            this.ver.Name = "ver";
            this.ver.Size = new System.Drawing.Size(15, 14);
            this.ver.TabIndex = 9;
            this.ver.UseVisualStyleBackColor = true;
            this.ver.CheckedChanged += new System.EventHandler(this.ver_CheckedChanged);
            // 
            // Iniciar_Sessao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(490, 176);
            this.Controls.Add(this.ver);
            this.Controls.Add(this.voltar);
            this.Controls.Add(this.password_entrar);
            this.Controls.Add(this.nome_entrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.entrar_menu);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Iniciar_Sessao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar_Sessao";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button entrar_menu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nome_entrar;
        private System.Windows.Forms.TextBox password_entrar;
        private System.Windows.Forms.Button voltar;
        private System.Windows.Forms.CheckBox ver;
    }
}