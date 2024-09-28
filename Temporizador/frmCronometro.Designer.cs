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
            btnControl.Location = new Point(233, 170);
            btnControl.Margin = new Padding(2);
            btnControl.Name = "btnControl";
            btnControl.Size = new Size(90, 27);
            btnControl.TabIndex = 0;
            btnControl.Text = "Iniciar";
            btnControl.UseVisualStyleBackColor = true;
            btnControl.Click += btnControl_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(327, 170);
            btnReset.Margin = new Padding(2);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(90, 27);
            btnReset.TabIndex = 1;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // lblHoras
            // 
            lblHoras.AutoSize = true;
            lblHoras.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHoras.Location = new Point(-6, 9);
            lblHoras.Margin = new Padding(2, 0, 2, 0);
            lblHoras.Name = "lblHoras";
            lblHoras.Size = new Size(197, 159);
            lblHoras.TabIndex = 2;
            lblHoras.Text = "00";
            // 
            // lblMinutos
            // 
            lblMinutos.AutoSize = true;
            lblMinutos.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMinutos.Location = new Point(231, 9);
            lblMinutos.Margin = new Padding(2, 0, 2, 0);
            lblMinutos.Name = "lblMinutos";
            lblMinutos.Size = new Size(197, 159);
            lblMinutos.TabIndex = 3;
            lblMinutos.Text = "00";
            // 
            // lblSegundos
            // 
            lblSegundos.AutoSize = true;
            lblSegundos.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSegundos.Location = new Point(457, 9);
            lblSegundos.Margin = new Padding(2, 0, 2, 0);
            lblSegundos.Name = "lblSegundos";
            lblSegundos.Size = new Size(197, 159);
            lblSegundos.TabIndex = 4;
            lblSegundos.Text = "00";
            lblSegundos.Click += lblSegundos_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(155, -1);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(93, 159);
            label4.TabIndex = 5;
            label4.Text = ":";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(386, -1);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(93, 159);
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
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(647, 217);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(lblSegundos);
            Controls.Add(lblMinutos);
            Controls.Add(lblHoras);
            Controls.Add(btnReset);
            Controls.Add(btnControl);
            Margin = new Padding(2);
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