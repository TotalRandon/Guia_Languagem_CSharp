
namespace MDI_Example
{
    partial class MDIParentForm
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
            this.btnShowChild2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnShowChild2
            // 
            this.btnShowChild2.Location = new System.Drawing.Point(150, 100);
            this.btnShowChild2.Name = "btnShowChild2";
            this.btnShowChild2.Size = new System.Drawing.Size(106, 32);
            this.btnShowChild2.TabIndex = 1;
            this.btnShowChild2.Text = "Clique aqui";
            this.btnShowChild2.UseVisualStyleBackColor = true;
            this.btnShowChild2.Click += new System.EventHandler(this.btnShowChild2_Click);
            // 
            // MDIParentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnShowChild2);
            this.IsMdiContainer = true;
            this.Name = "MDIParentForm";
            this.Text = "MDI Parent";
            this.Load += new System.EventHandler(this.MDIParentForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShowChild2;
    }
}

