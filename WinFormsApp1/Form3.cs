using System;
using System.Data;
using System.Windows.Forms;
using WinFormsApp1.clases;
using System.Linq;

namespace WinFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            CargarEstadisticas();
        }

        private void CargarEstadisticas()
        {
            try
            {
                // Obtener datos base
                DataTable alumnosPorCarrera = Db.Select(@"
                    SELECT Carrera, COUNT(*) AS Cantidad
                    FROM Alumnos
                    GROUP BY Carrera
                    ORDER BY Cantidad DESC");

                int totalAlumnos = Convert.ToInt32(Db.Escalar("SELECT COUNT(*) FROM Alumnos"));
                int totalCarreras = alumnosPorCarrera.Rows.Count;

                // --- 1. Cantidad total de alumnos y carreras ---
                string totalCarrerasStr = totalCarreras.ToString();

                // --- 2. Carrera con más alumnos ---
                string carreraTop = "Sin datos";
                string cantidadTop = "0";

                if (alumnosPorCarrera.Rows.Count > 0)
                {
                    DataRow topRow = alumnosPorCarrera.Rows[0];
                    carreraTop = topRow["Carrera"].ToString();
                    cantidadTop = topRow["Cantidad"].ToString();
                }

                // --- 3. Antigüedad del Último Alumno Agregado ---
                // Asumo que tu tabla tiene una columna FechaIngreso de tipo datetime
                object fechaRecienteObj = Db.Escalar("SELECT MAX(FechaIngreso) FROM Alumnos");
                string antiguedad = "N/A";

                if (fechaRecienteObj != DBNull.Value && fechaRecienteObj != null)
                {
                    DateTime fechaReciente = Convert.ToDateTime(fechaRecienteObj);
                    TimeSpan diferencia = DateTime.Now - fechaReciente;
                    antiguedad = $"{diferencia.TotalDays:0} días";
                }

                // --- 4. Promedio de alumnos por carrera (solo si hay carreras) ---
                string promedioAlumnos = "0";
                if (totalCarreras > 0)
                {
                    promedioAlumnos = $"{(double)totalAlumnos / totalCarreras:N2}";
                }

                // === Asegurar columnas ===
                if (dgvStats.Columns.Count == 0)
                {
                    dgvStats.Columns.Add("Descripcion", "Descripción");
                    dgvStats.Columns.Add("Valor", "Valor");
                    dgvStats.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }

                // Limpiar y cargar las estadísticas principales
                dgvStats.Rows.Clear();

                dgvStats.Rows.Add("Cantidad total de alumnos", totalAlumnos);
                dgvStats.Rows.Add("Total de carreras únicas registradas", totalCarrerasStr);
                dgvStats.Rows.Add("Promedio de alumnos por carrera", promedioAlumnos);
                dgvStats.Rows.Add("Carrera con más alumnos", $"{carreraTop} ({cantidadTop})");
                dgvStats.Rows.Add("Tiempo desde el último registro", antiguedad);

                // --- Separador y Detalle por Carrera ---
                dgvStats.Rows.Add("--- DISTRIBUCIÓN POR CARRERA ---", "");

                foreach (DataRow row in alumnosPorCarrera.Rows)
                {
                    string carrera = row["Carrera"].ToString();
                    string cantidad = row["Cantidad"].ToString();
                    dgvStats.Rows.Add($"Alumnos en '{carrera}'", cantidad);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar estadísticas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Gestion_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Close();
            form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Close();
            form2.Show();
        }
    }
}