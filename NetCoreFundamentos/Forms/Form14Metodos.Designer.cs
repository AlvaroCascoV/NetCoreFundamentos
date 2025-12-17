namespace NetCoreFundamentos.Forms
{
    partial class Form14Metodos
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
            btnDobleValor = new Button();
            btnDobleReferencia = new Button();
            txtNumero = new TextBox();
            lblResultado = new Label();
            btnObjetoReferencia = new Button();
            lblRaton = new Label();
            txtSoloNumeros = new TextBox();
            txtSoloLetras = new TextBox();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 61);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Número";
            // 
            // btnDobleValor
            // 
            btnDobleValor.Location = new Point(60, 159);
            btnDobleValor.Name = "btnDobleValor";
            btnDobleValor.Size = new Size(116, 41);
            btnDobleValor.TabIndex = 1;
            btnDobleValor.Text = "Doble Valor";
            btnDobleValor.UseVisualStyleBackColor = true;
            btnDobleValor.Click += btnDobleValor_Click;
            // 
            // btnDobleReferencia
            // 
            btnDobleReferencia.Location = new Point(60, 194);
            btnDobleReferencia.Name = "btnDobleReferencia";
            btnDobleReferencia.Size = new Size(116, 44);
            btnDobleReferencia.TabIndex = 2;
            btnDobleReferencia.Text = "Doble Referencia";
            btnDobleReferencia.UseVisualStyleBackColor = true;
            btnDobleReferencia.Click += btnDobleReferencia_Click;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(60, 79);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(100, 23);
            txtNumero.TabIndex = 3;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(60, 125);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(72, 15);
            lblResultado.TabIndex = 4;
            lblResultado.Text = "lblResultado";
            // 
            // btnObjetoReferencia
            // 
            btnObjetoReferencia.Location = new Point(60, 232);
            btnObjetoReferencia.Name = "btnObjetoReferencia";
            btnObjetoReferencia.Size = new Size(116, 43);
            btnObjetoReferencia.TabIndex = 5;
            btnObjetoReferencia.Text = "Objeto Referencia";
            btnObjetoReferencia.UseVisualStyleBackColor = true;
            btnObjetoReferencia.Click += btnObjetoReferencia_Click;
            // 
            // lblRaton
            // 
            lblRaton.BackColor = Color.FromArgb(128, 255, 128);
            lblRaton.Location = new Point(196, 141);
            lblRaton.Name = "lblRaton";
            lblRaton.Size = new Size(255, 134);
            lblRaton.TabIndex = 6;
            lblRaton.Text = "lblRaton";
            lblRaton.TextAlign = ContentAlignment.MiddleCenter;
            lblRaton.MouseMove += lblRaton_MouseMove;
            // 
            // txtSoloNumeros
            // 
            txtSoloNumeros.Location = new Point(280, 79);
            txtSoloNumeros.Name = "txtSoloNumeros";
            txtSoloNumeros.Size = new Size(100, 23);
            txtSoloNumeros.TabIndex = 7;
            txtSoloNumeros.KeyPress += txtSoloNumeros_KeyPress;
            // 
            // txtSoloLetras
            // 
            txtSoloLetras.Location = new Point(280, 108);
            txtSoloLetras.Name = "txtSoloLetras";
            txtSoloLetras.Size = new Size(100, 23);
            txtSoloLetras.TabIndex = 8;
            txtSoloLetras.KeyPress += txtSoloLetras_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(196, 82);
            label2.Name = "label2";
            label2.Size = new Size(80, 15);
            label2.TabIndex = 9;
            label2.Text = "Solo números";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(196, 111);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 10;
            label3.Text = "Solo letras";
            // 
            // Form14Metodos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtSoloLetras);
            Controls.Add(txtSoloNumeros);
            Controls.Add(lblRaton);
            Controls.Add(btnObjetoReferencia);
            Controls.Add(lblResultado);
            Controls.Add(txtNumero);
            Controls.Add(btnDobleReferencia);
            Controls.Add(btnDobleValor);
            Controls.Add(label1);
            Name = "Form14Metodos";
            Text = "Form14Metodos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnDobleValor;
        private Button btnDobleReferencia;
        private TextBox txtNumero;
        private Label lblResultado;
        private Button btnObjetoReferencia;
        private Label lblRaton;
        private TextBox txtSoloNumeros;
        private TextBox txtSoloLetras;
        private Label label2;
        private Label label3;
    }
}