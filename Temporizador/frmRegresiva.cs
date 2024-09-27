using Microsoft.VisualBasic;
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
        int seg;
        int min;
        int h;

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

                h = establecer.tiempo[2];
                min = establecer.tiempo[1];
                seg = establecer.tiempo[0];

                
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

        private void btnReset_Click(object sender, EventArgs e)
        {
            seg = 0;
            min = 0;
            h = 0; 
            timer1.Stop();
            lblSegundos.Text = "00";
            lblMinutos.Text = "00";
            lblHoras.Text = "00";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (seg > 0)
            {
                seg--;
            }
            else
            {
                if (min > 0)
                {
                    min--;
                    seg = 59;
                } else if (h > 0)
                {
                    h--;
                    min = 59;
                    seg = 59;
                }
                if (h == 0 && min == 0 && seg == 0)
                {
                    timer1.Stop();
                }
            }
            lblSegundos.Text = formatear(seg.ToString());
            lblMinutos.Text = formatear(min.ToString());
            lblHoras.Text = formatear(h.ToString());
        }
    }
}