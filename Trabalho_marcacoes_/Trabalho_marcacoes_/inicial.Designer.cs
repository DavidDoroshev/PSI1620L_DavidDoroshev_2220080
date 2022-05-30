
namespace Trabalho_marcacoes_
{
    partial class inicial
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
            this.SuspendLayout();
            // 
            // cliente_botao
            // 
            this.cliente_botao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cliente_botao.Location = new System.Drawing.Point(148, 213);
            this.cliente_botao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cliente_botao.Name = "cliente_botao";
            this.cliente_botao.Size = new System.Drawing.Size(175, 80);
            this.cliente_botao.TabIndex = 0;
            this.cliente_botao.Text = "Cliente";
            this.cliente_botao.UseVisualStyleBackColor = true;
            this.cliente_botao.Click += new System.EventHandler(this.cliente_botao_Click);
            // 
            // iniciar_botoa
            // 
            this.iniciar_botoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iniciar_botoa.Location = new System.Drawing.Point(299, 96);
            this.iniciar_botoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iniciar_botoa.Name = "iniciar_botoa";
            this.iniciar_botoa.Size = new System.Drawing.Size(175, 80);
            this.iniciar_botoa.TabIndex = 1;
            this.iniciar_botoa.Text = "Iniciar Sessão";
            this.iniciar_botoa.UseVisualStyleBackColor = true;
            this.iniciar_botoa.Click += new System.EventHandler(this.iniciar_botoa_Click);
            // 
            // trabalhador_botao
            // 
            this.trabalhador_botao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trabalhador_botao.Location = new System.Drawing.Point(444, 213);
            this.trabalhador_botao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trabalhador_botao.Name = "trabalhador_botao";
            this.trabalhador_botao.Size = new System.Drawing.Size(175, 80);
            this.trabalhador_botao.TabIndex = 2;
            this.trabalhador_botao.Text = "Trabalhador";
            this.trabalhador_botao.UseVisualStyleBackColor = true;
            this.trabalhador_botao.Click += new System.EventHandler(this.trabalhador_botao_Click);
            // 
            // inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.trabalhador_botao);
            this.Controls.Add(this.iniciar_botoa);
            this.Controls.Add(this.cliente_botao);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "inicial";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marcações";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cliente_botao;
        private System.Windows.Forms.Button iniciar_botoa;
        private System.Windows.Forms.Button trabalhador_botao;
    }
}

