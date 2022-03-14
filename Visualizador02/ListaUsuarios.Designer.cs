
namespace Visualizador02
{
    partial class ListaUsuarios
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
            this.tb_NomeUsuario = new System.Windows.Forms.TextBox();
            this.lbx_Usuarios = new System.Windows.Forms.ListBox();
            this.btn_Inserir = new System.Windows.Forms.Button();
            this.btn_Apagar = new System.Windows.Forms.Button();
            this.btnClosehere = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_NomeUsuario
            // 
            this.tb_NomeUsuario.Location = new System.Drawing.Point(12, 12);
            this.tb_NomeUsuario.Name = "tb_NomeUsuario";
            this.tb_NomeUsuario.Size = new System.Drawing.Size(296, 22);
            this.tb_NomeUsuario.TabIndex = 0;
            this.tb_NomeUsuario.Text = "Lista de Usuarios";
            // 
            // lbx_Usuarios
            // 
            this.lbx_Usuarios.FormattingEnabled = true;
            this.lbx_Usuarios.ItemHeight = 16;
            this.lbx_Usuarios.Location = new System.Drawing.Point(12, 54);
            this.lbx_Usuarios.Name = "lbx_Usuarios";
            this.lbx_Usuarios.Size = new System.Drawing.Size(296, 340);
            this.lbx_Usuarios.TabIndex = 1;
            this.lbx_Usuarios.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btn_Inserir
            // 
            this.btn_Inserir.Location = new System.Drawing.Point(373, 12);
            this.btn_Inserir.Name = "btn_Inserir";
            this.btn_Inserir.Size = new System.Drawing.Size(137, 36);
            this.btn_Inserir.TabIndex = 2;
            this.btn_Inserir.Text = "Inserir";
            this.btn_Inserir.UseVisualStyleBackColor = true;
            this.btn_Inserir.Click += new System.EventHandler(this.btn_Inserir_Click);
            // 
            // btn_Apagar
            // 
            this.btn_Apagar.Location = new System.Drawing.Point(373, 54);
            this.btn_Apagar.Name = "btn_Apagar";
            this.btn_Apagar.Size = new System.Drawing.Size(137, 36);
            this.btn_Apagar.TabIndex = 3;
            this.btn_Apagar.Text = "Apagar";
            this.btn_Apagar.UseVisualStyleBackColor = true;
            this.btn_Apagar.Click += new System.EventHandler(this.btn_Apagar_Click);
            // 
            // btnClosehere
            // 
            this.btnClosehere.Location = new System.Drawing.Point(373, 96);
            this.btnClosehere.Name = "btnClosehere";
            this.btnClosehere.Size = new System.Drawing.Size(137, 36);
            this.btnClosehere.TabIndex = 4;
            this.btnClosehere.Text = "Fechar";
            this.btnClosehere.UseVisualStyleBackColor = true;
            this.btnClosehere.Click += new System.EventHandler(this.btnClosehere_Click);
            // 
            // ListaUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 450);
            this.Controls.Add(this.btnClosehere);
            this.Controls.Add(this.btn_Apagar);
            this.Controls.Add(this.btn_Inserir);
            this.Controls.Add(this.lbx_Usuarios);
            this.Controls.Add(this.tb_NomeUsuario);
            this.Name = "ListaUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ListaUsuarios";
            this.Load += new System.EventHandler(this.ListaUsuarios_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_NomeUsuario;
        private System.Windows.Forms.ListBox lbx_Usuarios;
        private System.Windows.Forms.Button btn_Inserir;
        private System.Windows.Forms.Button btn_Apagar;
        private System.Windows.Forms.Button btnClosehere;
    }
}