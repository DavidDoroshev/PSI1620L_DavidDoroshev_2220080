﻿
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
            this.label1 = new System.Windows.Forms.Label();
            this.ver_marcacoes_trabalhador = new System.Windows.Forms.Button();
            this.perfil_trabalhador = new System.Windows.Forms.Button();
            this.trabalhador_atual = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Bem vindo ";
            // 
            // ver_marcacoes_trabalhador
            // 
            this.ver_marcacoes_trabalhador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ver_marcacoes_trabalhador.Location = new System.Drawing.Point(346, 110);
            this.ver_marcacoes_trabalhador.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ver_marcacoes_trabalhador.Name = "ver_marcacoes_trabalhador";
            this.ver_marcacoes_trabalhador.Size = new System.Drawing.Size(171, 74);
            this.ver_marcacoes_trabalhador.TabIndex = 10;
            this.ver_marcacoes_trabalhador.Text = "Marcações";
            this.ver_marcacoes_trabalhador.UseVisualStyleBackColor = true;
            // 
            // perfil_trabalhador
            // 
            this.perfil_trabalhador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.perfil_trabalhador.Location = new System.Drawing.Point(46, 110);
            this.perfil_trabalhador.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.perfil_trabalhador.Name = "perfil_trabalhador";
            this.perfil_trabalhador.Size = new System.Drawing.Size(171, 74);
            this.perfil_trabalhador.TabIndex = 9;
            this.perfil_trabalhador.Text = "Perfil";
            this.perfil_trabalhador.UseVisualStyleBackColor = true;
            // 
            // trabalhador_atual
            // 
            this.trabalhador_atual.AutoSize = true;
            this.trabalhador_atual.Location = new System.Drawing.Point(129, 44);
            this.trabalhador_atual.Name = "trabalhador_atual";
            this.trabalhador_atual.Size = new System.Drawing.Size(0, 17);
            this.trabalhador_atual.TabIndex = 14;
            // 
            // menu_trabalhador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 242);
            this.Controls.Add(this.trabalhador_atual);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ver_marcacoes_trabalhador);
            this.Controls.Add(this.perfil_trabalhador);
            this.Name = "menu_trabalhador";
            this.Text = "menu_trabalhador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ver_marcacoes_trabalhador;
        private System.Windows.Forms.Button perfil_trabalhador;
        private System.Windows.Forms.Label trabalhador_atual;
    }
}