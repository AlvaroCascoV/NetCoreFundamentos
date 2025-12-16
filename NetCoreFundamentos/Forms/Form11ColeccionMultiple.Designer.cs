namespace NetCoreFundamentos.Forms
{
    partial class Form11ColeccionMultiple
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
            lblIndex = new Label();
            lblItem = new Label();
            btnBorrarTodo = new Button();
            btnEliminar = new Button();
            btnInsert = new Button();
            txtNuevoElemento = new TextBox();
            label2 = new Label();
            label1 = new Label();
            lstElementos = new ListBox();
            btnSeleccionados = new Button();
            SuspendLayout();
            // 
            // lblIndex
            // 
            lblIndex.AutoSize = true;
            lblIndex.Location = new Point(47, 251);
            lblIndex.Name = "lblIndex";
            lblIndex.Size = new Size(49, 15);
            lblIndex.TabIndex = 17;
            lblIndex.Text = "lblIndex";
            // 
            // lblItem
            // 
            lblItem.AutoSize = true;
            lblItem.Location = new Point(47, 226);
            lblItem.Name = "lblItem";
            lblItem.Size = new Size(44, 15);
            lblItem.TabIndex = 16;
            lblItem.Text = "lblItem";
            // 
            // btnBorrarTodo
            // 
            btnBorrarTodo.Location = new Point(188, 173);
            btnBorrarTodo.Name = "btnBorrarTodo";
            btnBorrarTodo.Size = new Size(90, 22);
            btnBorrarTodo.TabIndex = 15;
            btnBorrarTodo.Text = "Borrar Todo";
            btnBorrarTodo.UseVisualStyleBackColor = true;
            btnBorrarTodo.Click += btnBorrarTodo_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Red;
            btnEliminar.ForeColor = SystemColors.ButtonFace;
            btnEliminar.Location = new Point(188, 144);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(90, 23);
            btnEliminar.TabIndex = 14;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(188, 115);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(90, 23);
            btnInsert.TabIndex = 13;
            btnInsert.Text = "Insertar";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // txtNuevoElemento
            // 
            txtNuevoElemento.Location = new Point(188, 75);
            txtNuevoElemento.Name = "txtNuevoElemento";
            txtNuevoElemento.Size = new Size(112, 23);
            txtNuevoElemento.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(188, 48);
            label2.Name = "label2";
            label2.Size = new Size(95, 15);
            label2.TabIndex = 11;
            label2.Text = "Nuevo elemento";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 48);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 10;
            label1.Text = "Elementos";
            // 
            // lstElementos
            // 
            lstElementos.FormattingEnabled = true;
            lstElementos.Location = new Point(47, 75);
            lstElementos.Name = "lstElementos";
            lstElementos.Size = new Size(122, 139);
            lstElementos.TabIndex = 9;
            // 
            // btnSeleccionados
            // 
            btnSeleccionados.Location = new Point(188, 201);
            btnSeleccionados.Name = "btnSeleccionados";
            btnSeleccionados.Size = new Size(90, 23);
            btnSeleccionados.TabIndex = 18;
            btnSeleccionados.Text = "Seleccionados";
            btnSeleccionados.UseVisualStyleBackColor = true;
            btnSeleccionados.Click += btnSeleccionados_Click;
            // 
            // Form11ColeccionMultiple
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSeleccionados);
            Controls.Add(lblIndex);
            Controls.Add(lblItem);
            Controls.Add(btnBorrarTodo);
            Controls.Add(btnEliminar);
            Controls.Add(btnInsert);
            Controls.Add(txtNuevoElemento);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lstElementos);
            Name = "Form11ColeccionMultiple";
            Text = "Form11ColeccionMultiple";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblIndex;
        private Label lblItem;
        private Button btnBorrarTodo;
        private Button btnEliminar;
        private Button btnInsert;
        private TextBox txtNuevoElemento;
        private Label label2;
        private Label label1;
        private ListBox lstElementos;
        private Button btnSeleccionados;
    }
}