using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using WinFormsApp1.clases;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Cargar alumnos al iniciar
            dgvAlumnos.DataSource = Db.Select("SELECT * FROM Alumnos");

            // Conectar el evento SelectionChanged del DataGridView
            dgvAlumnos.SelectionChanged += dgvAlumnos_SelectionChanged;
        }

        // ================== AGREGAR ==================
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtNombre.Text.Trim();
                string apellido = txtApellido.Text.Trim();
                string dni = txtDNI.Text.Trim();
                string carrera = txtCarrera.Text.Trim();

                string sql = "INSERT INTO Alumnos (Nombre, Apellido, DNI, Carrera, FechaIngreso) " +
                             "VALUES (@Nombre, @Apellido, @DNI, @Carrera, GETDATE())";

                using (SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS01;Initial Catalog=GestionAlumnosDB;Integrated Security=True;TrustServerCertificate=True"))
                using (SqlCommand comando = new SqlCommand(sql, con))
                {
                    comando.Parameters.AddWithValue("@Nombre", nombre);
                    comando.Parameters.AddWithValue("@Apellido", apellido);
                    comando.Parameters.AddWithValue("@DNI", dni);
                    comando.Parameters.AddWithValue("@Carrera", carrera);

                    con.Open();
                    int filas = comando.ExecuteNonQuery();
                    MessageBox.Show($"Alumno agregado correctamente. Filas insertadas: {filas}");
                }

                txtNombre.Clear();
                txtApellido.Clear();
                txtDNI.Clear();
                txtCarrera.Clear();

                dgvAlumnos.DataSource = Db.Select("SELECT * FROM Alumnos");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar alumno: " + ex.Message);
            }
        }

        // ================== ELIMINAR ==================
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvAlumnos.CurrentRow == null)
                {
                    MessageBox.Show("Seleccioná un alumno para eliminar.");
                    return;
                }

                int id = Convert.ToInt32(dgvAlumnos.CurrentRow.Cells["idAlumno"].Value);

                string sql = "DELETE FROM Alumnos WHERE idAlumno = @idAlumno";

                using (SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS01;Initial Catalog=GestionAlumnosDB;Integrated Security=True;TrustServerCertificate=True"))
                using (SqlCommand comando = new SqlCommand(sql, con))
                {
                    comando.Parameters.AddWithValue("@idAlumno", id);

                    con.Open();
                    int filas = comando.ExecuteNonQuery();
                    MessageBox.Show($"Alumno eliminado correctamente. Filas afectadas: {filas}");
                }

                dgvAlumnos.DataSource = Db.Select("SELECT * FROM Alumnos");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar alumno: " + ex.Message);
            }
        }

        // ================== MODIFICAR ==================
        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvAlumnos.CurrentRow == null)
                {
                    MessageBox.Show("Seleccioná un alumno para modificar.");
                    return;
                }

                int id = Convert.ToInt32(dgvAlumnos.CurrentRow.Cells["idAlumno"].Value);

                string nombre = txtNombre.Text.Trim();
                string apellido = txtApellido.Text.Trim();
                string dni = txtDNI.Text.Trim();
                string carrera = txtCarrera.Text.Trim();

                string sql = "UPDATE Alumnos SET Nombre=@Nombre, Apellido=@Apellido, DNI=@DNI, Carrera=@Carrera WHERE idAlumno=@idAlumno";

                using (SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS01;Initial Catalog=GestionAlumnosDB;Integrated Security=True;TrustServerCertificate=True"))
                using (SqlCommand comando = new SqlCommand(sql, con))
                {
                    comando.Parameters.AddWithValue("@idAlumno", id);
                    comando.Parameters.AddWithValue("@Nombre", nombre);
                    comando.Parameters.AddWithValue("@Apellido", apellido);
                    comando.Parameters.AddWithValue("@DNI", dni);
                    comando.Parameters.AddWithValue("@Carrera", carrera);

                    con.Open();
                    int filas = comando.ExecuteNonQuery();
                    MessageBox.Show($"Alumno modificado correctamente. Filas afectadas: {filas}");
                }

                dgvAlumnos.DataSource = Db.Select("SELECT * FROM Alumnos");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar alumno: " + ex.Message);
            }
        }

        // ================== SELECCIÓN AUTOMÁTICA ==================
        private void dgvAlumnos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvAlumnos.CurrentRow != null)
            {
                txtNombre.Text = dgvAlumnos.CurrentRow.Cells["Nombre"].Value.ToString();
                txtApellido.Text = dgvAlumnos.CurrentRow.Cells["Apellido"].Value.ToString();
                txtDNI.Text = dgvAlumnos.CurrentRow.Cells["DNI"].Value.ToString();
                txtCarrera.Text = dgvAlumnos.CurrentRow.Cells["Carrera"].Value.ToString();
            }
        }

        // ================== LOAD ==================
        private void Form1_Load(object sender, EventArgs e)
        {
            // Opcional: código al iniciar el formulario
        }
    }
}
