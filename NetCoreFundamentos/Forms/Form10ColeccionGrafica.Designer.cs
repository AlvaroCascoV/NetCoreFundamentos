namespace NetCoreFundamentos.Forms
{
    partial class Form10ColeccionGrafica
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
            lstElementos = new ListBox();
            label1 = new Label();
            label2 = new Label();
            txtNuevoElemento = new TextBox();
            btnInsert = new Button();
            btnEliminar = new Button();
            btnBorrarTodo = new Button();
            lblItem = new Label();
            lblIndex = new Label();
            SuspendLayout();
            // 
            // lstElementos
            // 
            lstElementos.FormattingEnabled = true;
            lstElementos.Location = new Point(86, 88);
            lstElementos.Name = "lstElementos";
            lstElementos.Size = new Size(122, 139);
            lstElementos.TabIndex = 0;
            lstElementos.SelectedIndexChanged += lstElementos_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(86, 61);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 1;
            label1.Text = "Elementos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(227, 61);
            label2.Name = "label2";
            label2.Size = new Size(95, 15);
            label2.TabIndex = 2;
            label2.Text = "Nuevo elemento";
            // 
            // txtNuevoElemento
            // 
            txtNuevoElemento.Location = new Point(227, 88);
            txtNuevoElemento.Name = "txtNuevoElemento";
            txtNuevoElemento.Size = new Size(112, 23);
            txtNuevoElemento.TabIndex = 3;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(227, 128);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(90, 23);
            btnInsert.TabIndex = 4;
            btnInsert.Text = "Insertar";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsertar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(227, 157);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(90, 23);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnBorrarTodo
            // 
            btnBorrarTodo.Location = new Point(227, 186);
            btnBorrarTodo.Name = "btnBorrarTodo";
            btnBorrarTodo.Size = new Size(90, 22);
            btnBorrarTodo.TabIndex = 6;
            btnBorrarTodo.Text = "Borrar Todo";
            btnBorrarTodo.UseVisualStyleBackColor = true;
            btnBorrarTodo.Click += btnBorrarTodo_Click;
            // 
            // lblItem
            // 
            lblItem.AutoSize = true;
            lblItem.Location = new Point(86, 239);
            lblItem.Name = "lblItem";
            lblItem.Size = new Size(44, 15);
            lblItem.TabIndex = 7;
            lblItem.Text = "lblItem";
            // 
            // lblIndex
            // 
            lblIndex.AutoSize = true;
            lblIndex.Location = new Point(86, 264);
            lblIndex.Name = "lblIndex";
            lblIndex.Size = new Size(49, 15);
            lblIndex.TabIndex = 8;
            lblIndex.Text = "lblIndex";
            // 
            // Form10ColeccionGrafica
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblIndex);
            Controls.Add(lblItem);
            Controls.Add(btnBorrarTodo);
            Controls.Add(btnEliminar);
            Controls.Add(btnInsert);
            Controls.Add(txtNuevoElemento);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lstElementos);
            Name = "Form10ColeccionGrafica";
            Text = "Form10ColeccionGrafica";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstElementos;
        private Label label1;
        private Label label2;
        private TextBox txtNuevoElemento;
        private Button btnInsert;
        private Button btnEliminar;
        private Button btnBorrarTodo;
        private Label lblItem;
        private Label lblIndex;
    }
}