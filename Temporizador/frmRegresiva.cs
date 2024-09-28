using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temporizador
{
    public partial class frmRegresiva : Form
    {
        // Atributos
        int segundo = 0;
        int minuto = 0;
        int hora = 0;
        bool bandera = false;


        // Constructor
        public frmRegresiva()
        {
            InitializeComponent();
        } // end constructor

        // Metodos
        private void btnEstablecer_Click(object sender, EventArgs e)
        {

            DialogResult resultado;
            frmEstablecer establecer = new frmEstablecer();
            resultado = establecer.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                lblSegundos.Text = formatear(establecer.tiempo[0].ToString());
                lblMinutos.Text = formatear(establecer.tiempo[1].ToString());
                lblHoras.Text = formatear(establecer.tiempo[2].ToString());

                segundo = Int32.Parse(lblSegundos.Text);
                minuto = Int32.Parse(lblMinutos.Text);
                hora = Int32.Parse(lblHoras.Text);
            }
        } // end btnEstablecer_Click()

        private string formatear(string numero)
        {
            if (numero.Length == 1)
            {
                return "0" + numero;
            }
            return numero;
        } // end formatear()

        // Inicia la cuenta regresiva
        private void button2_Click(object sender, EventArgs e)
        {
            if (bandera == false)
            {
                bandera = true;
                tmrRegresiva.Enabled = true;
                btnIniciar.Text = "Detener";
            }
            else
            {
                bandera = false;
                tmrRegresiva.Enabled = false;
                btnIniciar.Text = "Iniciar";
            }
        } // end button2_Click()


        // Funcion que se encarga de contabilizar el tiempo, falta hacerlo regresivo
        private void tmrRegresiva_Tick(object sender, EventArgs e)
        {
            // segundo--;
            

            if (minuto < 0)
            {
                hora--;
                minuto = 59;
                
            }

            if (segundo < 0)
            {
                minuto--;
                segundo = 59;
                
            }

            if (segundo < 10)
                lblSegundos.Text = "0" + segundo.ToString();
            else
                lblSegundos.Text = segundo.ToString();

            if (hora < 10)
                lblHoras.Text = "0" + hora.ToString();
            else
                lblHoras.Text = hora.ToString();

            if (minuto < 10)
                lblMinutos.Text = "0" + minuto.ToString();
            else
                lblMinutos.Text = minuto.ToString();

            if (hora == 0 && minuto == 0 && segundo == 0)
            {

                return;
            }

            segundo--;
        } // end tmrRegresiva_Tick()

        private void btnResetear_Click(object sender, EventArgs e)
        {
            segundo = 0;
            minuto = 0;
            hora = 0;
            lblSegundos.Text = "00";
            lblMinutos.Text = "00";
            lblHoras.Text = "00";

        } // end btnResetear_Click
    } // end class frmRegresiva
}// end namespace Temporizador