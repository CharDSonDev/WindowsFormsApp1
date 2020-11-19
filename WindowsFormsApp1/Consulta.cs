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
    public partial class Consulta : Form
    {
        SqlConnection conexion = new SqlConnection("Data Source=ASUS-X553MA\\MSSQLSERVER01;database=Clientes; Initial Catalog=G6; Integrated Security=true");
        public Consulta()
        {
            InitializeComponent();
        }

        public void Mostrar()
        {
            SqlCommand comando = new SqlCommand("SELECT * FROM Clientes", conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dtgv.DataSource = tabla;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                string query = "DELETE FROM Clientes WHERE Cedula = @cedula";
                conexion.Open();
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@cedula", textCedula.Text);
                comando.ExecuteNonQuery();
                conexion.Close();
                Mostrar();
                MessageBox.Show("Datos eliminados");
            }
            catch (Exception)
            {
                MessageBox.Show("Esta dejando campos vacios o datos erroneos");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT * FROM Clientes WHERE Nombre like '" + textNombre.Text + "'or Cedula like '" + textCedula.Text +"'";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comando;
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                dtgv.DataSource = tabla;
            }
            catch (Exception)
            {
                MessageBox.Show("Estas introduccion datos erroneos, vuelve a revisar y intenta denuevo");
            }
        }

        private void button2_Click(object sender, EventArgs e)
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
                Mostrar();
                MessageBox.Show("Datos actualizados.");
            }
            catch (Exception)
            {
                MessageBox.Show("Esta dejando campos vacios o datos erroneos");
            }
        }
    }
}
