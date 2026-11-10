
namespace SWControls
{
    partial class SWTextBox
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
            this.SWTCodi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SWTCodi
            // 
            this.SWTCodi.Location = new System.Drawing.Point(123, 55);
            this.SWTCodi.Name = "SWTCodi";
            this.SWTCodi.Size = new System.Drawing.Size(177, 22);
            this.SWTCodi.TabIndex = 0;
            this.SWTCodi.Enter += new System.EventHandler(this.swtCodi_Enter);
            this.SWTCodi.Leave += new System.EventHandler(this.swtCodi_Leave);
            // 
            // SWTextbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SWTCodi);
            this.Name = "SWTextbox";
            this.Size = new System.Drawing.Size(447, 150);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SWTCodi;
    }
}
