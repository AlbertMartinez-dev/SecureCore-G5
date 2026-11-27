
namespace BaseForms
{
    partial class frmBaseSimple
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
            this.dtgDades = new System.Windows.Forms.DataGridView();
            this.btnNou = new System.Windows.Forms.Button();
            this.btnActualitzar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDades)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgDades
            // 
            this.dtgDades.AllowUserToAddRows = false;
            this.dtgDades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDades.Location = new System.Drawing.Point(12, 171);
            this.dtgDades.Name = "dtgDades";
            this.dtgDades.ReadOnly = true;
            this.dtgDades.RowHeadersWidth = 51;
            this.dtgDades.RowTemplate.Height = 24;
            this.dtgDades.Size = new System.Drawing.Size(776, 267);
            this.dtgDades.TabIndex = 0;
            // 
            // btnNou
            // 
            this.btnNou.Location = new System.Drawing.Point(602, 138);
            this.btnNou.Name = "btnNou";
            this.btnNou.Size = new System.Drawing.Size(85, 27);
            this.btnNou.TabIndex = 1;
            this.btnNou.Text = "Nou";
            this.btnNou.UseVisualStyleBackColor = true;
            this.btnNou.Click += new System.EventHandler(this.btnNou_Click);
            // 
            // btnActualitzar
            // 
            this.btnActualitzar.Location = new System.Drawing.Point(693, 138);
            this.btnActualitzar.Name = "btnActualitzar";
            this.btnActualitzar.Size = new System.Drawing.Size(85, 27);
            this.btnActualitzar.TabIndex = 2;
            this.btnActualitzar.Text = "Actualitzar";
            this.btnActualitzar.UseVisualStyleBackColor = true;
            this.btnActualitzar.Click += new System.EventHandler(this.btnActualitzar_Click);
            // 
            // frmBaseSimple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnActualitzar);
            this.Controls.Add(this.btnNou);
            this.Controls.Add(this.dtgDades);
            this.Name = "frmBaseSimple";
            this.Text = "frmBaseSimple";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmBaseSimple_FormClosed);
            this.Load += new System.EventHandler(this.frmBaseSimple_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDades)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgDades;
        private System.Windows.Forms.Button btnNou;
        private System.Windows.Forms.Button btnActualitzar;
    }
}