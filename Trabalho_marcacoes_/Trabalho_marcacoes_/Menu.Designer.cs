
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
            this.SuspendLayout();
            // 
            // Marcações
            // 
            this.Marcações.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Marcações.Location = new System.Drawing.Point(62, 182);
            this.Marcações.Margin = new System.Windows.Forms.Padding(2);
            this.Marcações.Name = "Marcações";
            this.Marcações.Size = new System.Drawing.Size(128, 60);
            this.Marcações.TabIndex = 2;
            this.Marcações.Text = "Marcações- Medico";
            this.Marcações.UseVisualStyleBackColor = true;
            this.Marcações.Click += new System.EventHandler(this.Marcações_Click);
            // 
            // Perfil
            // 
            this.Perfil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Perfil.Location = new System.Drawing.Point(62, 77);
            this.Perfil.Margin = new System.Windows.Forms.Padding(2);
            this.Perfil.Name = "Perfil";
            this.Perfil.Size = new System.Drawing.Size(128, 60);
            this.Perfil.TabIndex = 3;
            this.Perfil.Text = "Perfil";
            this.Perfil.UseVisualStyleBackColor = true;
            this.Perfil.Click += new System.EventHandler(this.Perfil_Click);
            // 
            // marcar
            // 
            this.marcar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.marcar.Location = new System.Drawing.Point(326, 77);
            this.marcar.Margin = new System.Windows.Forms.Padding(2);
            this.marcar.Name = "marcar";
            this.marcar.Size = new System.Drawing.Size(128, 60);
            this.marcar.TabIndex = 4;
            this.marcar.Text = "Marcações";
            this.marcar.UseVisualStyleBackColor = true;
            this.marcar.Click += new System.EventHandler(this.marcar_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(326, 182);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 60);
            this.button1.TabIndex = 5;
            this.button1.Text = "Marcações- Estetica";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.marcar);
            this.Controls.Add(this.Perfil);
            this.Controls.Add(this.Marcações);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Marcações;
        private System.Windows.Forms.Button Perfil;
        private System.Windows.Forms.Button marcar;
        private System.Windows.Forms.Button button1;
    }
}