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
    public partial class frmEstablecer : Form
    {
        public List<int> tiempo = new List<int>();
        public frmEstablecer()
        {
            InitializeComponent();

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            tiempo.Add(int.Parse(txtSegundos.Text));
            tiempo.Add(int.Parse(txtMinutos.Text));
            tiempo.Add(int.Parse(txtHoras.Text));
            this.Close();


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
