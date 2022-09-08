using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pjDivisionEntrecero
{
    public partial class frmDivisionEntreCero : Form
    {
        public frmDivisionEntreCero()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                //Capturando Datos
                int numerador = int.Parse(txtNumerador.Text);
                int denominador = int.Parse(txtDenominador.Text);

                //Realizando calculo
                double resultado = numerador / denominador;

                lblResultado.Text = resultado.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Debe escribir los datos", "Formato de numero invalido", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (DivideByZeroException aaa)
            {
                MessageBox.Show(aaa.Message, "Intento de division por cero", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
