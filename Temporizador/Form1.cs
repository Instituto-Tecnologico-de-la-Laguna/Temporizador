namespace Temporizador
{
    public partial class frmReloj : Form
    {
        private int tiempoRestante;
        private object nudSegundos;

        public frmReloj()
        {
            InitializeComponent();
        }

        private void tmrTemporizador_Tick(object sender, EventArgs e)
        {
            if (tiempoRestante > 0)
            {
                lblHora.Text = DateTime.Now.ToLongTimeString();
                toolStripStatusLabelFecha.Text = DateTime.Now.ToShortDateString();
            }
            else
                tmrTemporizador.Stop(); // Detiene el temporizador
            lblHora.Text = "¡Tiempo terminado!";
            MessageBox.Show("¡Tiempo terminado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void btnIniciar_Click(object sender, EventArgs e)
        {
            tiempoRestante = (int)nudSegundos ;
            lblHora.Text = tiempoRestante.ToString() + " segundos restantes";
            tmrTemporizador.Start();
        }
    }
    }
