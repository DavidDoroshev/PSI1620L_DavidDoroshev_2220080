
namespace Trabalho_marcacoes_
{
    partial class Menu
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
            this.Marcações = new System.Windows.Forms.Button();
            this.Perfil = new System.Windows.Forms.Button();
            this.marcar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textonome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Marcações
            // 
            this.Marcações.Location = new System.Drawing.Point(93, 280);
            this.Marcações.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Marcações.Name = "Marcações";
            this.Marcações.Size = new System.Drawing.Size(191, 92);
            this.Marcações.TabIndex = 2;
            this.Marcações.Text = "Marcações- Medico";
            this.Marcações.UseVisualStyleBackColor = true;
            // 
            // Perfil
            // 
            this.Perfil.Location = new System.Drawing.Point(93, 119);
            this.Perfil.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Perfil.Name = "Perfil";
            this.Perfil.Size = new System.Drawing.Size(191, 92);
            this.Perfil.TabIndex = 3;
            this.Perfil.Text = "Perfil";
            this.Perfil.UseVisualStyleBackColor = true;
            this.Perfil.Click += new System.EventHandler(this.Perfil_Click);
            // 
            // marcar
            // 
            this.marcar.Location = new System.Drawing.Point(488, 119);
            this.marcar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.marcar.Name = "marcar";
            this.marcar.Size = new System.Drawing.Size(191, 92);
            this.marcar.TabIndex = 4;
            this.marcar.Text = "Marcar";
            this.marcar.UseVisualStyleBackColor = true;
            this.marcar.Click += new System.EventHandler(this.marcar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(488, 280);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 92);
            this.button1.TabIndex = 5;
            this.button1.Text = "Marcações- Estetica";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Olá";
            // 
            // textonome
            // 
            this.textonome.AutoSize = true;
            this.textonome.Location = new System.Drawing.Point(117, 39);
            this.textonome.Name = "textonome";
            this.textonome.Size = new System.Drawing.Size(0, 20);
            this.textonome.TabIndex = 7;
            this.textonome.Click += new System.EventHandler(this.textonome_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textonome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.marcar);
            this.Controls.Add(this.Perfil);
            this.Controls.Add(this.Marcações);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Marcações;
        private System.Windows.Forms.Button Perfil;
        private System.Windows.Forms.Button marcar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label textonome;
    }
}