
namespace SecureCore
{
    partial class Form1
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.swLaunchForm2 = new SWControls.SWLaunchForm();
            this.swLaunchForm1 = new SWControls.SWLaunchForm();
            this.swTextBox1 = new SWControls.SWTextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(209, 140);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 1;
            // 
            // swLaunchForm2
            // 
            this.swLaunchForm2.Classe = "";
            this.swLaunchForm2.Descripcio = "Descripció";
            this.swLaunchForm2.Formulari = "";
            this.swLaunchForm2.Location = new System.Drawing.Point(160, 211);
            this.swLaunchForm2.Name = "swLaunchForm2";
            this.swLaunchForm2.PathImatge = "\"C:\\Users\\Polto\\Downloads\\file.jpg\"";
            this.swLaunchForm2.Size = new System.Drawing.Size(464, 216);
            this.swLaunchForm2.TabIndex = 4;
            // 
            // swLaunchForm1
            // 
            this.swLaunchForm1.Classe = "";
            this.swLaunchForm1.Descripcio = "Descripció";
            this.swLaunchForm1.Formulari = "";
            this.swLaunchForm1.Location = new System.Drawing.Point(126, 193);
            this.swLaunchForm1.Name = "swLaunchForm1";
            this.swLaunchForm1.PathImatge = "";
            this.swLaunchForm1.Size = new System.Drawing.Size(464, 216);
            this.swLaunchForm1.TabIndex = 3;
            // 
            // swTextBox1
            // 
            this.swTextBox1.CampDB = "";
            this.swTextBox1.DadaPermesa = SWControls.SWTextBox.TipusDada.Codi;
            this.swTextBox1.Location = new System.Drawing.Point(51, 25);
            this.swTextBox1.Name = "swTextBox1";
            this.swTextBox1.Requerit = false;
            this.swTextBox1.Size = new System.Drawing.Size(342, 109);
            this.swTextBox1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.swLaunchForm2);
            this.Controls.Add(this.swLaunchForm1);
            this.Controls.Add(this.swTextBox1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.TextBox textBox1;
        private SWControls.SWTextBox swTextBox1;
        private SWControls.SWLaunchForm swLaunchForm1;
        private SWControls.SWLaunchForm swLaunchForm2;
    }
}

