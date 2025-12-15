namespace NetCoreFundamentos.Forms
{
    partial class Form07SumarString
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
            btnSumarNumeros = new Button();
            txtNumeros = new TextBox();
            label1 = new Label();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // btnSumarNumeros
            // 
            btnSumarNumeros.Location = new Point(56, 108);
            btnSumarNumeros.Name = "btnSumarNumeros";
            btnSumarNumeros.Size = new Size(178, 23);
            btnSumarNumeros.TabIndex = 0;
            btnSumarNumeros.Text = "Sumar números";
            btnSumarNumeros.UseVisualStyleBackColor = true;
            btnSumarNumeros.Click += btnSumar_Click;
            // 
            // txtNumeros
            // 
            txtNumeros.Location = new Point(56, 69);
            txtNumeros.Name = "txtNumeros";
            txtNumeros.Size = new Size(188, 23);
            txtNumeros.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 41);
            label1.Name = "label1";
            label1.Size = new Size(113, 15);
            label1.TabIndex = 2;
            label1.Text = "Introduzca números";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.ForeColor = SystemColors.HotTrack;
            lblResultado.Location = new Point(56, 144);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(0, 15);
            lblResultado.TabIndex = 3;
            // 
            // Form07SumarString
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResultado);
            Controls.Add(label1);
            Controls.Add(txtNumeros);
            Controls.Add(btnSumarNumeros);
            Name = "Form07SumarString";
            Text = "Form07SumarString";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSumarNumeros;
        private TextBox txtNumeros;
        private Label label1;
        private Label lblResultado;
    }
}