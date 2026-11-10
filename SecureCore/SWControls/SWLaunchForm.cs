using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Reflection;

using System.IO;

namespace SWControls
{
    public partial class SWLaunchForm : UserControl
    {
        public string VClasse = "";
        public string VFormulari = "";
        public string VDescripcio = "Descripció";
        public string VPathImatge = "";

        public SWLaunchForm()
        {
            InitializeComponent();

            this.Click += SWLaunchForm_Click;
            PnlPrincipal.Click += SWLaunchForm_Click;
            PicImage.Click += SWLaunchForm_Click;
            lblDescripcio.Click += SWLaunchForm_Click;

            ActualitzarDescrip();

            ActualitzarImatge();
        }

        public string Classe
        {
            get { return VClasse; }
            set { VClasse = value; }
        }

        public string Formulari
        {
            get { return VFormulari; }
            set { VFormulari = value; }
        }

        public string Descripcio
        {
            get { return VDescripcio; }
            set { VDescripcio = value; ActualitzarDescrip(); }
        }

        public string PathImatge
        {
            get { return VPathImatge; }
            set { VPathImatge = value; ActualitzarImatge(); }
        }

        private void ActualitzarDescrip()
        {
            if (lblDescripcio != null)
            {
                lblDescripcio.Text = VDescripcio;
            }
        }

        private void ActualitzarImatge()
        {

            if (File.Exists(VPathImatge))
            {
                Image img = Image.FromFile(VPathImatge);
                PicImage.Image = new Bitmap(img);
                img.Dispose();

                PicImage.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void SWLaunchForm_Click(object sender, EventArgs e)
        {
            Assembly dll = Assembly.LoadFrom(Classe);
            Type tipus = dll.GetType(Formulari);


            Form f = (Form)Activator.CreateInstance(tipus);
            f.Text = Descripcio;
            f.ShowDialog();
            f.Dispose();
        }
    }


}
