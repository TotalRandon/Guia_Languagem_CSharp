
namespace Visualizador02
{
    partial class ListsForm
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
            this.lstPinkFloydAlbums = new System.Windows.Forms.ListBox();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnShowiten = new System.Windows.Forms.Button();
            this.cboColors = new System.Windows.Forms.ComboBox();
            this.btnClose02 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstPinkFloydAlbums
            // 
            this.lstPinkFloydAlbums.FormattingEnabled = true;
            this.lstPinkFloydAlbums.ItemHeight = 16;
            this.lstPinkFloydAlbums.Items.AddRange(new object[] {
            ". Atom Heart Mother",
            ". Wish You Were Here",
            ". Animals",
            ". Echoes",
            ". Meddle",
            ". Dark Side of the Moon"});
            this.lstPinkFloydAlbums.Location = new System.Drawing.Point(50, 28);
            this.lstPinkFloydAlbums.Name = "lstPinkFloydAlbums";
            this.lstPinkFloydAlbums.Size = new System.Drawing.Size(295, 196);
            this.lstPinkFloydAlbums.TabIndex = 0;
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(50, 230);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(118, 29);
            this.btnAddItem.TabIndex = 1;
            this.btnAddItem.Text = "Adicionar Itens";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.Location = new System.Drawing.Point(50, 265);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(118, 29);
            this.btnRemoveItem.TabIndex = 2;
            this.btnRemoveItem.Text = "Excluir itens";
            this.btnRemoveItem.UseVisualStyleBackColor = true;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(50, 300);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(118, 29);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Limpar itens";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnShowiten
            // 
            this.btnShowiten.Location = new System.Drawing.Point(50, 335);
            this.btnShowiten.Name = "btnShowiten";
            this.btnShowiten.Size = new System.Drawing.Size(118, 29);
            this.btnShowiten.TabIndex = 4;
            this.btnShowiten.Text = "Mostrar itens";
            this.btnShowiten.UseVisualStyleBackColor = true;
            this.btnShowiten.Click += new System.EventHandler(this.btnShowiten_Click);
            // 
            // cboColors
            // 
            this.cboColors.FormattingEnabled = true;
            this.cboColors.Items.AddRange(new object[] {
            ". Black",
            ". Blue",
            ". Gold",
            ". Green",
            ". Red",
            ". Yellow"});
            this.cboColors.Location = new System.Drawing.Point(224, 235);
            this.cboColors.Name = "cboColors";
            this.cboColors.Size = new System.Drawing.Size(121, 24);
            this.cboColors.TabIndex = 5;
            this.cboColors.Text = "Leave blank";
            this.cboColors.SelectedIndexChanged += new System.EventHandler(this.cboColors_SelectedIndexChanged);
            // 
            // btnClose02
            // 
            this.btnClose02.Location = new System.Drawing.Point(50, 370);
            this.btnClose02.Name = "btnClose02";
            this.btnClose02.Size = new System.Drawing.Size(118, 29);
            this.btnClose02.TabIndex = 6;
            this.btnClose02.Text = "Voltar";
            this.btnClose02.UseVisualStyleBackColor = true;
            this.btnClose02.Click += new System.EventHandler(this.btnClose02_Click);
            // 
            // ListsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Visualizador02.Properties.Resources._3d_pretos_sofa_claro_imagem_de_fundo;
            this.ClientSize = new System.Drawing.Size(402, 450);
            this.Controls.Add(this.btnClose02);
            this.Controls.Add(this.cboColors);
            this.Controls.Add(this.btnShowiten);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRemoveItem);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.lstPinkFloydAlbums);
            this.Name = "ListsForm";
            this.Text = "Exemplo de Lista";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstPinkFloydAlbums;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnShowiten;
        private System.Windows.Forms.ComboBox cboColors;
        private System.Windows.Forms.Button btnClose02;
    }
}