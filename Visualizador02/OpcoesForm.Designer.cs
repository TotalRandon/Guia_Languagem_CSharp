
namespace Visualizador02
{
    partial class frm_Opcoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Opcoes));
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblassword = new System.Windows.Forms.Label();
            this.txtBoxPassword = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.chkPromptOnExit = new System.Windows.Forms.CheckBox();
            this.grpDefaultBackcolor = new System.Windows.Forms.GroupBox();
            this.optBackgroundDefault = new System.Windows.Forms.RadioButton();
            this.optBackgroundWhite = new System.Windows.Forms.RadioButton();
            this.grpDefaultBackcolor.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(12, 40);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(83, 17);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "User Name:";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(122, 40);
            this.txtUserName.MaxLength = 10;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(186, 22);
            this.txtUserName.TabIndex = 2;
            this.txtUserName.Text = "Deixe em branco";
            this.txtUserName.TextChanged += new System.EventHandler(this.txtUserName_TextChanged);
            // 
            // lblassword
            // 
            this.lblassword.AutoSize = true;
            this.lblassword.Location = new System.Drawing.Point(12, 65);
            this.lblassword.Name = "lblassword";
            this.lblassword.Size = new System.Drawing.Size(81, 17);
            this.lblassword.TabIndex = 3;
            this.lblassword.Text = "Senha:       ";
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.Location = new System.Drawing.Point(122, 65);
            this.txtBoxPassword.MaxLength = 12;
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.PasswordChar = '*';
            this.txtBoxPassword.Size = new System.Drawing.Size(186, 22);
            this.txtBoxPassword.TabIndex = 4;
            this.txtBoxPassword.Text = ",";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(443, 12);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(137, 34);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(443, 52);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(137, 30);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // chkPromptOnExit
            // 
            this.chkPromptOnExit.AutoSize = true;
            this.chkPromptOnExit.Location = new System.Drawing.Point(15, 209);
            this.chkPromptOnExit.Name = "chkPromptOnExit";
            this.chkPromptOnExit.Size = new System.Drawing.Size(186, 21);
            this.chkPromptOnExit.TabIndex = 7;
            this.chkPromptOnExit.Text = "Prompt to confirm on exit";
            this.chkPromptOnExit.UseVisualStyleBackColor = true;
            // 
            // grpDefaultBackcolor
            // 
            this.grpDefaultBackcolor.Controls.Add(this.optBackgroundWhite);
            this.grpDefaultBackcolor.Controls.Add(this.optBackgroundDefault);
            this.grpDefaultBackcolor.Location = new System.Drawing.Point(15, 109);
            this.grpDefaultBackcolor.Name = "grpDefaultBackcolor";
            this.grpDefaultBackcolor.Size = new System.Drawing.Size(293, 78);
            this.grpDefaultBackcolor.TabIndex = 8;
            this.grpDefaultBackcolor.TabStop = false;
            this.grpDefaultBackcolor.Text = "Default Picture Background Color";
            // 
            // optBackgroundDefault
            // 
            this.optBackgroundDefault.AutoSize = true;
            this.optBackgroundDefault.Location = new System.Drawing.Point(6, 21);
            this.optBackgroundDefault.Name = "optBackgroundDefault";
            this.optBackgroundDefault.Size = new System.Drawing.Size(109, 21);
            this.optBackgroundDefault.TabIndex = 9;
            this.optBackgroundDefault.Text = "Default Gray";
            this.optBackgroundDefault.UseVisualStyleBackColor = true;
            // 
            // optBackgroundWhite
            // 
            this.optBackgroundWhite.AutoSize = true;
            this.optBackgroundWhite.Checked = true;
            this.optBackgroundWhite.Location = new System.Drawing.Point(6, 49);
            this.optBackgroundWhite.Name = "optBackgroundWhite";
            this.optBackgroundWhite.Size = new System.Drawing.Size(65, 21);
            this.optBackgroundWhite.TabIndex = 10;
            this.optBackgroundWhite.TabStop = true;
            this.optBackgroundWhite.Text = "White";
            this.optBackgroundWhite.UseVisualStyleBackColor = true;
            // 
            // frm_Opcoes
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::Visualizador02.Properties.Resources.thumb2_3d_black_cubes_texture_black_cubes_background_3d_texture_creative_3d_background_black_3d_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(592, 483);
            this.Controls.Add(this.grpDefaultBackcolor);
            this.Controls.Add(this.chkPromptOnExit);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtBoxPassword);
            this.Controls.Add(this.lblassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lblUserName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Opcoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Formlulario de opções";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frm_Opcoes_Load);
            this.grpDefaultBackcolor.ResumeLayout(false);
            this.grpDefaultBackcolor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblassword;
        private System.Windows.Forms.TextBox txtBoxPassword;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.CheckBox chkPromptOnExit;
        private System.Windows.Forms.GroupBox grpDefaultBackcolor;
        private System.Windows.Forms.RadioButton optBackgroundWhite;
        private System.Windows.Forms.RadioButton optBackgroundDefault;
    }
}