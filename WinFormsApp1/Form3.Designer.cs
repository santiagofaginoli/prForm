namespace WinFormsApp1
{
    partial class Form3
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
            dgvStats = new DataGridView();
            Home = new Button();
            button2 = new Button();
            Gestion = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvStats).BeginInit();
            SuspendLayout();
            // 
            // dgvStats
            // 
            dgvStats.ColumnHeadersHeight = 29;
            dgvStats.Location = new Point(12, 102);
            dgvStats.Name = "dgvStats";
            dgvStats.RowHeadersWidth = 51;
            dgvStats.Size = new Size(1018, 440);
            dgvStats.TabIndex = 22;
            // 
            // Home
            // 
            Home.BackColor = Color.Purple;
            Home.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            Home.Location = new Point(12, 16);
            Home.Name = "Home";
            Home.Size = new Size(130, 56);
            Home.TabIndex = 18;
            Home.Text = "Home";
            Home.UseVisualStyleBackColor = false;
            Home.Click += Home_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkCyan;
            button2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            button2.Location = new Point(284, 16);
            button2.Name = "button2";
            button2.Size = new Size(130, 56);
            button2.TabIndex = 19;
            button2.Text = "Buscador";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Gestion
            // 
            Gestion.BackColor = Color.ForestGreen;
            Gestion.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            Gestion.Location = new Point(148, 16);
            Gestion.Name = "Gestion";
            Gestion.Size = new Size(130, 56);
            Gestion.TabIndex = 20;
            Gestion.Text = "Gestión";
            Gestion.UseVisualStyleBackColor = false;
            Gestion.Click += Gestion_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            label1.Location = new Point(534, 18);
            label1.Name = "label1";
            label1.Size = new Size(240, 54);
            label1.TabIndex = 21;
            label1.Text = "Estadísticas";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1062, 673);
            Controls.Add(label1);
            Controls.Add(Gestion);
            Controls.Add(button2);
            Controls.Add(Home);
            Controls.Add(dgvStats);
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)dgvStats).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvStats;
        private Button Home;
        private Button button2;
        private Button Gestion;
        private Label label1;
    }
}