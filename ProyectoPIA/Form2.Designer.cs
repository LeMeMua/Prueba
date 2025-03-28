namespace ProyectoPIA
{
    partial class EmpleadoCrear
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
            crearEmpleados = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            comboBox1 = new ComboBox();
            celularbox = new TextBox();
            edadbox = new TextBox();
            nombrebox = new TextBox();
            lb_id = new Label();
            savebtn = new Button();
            cancelbtn = new Button();
            SuspendLayout();
            // 
            // crearEmpleados
            // 
            crearEmpleados.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            crearEmpleados.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            crearEmpleados.Location = new Point(3, 18);
            crearEmpleados.Name = "crearEmpleados";
            crearEmpleados.Size = new Size(760, 23);
            crearEmpleados.TabIndex = 0;
            crearEmpleados.Text = "Crear Empleados";
            crearEmpleados.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Location = new Point(66, 127);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 1;
            label1.Text = "Empleado ID";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.Location = new Point(66, 162);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 2;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label3.AutoSize = true;
            label3.Location = new Point(66, 198);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 3;
            label3.Text = "Edad";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label4.AutoSize = true;
            label4.Location = new Point(66, 230);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 4;
            label4.Text = "Celular";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label5.AutoSize = true;
            label5.Location = new Point(66, 267);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 5;
            label5.Text = "Carrera";
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(191, 259);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 6;
            // 
            // celularbox
            // 
            celularbox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            celularbox.Location = new Point(190, 231);
            celularbox.Name = "celularbox";
            celularbox.Size = new Size(100, 23);
            celularbox.TabIndex = 7;
            
            // 
            // edadbox
            // 
            edadbox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            edadbox.Location = new Point(191, 202);
            edadbox.Name = "edadbox";
            edadbox.Size = new Size(100, 23);
            edadbox.TabIndex = 8;
            // 
            // nombrebox
            // 
            nombrebox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            nombrebox.Location = new Point(189, 161);
            nombrebox.Name = "nombrebox";
            nombrebox.Size = new Size(100, 23);
            nombrebox.TabIndex = 9;
            // 
            // lb_id
            // 
            lb_id.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lb_id.AutoSize = true;
            lb_id.Location = new Point(189, 124);
            lb_id.Name = "lb_id";
            lb_id.Size = new Size(0, 15);
            lb_id.TabIndex = 10;
            // 
            // savebtn
            // 
            savebtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            savebtn.Location = new Point(469, 356);
            savebtn.Name = "savebtn";
            savebtn.Size = new Size(75, 23);
            savebtn.TabIndex = 11;
            savebtn.Text = "Save";
            savebtn.UseVisualStyleBackColor = true;
            savebtn.Click += savebtn_Click;
            // 
            // cancelbtn
            // 
            cancelbtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cancelbtn.Location = new Point(581, 356);
            cancelbtn.Name = "cancelbtn";
            cancelbtn.Size = new Size(75, 23);
            cancelbtn.TabIndex = 12;
            cancelbtn.Text = "Cancel";
            cancelbtn.UseVisualStyleBackColor = true;
            // 
            // EmpleadoCrear
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(775, 409);
            Controls.Add(cancelbtn);
            Controls.Add(savebtn);
            Controls.Add(lb_id);
            Controls.Add(nombrebox);
            Controls.Add(edadbox);
            Controls.Add(celularbox);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(crearEmpleados);
            Name = "EmpleadoCrear";
            Text = "Crear Empleado";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label crearEmpleados;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox comboBox1;
        private TextBox celularbox;
        private TextBox edadbox;
        private TextBox nombrebox;
        private Label lb_id;
        private Button savebtn;
        private Button cancelbtn;
    }
}