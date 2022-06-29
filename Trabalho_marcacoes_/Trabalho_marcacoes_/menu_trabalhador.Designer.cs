
namespace Trabalho_marcacoes_
{
    partial class menu_trabalhador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu_trabalhador));
            this.label1 = new System.Windows.Forms.Label();
            this.ver_marcacoes_trabalhador = new System.Windows.Forms.Button();
            this.perfil_trabalhador = new System.Windows.Forms.Button();
            this.trabalhador_atual = new System.Windows.Forms.Label();
            this.sair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Bem vindo ";
            // 
            // ver_marcacoes_trabalhador
            // 
            this.ver_marcacoes_trabalhador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ver_marcacoes_trabalhador.Location = new System.Drawing.Point(260, 89);
            this.ver_marcacoes_trabalhador.Margin = new System.Windows.Forms.Padding(2);
            this.ver_marcacoes_trabalhador.Name = "ver_marcacoes_trabalhador";
            this.ver_marcacoes_trabalhador.Size = new System.Drawing.Size(128, 60);
            this.ver_marcacoes_trabalhador.TabIndex = 10;
            this.ver_marcacoes_trabalhador.Text = "Marcações";
            this.ver_marcacoes_trabalhador.UseVisualStyleBackColor = true;
            this.ver_marcacoes_trabalhador.Click += new System.EventHandler(this.ver_marcacoes_trabalhador_Click);
            // 
            // perfil_trabalhador
            // 
            this.perfil_trabalhador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.perfil_trabalhador.Location = new System.Drawing.Point(34, 89);
            this.perfil_trabalhador.Margin = new System.Windows.Forms.Padding(2);
            this.perfil_trabalhador.Name = "perfil_trabalhador";
            this.perfil_trabalhador.Size = new System.Drawing.Size(128, 60);
            this.perfil_trabalhador.TabIndex = 9;
            this.perfil_trabalhador.Text = "Perfil";
            this.perfil_trabalhador.UseVisualStyleBackColor = true;
            this.perfil_trabalhador.Click += new System.EventHandler(this.perfil_trabalhador_Click);
            // 
            // trabalhador_atual
            // 
            this.trabalhador_atual.AutoSize = true;
            this.trabalhador_atual.Location = new System.Drawing.Point(97, 36);
            this.trabalhador_atual.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.trabalhador_atual.Name = "trabalhador_atual";
            this.trabalhador_atual.Size = new System.Drawing.Size(0, 13);
            this.trabalhador_atual.TabIndex = 14;
            // 
            // sair
            // 
            this.sair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sair.Location = new System.Drawing.Point(164, 150);
            this.sair.Margin = new System.Windows.Forms.Padding(2);
            this.sair.Name = "sair";
            this.sair.Size = new System.Drawing.Size(92, 37);
            this.sair.TabIndex = 15;
            this.sair.Text = "Sair";
            this.sair.UseVisualStyleBackColor = true;
            this.sair.Click += new System.EventHandler(this.sair_Click);
            // 
            // menu_trabalhador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 197);
            this.Controls.Add(this.sair);
            this.Controls.Add(this.trabalhador_atual);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ver_marcacoes_trabalhador);
            this.Controls.Add(this.perfil_trabalhador);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "menu_trabalhador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ver_marcacoes_trabalhador;
        private System.Windows.Forms.Button perfil_trabalhador;
        private System.Windows.Forms.Label trabalhador_atual;
        private System.Windows.Forms.Button sair;
    }
}