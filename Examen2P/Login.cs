using MySql.Data.MySqlClient;
namespace Examen2P
{
    public partial class Login : Form
    {
        ConexionMySQL conn = new ConexionMySQL();
        MySqlCommand cmd;
       
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            conn.OpenConnection();
            try
            {
                if(string.IsNullOrEmpty(txtUser.Text) || string.IsNullOrEmpty(txtPass.Text))
                {
                    conn.CloseConnection();
                    return;
                }

                cmd = new MySqlCommand("SELECT id,nombre from vendedores where nombre=@nombre and contrasena = @contrasena",conn.conn);
                cmd.Parameters.AddWithValue("@nombre", txtUser.Text);
                cmd.Parameters.AddWithValue ("@contrasena", txtPass.Text);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read()) {
                    Globales.vendedor = new vendedorLogueado(
                        Convert.ToInt32(reader["id"]),
                        reader["nombre"].ToString()
                    );
                    Dashboard dashboard = new Dashboard();
                    dashboard.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario no reconocido");
                }
            }
            catch (MySqlException ex) {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.CloseConnection();
            }
        }

    }
}
