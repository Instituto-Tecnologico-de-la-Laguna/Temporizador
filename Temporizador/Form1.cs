namespace Temporizador
{
    public partial class frmReloj : Form
    {
        public frmReloj()
        {
            InitializeComponent();
        }

        private void tmrTemporizador_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            toolStripStatusLabelFecha.Text = DateTime.Now.ToShortDateString();
        }
    }
}
