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
        DialogResult resultado;
        frmEstablecer establecer = new frmEstablecer();
        
        public frmRegresiva()
        {
            InitializeComponent();
            
        }
        bool bandera = false;
        private void btnEstablecer_Click(object sender, EventArgs e)
        {

            //DialogResult resultado;
            //frmEstablecer establecer = new frmEstablecer();
            resultado = establecer.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                
                lblSegundos.Text = formatear(establecer.tiempo[0].ToString());
                lblMinutos.Text = formatear(establecer.tiempo[1].ToString());
                lblHoras.Text = formatear(establecer.tiempo[2].ToString());
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
        int horas, minutos, segundos;

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            
                horas = int.Parse(lblHoras.Text);
                minutos = int.Parse(lblMinutos.Text);
                segundos = int.Parse(lblSegundos.Text);

            if (bandera == false)
                {
                    bandera = true;
                    timer1.Enabled = true;
                    btnIniciar.Text = "Detener";
                }
                else
                {
                    bandera = false;
                    timer1.Enabled = false;
                    btnIniciar.Text = "Iniciar";
                }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (segundos > 0)
            {
                segundos--;
            }
            else
            {
                if (minutos > 0)
                {
                    minutos--;
                    segundos = 59;
                }
                else if (horas > 0)
                {
                    horas--;
                    minutos = 59;
                    segundos = 59;
                }
                else
                {
                    timer1.Stop();
                    btnIniciar.Text = "Iniciar";
                    establecer.tiempo.Clear();
                }

            }

            lblSegundos.Text = formatear(segundos.ToString());
            lblMinutos.Text = formatear(minutos.ToString());
            lblHoras.Text = formatear(horas.ToString());

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            establecer.tiempo.Clear();
            lblSegundos.Text = "00";
            lblMinutos.Text = "00";
            lblHoras.Text = "00";
            timer1.Stop();
            if (bandera == false)
                btnIniciar.Text = "Detener";
            else
                btnIniciar.Text = "Iniciar";

        }
    }
}
