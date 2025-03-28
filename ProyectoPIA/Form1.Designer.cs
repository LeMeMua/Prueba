namespace ProyectoPIA
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnCrearEmpleado = new Button();
            btnEditarEmpleado = new Button();
            btnEliminarEmpleado = new Button();
            empleadoTable = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)empleadoTable).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(655, 23);
            label1.TabIndex = 0;
            label1.Text = "Empleados";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // btnCrearEmpleado
            // 
            btnCrearEmpleado.AutoSize = true;
            btnCrearEmpleado.Location = new Point(22, 71);
            btnCrearEmpleado.Name = "btnCrearEmpleado";
            btnCrearEmpleado.Size = new Size(101, 25);
            btnCrearEmpleado.TabIndex = 1;
            btnCrearEmpleado.Text = "Crear Empleado";
            btnCrearEmpleado.UseVisualStyleBackColor = true;
            btnCrearEmpleado.Click += button1_Click;
            // 
            // btnEditarEmpleado
            // 
            btnEditarEmpleado.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEditarEmpleado.AutoSize = true;
            btnEditarEmpleado.Location = new Point(473, 73);
            btnEditarEmpleado.Name = "btnEditarEmpleado";
            btnEditarEmpleado.Size = new Size(103, 25);
            btnEditarEmpleado.TabIndex = 2;
            btnEditarEmpleado.Text = "Editar Empleado";
            btnEditarEmpleado.UseVisualStyleBackColor = true;
            // 
            // btnEliminarEmpleado
            // 
            btnEliminarEmpleado.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEliminarEmpleado.AutoSize = true;
            btnEliminarEmpleado.Location = new Point(592, 73);
            btnEliminarEmpleado.Name = "btnEliminarEmpleado";
            btnEliminarEmpleado.Size = new Size(75, 25);
            btnEliminarEmpleado.TabIndex = 3;
            btnEliminarEmpleado.Text = "Eliminar";
            btnEliminarEmpleado.UseVisualStyleBackColor = true;
            // 
            // empleadoTable
            // 
            empleadoTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            empleadoTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            empleadoTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            empleadoTable.Location = new Point(22, 123);
            empleadoTable.MultiSelect = false;
            empleadoTable.Name = "empleadoTable";
            empleadoTable.RowHeadersVisible = false;
            empleadoTable.SelectionMode = DataGridViewSelectionMode.CellSelect;
            empleadoTable.Size = new Size(645, 312);
            empleadoTable.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(679, 447);
            Controls.Add(empleadoTable);
            Controls.Add(btnEliminarEmpleado);
            Controls.Add(btnEditarEmpleado);
            Controls.Add(btnCrearEmpleado);
            Controls.Add(label1);
            Name = "Form1";
            Text = "EmpleadoManager";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)empleadoTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnCrearEmpleado;
        private Button btnEditarEmpleado;
        private Button btnEliminarEmpleado;
        private DataGridView empleadoTable;
    }
}
