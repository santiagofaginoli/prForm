using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.clases;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            // Cargar alumnos al iniciar
            dgvAlumnos.DataSource = Db.Select("SELECT * FROM Alumnos");

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            string dni = txtBuscarDNI.Text.Trim();

            if (string.IsNullOrWhiteSpace(dni))
            {
                MessageBox.Show("Ingresá un DNI para buscar.");
                return;
            }

            if (!long.TryParse(dni, out _))
            {
                MessageBox.Show("El DNI debe ser solo números.");
                return;
            }

            try
            {
                string sql = $"SELECT * FROM Alumnos WHERE DNI = '{dni}'";
                DataTable dt = Db.Select(sql);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontró ningún alumno con ese DNI.");
                }

                dgvAlumnos.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar: " + ex.Message);
            }
        }

        private void dgvAlumnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Gestion_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Close();
            form1.Show();
        }
        private void stats_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            this.Close();
            form3.Show();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
