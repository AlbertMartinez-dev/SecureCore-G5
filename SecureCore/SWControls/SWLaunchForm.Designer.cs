
namespace SWControls
{
    partial class SWLaunchForm
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.PnlPrincipal = new System.Windows.Forms.Panel();
            this.lblDescripcio = new System.Windows.Forms.Label();
            this.PicImage = new System.Windows.Forms.PictureBox();
            this.PnlPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicImage)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlPrincipal
            // 
            this.PnlPrincipal.Controls.Add(this.lblDescripcio);
            this.PnlPrincipal.Controls.Add(this.PicImage);
            this.PnlPrincipal.Location = new System.Drawing.Point(59, 3);
            this.PnlPrincipal.Name = "PnlPrincipal";
            this.PnlPrincipal.Size = new System.Drawing.Size(341, 190);
            this.PnlPrincipal.TabIndex = 3;
            // 
            // lblDescripcio
            // 
            this.lblDescripcio.AutoSize = true;
            this.lblDescripcio.Location = new System.Drawing.Point(252, 79);
            this.lblDescripcio.Name = "lblDescripcio";
            this.lblDescripcio.Size = new System.Drawing.Size(46, 17);
            this.lblDescripcio.TabIndex = 1;
            this.lblDescripcio.Text = "label1";
            // 
            // PicImage
            // 
            this.PicImage.Location = new System.Drawing.Point(60, 44);
            this.PicImage.Name = "PicImage";
            this.PicImage.Size = new System.Drawing.Size(148, 111);
            this.PicImage.TabIndex = 0;
            this.PicImage.TabStop = false;
            // 
            // SWLaunchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PnlPrincipal);
            this.Name = "SWLaunchForm";
            this.Size = new System.Drawing.Size(464, 216);
            this.Click += new System.EventHandler(this.SWLaunchForm_Click);
            this.PnlPrincipal.ResumeLayout(false);
            this.PnlPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlPrincipal;
        private System.Windows.Forms.Label lblDescripcio;
        private System.Windows.Forms.PictureBox PicImage;
    }
}
