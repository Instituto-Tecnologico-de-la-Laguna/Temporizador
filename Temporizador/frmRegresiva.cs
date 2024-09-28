using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temporizador
{
    public partial class frmRegresiva : Form
    {


        public frmRegresiva()
        {
            InitializeComponent();
        }
        int segundo, minuto, hora;
        bool bandera = false;

        private void btnEstablecer_Click(object sender, EventArgs e)
        {
            lblSegundos.Text = "00";
            lblMinutos.Text = "00";
            lblHoras.Text = "00";

            DialogResult resultado;
            frmEstablecer establecer = new frmEstablecer();
            resultado = establecer.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                lblSegundos.Text = formatear(establecer.tiempo[0].ToString());
                lblMinutos.Text = formatear(establecer.tiempo[1].ToString());
                lblHoras.Text = formatear(establecer.tiempo[2].ToString());

                segundo = establecer.tiempo[0];
                minuto = establecer.tiempo[1];
                hora = establecer.tiempo[2];
            }
        }

        private string formatear(string numero)
        {
            if (numero.Length == 1)
            {
                return "0" + numero;
            }
            return numero;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (bandera == false)
            {
                bandera = true;
                tmrRegresiva.Enabled = true;
                btnControl.Text = "Pausar";
            }
            else
            {
                bandera = false;
                tmrRegresiva.Enabled = false;
                btnControl.Text = "Iniciar";
            }

        }

        private void tmrRegresiva_Tick(object sender, EventArgs e)
        {
            segundo--;

            if (segundo < 0)
            {
                segundo = 59;
                minuto--;

                if (minuto < 0)
                {
                    minuto = 59;
                    hora--;

                }
            }

            if (segundo < 10)
                lblSegundos.Text = "0" + segundo.ToString();
            else
                lblSegundos.Text = segundo.ToString();

            if (minuto < 10)
                lblMinutos.Text = "0" + minuto.ToString();
            else
                lblMinutos.Text = minuto.ToString();

            if (hora < 10)
                lblHoras.Text = "0" + hora.ToString();
            else
                lblHoras.Text = hora.ToString();


            if (hora == 0 && minuto == 0 && segundo == 0)
            {
                tmrRegresiva.Stop();
                MessageBox.Show("Tiempo terminado");
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tmrRegresiva.Enabled = false;
            btnControl.Text = "Iniciar";
            lblSegundos.Text = "00";
            lblMinutos.Text = "00";
            lblHoras.Text = "00";
        }
    }
}