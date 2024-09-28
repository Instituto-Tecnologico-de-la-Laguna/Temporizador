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
            butIniciar = new Button();
            tiempo = new System.Windows.Forms.Timer(components);
            button1 = new Button();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(342, 8);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(75, 128);
            label5.TabIndex = 11;
            label5.Text = ":";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(141, 8);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(75, 128);
            label4.TabIndex = 10;
            label4.Text = ":";
            // 
            // lblSegundos
            // 
            lblSegundos.AutoSize = true;
            lblSegundos.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSegundos.Location = new Point(393, 16);
            lblSegundos.Margin = new Padding(2, 0, 2, 0);
            lblSegundos.Name = "lblSegundos";
            lblSegundos.Size = new Size(158, 128);
            lblSegundos.TabIndex = 9;
            lblSegundos.Text = "00";
            // 
            // lblMinutos
            // 
            lblMinutos.AutoSize = true;
            lblMinutos.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMinutos.Location = new Point(207, 16);
            lblMinutos.Margin = new Padding(2, 0, 2, 0);
            lblMinutos.Name = "lblMinutos";
            lblMinutos.Size = new Size(158, 128);
            lblMinutos.TabIndex = 8;
            lblMinutos.Text = "00";
            // 
            // lblHoras
            // 
            lblHoras.AutoSize = true;
            lblHoras.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHoras.Location = new Point(-1, 16);
            lblHoras.Margin = new Padding(2, 0, 2, 0);
            lblHoras.Name = "lblHoras";
            lblHoras.Size = new Size(158, 128);
            lblHoras.TabIndex = 7;
            lblHoras.Text = "00";
            // 
            // btnEstablecer
            // 
            btnEstablecer.Location = new Point(197, 138);
            btnEstablecer.Margin = new Padding(2);
            btnEstablecer.Name = "btnEstablecer";
            btnEstablecer.Size = new Size(78, 41);
            btnEstablecer.TabIndex = 12;
            btnEstablecer.Text = "Establecer Tiempo";
            btnEstablecer.UseVisualStyleBackColor = true;
            btnEstablecer.Click += btnEstablecer_Click;
            // 
            // butIniciar
            // 
            butIniciar.Location = new Point(284, 138);
            butIniciar.Margin = new Padding(2);
            butIniciar.Name = "butIniciar";
            butIniciar.Size = new Size(78, 41);
            butIniciar.TabIndex = 13;
            butIniciar.Text = "Iniciar";
            butIniciar.UseVisualStyleBackColor = true;
            butIniciar.Click += button2_Click;
            // 
            // tiempo
            // 
            tiempo.Interval = 1000;
            tiempo.Tick += tiempo_Tick;
            // 
            // button1
            // 
            button1.Location = new Point(367, 138);
            button1.Name = "button1";
            button1.Size = new Size(75, 41);
            button1.TabIndex = 14;
            button1.Text = "Restablecer";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frmRegresiva
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 194);
            Controls.Add(button1);
            Controls.Add(butIniciar);
            Controls.Add(btnEstablecer);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(lblSegundos);
            Controls.Add(lblMinutos);
            Controls.Add(lblHoras);
            Margin = new Padding(2);
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
        private Button butIniciar;
        private System.Windows.Forms.Timer tiempo;
        private Button button1;
    }
}