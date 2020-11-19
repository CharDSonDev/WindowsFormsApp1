using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Actualizar : Form
    {
        SqlConnection conexion = new SqlConnection("Data Source=ASUS-X553MA\\MSSQLSERVER01;database=Clientes; Initial Catalog=G6; Integrated Security=true");
        public Actualizar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "UPDATE Clientes SET Nombre = @nombre, Apellido = @apellido, Correo = @correo, Direccion = @direccion, Telefono = @telefono, contrasena = @contrasena WHRE Cedula = @cedula";
                conexion.Open();
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@cedula", textCedula.Text);
                comando.Parameters.AddWithValue("@nombre", textNombre.Text);
                comando.Parameters.AddWithValue("@apellido", textApellido.Text);
                comando.Parameters.AddWithValue("@correo", textCorreo.Text);
                comando.Parameters.AddWithValue("@direccion", textDireccion.Text);
                comando.Parameters.AddWithValue("@telefono", textTelefono.Text);
                comando.Parameters.AddWithValue("@contrasena", textContrasena.Text);
                comando.ExecuteNonQuery();
                conexion.Close();
                MessageBox.Show("Datos actualizados.");
            }
            catch (Exception)
            {
                MessageBox.Show("Esta dejando campos vacios o datos erroneos");
            }
        }
    }
}
