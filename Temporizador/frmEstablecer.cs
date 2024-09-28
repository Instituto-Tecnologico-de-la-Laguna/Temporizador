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
            /* primero verifico si escribió algo en el txtField.
               Si no escribió nada lo tomo como un cero.
               Si escribió algo verifico que sea un número entre 0 y 59.
               Si no es un número entre 0 y 59, manda un msgBox indicando donde está el error,
               Deja el número actual que tiene la lista en el lbl, hay que resetear antes de agregar un número nuevo
               */

            if (txtSegundos.Text.Length > 0)
            {
                int segundos = int.Parse(txtSegundos.Text);
                if (segundos >= 0 && segundos < 60)
                {
                    tiempo.Add(segundos);
                }
                else
                {
                    MessageBox.Show("Ingrese un número entre 0 y 59", "Segundos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tiempo.Add(0);
                }
            }
            else
                tiempo.Add(0);

            if (txtMinutos.Text.Length > 0)
            {
                int minutos = int.Parse(txtMinutos.Text);
                if (minutos >= 0 && minutos < 60)
                {
                    tiempo.Add(minutos);
                }
                else
                {
                    MessageBox.Show("Ingrese un Número entre 0 y 59", "Minutos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tiempo.Add(0);
                }
            }
            else
                tiempo.Add(0);

            if (txtHoras.Text.Length > 0)
            {
                int horas = int.Parse(txtHoras.Text);
                if (horas >= 0 && horas < 60)
                {
                    tiempo.Add(horas);
                }
                else
                {
                    MessageBox.Show("Ingrese un número entre 0 y 59", "Horas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tiempo.Add(0);
                }
            }
            else
                tiempo.Add(0);

            //tiempo.Add(int.Parse(txtSegundos.Text));
            //tiempo.Add(int.Parse(txtMinutos.Text));
            //tiempo.Add(int.Parse(txtHoras.Text));

            // pongo los txtfields en blanco para que al volver a abrir el frm establecer no estén los 
            //números anteriores
            txtSegundos.Text = "";
            txtMinutos.Text = "";
            txtHoras.Text = "";
            this.Close();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
