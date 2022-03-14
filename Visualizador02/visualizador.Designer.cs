
namespace Visualizador02
{
    partial class FRM_Visualizador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Visualizador));
            this.btn_Selecionar = new System.Windows.Forms.Button();
            this.btn_Fechar = new System.Windows.Forms.Button();
            this.ofd_SelFigura = new System.Windows.Forms.OpenFileDialog();
            this.btn_Aumentar = new System.Windows.Forms.Button();
            this.btn_Diminuir = new System.Windows.Forms.Button();
            this.btn_Borda = new System.Windows.Forms.Button();
            this.labX = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.btn_Abrir = new System.Windows.Forms.Button();
            this.btnListaInicio = new System.Windows.Forms.Button();
            this.pb_figura = new System.Windows.Forms.PictureBox();
            this.btn_Usuarios = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_figura)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Selecionar
            // 
            this.btn_Selecionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Selecionar.Location = new System.Drawing.Point(511, 33);
            this.btn_Selecionar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Selecionar.Name = "btn_Selecionar";
            this.btn_Selecionar.Size = new System.Drawing.Size(172, 30);
            this.btn_Selecionar.TabIndex = 0;
            this.btn_Selecionar.Text = "Selecionar";
            this.btn_Selecionar.UseVisualStyleBackColor = true;
            this.btn_Selecionar.Click += new System.EventHandler(this.btn_Selecionar_Click);
            // 
            // btn_Fechar
            // 
            this.btn_Fechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Fechar.Location = new System.Drawing.Point(511, 69);
            this.btn_Fechar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Fechar.Name = "btn_Fechar";
            this.btn_Fechar.Size = new System.Drawing.Size(172, 30);
            this.btn_Fechar.TabIndex = 1;
            this.btn_Fechar.Text = "Fechar";
            this.btn_Fechar.UseVisualStyleBackColor = true;
            this.btn_Fechar.Click += new System.EventHandler(this.btn_Fechar_Click);
            // 
            // ofd_SelFigura
            // 
            this.ofd_SelFigura.Filter = "Windows Bitmaps|*.bmp|Arquivos JPEG|*.jpg";
            this.ofd_SelFigura.Title = "Selecionar figura";
            // 
            // btn_Aumentar
            // 
            this.btn_Aumentar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Aumentar.Location = new System.Drawing.Point(611, 482);
            this.btn_Aumentar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Aumentar.Name = "btn_Aumentar";
            this.btn_Aumentar.Size = new System.Drawing.Size(33, 39);
            this.btn_Aumentar.TabIndex = 3;
            this.btn_Aumentar.Text = "v";
            this.btn_Aumentar.UseVisualStyleBackColor = true;
            this.btn_Aumentar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Diminuir
            // 
            this.btn_Diminuir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Diminuir.Location = new System.Drawing.Point(650, 482);
            this.btn_Diminuir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Diminuir.Name = "btn_Diminuir";
            this.btn_Diminuir.Size = new System.Drawing.Size(33, 39);
            this.btn_Diminuir.TabIndex = 4;
            this.btn_Diminuir.Text = "∧";
            this.btn_Diminuir.UseVisualStyleBackColor = true;
            this.btn_Diminuir.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btn_Borda
            // 
            this.btn_Borda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Borda.Location = new System.Drawing.Point(511, 105);
            this.btn_Borda.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Borda.Name = "btn_Borda";
            this.btn_Borda.Size = new System.Drawing.Size(172, 28);
            this.btn_Borda.TabIndex = 5;
            this.btn_Borda.Text = "Borda";
            this.btn_Borda.UseVisualStyleBackColor = true;
            this.btn_Borda.Click += new System.EventHandler(this.btn_Borda_Click);
            // 
            // labX
            // 
            this.labX.AutoSize = true;
            this.labX.Location = new System.Drawing.Point(504, 182);
            this.labX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labX.Name = "labX";
            this.labX.Size = new System.Drawing.Size(0, 17);
            this.labX.TabIndex = 6;
            this.labX.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblX
            // 
            this.lblX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(508, 207);
            this.lblX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(21, 17);
            this.lblX.TabIndex = 7;
            this.lblX.Text = "X:";
            // 
            // lblY
            // 
            this.lblY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(508, 224);
            this.lblY.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(21, 17);
            this.lblY.TabIndex = 8;
            this.lblY.Text = "Y:";
            // 
            // btn_Abrir
            // 
            this.btn_Abrir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Abrir.Location = new System.Drawing.Point(511, 140);
            this.btn_Abrir.Name = "btn_Abrir";
            this.btn_Abrir.Size = new System.Drawing.Size(172, 29);
            this.btn_Abrir.TabIndex = 9;
            this.btn_Abrir.Text = "Opções";
            this.btn_Abrir.UseVisualStyleBackColor = true;
            this.btn_Abrir.Click += new System.EventHandler(this.btn_Abrir_Click);
            this.btn_Abrir.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_Abrir_MouseClick);
            // 
            // btnListaInicio
            // 
            this.btnListaInicio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnListaInicio.Location = new System.Drawing.Point(511, 175);
            this.btnListaInicio.Name = "btnListaInicio";
            this.btnListaInicio.Size = new System.Drawing.Size(172, 29);
            this.btnListaInicio.TabIndex = 10;
            this.btnListaInicio.Text = "Lista";
            this.btnListaInicio.UseVisualStyleBackColor = true;
            this.btnListaInicio.Click += new System.EventHandler(this.btnListaInicio_Click);
            // 
            // pb_figura
            // 
            this.pb_figura.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_figura.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pb_figura.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pb_figura.Location = new System.Drawing.Point(15, 12);
            this.pb_figura.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pb_figura.Name = "pb_figura";
            this.pb_figura.Size = new System.Drawing.Size(484, 509);
            this.pb_figura.TabIndex = 2;
            this.pb_figura.TabStop = false;
            this.pb_figura.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pb_figura_MouseMove);
            // 
            // btn_Usuarios
            // 
            this.btn_Usuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Usuarios.Location = new System.Drawing.Point(511, 448);
            this.btn_Usuarios.Name = "btn_Usuarios";
            this.btn_Usuarios.Size = new System.Drawing.Size(172, 29);
            this.btn_Usuarios.TabIndex = 11;
            this.btn_Usuarios.Text = "Usuarios";
            this.btn_Usuarios.UseVisualStyleBackColor = true;
            this.btn_Usuarios.Click += new System.EventHandler(this.btn_Usuarios_Click);
            // 
            // FRM_Visualizador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(1, 1);
            this.AutoScrollMinSize = new System.Drawing.Size(10, 10);
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(695, 532);
            this.Controls.Add(this.btn_Usuarios);
            this.Controls.Add(this.btnListaInicio);
            this.Controls.Add(this.btn_Abrir);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.labX);
            this.Controls.Add(this.btn_Borda);
            this.Controls.Add(this.btn_Diminuir);
            this.Controls.Add(this.btn_Aumentar);
            this.Controls.Add(this.pb_figura);
            this.Controls.Add(this.btn_Fechar);
            this.Controls.Add(this.btn_Selecionar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FRM_Visualizador";
            this.Text = "Visualizador bi3014312";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.FRM_Visualizador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_figura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_figura;
        private System.Windows.Forms.Button btn_Selecionar;
        private System.Windows.Forms.Button btn_Fechar;
        private System.Windows.Forms.OpenFileDialog ofd_SelFigura;
        private System.Windows.Forms.Button btn_Aumentar;
        private System.Windows.Forms.Button btn_Diminuir;
        private System.Windows.Forms.Button btn_Borda;
        private System.Windows.Forms.Label labX;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Button btn_Abrir;
        private System.Windows.Forms.Button btnListaInicio;
        private System.Windows.Forms.Button btn_Usuarios;
    }
}

