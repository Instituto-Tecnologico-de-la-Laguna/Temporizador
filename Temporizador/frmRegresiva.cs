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

        private void btnEstablecer_Click(object sender, EventArgs e)
        {

            DialogResult resultado;
            frmEstablecer establecer = new frmEstablecer();
            resultado = establecer.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                lblSegundos.Text = formatear(establecer.tiempo[0].ToString());
                lblMinutos.Text = formatear( establecer.tiempo[1].ToString());
                lblHoras.Text =formatear( establecer.tiempo[2].ToString());
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
    }
}