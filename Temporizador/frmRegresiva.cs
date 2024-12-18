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
    using System;
    using System.Windows.Forms;

    public partial class frmRegresiva : Form
    {
        private Timer timer1; // Temporizador para la cuenta regresiva
        private int horas, minutos, segundos; // Variables para almacenar el tiempo

        public frmRegresiva()
        {
            InitializeComponent();

            // Configuración del temporizador
            timer1 = new Timer();
            timer1.Interval = 1000; // Intervalo de 1 segundo
            timer1.Tick += Timer_Tick; // Asociamos el evento Timer_Tick al temporizador
        }

        private void btnEstablecer_Click(object sender, EventArgs e)
        {
            frmEstablecer establecer = new frmEstablecer();
            if (establecer.ShowDialog() == DialogResult.OK) // Solo procesamos si el usuario presionó "Aceptar"
            {
                // Asignamos los valores establecidos
                segundos = establecer.tiempo[0];
                minutos = establecer.tiempo[1];
                horas = establecer.tiempo[2];

                // Actualizamos las etiquetas del formulario principal
                lblSegundos.Text = formatear(segundos.ToString());
                lblMinutos.Text = formatear(minutos.ToString());
                lblHoras.Text = formatear(horas.ToString());
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (horas > 0 || minutos > 0 || segundos > 0)
            {
                timer1.Start(); // Iniciamos el temporizador
            }
            else
            {
                MessageBox.Show("Por favor, establece un tiempo válido antes de iniciar.");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            timer1.Stop(); // Detenemos el temporizador
            lblSegundos.Text = "00";
            lblMinutos.Text = "00";
            lblHoras.Text = "00";
            horas = minutos = segundos = 0; // Reiniciamos las variables
        }


        private string formatear(string numero)
        {
            return numero.Length == 1 ? "0" + numero : numero;
        }



        private void Timer_Tick(object sender, EventArgs e)
        {
            if (segundos > 0)
            {
                segundos--;
            }
            else if (minutos > 0)
            {
                minutos--;
                segundos = 59;
            }
            else if (horas > 0)
            {
                horas--;
                minutos = 59;
                segundos = 59;
            }
            else
            {
                timer1.Stop(); // Detenemos el temporizador cuando llegue a 0
                MessageBox.Show("¡Tiempo finalizado!");
            }

            // Actualizamos las etiquetas en cada tick
            lblSegundos.Text = formatear(segundos.ToString());
            lblMinutos.Text = formatear(minutos.ToString());
            lblHoras.Text = formatear(horas.ToString());
        }
    }
}
