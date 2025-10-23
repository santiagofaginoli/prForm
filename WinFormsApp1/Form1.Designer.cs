namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Nombredesign = new Button();
            txtNombre = new TextBox();
            txtDNI = new TextBox();
            txtApellido = new TextBox();
            Nombre = new Label();
            Apellido = new Label();
            Carrera = new Label();
            DNI = new Label();
            dgvAlumnos = new DataGridView();
            btnEliminar = new Button();
            Modificar = new Button();
            button2 = new Button();
            stats = new Button();
            Home = new Button();
            label1 = new Label();
            cmbcarrera = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).BeginInit();
            SuspendLayout();
            // 
            // Nombredesign
            // 
            Nombredesign.BackColor = Color.DarkGreen;
            Nombredesign.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            Nombredesign.Location = new Point(729, 443);
            Nombredesign.Name = "Nombredesign";
            Nombredesign.Size = new Size(243, 55);
            Nombredesign.TabIndex = 0;
            Nombredesign.Text = "Agregar";
            Nombredesign.UseVisualStyleBackColor = false;
            Nombredesign.Click += btnAgregar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(98, 123);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(186, 27);
            txtNombre.TabIndex = 1;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(841, 123);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(186, 27);
            txtDNI.TabIndex = 2;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(363, 123);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(186, 27);
            txtApellido.TabIndex = 4;
            // 
            // Nombre
            // 
            Nombre.AutoSize = true;
            Nombre.Font = new Font("Segoe UI", 11F);
            Nombre.Location = new Point(98, 87);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(81, 25);
            Nombre.TabIndex = 5;
            Nombre.Text = "Nombre";
            // 
            // Apellido
            // 
            Apellido.AutoSize = true;
            Apellido.Font = new Font("Segoe UI", 11F);
            Apellido.Location = new Point(363, 87);
            Apellido.Name = "Apellido";
            Apellido.Size = new Size(82, 25);
            Apellido.TabIndex = 6;
            Apellido.Text = "Apellido";
            // 
            // Carrera
            // 
            Carrera.AutoSize = true;
            Carrera.Font = new Font("Segoe UI", 11F);
            Carrera.Location = new Point(607, 87);
            Carrera.Name = "Carrera";
            Carrera.Size = new Size(75, 25);
            Carrera.TabIndex = 7;
            Carrera.Text = "Carrera";
            // 
            // DNI
            // 
            DNI.AutoSize = true;
            DNI.Font = new Font("Segoe UI", 11F);
            DNI.Location = new Point(841, 87);
            DNI.Name = "DNI";
            DNI.Size = new Size(44, 25);
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
            dgvAlumnos.Size = new Size(1038, 255);
            dgvAlumnos.TabIndex = 9;
            dgvAlumnos.CellContentClick += dgvAlumnos_CellContentClick;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Red;
            btnEliminar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnEliminar.Location = new Point(446, 443);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(243, 55);
            btnEliminar.TabIndex = 10;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // Modificar
            // 
            Modificar.BackColor = SystemColors.ControlLightLight;
            Modificar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            Modificar.Location = new Point(149, 443);
            Modificar.Name = "Modificar";
            Modificar.Size = new Size(248, 55);
            Modificar.TabIndex = 11;
            Modificar.Text = "Modificar";
            Modificar.UseVisualStyleBackColor = false;
            Modificar.Click += btnModificar_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkCyan;
            button2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            button2.Location = new Point(145, 10);
            button2.Name = "button2";
            button2.Size = new Size(135, 56);
            button2.TabIndex = 13;
            button2.Text = "Buscador";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // stats
            // 
            stats.BackColor = Color.FromArgb(192, 64, 0);
            stats.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            stats.Location = new Point(286, 10);
            stats.Name = "stats";
            stats.Size = new Size(135, 56);
            stats.TabIndex = 14;
            stats.Text = "Estadísticas";
            stats.UseVisualStyleBackColor = false;
            stats.Click += stats_Click;
            // 
            // Home
            // 
            Home.BackColor = Color.Purple;
            Home.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            Home.Location = new Point(10, 10);
            Home.Name = "Home";
            Home.Size = new Size(129, 56);
            Home.TabIndex = 17;
            Home.Text = "Home";
            Home.UseVisualStyleBackColor = false;
            Home.Click += Home_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.Location = new Point(800, 13);
            label1.Name = "label1";
            label1.Size = new Size(125, 41);
            label1.TabIndex = 18;
            label1.Text = "Gestión";
            // 
            // cmbcarrera
            // 
            cmbcarrera.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbcarrera.FormattingEnabled = true;
            cmbcarrera.Items.AddRange(new object[] { "Ingeniería en Sistemas", "Ingenieria Aeroespacial", "Administración", "Ciberseguridad", "Medicina" });
            cmbcarrera.Location = new Point(607, 123);
            cmbcarrera.Name = "cmbcarrera";
            cmbcarrera.Size = new Size(186, 28);
            cmbcarrera.TabIndex = 19;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1062, 673);
            Controls.Add(cmbcarrera);
            Controls.Add(label1);
            Controls.Add(Home);
            Controls.Add(stats);
            Controls.Add(button2);
            Controls.Add(Modificar);
            Controls.Add(btnEliminar);
            Controls.Add(dgvAlumnos);
            Controls.Add(DNI);
            Controls.Add(Carrera);
            Controls.Add(Apellido);
            Controls.Add(Nombre);
            Controls.Add(txtApellido);
            Controls.Add(txtDNI);
            Controls.Add(txtNombre);
            Controls.Add(Nombredesign);
            Name = "Form1";
            Text = "Gestión";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Nombredesign;
        private TextBox txtNombre;
        private TextBox txtDNI;
        private TextBox txtApellido;
        private Label Nombre;
        private Label Apellido;
        private Label Carrera;
        private Label DNI;
        private DataGridView dgvAlumnos;
        private Button btnEliminar;
        private Button Modificar;
        private Button button2;
        private Button stats;
        private Button Home;
        private Label label1;
        private ComboBox cmbcarrera;
    }
}