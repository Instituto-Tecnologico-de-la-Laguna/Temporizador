namespace Temporizador
{
    partial class frmEstablecer
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
            label1 = new Label();
            txtSegundos = new TextBox();
            txtMinutos = new TextBox();
            label2 = new Label();
            txtHoras = new TextBox();
            label3 = new Label();
            btnAceptar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 13);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 0;
            label1.Text = "Segundos";
            // 
            // txtSegundos
            // 
            txtSegundos.Location = new Point(8, 30);
            txtSegundos.Margin = new Padding(2, 2, 2, 2);
            txtSegundos.Name = "txtSegundos";
            txtSegundos.Size = new Size(106, 23);
            txtSegundos.TabIndex = 1;
            // 
            // txtMinutos
            // 
            txtMinutos.Location = new Point(8, 75);
            txtMinutos.Margin = new Padding(2, 2, 2, 2);
            txtMinutos.Name = "txtMinutos";
            txtMinutos.Size = new Size(106, 23);
            txtMinutos.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 58);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 2;
            label2.Text = "Minutos";
            // 
            // txtHoras
            // 
            txtHoras.Location = new Point(8, 119);
            txtHoras.Margin = new Padding(2, 2, 2, 2);
            txtHoras.Name = "txtHoras";
            txtHoras.Size = new Size(106, 23);
            txtHoras.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 103);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 4;
            label3.Text = "Horas";
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = SystemColors.ActiveCaption;
            btnAceptar.DialogResult = DialogResult.OK;
            btnAceptar.Location = new Point(150, 53);
            btnAceptar.Margin = new Padding(2, 2, 2, 2);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(78, 25);
            btnAceptar.TabIndex = 4;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = SystemColors.ActiveCaption;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(150, 82);
            btnCancelar.Margin = new Padding(2, 2, 2, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(78, 25);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // frmEstablecer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(246, 153);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(txtHoras);
            Controls.Add(label3);
            Controls.Add(txtMinutos);
            Controls.Add(label2);
            Controls.Add(txtSegundos);
            Controls.Add(label1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "frmEstablecer";
            Text = "Tiempo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtSegundos;
        private TextBox txtMinutos;
        private Label label2;
        private TextBox txtHoras;
        private Label label3;
        private Button btnAceptar;
        private Button btnCancelar;
    }
}