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
    public partial class frmCronometro : Form
    {
        public frmCronometro()
        {
            InitializeComponent();
        }
        int segundo = 0, minuto = 0, hora = 0;
        bool bandera = false;
        private void tmrCronometro_Tick(object sender, EventArgs e)
        {

            segundo++;
            if (segundo < 10)
                lblSegundos.Text = "0" + segundo.ToString();
            else
                lblSegundos.Text = segundo.ToString();

            if (segundo == 59)
            {
                minuto++;
                segundo = 0;
                if (minuto < 10)
                    lblMinutos.Text = "0" + minuto.ToString();
                else
                    lblMinutos.Text = minuto.ToString();
            }
            if (minuto == 59)
            {
                hora++;
                minuto = 0;
                if (hora < 10)
                    lblHoras.Text = "0" + hora.ToString();
                else
                    lblHoras.Text = hora.ToString();
            }


        }

        private void btnControl_Click(object sender, EventArgs e)
        {
            if (bandera == false)
            {
                bandera = true;
                tmrCronometro.Enabled = true;
                btnControl.Text = "Detener";
            }
            else
            {
                bandera = false;
                tmrCronometro.Enabled = false;
                btnControl.Text = "Iniciar";
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            segundo = 0;
            minuto = 0;
            hora = 0;
            lblSegundos.Text = "00";
            lblMinutos.Text = "00";
            lblHoras.Text = "00";
        }
    }
}
