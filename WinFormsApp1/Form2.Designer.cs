namespace WinFormsApp1
{
    partial class Form2
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
            txtBuscarDNI = new TextBox();
            label1 = new Label();
            dgvAlumnos = new DataGridView();
            btnBuscar = new Button();
            label2 = new Label();
            Gestion = new Button();
            stats = new Button();
            Home = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).BeginInit();
            SuspendLayout();
            // 
            // txtBuscarDNI
            // 
            txtBuscarDNI.Location = new Point(12, 427);
            txtBuscarDNI.Name = "txtBuscarDNI";
            txtBuscarDNI.Size = new Size(209, 27);
            txtBuscarDNI.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.Location = new Point(12, 384);
            label1.Name = "label1";
            label1.Size = new Size(47, 25);
            label1.TabIndex = 2;
            label1.Text = "DNI";
            // 
            // dgvAlumnos
            // 
            dgvAlumnos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlumnos.Location = new Point(12, 115);
            dgvAlumnos.Name = "dgvAlumnos";
            dgvAlumnos.ReadOnly = true;
            dgvAlumnos.RowHeadersWidth = 51;
            dgvAlumnos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAlumnos.Size = new Size(1038, 255);
            dgvAlumnos.TabIndex = 10;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.SkyBlue;
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnBuscar.Location = new Point(431, 449);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(204, 63);
            btnBuscar.TabIndex = 11;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label2.Location = new Point(431, 60);
            label2.Name = "label2";
            label2.Size = new Size(181, 41);
            label2.TabIndex = 12;
            label2.Text = "BUSCADOR";
            // 
            // Gestion
            // 
            Gestion.BackColor = Color.ForestGreen;
            Gestion.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            Gestion.Location = new Point(152, 12);
            Gestion.Name = "Gestion";
            Gestion.Size = new Size(129, 56);
            Gestion.TabIndex = 13;
            Gestion.Text = "Gestión";
            Gestion.UseVisualStyleBackColor = false;
            Gestion.Click += Gestion_Click;
            // 
            // stats
            // 
            stats.BackColor = Color.FromArgb(192, 64, 0);
            stats.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            stats.Location = new Point(296, 12);
            stats.Name = "stats";
            stats.Size = new Size(129, 56);
            stats.TabIndex = 15;
            stats.Text = "Estadísticas";
            stats.UseVisualStyleBackColor = false;
            stats.Click += stats_Click;
            // 
            // Home
            // 
            Home.BackColor = Color.Purple;
            Home.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            Home.Location = new Point(12, 12);
            Home.Name = "Home";
            Home.Size = new Size(129, 56);
            Home.TabIndex = 16;
            Home.Text = "Home";
            Home.UseVisualStyleBackColor = false;
            Home.Click += Home_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1062, 673);
            Controls.Add(Home);
            Controls.Add(stats);
            Controls.Add(Gestion);
            Controls.Add(label2);
            Controls.Add(btnBuscar);
            Controls.Add(dgvAlumnos);
            Controls.Add(label1);
            Controls.Add(txtBuscarDNI);
            Name = "Form2";
            Text = "Buscador";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtBuscarDNI;
        private Label label1;
        private DataGridView dgvAlumnos;
        private Button btnBuscar;
        private Label label2;
        private Button Gestion;
        private Button stats;
        private Button Home;
    }
}