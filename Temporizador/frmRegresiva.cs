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
        private int tiempoRestante;
        private Thread hiloTemporizador;
        private bool enEjecucion = false;

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

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (enEjecucion) return;

            // Obtener el tiempo ingresado por el usuario
            if (int.TryParse(lblHoras.Text, out tiempoRestante) && tiempoRestante > 0)
            {
                enEjecucion = true;
                hiloTemporizador = new Thread(IniciarCuentaRegresiva);
                hiloTemporizador.Start();
            }
            else
            {
                MessageBox.Show("Ingrese un tiempo válido en segundos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void IniciarCuentaRegresiva()
        {
            while (tiempoRestante > 0 && enEjecucion)
            {
                Invoke(new Action(() => lblMinutos.Text = tiempoRestante.ToString()));
                Thread.Sleep(1000);
                tiempoRestante--;
            }

            if (tiempoRestante == 0)
            {
                Invoke(new Action(() =>
                {
                    lblSegundos.Text = "¡Tiempo terminado!";
                    MessageBox.Show("La cuenta regresiva ha finalizado.", "Aviso");
                }));
            }

            enEjecucion = false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // Detener el temporizador y reiniciar sus valores
            enEjecucion = false;
            tiempoRestante = 0;
            if (hiloTemporizador != null && hiloTemporizador.IsAlive)
                hiloTemporizador.Join(); // Espera a que el hilo termine

            lblHoras.Text = "00";
            lblMinutos.Text = "";
        }
    }
}