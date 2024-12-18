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

            try
            {
                int segundos = int.Parse(txtSegundos.Text);
                int minutos = int.Parse(txtMinutos.Text);
                int horas = int.Parse(txtHoras.Text);

                if (segundos < 0 || segundos > 59 || minutos < 0 || minutos > 59 || horas < 0)
                {
                    MessageBox.Show("Por favor, ingresa valores válidos:\n- Segundos (0-59)\n- Minutos (0-59)\n- Horas (0 o más)");
                    return;
                }

                tiempo.Clear();
                tiempo.Add(segundos);
                tiempo.Add(minutos);
                tiempo.Add(horas);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingresa solo números en los campos.");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel; // Indicamos que el usuario canceló
            this.Close();
        }
    }
}
