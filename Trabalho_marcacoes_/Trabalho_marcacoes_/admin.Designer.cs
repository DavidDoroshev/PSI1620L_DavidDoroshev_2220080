
namespace Trabalho_marcacoes_
{
    partial class admin
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
            this.cliente_mos = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Pass = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.trabalhador_mos = new System.Windows.Forms.ListView();
            this.id_tr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nome_tr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pass_tr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cp_tr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.especialidade_tr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.apagar = new System.Windows.Forms.Button();
            this.apagar_tra = new System.Windows.Forms.Button();
            this.marcacoes_mos = new System.Windows.Forms.ListView();
            this.id_mar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nome_uti = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nome_trabalha = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.especialidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dia_marcacao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hora = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.adicionar = new System.Windows.Forms.Button();
            this.add_tra = new System.Windows.Forms.Button();
            this.apagar_mar = new System.Windows.Forms.Button();
            this.add_marca = new System.Windows.Forms.Button();
            this.Sair = new System.Windows.Forms.Button();
            this.proximo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cliente_mos
            // 
            this.cliente_mos.BackColor = System.Drawing.SystemColors.Menu;
            this.cliente_mos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cliente_mos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.nome,
            this.Pass,
            this.cp});
            this.cliente_mos.FullRowSelect = true;
            this.cliente_mos.HideSelection = false;
            this.cliente_mos.Location = new System.Drawing.Point(10, 34);
            this.cliente_mos.MultiSelect = false;
            this.cliente_mos.Name = "cliente_mos";
            this.cliente_mos.Size = new System.Drawing.Size(356, 144);
            this.cliente_mos.TabIndex = 9;
            this.cliente_mos.UseCompatibleStateImageBehavior = false;
            this.cliente_mos.View = System.Windows.Forms.View.Details;
            this.cliente_mos.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.cliente_mos_ColumnWidthChanging);
            // 
            // id
            // 
            this.id.Text = "Id";
            this.id.Width = 50;
            // 
            // nome
            // 
            this.nome.Text = "Nome";
            this.nome.Width = 100;
            // 
            // Pass
            // 
            this.Pass.DisplayIndex = 3;
            this.Pass.Text = "Pass";
            this.Pass.Width = 100;
            // 
            // cp
            // 
            this.cp.DisplayIndex = 2;
            this.cp.Text = "Código Postal";
            this.cp.Width = 100;
            // 
            // trabalhador_mos
            // 
            this.trabalhador_mos.BackColor = System.Drawing.SystemColors.Menu;
            this.trabalhador_mos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.trabalhador_mos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id_tr,
            this.nome_tr,
            this.pass_tr,
            this.cp_tr,
            this.especialidade_tr});
            this.trabalhador_mos.FullRowSelect = true;
            this.trabalhador_mos.HideSelection = false;
            this.trabalhador_mos.Location = new System.Drawing.Point(380, 34);
            this.trabalhador_mos.MultiSelect = false;
            this.trabalhador_mos.Name = "trabalhador_mos";
            this.trabalhador_mos.Size = new System.Drawing.Size(518, 145);
            this.trabalhador_mos.TabIndex = 10;
            this.trabalhador_mos.UseCompatibleStateImageBehavior = false;
            this.trabalhador_mos.View = System.Windows.Forms.View.Details;
            this.trabalhador_mos.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.trabalhador_mos_ColumnWidthChanging);
            // 
            // id_tr
            // 
            this.id_tr.Text = "Id";
            this.id_tr.Width = 50;
            // 
            // nome_tr
            // 
            this.nome_tr.Text = "Nome";
            this.nome_tr.Width = 100;
            // 
            // pass_tr
            // 
            this.pass_tr.Text = "Pass";
            this.pass_tr.Width = 100;
            // 
            // cp_tr
            // 
            this.cp_tr.Text = "Código Postal";
            this.cp_tr.Width = 100;
            // 
            // especialidade_tr
            // 
            this.especialidade_tr.Text = "Especialidade";
            this.especialidade_tr.Width = 148;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Utilizador";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(377, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Trabalhador";
            // 
            // apagar
            // 
            this.apagar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.apagar.Location = new System.Drawing.Point(13, 183);
            this.apagar.Margin = new System.Windows.Forms.Padding(2);
            this.apagar.Name = "apagar";
            this.apagar.Size = new System.Drawing.Size(89, 32);
            this.apagar.TabIndex = 1;
            this.apagar.Text = "Apagar CLiente";
            this.apagar.UseVisualStyleBackColor = true;
            this.apagar.Click += new System.EventHandler(this.apagar_Click);
            // 
            // apagar_tra
            // 
            this.apagar_tra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.apagar_tra.Location = new System.Drawing.Point(380, 184);
            this.apagar_tra.Margin = new System.Windows.Forms.Padding(2);
            this.apagar_tra.Name = "apagar_tra";
            this.apagar_tra.Size = new System.Drawing.Size(118, 32);
            this.apagar_tra.TabIndex = 3;
            this.apagar_tra.Text = "Apagar trabalhador";
            this.apagar_tra.UseVisualStyleBackColor = true;
            this.apagar_tra.Click += new System.EventHandler(this.apagar_tra_Click);
            // 
            // marcacoes_mos
            // 
            this.marcacoes_mos.BackColor = System.Drawing.SystemColors.Menu;
            this.marcacoes_mos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.marcacoes_mos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id_mar,
            this.nome_uti,
            this.nome_trabalha,
            this.especialidade,
            this.dia_marcacao,
            this.hora});
            this.marcacoes_mos.FullRowSelect = true;
            this.marcacoes_mos.HideSelection = false;
            this.marcacoes_mos.Location = new System.Drawing.Point(12, 245);
            this.marcacoes_mos.MultiSelect = false;
            this.marcacoes_mos.Name = "marcacoes_mos";
            this.marcacoes_mos.Size = new System.Drawing.Size(604, 144);
            this.marcacoes_mos.TabIndex = 15;
            this.marcacoes_mos.UseCompatibleStateImageBehavior = false;
            this.marcacoes_mos.View = System.Windows.Forms.View.Details;
            this.marcacoes_mos.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.marcacoes_mos_ColumnWidthChanging);
            // 
            // id_mar
            // 
            this.id_mar.Text = "Id";
            this.id_mar.Width = 50;
            // 
            // nome_uti
            // 
            this.nome_uti.Text = "Nome - Utilizador";
            this.nome_uti.Width = 125;
            // 
            // nome_trabalha
            // 
            this.nome_trabalha.Text = "Nome - trabalhador";
            this.nome_trabalha.Width = 135;
            // 
            // especialidade
            // 
            this.especialidade.Text = "Especialidade";
            this.especialidade.Width = 100;
            // 
            // dia_marcacao
            // 
            this.dia_marcacao.Tag = "";
            this.dia_marcacao.Text = "Dia";
            this.dia_marcacao.Width = 105;
            // 
            // hora
            // 
            this.hora.Tag = "";
            this.hora.Text = "Hora";
            this.hora.Width = 70;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 228);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Marcações";
            // 
            // adicionar
            // 
            this.adicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adicionar.Location = new System.Drawing.Point(106, 183);
            this.adicionar.Margin = new System.Windows.Forms.Padding(2);
            this.adicionar.Name = "adicionar";
            this.adicionar.Size = new System.Drawing.Size(101, 32);
            this.adicionar.TabIndex = 2;
            this.adicionar.Text = "Adicionar Cliente";
            this.adicionar.UseVisualStyleBackColor = true;
            this.adicionar.Click += new System.EventHandler(this.adicionar_Click);
            // 
            // add_tra
            // 
            this.add_tra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_tra.Location = new System.Drawing.Point(502, 184);
            this.add_tra.Margin = new System.Windows.Forms.Padding(2);
            this.add_tra.Name = "add_tra";
            this.add_tra.Size = new System.Drawing.Size(121, 32);
            this.add_tra.TabIndex = 4;
            this.add_tra.Text = "Adicionar Trabalhador";
            this.add_tra.UseVisualStyleBackColor = true;
            this.add_tra.Click += new System.EventHandler(this.add_tra_Click);
            // 
            // apagar_mar
            // 
            this.apagar_mar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.apagar_mar.Location = new System.Drawing.Point(10, 394);
            this.apagar_mar.Margin = new System.Windows.Forms.Padding(2);
            this.apagar_mar.Name = "apagar_mar";
            this.apagar_mar.Size = new System.Drawing.Size(104, 32);
            this.apagar_mar.TabIndex = 5;
            this.apagar_mar.Text = "Apagar Marcação";
            this.apagar_mar.UseVisualStyleBackColor = true;
            this.apagar_mar.Click += new System.EventHandler(this.apagar_mar_Click);
            // 
            // add_marca
            // 
            this.add_marca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_marca.Location = new System.Drawing.Point(118, 394);
            this.add_marca.Margin = new System.Windows.Forms.Padding(2);
            this.add_marca.Name = "add_marca";
            this.add_marca.Size = new System.Drawing.Size(121, 32);
            this.add_marca.TabIndex = 6;
            this.add_marca.Text = "Adicionar Marcação";
            this.add_marca.UseVisualStyleBackColor = true;
            this.add_marca.Click += new System.EventHandler(this.add_marca_Click);
            // 
            // Sair
            // 
            this.Sair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Sair.Location = new System.Drawing.Point(814, 394);
            this.Sair.Name = "Sair";
            this.Sair.Size = new System.Drawing.Size(84, 32);
            this.Sair.TabIndex = 17;
            this.Sair.Text = "Sair";
            this.Sair.UseVisualStyleBackColor = true;
            this.Sair.Click += new System.EventHandler(this.Sair_Click);
            // 
            // proximo
            // 
            this.proximo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.proximo.Location = new System.Drawing.Point(814, 350);
            this.proximo.Name = "proximo";
            this.proximo.Size = new System.Drawing.Size(84, 23);
            this.proximo.TabIndex = 18;
            this.proximo.Text = "Próxima pag";
            this.proximo.UseVisualStyleBackColor = true;
            this.proximo.Click += new System.EventHandler(this.proximo_Click);
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 449);
            this.Controls.Add(this.proximo);
            this.Controls.Add(this.Sair);
            this.Controls.Add(this.add_marca);
            this.Controls.Add(this.apagar_mar);
            this.Controls.Add(this.add_tra);
            this.Controls.Add(this.adicionar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.marcacoes_mos);
            this.Controls.Add(this.apagar_tra);
            this.Controls.Add(this.apagar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trabalhador_mos);
            this.Controls.Add(this.cliente_mos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "admin";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView cliente_mos;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader nome;
        private System.Windows.Forms.ColumnHeader Pass;
        private System.Windows.Forms.ColumnHeader cp;
        private System.Windows.Forms.ListView trabalhador_mos;
        private System.Windows.Forms.ColumnHeader id_tr;
        private System.Windows.Forms.ColumnHeader nome_tr;
        private System.Windows.Forms.ColumnHeader pass_tr;
        private System.Windows.Forms.ColumnHeader cp_tr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button apagar;
        private System.Windows.Forms.Button apagar_tra;
        private System.Windows.Forms.ListView marcacoes_mos;
        private System.Windows.Forms.ColumnHeader id_mar;
        private System.Windows.Forms.ColumnHeader nome_uti;
        private System.Windows.Forms.ColumnHeader nome_trabalha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button adicionar;
        private System.Windows.Forms.ColumnHeader especialidade;
        private System.Windows.Forms.ColumnHeader dia_marcacao;
        private System.Windows.Forms.ColumnHeader hora;
        private System.Windows.Forms.ColumnHeader especialidade_tr;
        private System.Windows.Forms.Button add_tra;
        private System.Windows.Forms.Button apagar_mar;
        private System.Windows.Forms.Button add_marca;
        private System.Windows.Forms.Button Sair;
        private System.Windows.Forms.Button proximo;
    }
}