using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;
using SWControls;

namespace BaseForms
{
    public partial class frmBaseSimple : Form
    {
        public frmBaseSimple()
        {
            InitializeComponent();
        }

        protected string nomTaula;
        protected string query;
        protected DataSet dts;
        protected Boolean EsNou = false;
        protected ComponentDades dades = new ComponentDades();

        public string NomTaula { get; set; }

        private void frmBaseSimple_Load(object sender, EventArgs e)
        {
            CarregarDades();
        }

        private void btnNou_Click(object sender, EventArgs e)
        {
            CrearNouRegistre();
        }

        private void btnActualitzar_Click(object sender, EventArgs e)
        {
            ActualitzarDades();
        }

        private void frmBaseSimple_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (dts != null)
            {
                dts.Dispose();
                dts = null;
            }
        }

        protected void CarregarDades()
        {
            nomTaula = NomTaula;
            query = "select * from " + nomTaula;
            dts = dades.PortarTaula(nomTaula);
            dtgDades.DataSource = dts.Tables[nomTaula];

            FerBinding();
        }

        private void FerBinding()
        {
            foreach (Control item in this.Controls)
            {
                if (item is SWTextBox)
                {
                    SWTextBox ctr = (SWTextBox)item;

                    ctr.DataBindings.Clear();
                    ctr.DataBindings.Add("Text", dts.Tables[nomTaula], ctr.CampDB, true, DataSourceUpdateMode.OnValidation);

                    ctr.Validated -= ValidarTextBox;
                    ctr.Validated += ValidarTextBox;
                }
            }
        }

        protected void ValidarTextBox(object sender, EventArgs e)
        {
            TextBox ctr = (TextBox)sender;
            if (ctr.DataBindings.Count > 0)
            {
                ctr.DataBindings[0].BindingManagerBase.EndCurrentEdit();
            }
        }

        protected void ActualitzarDades()
        {
            if (EsNou)
            {
                DataRow dr = dts.Tables[nomTaula].NewRow();

                foreach (Control item in this.Controls)
                {
                    if (item is TextBox)
                    {
                        TextBox ctr = (TextBox)item;
                        dr[ctr.Tag.ToString()] = ctr.Text;
                    }
                }

                dts.Tables[nomTaula].Rows.Add(dr);
                EsNou = false;
            }

            if (dts.HasChanges())
            {
                int result = dades.Actualitzar(query, dts);
                MessageBox.Show("Registres modificats: " + result.ToString());
            }

            dts.Tables[nomTaula].Clear();
            dts = dades.PortarTaula(nomTaula);
            dtgDades.DataSource = dts.Tables[nomTaula];
            FerBinding();
        }

        protected void CrearNouRegistre()
        {
            EsNou = true;

            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    TextBox ctr = (TextBox)item;
                    ctr.DataBindings.Clear();
                    ctr.Text = "";
                    ctr.Validated -= new System.EventHandler(this.ValidarTextBox);
                }
            }
        }
    }
}
