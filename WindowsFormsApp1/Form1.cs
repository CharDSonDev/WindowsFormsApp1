using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        SqlConnection conexion = new SqlConnection("Data Source=ASUS-X553MA\\MSSQLSERVER01;database=CLientes; Initial Catalog=G6; Integrated Security=true");
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT * FROM Clientes WHERE Correo = '" + textCorreo.Text + "' AND Contrasena = '" + textContrasena.Text + "'";
                conexion.Open();
                SqlDataAdapter sda = new SqlDataAdapter(query, conexion);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                if (dtbl.Rows.Count == 1)
                {
                    Hide();
                    Consulta consulta = new Consulta();
                    consulta.ShowDialog();
                    Close();
                }
                else
                {
                    MessageBox.Show("Datos erroneos");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Que");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ButtonRegistrarse_Click(object sender, EventArgs e)
        {
            Registrarse registrarse = new Registrarse();
            registrarse.ShowDialog();
        }
    }
}
