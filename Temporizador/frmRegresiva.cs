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

        int segundo = 0;
        int minuto = 0;
        int hora = 0;
        bool bandera = false;



        public frmRegresiva()
        {
            InitializeComponent();

        }

        private void btnIniciar_Click(object sender, EventArgs e)
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


                segundo = Int32.Parse(lblSegundos.Text);
                minuto = Int32.Parse(lblMinutos.Text);
                hora = Int32.Parse(lblHoras.Text);
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

        private void tmrRegresiva_Tick(object sender, EventArgs e)
        {

            if (segundo == 0)
            {
                Thread.Sleep(1000);
                //  lblSegundos.Text = segundo.ToString();
                segundo = 59;
                lblSegundos.Text = segundo.ToString();
            }
            else if (segundo > 0)
            {
                segundo--;
                Thread.Sleep(1000);
                lblSegundos.Text = segundo.ToString();
            }

            else
            {
                if (minuto > 0)
                {
                    minuto--;
                    lblMinutos.Text = minuto.ToString();
                }
                else
                {
                    minuto = 59;
                    lblMinutos.Text = minuto.ToString();
                    if (hora > 0)
                    {
                        hora--;
                        lblHoras.Text = hora.ToString();
                    }

                }
            }



            if (hora == 0 && minuto == 0 && segundo == 0)
            {
                MessageBox.Show("Tiempo terminado");
            }

        }

        private void btnResetear_Click(object sender, EventArgs e)
        {
            segundo = 0;
            minuto = 0;
            hora = 0;

            lblHoras.Text = "00";
            lblMinutos.Text = "00";
            lblSegundos.Text = "00";
        }
    }
       

        

      
    }


