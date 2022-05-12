
namespace Trabalho_Marcações
{
    partial class Criar_Conta_CLiente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Criar_Conta_CLiente));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.nome_cliente = new System.Windows.Forms.TextBox();
            this.password_cliente = new System.Windows.Forms.TextBox();
            this.zona_cliente = new System.Windows.Forms.ComboBox();
            this.cidade_cliente = new System.Windows.Forms.ComboBox();
            this.voltar_conta = new System.Windows.Forms.Button();
            this.Guardar_Cliente = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // password
            // 
            resources.ApplyResources(this.password, "password");
            this.password.Name = "password";
            // 
            // label
            // 
            resources.ApplyResources(this.label, "label");
            this.label.Name = "label";
            // 
            // nome_cliente
            // 
            resources.ApplyResources(this.nome_cliente, "nome_cliente");
            this.nome_cliente.Name = "nome_cliente";
            this.nome_cliente.TextChanged += new System.EventHandler(this.nome_cliente_TextChanged);
            // 
            // password_cliente
            // 
            resources.ApplyResources(this.password_cliente, "password_cliente");
            this.password_cliente.Name = "password_cliente";
            this.password_cliente.TextChanged += new System.EventHandler(this.password_cliente_TextChanged);
            // 
            // zona_cliente
            // 
            this.zona_cliente.FormattingEnabled = true;
            resources.ApplyResources(this.zona_cliente, "zona_cliente");
            this.zona_cliente.Name = "zona_cliente";
            this.zona_cliente.SelectedIndexChanged += new System.EventHandler(this.zona_cliente_SelectedIndexChanged);
            // 
            // cidade_cliente
            // 
            this.cidade_cliente.FormattingEnabled = true;
            resources.ApplyResources(this.cidade_cliente, "cidade_cliente");
            this.cidade_cliente.Name = "cidade_cliente";
            this.cidade_cliente.SelectedIndexChanged += new System.EventHandler(this.cidade_cliente_SelectedIndexChanged);
            // 
            // voltar_conta
            // 
            resources.ApplyResources(this.voltar_conta, "voltar_conta");
            this.voltar_conta.Name = "voltar_conta";
            this.voltar_conta.UseVisualStyleBackColor = true;
            this.voltar_conta.Click += new System.EventHandler(this.button1_Click);
            // 
            // Guardar_Cliente
            // 
            resources.ApplyResources(this.Guardar_Cliente, "Guardar_Cliente");
            this.Guardar_Cliente.Name = "Guardar_Cliente";
            this.Guardar_Cliente.UseVisualStyleBackColor = true;
            this.Guardar_Cliente.Click += new System.EventHandler(this.Guardar_Cliente_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.Name = "label3";
            // 
            // Criar_Conta_CLiente
            // 
            this.AllowDrop = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Guardar_Cliente);
            this.Controls.Add(this.voltar_conta);
            this.Controls.Add(this.cidade_cliente);
            this.Controls.Add(this.zona_cliente);
            this.Controls.Add(this.password_cliente);
            this.Controls.Add(this.nome_cliente);
            this.Controls.Add(this.label);
            this.Controls.Add(this.password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Criar_Conta_CLiente";
            this.Load += new System.EventHandler(this.Criar_Conta_CLiente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox nome_cliente;
        private System.Windows.Forms.TextBox password_cliente;
        private System.Windows.Forms.ComboBox zona_cliente;
        private System.Windows.Forms.ComboBox cidade_cliente;
        private System.Windows.Forms.Button voltar_conta;
        private System.Windows.Forms.Button Guardar_Cliente;
        private System.Windows.Forms.Label label3;
    }
}