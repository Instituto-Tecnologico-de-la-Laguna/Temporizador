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
            label5 = new Label();
            label4 = new Label();
            lblSegundos = new Label();
            lblMinutos = new Label();
            lblHoras = new Label();
            btnEstablecer = new Button();
            button2 = new Button();
            btnRegresiva = new Button();
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
            btnEstablecer.Margin = new Padding(2, 2, 2, 2);
            btnEstablecer.Name = "btnEstablecer";
            btnEstablecer.Size = new Size(78, 41);
            btnEstablecer.TabIndex = 12;
            btnEstablecer.Text = "Establecer Tiempo";
            btnEstablecer.UseVisualStyleBackColor = true;
            btnEstablecer.Click += btnEstablecer_Click;
            // 
            // button2
            // 
            button2.Location = new Point(284, 138);
            button2.Margin = new Padding(2, 2, 2, 2);
            button2.Name = "button2";
            button2.Size = new Size(78, 41);
            button2.TabIndex = 13;
            button2.Text = "Iniciar";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnRegresiva
            // 
            btnRegresiva.Location = new Point(235, 208);
            btnRegresiva.Margin = new Padding(2);
            btnRegresiva.Name = "btnRegresiva";
            btnRegresiva.Size = new Size(78, 41);
            btnRegresiva.TabIndex = 14;
            btnRegresiva.Text = "Cuenta Regresiva";
            btnRegresiva.UseVisualStyleBackColor = true;
            btnRegresiva.Click += button1_Click;
            // 
            // frmRegresiva
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 288);
            Controls.Add(btnRegresiva);
            Controls.Add(button2);
            Controls.Add(btnEstablecer);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(lblSegundos);
            Controls.Add(lblMinutos);
            Controls.Add(lblHoras);
            Margin = new Padding(2, 2, 2, 2);
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
        private Button button2;
        private Button btnRegresiva;
    }
}