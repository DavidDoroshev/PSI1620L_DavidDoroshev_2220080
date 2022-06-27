
namespace Trabalho_marcacoes_
{
    partial class menu_cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu_cliente));
            this.Perfil = new System.Windows.Forms.Button();
            this.ver_marca = new System.Windows.Forms.Button();
            this.marcar_estetica = new System.Windows.Forms.Button();
            this.ir_medico = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.current_user = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Perfil
            // 
            this.Perfil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Perfil.Location = new System.Drawing.Point(83, 95);
            this.Perfil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Perfil.Name = "Perfil";
            this.Perfil.Size = new System.Drawing.Size(171, 74);
            this.Perfil.TabIndex = 3;
            this.Perfil.Text = "Perfil";
            this.Perfil.UseVisualStyleBackColor = true;
            this.Perfil.Click += new System.EventHandler(this.Perfil_Click);
            // 
            // ver_marca
            // 
            this.ver_marca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ver_marca.Location = new System.Drawing.Point(420, 95);
            this.ver_marca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ver_marca.Name = "ver_marca";
            this.ver_marca.Size = new System.Drawing.Size(171, 74);
            this.ver_marca.TabIndex = 4;
            this.ver_marca.Text = "Marcações";
            this.ver_marca.UseVisualStyleBackColor = true;
            this.ver_marca.Click += new System.EventHandler(this.ver_marca_Click);
            // 
            // marcar_estetica
            // 
            this.marcar_estetica.Cursor = System.Windows.Forms.Cursors.Hand;
            this.marcar_estetica.Location = new System.Drawing.Point(420, 224);
            this.marcar_estetica.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.marcar_estetica.Name = "marcar_estetica";
            this.marcar_estetica.Size = new System.Drawing.Size(171, 74);
            this.marcar_estetica.TabIndex = 5;
            this.marcar_estetica.Text = "Marcar - Estetica";
            this.marcar_estetica.UseVisualStyleBackColor = true;
            this.marcar_estetica.Click += new System.EventHandler(this.marcar_estetica_Click);
            // 
            // ir_medico
            // 
            this.ir_medico.Location = new System.Drawing.Point(83, 224);
            this.ir_medico.Margin = new System.Windows.Forms.Padding(4);
            this.ir_medico.Name = "ir_medico";
            this.ir_medico.Size = new System.Drawing.Size(171, 74);
            this.ir_medico.TabIndex = 6;
            this.ir_medico.Text = "Marcar - Medico";
            this.ir_medico.UseVisualStyleBackColor = true;
            this.ir_medico.Click += new System.EventHandler(this.ir_medico_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Bem vindo ";
            // 
            // current_user
            // 
            this.current_user.AutoSize = true;
            this.current_user.Location = new System.Drawing.Point(143, 43);
            this.current_user.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.current_user.Name = "current_user";
            this.current_user.Size = new System.Drawing.Size(0, 17);
            this.current_user.TabIndex = 8;
            // 
            // menu_cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 359);
            this.Controls.Add(this.current_user);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ir_medico);
            this.Controls.Add(this.marcar_estetica);
            this.Controls.Add(this.ver_marca);
            this.Controls.Add(this.Perfil);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "menu_cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.menu_cliente_FormClosing);
            this.Load += new System.EventHandler(this.Menu_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Perfil;
        private System.Windows.Forms.Button ver_marca;
        private System.Windows.Forms.Button marcar_estetica;
        private System.Windows.Forms.Button ir_medico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label current_user;
    }
}