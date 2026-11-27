using System;
using System.ComponentModel;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SWControls
{
    public class SWTextbox : TextBox
    {
        public enum TipusDada
        {
            Numero,
            Text,
            Codi
        }

        private TipusDada _DadaPermesa = TipusDada.Text;

        public TipusDada DadaPermesa
        {
            get { return _DadaPermesa; }
            set { _DadaPermesa = value; }
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

        private bool _ClauForana = false;

        public bool ClauForana
        {
            get { return _ClauForana; }
            set { _ClauForana = value; }
        }

        private Color _ColorOriginal;

        public static string CodiStarWars()
        {
            return @"^[AEIOU][A-Z]{3}-\d{2}[13579]$";
        }

        public static string Numero()
        {
            return @"^\d+$";
        }

        public static bool ValidarCodigo(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return false;

            return Regex.IsMatch(input, CodiStarWars());
        }

        public bool ValidarDada(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return !Requerit;

            switch (DadaPermesa)
            {
                case TipusDada.Numero:
                    return Regex.IsMatch(input, Numero());

                case TipusDada.Text:
                    return true;

                case TipusDada.Codi:
                    return ValidarCodigo(input);

                default:
                    return false;
            }
        }

        protected override void OnEnter(EventArgs e)
        {
            base.OnEnter(e);

            _ColorOriginal = BackColor;
            BackColor = Color.GreenYellow;
        }

        protected override void OnValidating(CancelEventArgs e)
        {
            base.OnValidating(e);

            if (!ValidarDada(Text))
            {
                BackColor = Color.MistyRose;
                e.Cancel = true;

                MessageBox.Show("El format de la dada és incorrecte.\n" + "Segueix el patró de " + 
                    DadaPermesa.ToString(), "Error de validació", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        protected override void OnValidated(EventArgs e)
        {
            base.OnValidated(e);

            BackColor = _ColorOriginal;
        }
    }
}
