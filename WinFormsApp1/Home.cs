using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Home : Form
    {
        private Button Gestion;


        public Home()
        {
            InitializeComponent();
        }

        // Tamaño y título del Home


        // ================== Eventos Click ==================
        private void Home_Load(object sender, EventArgs e)
        {
            // Si no necesitas hacer nada al cargar, puede quedar vacío
        }

        private void Gestion_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide(); // Oculta el Home
            form1.FormClosed += (s, args) => this.Show(); // Muestra Home al cerrar
            form1.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Hide();
            form2.FormClosed += (s, args) => this.Show();
            form2.Show();

        }

        private void stats_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            this.Hide();
            form3.FormClosed += (s, args) => this.Show();
            form3.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
