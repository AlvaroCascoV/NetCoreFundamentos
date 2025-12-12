namespace NetCoreFundamentos.Forms
{
    partial class Form02ColoresPosicion
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
            txtPosicionY = new TextBox();
            txtColorRojo = new TextBox();
            txtPosicionX = new TextBox();
            txtColorVerde = new TextBox();
            txtColorAzul = new TextBox();
            btnCambiarPosicion = new Button();
            btnCambiarFondo = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // txtPosicionY
            // 
            txtPosicionY.Location = new Point(31, 119);
            txtPosicionY.Name = "txtPosicionY";
            txtPosicionY.Size = new Size(100, 23);
            txtPosicionY.TabIndex = 0;
            // 
            // txtColorRojo
            // 
            txtColorRojo.Location = new Point(321, 40);
            txtColorRojo.Name = "txtColorRojo";
            txtColorRojo.Size = new Size(100, 23);
            txtColorRojo.TabIndex = 1;
            // 
            // txtPosicionX
            // 
            txtPosicionX.Location = new Point(31, 61);
            txtPosicionX.Name = "txtPosicionX";
            txtPosicionX.Size = new Size(100, 23);
            txtPosicionX.TabIndex = 2;
            // 
            // txtColorVerde
            // 
            txtColorVerde.Location = new Point(321, 79);
            txtColorVerde.Name = "txtColorVerde";
            txtColorVerde.Size = new Size(100, 23);
            txtColorVerde.TabIndex = 3;
            // 
            // txtColorAzul
            // 
            txtColorAzul.Location = new Point(321, 119);
            txtColorAzul.Name = "txtColorAzul";
            txtColorAzul.Size = new Size(100, 23);
            txtColorAzul.TabIndex = 4;
            // 
            // btnCambiarPosicion
            // 
            btnCambiarPosicion.Location = new Point(31, 148);
            btnCambiarPosicion.Name = "btnCambiarPosicion";
            btnCambiarPosicion.Size = new Size(100, 49);
            btnCambiarPosicion.TabIndex = 5;
            btnCambiarPosicion.Text = "Cambiar posicion";
            btnCambiarPosicion.UseVisualStyleBackColor = true;
            btnCambiarPosicion.Click += btnCambiarPosicion_Click;
            // 
            // btnCambiarFondo
            // 
            btnCambiarFondo.Location = new Point(321, 148);
            btnCambiarFondo.Name = "btnCambiarFondo";
            btnCambiarFondo.Size = new Size(100, 55);
            btnCambiarFondo.TabIndex = 6;
            btnCambiarFondo.Text = "Cambiar fondo";
            btnCambiarFondo.UseVisualStyleBackColor = true;
            btnCambiarFondo.Click += btnCambiarFondo_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 43);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 7;
            label1.Text = "Posicion X";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 101);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 8;
            label2.Text = "Posicion Y";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(279, 48);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 9;
            label3.Text = "Rojo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(279, 82);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 10;
            label4.Text = "Verde";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(280, 122);
            label5.Name = "label5";
            label5.Size = new Size(30, 15);
            label5.TabIndex = 11;
            label5.Text = "Azul";
            // 
            // Form02ColoresPosicion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCambiarFondo);
            Controls.Add(btnCambiarPosicion);
            Controls.Add(txtColorAzul);
            Controls.Add(txtColorVerde);
            Controls.Add(txtPosicionX);
            Controls.Add(txtColorRojo);
            Controls.Add(txtPosicionY);
            Name = "Form02ColoresPosicion";
            Text = "Form02ColoresPosicion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPosicionY;
        private TextBox txtColorRojo;
        private TextBox txtPosicionX;
        private TextBox txtColorVerde;
        private TextBox txtColorAzul;
        private Button btnCambiarPosicion;
        private Button btnCambiarFondo;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}