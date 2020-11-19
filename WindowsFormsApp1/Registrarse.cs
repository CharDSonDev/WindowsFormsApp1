using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Registrarse : Form
    {
        SqlConnection conexion = new SqlConnection("Data Source=ASUS-X553MA\\MSSQLSERVER01;database=Clientes; Initial Catalog=G6; Integrated Security=true");
        public Registrarse()
        {
            InitializeComponent();
        }

        private void Registrarse_Load(object sender, EventArgs e)
        {

        }

        private void buttonRegistrarse_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "INSERT INTO Clientes(Cedula,Nombre,Apellido,Correo,Direccion,Telefono,contrasena) VALUES (@cedula,@nombre,@apellido,@correo,@direccion,@telefono,@contrasena)";
                conexion.Open();
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@cedula",textCedula.Text);
                comando.Parameters.AddWithValue("@nombre",textNombre.Text);
                comando.Parameters.AddWithValue("@apellido",textApellido.Text);
                comando.Parameters.AddWithValue("@correo",textCorreo.Text);
                comando.Parameters.AddWithValue("@direccion",textDireccion.Text);
                comando.Parameters.AddWithValue("@telefono",textTelefono.Text);
                comando.Parameters.AddWithValue("@contrasena",textContrasena.Text);
                comando.ExecuteNonQuery();
                conexion.Close();
                MessageBox.Show("Registro completo");
            }
            catch (Exception)
            {
                MessageBox.Show("Faltan campos por llenar.");
            }
        }
    }
}
