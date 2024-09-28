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
        int segundo;
        int minuto;
        int hora;
        bool bandera = false;
        frmEstablecer establecer = new frmEstablecer();
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
            int segundo = 0, minuto = 1, hora = 2;

            if (minuto < 0)
            {
                hora--;
                minuto = 59;
                hora = establecer.tiempo[2];
            }
            if (segundo < 0)
            {
                minuto--;
                segundo = 59;
                segundo = establecer.tiempo[0];
            }
            
            
            if (segundo < 10)
                lblSegundos.Text = "0" + segundo.ToString();
            else
                lblSegundos.Text = segundo.ToString();
            
            if (hora < 10)
                lblHoras.Text = "0" + hora.ToString();
            else
                lblHoras.Text = hora.ToString();
            
            if(minuto < 10)
                lblMinutos.Text = "0" + minuto.ToString();
            else
                lblMinutos.Text = minuto.ToString();
            

            if(hora == 0 && minuto == 0 && segundo == 0)
            {
                return;
            }

            segundo--;
        }
    }
}