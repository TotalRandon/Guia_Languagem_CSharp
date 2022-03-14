namespace EncapsulamentoExercicios
{
    partial class ContasUsuarios
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Contas = new System.Windows.Forms.Button();
            this.lbxContas = new System.Windows.Forms.ListBox();
            this.btn_Limpar = new System.Windows.Forms.Button();
            this.tb_Conta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_Saldo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_Limite = new System.Windows.Forms.TextBox();
            this.btn_Cadastrar = new System.Windows.Forms.Button();
            this.btn_Apagar = new System.Windows.Forms.Button();
            this.btn_Limite = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Contas
            // 
            this.btn_Contas.Location = new System.Drawing.Point(367, 95);
            this.btn_Contas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Contas.Name = "btn_Contas";
            this.btn_Contas.Size = new System.Drawing.Size(155, 39);
            this.btn_Contas.TabIndex = 0;
            this.btn_Contas.Text = "Mostrar Contas";
            this.btn_Contas.UseVisualStyleBackColor = true;
            this.btn_Contas.Click += new System.EventHandler(this.btn_Contas_Click);
            // 
            // lbxContas
            // 
            this.lbxContas.FormattingEnabled = true;
            this.lbxContas.ItemHeight = 16;
            this.lbxContas.Location = new System.Drawing.Point(15, 95);
            this.lbxContas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbxContas.Name = "lbxContas";
            this.lbxContas.Size = new System.Drawing.Size(345, 260);
            this.lbxContas.TabIndex = 1;
            this.lbxContas.SelectedIndexChanged += new System.EventHandler(this.lbxContas_SelectedIndexChanged);
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.Location = new System.Drawing.Point(367, 183);
            this.btn_Limpar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(155, 39);
            this.btn_Limpar.TabIndex = 2;
            this.btn_Limpar.Text = "Limpar Tela";
            this.btn_Limpar.UseVisualStyleBackColor = true;
            this.btn_Limpar.Click += new System.EventHandler(this.btn_Limpar_Click);
            // 
            // tb_Conta
            // 
            this.tb_Conta.Location = new System.Drawing.Point(75, 15);
            this.tb_Conta.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Conta.Name = "tb_Conta";
            this.tb_Conta.Size = new System.Drawing.Size(132, 22);
            this.tb_Conta.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Conta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(227, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Saldo:";
            // 
            // tb_Saldo
            // 
            this.tb_Saldo.Location = new System.Drawing.Point(283, 16);
            this.tb_Saldo.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Saldo.Name = "tb_Saldo";
            this.tb_Saldo.Size = new System.Drawing.Size(132, 22);
            this.tb_Saldo.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 57);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Limite:";
            // 
            // tb_Limite
            // 
            this.tb_Limite.Location = new System.Drawing.Point(75, 52);
            this.tb_Limite.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Limite.Name = "tb_Limite";
            this.tb_Limite.Size = new System.Drawing.Size(132, 22);
            this.tb_Limite.TabIndex = 7;
            // 
            // btn_Cadastrar
            // 
            this.btn_Cadastrar.Location = new System.Drawing.Point(422, 16);
            this.btn_Cadastrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Cadastrar.Name = "btn_Cadastrar";
            this.btn_Cadastrar.Size = new System.Drawing.Size(155, 39);
            this.btn_Cadastrar.TabIndex = 9;
            this.btn_Cadastrar.Text = "Cadastrar Conta";
            this.btn_Cadastrar.UseVisualStyleBackColor = true;
            this.btn_Cadastrar.Click += new System.EventHandler(this.btn_Cadastrar_Click);
            // 
            // btn_Apagar
            // 
            this.btn_Apagar.Location = new System.Drawing.Point(367, 139);
            this.btn_Apagar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Apagar.Name = "btn_Apagar";
            this.btn_Apagar.Size = new System.Drawing.Size(155, 39);
            this.btn_Apagar.TabIndex = 10;
            this.btn_Apagar.Text = "Apagar Contas";
            this.btn_Apagar.UseVisualStyleBackColor = true;
            this.btn_Apagar.Click += new System.EventHandler(this.btn_Apagar_Click);
            // 
            // btn_Limite
            // 
            this.btn_Limite.Location = new System.Drawing.Point(214, 51);
            this.btn_Limite.Name = "btn_Limite";
            this.btn_Limite.Size = new System.Drawing.Size(155, 39);
            this.btn_Limite.TabIndex = 11;
            this.btn_Limite.Text = "Alterar Limite";
            this.btn_Limite.UseVisualStyleBackColor = true;
            this.btn_Limite.Click += new System.EventHandler(this.btn_Limite_Click);
            // 
            // ContasUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 367);
            this.Controls.Add(this.btn_Limite);
            this.Controls.Add(this.btn_Apagar);
            this.Controls.Add(this.btn_Cadastrar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_Limite);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_Saldo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_Conta);
            this.Controls.Add(this.btn_Limpar);
            this.Controls.Add(this.lbxContas);
            this.Controls.Add(this.btn_Contas);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ContasUsuarios";
            this.Text = "Contas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Contas;
        private System.Windows.Forms.ListBox lbxContas;
        private System.Windows.Forms.Button btn_Limpar;
        private System.Windows.Forms.TextBox tb_Conta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_Saldo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_Limite;
        private System.Windows.Forms.Button btn_Cadastrar;
        private System.Windows.Forms.Button btn_Apagar;
        private System.Windows.Forms.Button btn_Limite;
    }
}

