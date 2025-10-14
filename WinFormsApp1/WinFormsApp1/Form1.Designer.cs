namespace WinFormsApp1
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
            Nombredesign = new Button();
            txtNombre = new TextBox();
            txtDNI = new TextBox();
            txtCarrera = new TextBox();
            txtApellido = new TextBox();
            Nombre = new Label();
            Apellido = new Label();
            Carrera = new Label();
            DNI = new Label();
            dgvAlumnos = new DataGridView();
            btnEliminar = new Button();
            Modificar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).BeginInit();
            SuspendLayout();
            // 
            // Nombredesign
            // 
            Nombredesign.BackColor = SystemColors.ControlLightLight;
            Nombredesign.Location = new Point(538, 469);
            Nombredesign.Name = "Nombredesign";
            Nombredesign.Size = new Size(94, 29);
            Nombredesign.TabIndex = 0;
            Nombredesign.Text = "Agregar";
            Nombredesign.UseVisualStyleBackColor = false;
            Nombredesign.Click += btnAgregar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(46, 44);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 1;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(246, 123);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(125, 27);
            txtDNI.TabIndex = 2;
            // 
            // txtCarrera
            // 
            txtCarrera.Location = new Point(46, 123);
            txtCarrera.Name = "txtCarrera";
            txtCarrera.Size = new Size(125, 27);
            txtCarrera.TabIndex = 3;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(246, 44);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(125, 27);
            txtApellido.TabIndex = 4;
            // 
            // Nombre
            // 
            Nombre.AutoSize = true;
            Nombre.Location = new Point(46, 21);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(64, 20);
            Nombre.TabIndex = 5;
            Nombre.Text = "Nombre";
            // 
            // Apellido
            // 
            Apellido.AutoSize = true;
            Apellido.Location = new Point(246, 21);
            Apellido.Name = "Apellido";
            Apellido.Size = new Size(66, 20);
            Apellido.TabIndex = 6;
            Apellido.Text = "Apellido";
            // 
            // Carrera
            // 
            Carrera.AutoSize = true;
            Carrera.Location = new Point(46, 100);
            Carrera.Name = "Carrera";
            Carrera.Size = new Size(57, 20);
            Carrera.TabIndex = 7;
            Carrera.Text = "Carrera";
            // 
            // DNI
            // 
            DNI.AutoSize = true;
            DNI.Location = new Point(246, 100);
            DNI.Name = "DNI";
            DNI.Size = new Size(35, 20);
            DNI.TabIndex = 8;
            DNI.Text = "DNI";
            // 
            // dgvAlumnos
            // 
            dgvAlumnos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlumnos.Location = new Point(12, 182);
            dgvAlumnos.Name = "dgvAlumnos";
            dgvAlumnos.ReadOnly = true;
            dgvAlumnos.RowHeadersWidth = 51;
            dgvAlumnos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAlumnos.Size = new Size(620, 255);
            dgvAlumnos.TabIndex = 9;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Red;
            btnEliminar.Location = new Point(438, 469);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 10;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // Modificar
            // 
            Modificar.BackColor = SystemColors.ControlLightLight;
            Modificar.Location = new Point(338, 469);
            Modificar.Name = "Modificar";
            Modificar.Size = new Size(94, 29);
            Modificar.TabIndex = 11;
            Modificar.Text = "Modificar";
            Modificar.UseVisualStyleBackColor = false;
            Modificar.Click += btnModificar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(644, 521);
            Controls.Add(Modificar);
            Controls.Add(btnEliminar);
            Controls.Add(dgvAlumnos);
            Controls.Add(DNI);
            Controls.Add(Carrera);
            Controls.Add(Apellido);
            Controls.Add(Nombre);
            Controls.Add(txtApellido);
            Controls.Add(txtCarrera);
            Controls.Add(txtDNI);
            Controls.Add(txtNombre);
            Controls.Add(Nombredesign);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Nombredesign;
        private TextBox txtNombre;
        private TextBox txtDNI;
        private TextBox txtCarrera;
        private TextBox txtApellido;
        private Label Nombre;
        private Label Apellido;
        private Label Carrera;
        private Label DNI;
        private DataGridView dgvAlumnos;
        private Button btnEliminar;
        private Button Modificar;
    }
}
