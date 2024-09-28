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

        private int horas, minutos, segundos;

        public frmRegresiva()
        {
            InitializeComponent();
        }

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

        private async void button1_Click(object sender, EventArgs e)
        {
            DialogResult resultado;
            frmEstablecer establecer = new frmEstablecer();
            resultado = establecer.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                lblSegundos.Text = formatear(establecer.tiempo[0].ToString());
                lblMinutos.Text = formatear(establecer.tiempo[1].ToString());
                lblHoras.Text = formatear(establecer.tiempo[2].ToString());

                int totalSegundos = horas * 3600 + minutos * 60 + segundos;

                while (totalSegundos > 0)
                {
                    await Task.Delay(1000);

                    totalSegundos--;

                    //Convertir
                    horas = totalSegundos / 3600;
                    minutos = (totalSegundos % 3600) / 60;
                    segundos = totalSegundos % 60;

                    lblSegundos.Text = formatear(segundos.ToString());
                    lblMinutos.Text = formatear(minutos.ToString());
                    lblHoras.Text = formatear(horas.ToString());
                }

                MessageBox.Show("Tiempo Finalizado.");

            }
        }
    }
}