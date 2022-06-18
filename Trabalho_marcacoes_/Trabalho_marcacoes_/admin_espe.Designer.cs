
namespace Trabalho_marcacoes_
{
    partial class admin_espe
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
            this.escolher_pro = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.add_espe = new System.Windows.Forms.TextBox();
            this.Voltar = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Escolher Profissão";
            // 
            // escolher_pro
            // 
            this.escolher_pro.FormattingEnabled = true;
            this.escolher_pro.Location = new System.Drawing.Point(109, 15);
            this.escolher_pro.Name = "escolher_pro";
            this.escolher_pro.Size = new System.Drawing.Size(121, 21);
            this.escolher_pro.TabIndex = 1;
            this.escolher_pro.SelectedIndexChanged += new System.EventHandler(this.escolher_pro_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(260, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Especialidade";
            // 
            // add_espe
            // 
            this.add_espe.Location = new System.Drawing.Point(339, 15);
            this.add_espe.Name = "add_espe";
            this.add_espe.Size = new System.Drawing.Size(100, 20);
            this.add_espe.TabIndex = 3;
            // 
            // Voltar
            // 
            this.Voltar.Location = new System.Drawing.Point(12, 125);
            this.Voltar.Name = "Voltar";
            this.Voltar.Size = new System.Drawing.Size(75, 23);
            this.Voltar.TabIndex = 4;
            this.Voltar.Text = "Voltar";
            this.Voltar.UseVisualStyleBackColor = true;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(364, 125);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 5;
            this.add.Text = "Adicionar";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // admin_espe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 164);
            this.Controls.Add(this.add);
            this.Controls.Add(this.Voltar);
            this.Controls.Add(this.add_espe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.escolher_pro);
            this.Controls.Add(this.label1);
            this.Name = "admin_espe";
            this.ShowIcon = false;
            this.Text = "Especialidade";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox escolher_pro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox add_espe;
        private System.Windows.Forms.Button Voltar;
        private System.Windows.Forms.Button add;
    }
}