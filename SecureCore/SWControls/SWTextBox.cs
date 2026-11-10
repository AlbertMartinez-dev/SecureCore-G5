using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace SWControls
{
    public partial class SWTextBox : UserControl
    {
        public SWTextBox()
        {
            InitializeComponent();
        }

        private void swtCodi_Enter(object sender, EventArgs e)
        {
            SWTCodi.BackColor = Color.GreenYellow;

        }

        private void swtCodi_Leave(object sender, EventArgs e)
        {
            SWTCodi.BackColor = Color.White;
            if (ValidarCodigo(SWTCodi.Text))
            {

                SWTCodi.BackColor = Color.White;
            }
            else
            {

                SWTCodi.BackColor = Color.MistyRose;

                MessageBox.Show("El format del codi es erroni\n" +
                                "segueix el patro de" + this.DadaPermesa.ToString(),
                                "Error de validación",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                SWTCodi.Focus();
            }

        }

        public enum TipusDada
        {
            Numero,
            Text,
            Codi
        }

        private TipusDada _DadaPermesa;

        public TipusDada DadaPermesa
        {
            get { return _DadaPermesa; }

            set

            {

                _DadaPermesa = value;

            }
        }

        public static string CodiStarWars()
        {
            string codi = @"^[AEIOU][A-Z]{3}-\d{2}[13579]$";
            return codi;
        }


        public static bool ValidarCodigo(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return false;
            }
            else
            {
                return Regex.IsMatch(input, CodiStarWars());
            }

        }

        private bool _Requerit = false;

        public bool Requerit
        {
            get { return _Requerit; }
            set { _Requerit = value; }
        }

        private string _CampDB = "";

        public string CampDB
        {
            get { return _CampDB; }
            set { _CampDB = value; }
        }


    }
}
