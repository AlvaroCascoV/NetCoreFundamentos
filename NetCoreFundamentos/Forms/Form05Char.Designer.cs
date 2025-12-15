namespace NetCoreFundamentos.Forms
{
    partial class Form05Char
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
            txtLetras = new TextBox();
            txtNumeros = new TextBox();
            label2 = new Label();
            txtSimbolos = new TextBox();
            label3 = new Label();
            txtPuntuacion = new TextBox();
            label4 = new Label();
            btnAscii = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(69, 29);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "Letras";
            // 
            // txtLetras
            // 
            txtLetras.Location = new Point(69, 47);
            txtLetras.Multiline = true;
            txtLetras.Name = "txtLetras";
            txtLetras.Size = new Size(171, 89);
            txtLetras.TabIndex = 1;
            // 
            // txtNumeros
            // 
            txtNumeros.Location = new Point(287, 47);
            txtNumeros.Multiline = true;
            txtNumeros.Name = "txtNumeros";
            txtNumeros.Size = new Size(171, 89);
            txtNumeros.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(287, 29);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 2;
            label2.Text = "Números";
            // 
            // txtSimbolos
            // 
            txtSimbolos.Location = new Point(69, 167);
            txtSimbolos.Multiline = true;
            txtSimbolos.Name = "txtSimbolos";
            txtSimbolos.Size = new Size(171, 89);
            txtSimbolos.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(69, 149);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 4;
            label3.Text = "Símbolos";
            // 
            // txtPuntuacion
            // 
            txtPuntuacion.Location = new Point(287, 167);
            txtPuntuacion.Multiline = true;
            txtPuntuacion.Name = "txtPuntuacion";
            txtPuntuacion.Size = new Size(171, 89);
            txtPuntuacion.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(287, 149);
            label4.Name = "label4";
            label4.Size = new Size(68, 15);
            label4.TabIndex = 6;
            label4.Text = "Puntuación";
            // 
            // btnAscii
            // 
            btnAscii.Location = new Point(197, 280);
            btnAscii.Name = "btnAscii";
            btnAscii.Size = new Size(122, 38);
            btnAscii.TabIndex = 8;
            btnAscii.Text = "Run ASCII";
            btnAscii.UseVisualStyleBackColor = true;
            btnAscii.Click += btnAscii_Click;
            // 
            // Form05Char
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(536, 375);
            Controls.Add(btnAscii);
            Controls.Add(txtPuntuacion);
            Controls.Add(label4);
            Controls.Add(txtSimbolos);
            Controls.Add(label3);
            Controls.Add(txtNumeros);
            Controls.Add(label2);
            Controls.Add(txtLetras);
            Controls.Add(label1);
            Name = "Form05Char";
            Text = "Form05Char";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtLetras;
        private TextBox txtNumeros;
        private Label label2;
        private TextBox txtSimbolos;
        private Label label3;
        private TextBox txtPuntuacion;
        private Label label4;
        private Button btnAscii;
    }
}