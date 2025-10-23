namespace WinFormsApp1
{
    partial class Home
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
            Gestion = new Button();
            Buscador = new Button();
            stats = new Button();
            label2 = new Label();
            nombre = new Label();
            SuspendLayout();
            // 
            // Gestion
            // 
            Gestion.BackColor = Color.ForestGreen;
            Gestion.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            Gestion.Location = new Point(72, 233);
            Gestion.Name = "Gestion";
            Gestion.Size = new Size(225, 117);
            Gestion.TabIndex = 0;
            Gestion.Text = "Gestión";
            Gestion.UseVisualStyleBackColor = false;
            Gestion.Click += Gestion_Click;
            // 
            // Buscador
            // 
            Buscador.BackColor = Color.DarkCyan;
            Buscador.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            Buscador.Location = new Point(428, 233);
            Buscador.Name = "Buscador";
            Buscador.Size = new Size(225, 117);
            Buscador.TabIndex = 1;
            Buscador.Text = "Buscador";
            Buscador.UseVisualStyleBackColor = false;
            Buscador.Click += button2_Click;
            // 
            // stats
            // 
            stats.BackColor = Color.FromArgb(192, 64, 0);
            stats.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            stats.Location = new Point(764, 233);
            stats.Name = "stats";
            stats.Size = new Size(225, 117);
            stats.TabIndex = 2;
            stats.Text = "Estadísticas";
            stats.UseVisualStyleBackColor = false;
            stats.Click += stats_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            label2.Location = new Point(474, 83);
            label2.Name = "label2";
            label2.Size = new Size(143, 54);
            label2.TabIndex = 13;
            label2.Text = "HOME";
            // 
            // nombre
            // 
            nombre.AutoSize = true;
            nombre.Location = new Point(37, 525);
            nombre.Name = "nombre";
            nombre.Size = new Size(144, 20);
            nombre.TabIndex = 14;
            nombre.Text = "@Faginoli y Oyarzun";
            nombre.Click += label1_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1062, 673);
            Controls.Add(nombre);
            Controls.Add(label2);
            Controls.Add(stats);
            Controls.Add(Buscador);
            Controls.Add(Gestion);
            Name = "Home";
            Text = "Home";
            Load += Home_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Buscador;
        private Button stats;
        private Label label2;
        private Label nombre;
    }
}