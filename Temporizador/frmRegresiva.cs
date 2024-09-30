using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Numerics;
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
        bool bandera = false;
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
                btnEstablecer.Enabled = true;
                btnIniciar.Text = "Detener";
            }
            else
            {
                bandera = false;
                btnEstablecer.Enabled = true;
                btnIniciar.Text = "Iniciar";
                
            }
        }
        private void tiempo_Tick(object sender, EventArgs e)
        {
            int segundos = int.Parse(lblSegundos.Text);
            btnEstablecer.Enabled = true;
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
                        btnEstablecer.Enabled = false;
                        MessageBox.Show("Tiempo Finalizado");
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

        private void button1_Click(object sender, EventArgs e)
        {
            lblSegundos.Text = "00";
            lblMinutos.Text = "00";
            lblHoras.Text = "00";
        }
    } 
    
}