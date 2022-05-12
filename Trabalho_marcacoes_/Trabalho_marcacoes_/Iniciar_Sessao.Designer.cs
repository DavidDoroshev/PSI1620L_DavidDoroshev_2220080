
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
            this.entrar_menu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nome_entrar = new System.Windows.Forms.TextBox();
            this.password_entrar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // entrar_menu
            // 
            this.entrar_menu.Location = new System.Drawing.Point(351, 73);
            this.entrar_menu.Name = "entrar_menu";
            this.entrar_menu.Size = new System.Drawing.Size(170, 74);
            this.entrar_menu.TabIndex = 0;
            this.entrar_menu.Text = "Entrar";
            this.entrar_menu.UseVisualStyleBackColor = true;
            this.entrar_menu.Click += new System.EventHandler(this.entrar_menu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password:";
            // 
            // nome_entrar
            // 
            this.nome_entrar.Location = new System.Drawing.Point(157, 50);
            this.nome_entrar.Name = "nome_entrar";
            this.nome_entrar.Size = new System.Drawing.Size(100, 22);
            this.nome_entrar.TabIndex = 6;
            this.nome_entrar.TextChanged += new System.EventHandler(this.nome_entrar_TextChanged);
            // 
            // password_entrar
            // 
            this.password_entrar.Location = new System.Drawing.Point(157, 130);
            this.password_entrar.Name = "password_entrar";
            this.password_entrar.Size = new System.Drawing.Size(100, 22);
            this.password_entrar.TabIndex = 7;
            this.password_entrar.TextChanged += new System.EventHandler(this.password_entrar_TextChanged);
            // 
            // Iniciar_Sessao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 216);
            this.Controls.Add(this.password_entrar);
            this.Controls.Add(this.nome_entrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.entrar_menu);
            this.Name = "Iniciar_Sessao";
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
    }
}