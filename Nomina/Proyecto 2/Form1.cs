using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void btnConfirmar_Click(object sender, EventArgs e)
        {
            String TextoN1;
            String TextoN2;
            int N1;
            int N2;
            int Resultado;
            int Resultado2;

            TextoN1 = txtDias.Text;
            TextoN2 = txtHora.Text;
            N1 = Convert.ToInt32(txtDias.Text);
            N2 = Convert.ToInt32(txtHora.Text);

            Resultado = N2 * 8;
            Resultado2 = Resultado * N1;

            txtTotal_Inicial.Text = Resultado2.ToString();
        }

        public void btnVer_Click(object sender, EventArgs e)
        {
            string TextoN3;
            string TextoN4;
            float N3;
            float N4;
            float Resultado;
            float Resulatdo2;
            float Resultado3;
            float Resultado4;
            float Resultado5;
            float Resultado6;
            double ISR = 0.23;
            double Social = 0.05;
            double Retiro = 0.10;

            TextoN3 = txtTotal_Inicial.Text;
            TextoN4 = txtPrestamo.Text;
            N3 = Convert.ToInt32(txtTotal_Inicial.Text);
            N4 = Convert.ToInt32(txtPrestamo.Text);

            //ISR
            Resultado = (float)(N3 * ISR);
            txtISR.Text = Resultado.ToString();

            //Ahorro para Retiro
            Resulatdo2 = (float)(N3 * Retiro);
            txtRetiro.Text = Resulatdo2.ToString();

            //Seguridad Social
            Resultado3 = (float)(N3 * Social);
            txtSocial.Text = Resultado3.ToString();

            //Prestamo
            Resultado4 = N4;
            txtPrestamo.Text = Resultado4.ToString();

            Resultado5 = Resultado + Resulatdo2 + Resultado3 + Resultado4;
            Resultado6 = N3 - Resultado5;

            txtSueldo_Final.Text = Resultado6.ToString();

        }

        private void txtDescuento_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
