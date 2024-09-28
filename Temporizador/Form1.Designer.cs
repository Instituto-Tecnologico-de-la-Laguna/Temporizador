namespace Temporizador
{
    partial class frmReloj
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblHora = new Label();
            tmrTemporizador = new System.Windows.Forms.Timer(components);
            statusStrip1 = new StatusStrip();
            toolStripStatusLabelFecha = new ToolStripStatusLabel();
            timer1 = new System.Windows.Forms.Timer(components);
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHora.Location = new Point(40, 19);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(461, 191);
            lblHora.TabIndex = 0;
            lblHora.Text = "label1";
            // 
            // tmrTemporizador
            // 
            tmrTemporizador.Enabled = true;
            tmrTemporizador.Interval = 1000;
            tmrTemporizador.Tick += tmrTemporizador_Tick;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(24, 24);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabelFecha });
            statusStrip1.Location = new Point(0, 254);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 32);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelFecha
            // 
            toolStripStatusLabelFecha.Name = "toolStripStatusLabelFecha";
            toolStripStatusLabelFecha.Size = new Size(179, 25);
            toolStripStatusLabelFecha.Text = "toolStripStatusLabel1";
            // 
            // frmReloj
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 286);
            Controls.Add(statusStrip1);
            Controls.Add(lblHora);
            Name = "frmReloj";
            Text = "Reloj";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHora;
        private System.Windows.Forms.Timer tmrTemporizador;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabelFecha;
        private System.Windows.Forms.Timer timer1;
    }
}
