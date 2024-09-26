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

        int segundo, minuto, hora;
        public frmRegresiva()
        {
            InitializeComponent();
        }

        public bool bandera;
        private void btnEstablecer_Click(object sender, EventArgs e)
        {
            if (btnEstablecer.Text == "Establecer tiempo")
            { 
            DialogResult resultado;
            frmEstablecer establecer = new frmEstablecer();
            resultado = establecer.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                lblSegundos.Text = formatear(establecer.tiempo[0].ToString());
                lblMinutos.Text = formatear(establecer.tiempo[1].ToString());
                lblHoras.Text = formatear(establecer.tiempo[2].ToString());
                segundo = int.Parse(lblSegundos.Text);
                minuto = int.Parse(lblMinutos.Text);
                hora = int.Parse(lblHoras.Text);
            }
        }
            if (btnEstablecer.Text == "Reiniciar" && timerRegresiva.Enabled == false)
            {
                bandera = false;
                lblHoras.Text = "00";
                lblMinutos.Text = "00";
                lblSegundos.Text = "00";
                hora = minuto = segundo = 0;
                btnEstablecer.Text = "Establecer tiempo";
                btnIniciar.Text = "Iniciar";
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
                timerRegresiva.Enabled = true;
                btnEstablecer.Text = "Reiniciar";
                btnIniciar.Text = "Pausar";
            }
            else
            {
                bandera= false;
                timerRegresiva.Enabled = false;
                btnIniciar.Text = "Reanudar";
            }
        }

        private void timerRegresiva_Tick(object sender, EventArgs e)
        {
            segundo--;
            lblSegundos.Text = formatear(segundo.ToString());
            lblMinutos.Text = formatear(minuto.ToString());
            lblHoras.Text = formatear(hora.ToString());

            if (segundo == 0)
            {
                segundo = 60;
                minuto--;
                if (minuto < 0)
                {
                    minuto = 59;
                    hora--;
                    if (hora < 0)
                    {
                        hora = 0;
                        minuto = 0;
                        segundo = 0;
                    }
                }
            }
            if (hora == 0 && minuto == 0 && segundo == 0)
            {
                timerRegresiva.Stop();
                MessageBox.Show("¡El tiempo ha terminado!");
            }

        }
    }
}