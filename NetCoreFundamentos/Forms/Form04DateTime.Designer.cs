namespace NetCoreFundamentos.Forms
{
    partial class Form04DateTime
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
            txtFechaActual = new TextBox();
            chkFormato = new CheckBox();
            radioDias = new RadioButton();
            radioAnyos = new RadioButton();
            radioMeses = new RadioButton();
            txtIncremento = new TextBox();
            label2 = new Label();
            btnIncremento = new Button();
            label3 = new Label();
            txtFechaFinal = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(116, 75);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 0;
            label1.Text = "Fecha Actual";
            // 
            // txtFechaActual
            // 
            txtFechaActual.Location = new Point(116, 93);
            txtFechaActual.Name = "txtFechaActual";
            txtFechaActual.Size = new Size(250, 23);
            txtFechaActual.TabIndex = 1;
            // 
            // chkFormato
            // 
            chkFormato.AutoSize = true;
            chkFormato.Location = new Point(116, 135);
            chkFormato.Name = "chkFormato";
            chkFormato.Size = new Size(119, 19);
            chkFormato.TabIndex = 2;
            chkFormato.Text = "Cambiar Formato";
            chkFormato.UseVisualStyleBackColor = true;
            chkFormato.CheckedChanged += chkFormato_CheckedChanged;
            // 
            // radioDias
            // 
            radioDias.AutoSize = true;
            radioDias.Location = new Point(116, 157);
            radioDias.Name = "radioDias";
            radioDias.Size = new Size(47, 19);
            radioDias.TabIndex = 3;
            radioDias.TabStop = true;
            radioDias.Text = "Días";
            radioDias.UseVisualStyleBackColor = true;
            // 
            // radioAnyos
            // 
            radioAnyos.AutoSize = true;
            radioAnyos.Location = new Point(116, 207);
            radioAnyos.Name = "radioAnyos";
            radioAnyos.Size = new Size(52, 19);
            radioAnyos.TabIndex = 5;
            radioAnyos.TabStop = true;
            radioAnyos.Text = "Años";
            radioAnyos.UseVisualStyleBackColor = true;
            // 
            // radioMeses
            // 
            radioMeses.AutoSize = true;
            radioMeses.Location = new Point(116, 182);
            radioMeses.Name = "radioMeses";
            radioMeses.Size = new Size(58, 19);
            radioMeses.TabIndex = 6;
            radioMeses.TabStop = true;
            radioMeses.Text = "Meses";
            radioMeses.UseVisualStyleBackColor = true;
            // 
            // txtIncremento
            // 
            txtIncremento.Location = new Point(266, 178);
            txtIncremento.Name = "txtIncremento";
            txtIncremento.Size = new Size(100, 23);
            txtIncremento.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(192, 184);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 8;
            label2.Text = "Incremento";
            // 
            // btnIncremento
            // 
            btnIncremento.Location = new Point(192, 207);
            btnIncremento.Name = "btnIncremento";
            btnIncremento.Size = new Size(174, 23);
            btnIncremento.TabIndex = 9;
            btnIncremento.Text = "Incrementar";
            btnIncremento.UseVisualStyleBackColor = true;
            btnIncremento.Click += btnIncremento_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(116, 247);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 10;
            label3.Text = "Fecha final";
            // 
            // txtFechaFinal
            // 
            txtFechaFinal.Location = new Point(116, 265);
            txtFechaFinal.Name = "txtFechaFinal";
            txtFechaFinal.Size = new Size(250, 23);
            txtFechaFinal.TabIndex = 11;
            // 
            // Form04DateTime
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtFechaFinal);
            Controls.Add(label3);
            Controls.Add(btnIncremento);
            Controls.Add(label2);
            Controls.Add(txtIncremento);
            Controls.Add(radioMeses);
            Controls.Add(radioAnyos);
            Controls.Add(radioDias);
            Controls.Add(chkFormato);
            Controls.Add(txtFechaActual);
            Controls.Add(label1);
            Name = "Form04DateTime";
            Text = "Form04DateTime";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtFechaActual;
        private CheckBox chkFormato;
        private RadioButton radioDias;
        private RadioButton radioAnyos;
        private RadioButton radioMeses;
        private TextBox txtIncremento;
        private Label label2;
        private Button btnIncremento;
        private Label label3;
        private TextBox txtFechaFinal;
    }
}