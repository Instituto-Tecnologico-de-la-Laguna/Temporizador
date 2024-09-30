namespace Temporizador
{
    partial class frmCronometro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btnControl = new Button();
            btnReset = new Button();
            lblHoras = new Label();
            lblMinutos = new Label();
            lblSegundos = new Label();
            label4 = new Label();
            label5 = new Label();
            tmrCronometro = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // btnControl
            // 
            btnControl.BackColor = SystemColors.ButtonShadow;
            btnControl.Location = new Point(207, 171);
            btnControl.Margin = new Padding(2, 2, 2, 2);
            btnControl.Name = "btnControl";
            btnControl.Size = new Size(78, 20);
            btnControl.TabIndex = 0;
            btnControl.Text = "Iniciar";
            btnControl.UseVisualStyleBackColor = false;
            btnControl.Click += btnControl_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = SystemColors.ControlDark;
            btnReset.Location = new Point(302, 171);
            btnReset.Margin = new Padding(2, 2, 2, 2);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(78, 20);
            btnReset.TabIndex = 1;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // lblHoras
            // 
            lblHoras.AutoSize = true;
            lblHoras.BackColor = SystemColors.ActiveCaption;
            lblHoras.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHoras.Location = new Point(8, 32);
            lblHoras.Margin = new Padding(2, 0, 2, 0);
            lblHoras.Name = "lblHoras";
            lblHoras.Size = new Size(158, 128);
            lblHoras.TabIndex = 2;
            lblHoras.Text = "00";
            // 
            // lblMinutos
            // 
            lblMinutos.AutoSize = true;
            lblMinutos.BackColor = SystemColors.ActiveCaption;
            lblMinutos.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMinutos.Location = new Point(216, 32);
            lblMinutos.Margin = new Padding(2, 0, 2, 0);
            lblMinutos.Name = "lblMinutos";
            lblMinutos.Size = new Size(158, 128);
            lblMinutos.TabIndex = 3;
            lblMinutos.Text = "00";
            // 
            // lblSegundos
            // 
            lblSegundos.AutoSize = true;
            lblSegundos.BackColor = SystemColors.ActiveCaption;
            lblSegundos.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSegundos.Location = new Point(402, 32);
            lblSegundos.Margin = new Padding(2, 0, 2, 0);
            lblSegundos.Name = "lblSegundos";
            lblSegundos.Size = new Size(158, 128);
            lblSegundos.TabIndex = 4;
            lblSegundos.Text = "00";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaption;
            label4.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(149, 32);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(75, 128);
            label4.TabIndex = 5;
            label4.Text = ":";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ActiveCaption;
            label5.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(352, 32);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(75, 128);
            label5.TabIndex = 6;
            label5.Text = ":";
            // 
            // tmrCronometro
            // 
            tmrCronometro.Interval = 200;
            tmrCronometro.Tick += tmrCronometro_Tick;
            // 
            // frmCronometro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(566, 209);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(lblSegundos);
            Controls.Add(lblMinutos);
            Controls.Add(lblHoras);
            Controls.Add(btnReset);
            Controls.Add(btnControl);
            Margin = new Padding(2, 2, 2, 2);
            Name = "frmCronometro";
            Text = "Cronometro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnControl;
        private Button btnReset;
        private Label lblHoras;
        private Label lblMinutos;
        private Label lblSegundos;
        private Label label4;
        private Label label5;
        private System.Windows.Forms.Timer tmrCronometro;
    }
}