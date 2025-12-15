namespace NetCoreFundamentos.Forms
{
    partial class Form03DiaNacimiento
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblResultado = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            txtDia = new TextBox();
            txtMes = new TextBox();
            txtAno = new TextBox();
            btnFecha = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(71, 67);
            label1.Name = "label1";
            label1.Size = new Size(24, 15);
            label1.TabIndex = 0;
            label1.Text = "Día";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(71, 102);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 1;
            label2.Text = "Mes";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(71, 138);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 2;
            label3.Text = "Año";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.ForeColor = Color.DodgerBlue;
            lblResultado.Location = new Point(71, 207);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(124, 15);
            lblResultado.TabIndex = 3;
            lblResultado.Text = "El día de la semana es ";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // txtDia
            // 
            txtDia.Location = new Point(117, 59);
            txtDia.Name = "txtDia";
            txtDia.Size = new Size(100, 23);
            txtDia.TabIndex = 5;
            // 
            // txtMes
            // 
            txtMes.Location = new Point(117, 94);
            txtMes.Name = "txtMes";
            txtMes.Size = new Size(100, 23);
            txtMes.TabIndex = 6;
            // 
            // txtAno
            // 
            txtAno.Location = new Point(117, 130);
            txtAno.Name = "txtAno";
            txtAno.Size = new Size(100, 23);
            txtAno.TabIndex = 7;
            // 
            // btnFecha
            // 
            btnFecha.Location = new Point(117, 169);
            btnFecha.Name = "btnFecha";
            btnFecha.Size = new Size(100, 23);
            btnFecha.TabIndex = 8;
            btnFecha.Text = "Mostrar día";
            btnFecha.UseVisualStyleBackColor = true;
            btnFecha.Click += btnFecha_click;
            // 
            // Form03DiaNacimiento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnFecha);
            Controls.Add(txtAno);
            Controls.Add(txtMes);
            Controls.Add(txtDia);
            Controls.Add(lblResultado);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form03DiaNacimiento";
            Text = "Form03DiaNacimiento";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblResultado;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox txtDia;
        private TextBox txtMes;
        private TextBox txtAno;
        private Button btnFecha;
    }
}