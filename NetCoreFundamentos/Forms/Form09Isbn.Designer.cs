namespace NetCoreFundamentos.Forms
{
    partial class Form09Isbn
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
            lblISBN = new Label();
            txtISBN = new TextBox();
            btnValidar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 53);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 0;
            label1.Text = "Introduzca ISBN";
            // 
            // lblISBN
            // 
            lblISBN.AutoSize = true;
            lblISBN.Location = new Point(32, 151);
            lblISBN.Name = "lblISBN";
            lblISBN.Size = new Size(98, 15);
            lblISBN.TabIndex = 1;
            lblISBN.Text = "Espere validacion";
            // 
            // txtISBN
            // 
            txtISBN.Location = new Point(32, 75);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(189, 23);
            txtISBN.TabIndex = 2;
            // 
            // btnValidar
            // 
            btnValidar.Location = new Point(32, 114);
            btnValidar.Name = "btnValidar";
            btnValidar.Size = new Size(110, 23);
            btnValidar.TabIndex = 3;
            btnValidar.Text = "Validar ISBN";
            btnValidar.UseVisualStyleBackColor = true;
            btnValidar.Click += btnValidar_Click;
            // 
            // Form09Isbn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnValidar);
            Controls.Add(txtISBN);
            Controls.Add(lblISBN);
            Controls.Add(label1);
            Name = "Form09Isbn";
            Text = "Form09Isbn";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblISBN;
        private TextBox txtISBN;
        private Button btnValidar;
    }
}