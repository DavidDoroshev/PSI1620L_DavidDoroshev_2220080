﻿
namespace Trabalho_marcacoes_
{
    partial class menu_inicial
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
            this.cliente_botao = new System.Windows.Forms.Button();
            this.iniciar_botoa = new System.Windows.Forms.Button();
            this.trabalhador_botao = new System.Windows.Forms.Button();
            this.sair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cliente_botao
            // 
            this.cliente_botao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cliente_botao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cliente_botao.Location = new System.Drawing.Point(103, 154);
            this.cliente_botao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cliente_botao.Name = "cliente_botao";
            this.cliente_botao.Size = new System.Drawing.Size(131, 65);
            this.cliente_botao.TabIndex = 0;
            this.cliente_botao.Text = "Cliente";
            this.cliente_botao.UseVisualStyleBackColor = true;
            this.cliente_botao.Click += new System.EventHandler(this.cliente_botao_Click);
            // 
            // iniciar_botoa
            // 
            this.iniciar_botoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iniciar_botoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iniciar_botoa.Location = new System.Drawing.Point(216, 58);
            this.iniciar_botoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.iniciar_botoa.Name = "iniciar_botoa";
            this.iniciar_botoa.Size = new System.Drawing.Size(131, 65);
            this.iniciar_botoa.TabIndex = 1;
            this.iniciar_botoa.Text = "Iniciar Sessão";
            this.iniciar_botoa.UseVisualStyleBackColor = true;
            this.iniciar_botoa.Click += new System.EventHandler(this.iniciar_botoa_Click);
            // 
            // trabalhador_botao
            // 
            this.trabalhador_botao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.trabalhador_botao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trabalhador_botao.Location = new System.Drawing.Point(325, 154);
            this.trabalhador_botao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.trabalhador_botao.Name = "trabalhador_botao";
            this.trabalhador_botao.Size = new System.Drawing.Size(131, 65);
            this.trabalhador_botao.TabIndex = 2;
            this.trabalhador_botao.Text = "Trabalhador";
            this.trabalhador_botao.UseVisualStyleBackColor = true;
            this.trabalhador_botao.Click += new System.EventHandler(this.trabalhador_botao_Click);
            // 
            // sair
            // 
            this.sair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sair.Location = new System.Drawing.Point(237, 253);
            this.sair.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sair.Name = "sair";
            this.sair.Size = new System.Drawing.Size(92, 37);
            this.sair.TabIndex = 3;
            this.sair.Text = "Sair";
            this.sair.UseVisualStyleBackColor = true;
            this.sair.Click += new System.EventHandler(this.sair_Click);
            // 
            // menu_inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 299);
            this.Controls.Add(this.sair);
            this.Controls.Add(this.trabalhador_botao);
            this.Controls.Add(this.iniciar_botoa);
            this.Controls.Add(this.cliente_botao);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "menu_inicial";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marcações";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cliente_botao;
        private System.Windows.Forms.Button iniciar_botoa;
        private System.Windows.Forms.Button trabalhador_botao;
        private System.Windows.Forms.Button sair;
    }
}

