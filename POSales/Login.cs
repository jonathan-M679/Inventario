using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSales
{
    public partial class Login : Form
    {
        // Define la conexión a la base de datos
        SqlConnection cn = new SqlConnection();
        // Define el comando SQL que se utilizará para la autenticación
        SqlCommand cm = new SqlCommand();
        // Conexión personalizada definida en la clase DBConnect
        DBConnect dbcon = new DBConnect();
        // Variable para almacenar los datos obtenidos de la consulta SQL
        SqlDataReader dr;

        // Variables para almacenar la contraseña del usuario y el estado de activación
        public string _pass = "";
        public bool _isactivate;

        public Login()
        {
            InitializeComponent();
            // Inicializa la conexión a la base de datos con la conexión definida en DBConnect
            cn = new SqlConnection(dbcon.myConnection());
            // Establece el foco en el campo de nombre de usuario cuando se carga el formulario
            txtName.Focus();
        }

        // Cierra la aplicación cuando se hace clic en el ícono de cerrar
        private void picClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Salir de la aplicación?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // Maneja el evento de inicio de sesión cuando se hace clic en el botón Login
        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Variables para almacenar la información del usuario
            string _username = "", _name = "", _role = "";
            try
            {
                cn.Open(); // Abre la conexión a la base de datos
                // Prepara el comando SQL para seleccionar el usuario con el username y password proporcionados
                cm = new SqlCommand("SELECT * FROM tbUser WHERE username COLLATE Latin1_General_CS_AS = @username AND password COLLATE Latin1_General_CS_AS = @password", cn);
                // Añade los parámetros al comando para prevenir SQL Injection
                cm.Parameters.AddWithValue("@username", txtName.Text);
                cm.Parameters.AddWithValue("@password", txtPass.Text);
                // Ejecuta el comando y guarda el resultado
                dr = cm.ExecuteReader();
                bool found = dr.Read(); // Verifica si se encontró un usuario

                if (found)
                {
                    // Guarda los datos del usuario si se encuentra en la base de datos
                    _username = dr["username"].ToString();
                    _name = dr["name"].ToString();
                    _role = dr["role"].ToString();
                    _pass = dr["password"].ToString();
                    _isactivate = bool.Parse(dr["isactivate"].ToString());
                }
                dr.Close(); // Cierra el lector de datos
                cn.Close(); // Cierra la conexión a la base de datos

                if (found)
                {
                    // Verifica si el usuario está activado
                    if (!_isactivate)
                    {
                        MessageBox.Show("La cuenta está desactivada. No se puede iniciar sesión", "Inactive Account", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Verifica el rol del usuario y muestra la ventana correspondiente
                    if (_role == "Cajero")
                    {
                        MessageBox.Show("Bienvenido " + _name + " |", "Acceso Concedido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtName.Clear();
                        txtPass.Clear();
                        this.Hide();
                        // Abre la ventana de Cajero
                        Cashier cashier = new Cashier();
                        cashier.lblUsername.Text = _username;
                        cashier.lblname.Text = _name + " | " + _role;
                        cashier.ShowDialog();
                        this.Show();
                    }
                    else if (_role == "Administrador")
                    {
                        MessageBox.Show("Bienvenido " + _name + " |", "Acceso Concedido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtName.Clear();
                        txtPass.Clear();
                        this.Hide();
                        // Abre la ventana principal de Administrador
                        MainForm main = new MainForm();
                        main.lblUsername.Text = _username;
                        main.lblName.Text = _name;
                        main._pass = _pass;
                        main.ShowDialog();
                        this.Show();
                    }
                    else if (_role == "S.Administrador")
                    {
                        MessageBox.Show("Bienvenido " + _name + "", "Acceso Concedido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtName.Clear();
                        txtPass.Clear();
                        this.Hide();
                        // Abre la ventana principal del Super Administrador
                        MainFormRoot mainRoot = new MainFormRoot();
                        mainRoot.lblUsername.Text = _username;
                        mainRoot.lblName.Text = _name;
                        mainRoot._pass = _pass;
                        mainRoot.ShowDialog();
                        this.Show();
                    }
                }
                else
                {
                    // Mensaje de error si el usuario o contraseña son incorrectos
                    MessageBox.Show("¡Nombre de usuario o contraseña no válidos!", "ACCESS DENIED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                cn.Close(); // Cierra la conexión en caso de error
                // Muestra el mensaje de error si ocurre una excepción
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Cierra la aplicación cuando se hace clic en el botón Cancelar
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Salir de la aplicación?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // Permite iniciar sesión al presionar la tecla Enter en el campo de contraseña
        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnLogin.PerformClick();
            }
        }

        // Eventos vacíos y sin funcionalidad (pueden ser eliminados si no se utilizan)
        private void pictureBox2_Click(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void Login_Load(object sender, EventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void txtName_Click(object sender, EventArgs e) { }
    }
}
