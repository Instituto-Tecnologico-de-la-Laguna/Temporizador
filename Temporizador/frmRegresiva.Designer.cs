namespace Temporizador
{
    partial class frmRegresiva
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
            label5 = new Label();
            label4 = new Label();
            lblSegundos = new Label();
            lblMinutos = new Label();
            lblHoras = new Label();
            btnEstablecer = new Button();
            btnControl = new Button();
            btnCancelar = new Button();
            tmrRegresiva = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(391, 11);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(93, 159);
            label5.TabIndex = 11;
            label5.Text = ":";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(161, 11);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(93, 159);
            label4.TabIndex = 10;
            label4.Text = ":";
            // 
            // lblSegundos
            // 
            lblSegundos.AutoSize = true;
            lblSegundos.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSegundos.Location = new Point(459, 21);
            lblSegundos.Margin = new Padding(2, 0, 2, 0);
            lblSegundos.Name = "lblSegundos";
            lblSegundos.Size = new Size(197, 159);
            lblSegundos.TabIndex = 9;
            lblSegundos.Text = "00";
            // 
            // lblMinutos
            // 
            lblMinutos.AutoSize = true;
            lblMinutos.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMinutos.Location = new Point(237, 21);
            lblMinutos.Margin = new Padding(2, 0, 2, 0);
            lblMinutos.Name = "lblMinutos";
            lblMinutos.Size = new Size(197, 159);
            lblMinutos.TabIndex = 8;
            lblMinutos.Text = "00";
            // 
            // lblHoras
            // 
            lblHoras.AutoSize = true;
            lblHoras.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHoras.Location = new Point(-1, 21);
            lblHoras.Margin = new Padding(2, 0, 2, 0);
            lblHoras.Name = "lblHoras";
            lblHoras.Size = new Size(197, 159);
            lblHoras.TabIndex = 7;
            lblHoras.Text = "00";
            // 
            // btnEstablecer
            // 
            btnEstablecer.Location = new Point(288, 183);
            btnEstablecer.Margin = new Padding(2, 3, 2, 3);
            btnEstablecer.Name = "btnEstablecer";
            btnEstablecer.Size = new Size(89, 55);
            btnEstablecer.TabIndex = 12;
            btnEstablecer.Text = "Establecer Tiempo";
            btnEstablecer.UseVisualStyleBackColor = true;
            btnEstablecer.Click += btnEstablecer_Click;
            // 
            // btnControl
            // 
            btnControl.Location = new Point(540, 183);
            btnControl.Margin = new Padding(2, 3, 2, 3);
            btnControl.Name = "btnControl";
            btnControl.Size = new Size(89, 55);
            btnControl.TabIndex = 13;
            btnControl.Text = "Iniciar";
            btnControl.UseVisualStyleBackColor = true;
            btnControl.Click += button2_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(11, 183);
            btnCancelar.Margin = new Padding(2, 3, 2, 3);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(89, 55);
            btnCancelar.TabIndex = 14;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // tmrRegresiva
            // 
            tmrRegresiva.Interval = 200;
            tmrRegresiva.Tick += tmrRegresiva_Tick;
            // 
            // frmRegresiva
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 259);
            Controls.Add(btnCancelar);
            Controls.Add(btnControl);
            Controls.Add(btnEstablecer);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(lblSegundos);
            Controls.Add(lblMinutos);
            Controls.Add(lblHoras);
            Margin = new Padding(2, 3, 2, 3);
            Name = "frmRegresiva";
            Text = "Cuenta Regresiva";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label label4;
        private Label lblSegundos;
        private Label lblMinutos;
        private Label lblHoras;
        private Button btnEstablecer;
        private Button btnControl;
        private Button btnCancelar;
        private System.Windows.Forms.Timer tmrRegresiva;
    }
}