
namespace SecureCore
{
    partial class frmCanviPassword
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
            this.lblTitol = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNouPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRepetirPassword = new System.Windows.Forms.TextBox();
            this.btnDesar = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitol
            // 
            this.lblTitol.AutoSize = true;
            this.lblTitol.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitol.Location = new System.Drawing.Point(28, 20);
            this.lblTitol.Name = "lblTitol";
            this.lblTitol.Size = new System.Drawing.Size(312, 39);
            this.lblTitol.TabIndex = 0;
            this.lblTitol.Text = "Canvi de contrasenya";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(31, 68);
            this.lblInfo.MaximumSize = new System.Drawing.Size(360, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(353, 36);
            this.lblInfo.TabIndex = 1;
            this.lblInfo.Text = "Has entrat amb la contrasenya inicial. Per continuar, n'has de triar una de nova.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nova contrasenya";
            // 
            // txtNouPassword
            // 
            this.txtNouPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNouPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNouPassword.Location = new System.Drawing.Point(35, 150);
            this.txtNouPassword.Name = "txtNouPassword";
            this.txtNouPassword.Size = new System.Drawing.Size(340, 30);
            this.txtNouPassword.TabIndex = 3;
            this.txtNouPassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Repeteix la contrasenya";
            // 
            // txtRepetirPassword
            // 
            this.txtRepetirPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRepetirPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRepetirPassword.Location = new System.Drawing.Point(35, 225);
            this.txtRepetirPassword.Name = "txtRepetirPassword";
            this.txtRepetirPassword.Size = new System.Drawing.Size(340, 30);
            this.txtRepetirPassword.TabIndex = 5;
            this.txtRepetirPassword.UseSystemPasswordChar = true;
            // 
            // btnDesar
            // 
            this.btnDesar.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnDesar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDesar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDesar.Location = new System.Drawing.Point(35, 315);
            this.btnDesar.Name = "btnDesar";
            this.btnDesar.Size = new System.Drawing.Size(340, 40);
            this.btnDesar.TabIndex = 6;
            this.btnDesar.Text = "Canviar contrasenya";
            this.btnDesar.UseVisualStyleBackColor = false;
            this.btnDesar.Click += new System.EventHandler(this.btnDesar_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(31, 270);
            this.lblError.MaximumSize = new System.Drawing.Size(360, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 18);
            this.lblError.TabIndex = 7;
            // 
            // frmCanviPassword
            // 
            this.AcceptButton = this.btnDesar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 380);
            this.Controls.Add(this.lblTitol);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNouPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRepetirPassword);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnDesar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCanviPassword";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Primer accés";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitol;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNouPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRepetirPassword;
        private System.Windows.Forms.Button btnDesar;
        private System.Windows.Forms.Label lblError;
    }
}
