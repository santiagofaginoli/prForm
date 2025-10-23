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
            // Lista para acumular todos los mensajes de error
            List<string> errores = new List<string>();
            string mensajeError;

            // 1. Obtener y limpiar los valores
            string nombre = txtNombre.Text.Trim();
            string apellido = txtApellido.Text.Trim();
            string dni = txtDNI.Text.Trim();
            string carrera = cmbcarrera.Text.Trim();

            // 2. Ejecutar las validaciones y acumular errores

            // Validar Requeridos
            if (!Validator.EsRequerido(nombre, "Nombre", out mensajeError))
                errores.Add(mensajeError);

            if (!Validator.EsRequerido(apellido, "Apellido", out mensajeError))
                errores.Add(mensajeError);

            if (!Validator.EsRequerido(dni, "DNI", out mensajeError))
                errores.Add(mensajeError);

            if (!Validator.EsRequerido(carrera, "Carrera", out mensajeError))
                errores.Add(mensajeError);

            // Validar DNI: Numérico y exactamente 8 caracteres
            if (!string.IsNullOrWhiteSpace(dni))
            {
                if (!Validator.EsNumero(dni, "DNI", out mensajeError))
                    errores.Add(mensajeError);

                // Validación de longitud mínima y máxima de 8
                if (dni.Length != 8)
                    errores.Add("El campo DNI debe tener exactamente 8 caracteres.");
            }

            // 3. Chequear si hay errores
            if (errores.Count > 0)
            {
                // Muestra todos los errores concatenados
                MessageBox.Show("Por favor, corrige los siguientes problemas:\n\n" + string.Join("\n", errores),
                                 "Error de Validación",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Warning);
                return; // Detiene la ejecución si hay errores
            }

            // 4. Si la validación es exitosa, procede con la lógica de negocio
            try
            {
                string sql = $"INSERT INTO Alumnos (Nombre, Apellido, DNI, Carrera, FechaIngreso) " +
                              $"VALUES ('{nombre}', '{apellido}', '{dni}', '{carrera}', GETDATE())";

                int filas = Db.Ejecutar(sql);
                MessageBox.Show($"Alumno agregado correctamente. Filas insertadas: {filas}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // 5. Limpiar campos después de la operación
                txtNombre.Clear();
                txtApellido.Clear();
                txtDNI.Clear();
                cmbcarrera.Text = string.Empty;
                cmbcarrera.SelectedIndex = -1;

                // 6. Actualizar DataGridView
                dgvAlumnos.DataSource = Db.Select("SELECT * FROM Alumnos");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar alumno: " + ex.Message, "Error de Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                // Usamos Db.Ejecutar en lugar de SqlConnection/SqlCommand
                string sql = $"DELETE FROM Alumnos WHERE idAlumno = {id}";
                int filas = Db.Ejecutar(sql);

                MessageBox.Show($"Alumno eliminado correctamente. Filas afectadas: {filas}");

                // Actualizar DataGridView
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
            // Validar que se haya seleccionado una fila para modificar
            if (dgvAlumnos.CurrentRow == null)
            {
                MessageBox.Show("Seleccioná un alumno para modificar.");
                return;
            }

            // Lista para acumular todos los mensajes de error
            List<string> errores = new List<string>();
            string mensajeError;

            // 1. Obtener y limpiar los valores
            int id = Convert.ToInt32(dgvAlumnos.CurrentRow.Cells["idAlumno"].Value);
            string nombre = txtNombre.Text.Trim();
            string apellido = txtApellido.Text.Trim();
            string dni = txtDNI.Text.Trim();
            string carrera = cmbcarrera.Text.Trim();

            // 2. Ejecutar las validaciones (igual que en btnAgregar_Click)

            // Validar Requeridos
            if (!Validator.EsRequerido(nombre, "Nombre", out mensajeError))
                errores.Add(mensajeError);

            if (!Validator.EsRequerido(apellido, "Apellido", out mensajeError))
                errores.Add(mensajeError);

            if (!Validator.EsRequerido(dni, "DNI", out mensajeError))
                errores.Add(mensajeError);

            if (!Validator.EsRequerido(carrera, "Carrera", out mensajeError))
                errores.Add(mensajeError);

            // Validar DNI: Numérico y exactamente 8 caracteres
            if (!string.IsNullOrWhiteSpace(dni))
            {
                if (!Validator.EsNumero(dni, "DNI", out mensajeError))
                    errores.Add(mensajeError);

                // Validación de longitud mínima y máxima de 8
                if (dni.Length != 8)
                    errores.Add("El campo DNI debe tener exactamente 8 caracteres.");
            }

            // 3. Chequear si hay errores
            if (errores.Count > 0)
            {
                // Muestra todos los errores concatenados
                MessageBox.Show("Por favor, corrige los siguientes problemas:\n\n" + string.Join("\n", errores),
                                 "Error de Validación",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Warning);
                return; // Detiene la ejecución si hay errores
            }

            // 4. Si la validación es exitosa, procede con la lógica de negocio
            try
            {
                // Usamos Db.Ejecutar en lugar de SqlConnection/SqlCommand
                string sql = $"UPDATE Alumnos SET " +
                             $"Nombre='{nombre}', " +
                             $"Apellido='{apellido}', " +
                             $"DNI='{dni}', " +
                             $"Carrera='{carrera}' " +
                             $"WHERE idAlumno={id}";

                int filas = Db.Ejecutar(sql);
                MessageBox.Show($"Alumno modificado correctamente. Filas afectadas: {filas}");

                // Actualizar DataGridView
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
            if (sender is DataGridView dgv && dgv.CurrentRow != null)
            {
                txtNombre.Text = dgv.CurrentRow.Cells["Nombre"].Value?.ToString() ?? string.Empty;
                txtApellido.Text = dgv.CurrentRow.Cells["Apellido"].Value?.ToString() ?? string.Empty;
                txtDNI.Text = dgv.CurrentRow.Cells["DNI"].Value?.ToString() ?? string.Empty;
                cmbcarrera.Text = dgv.CurrentRow.Cells["Carrera"].Value?.ToString() ?? string.Empty;
            }
        }

        // ================== LOAD ==================
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void dgvAlumnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Close();
            form2.Show();
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