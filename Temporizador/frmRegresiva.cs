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


        public frmRegresiva()
        {
            InitializeComponent();
        }
        Boolean bandera;
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
                tiempo.Enabled = true;
               butIniciar.Text = "Detener";


            }
            else
            {
                bandera = false;
                tiempo.Enabled = true;
                butIniciar.Text = "Iniciar";
                tiempo.Stop();
            }

        }

        private void tiempo_Tick(object sender, EventArgs e)
        {
            int segundos = int.Parse(lblSegundos.Text);
            tiempo.Enabled = true;
            segundos--;
            if (segundos < 0)
            {
                int minutos = int.Parse(lblMinutos.Text);
                minutos--;
                if (minutos < 0)
                {
                    int horas = int.Parse(lblHoras.Text);
                    horas--;
                    if (horas < 0)
                    {
                        tiempo.Enabled = false;
                        MessageBox.Show("Tiempo finalizado");
                    }
                    else
                    {
                        lblHoras.Text = formatear(horas.ToString());
                        lblMinutos.Text = "59";
                        lblSegundos.Text = "59";
                    }
                }
                else
                {
                    lblMinutos.Text = formatear(minutos.ToString());
                    lblSegundos.Text = "59";
                }
            }
            else
            {
                lblSegundos.Text = formatear(segundos.ToString());
            }
        }
    }
}