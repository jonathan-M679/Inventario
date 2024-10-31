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

namespace POSales
{
    public partial class MainForm : Form
    {
        // Conexión y comandos de SQL para interactuar con la base de datos
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;
        public string _pass;

        public MainForm()
        {
            InitializeComponent();
            customizeDesing();
            cn = new SqlConnection(dbcon.myConnection()); // Inicializa la conexión a la base de datos
        }

        #region panelSlide
        // Método para personalizar el diseño de los paneles desplegables
        private void customizeDesing()
        {
            panelSubProduct.Visible = false;
            panelSubRecord.Visible = false;
            panelSubStock.Visible = false;
            panelSubSetting.Visible = false;
        }

        // Oculta todos los submenús
        private void hideSubmenu()
        {
            if (panelSubProduct.Visible == true)
                panelSubProduct.Visible = false;
            if (panelSubRecord.Visible == true)
                panelSubRecord.Visible = false;
            if (panelSubSetting.Visible == true)
                panelSubSetting.Visible = false;
            if (panelSubStock.Visible == true)
                panelSubStock.Visible = false;
        }

        // Muestra el submenú correspondiente
        private void showSubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hideSubmenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }
        #endregion panelSlide

        // Variable para gestionar el formulario hijo activo
        private Form activeForm = null;

        // Método para abrir un formulario hijo dentro del panel principal
        public void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            panelMain.Controls.Add(childForm);
            panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        // Evento para abrir el formulario de Dashboard
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            openChildForm(new Dashboard());
            hideSubmenu();
        }

        // Evento para mostrar el submenú de productos
        private void btnProduct_Click(object sender, EventArgs e)
        {
            showSubmenu(panelSubProduct);
        }

        // Otros eventos para abrir formularios específicos de productos, categorías, etc.
        private void btnProductList_Click(object sender, EventArgs e)
        {
            openChildForm(new Product());
            hideSubmenu();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            openChildForm(new Category());
            hideSubmenu();
        }

        private void btnBrand_Click(object sender, EventArgs e)
        {
            openChildForm(new Brand());
            hideSubmenu();
        }

        private void btnInStock_Click(object sender, EventArgs e)
        {
            showSubmenu(panelSubStock);
        }

        private void btnStockEntry_Click(object sender, EventArgs e)
        {
            openChildForm(new StockIn(this));
            hideSubmenu();
        }

        private void btnStockAdjustment_Click(object sender, EventArgs e)
        {
            openChildForm(new Adjustments(this));
            hideSubmenu();
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            openChildForm(new Supplier());
            hideSubmenu();
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            showSubmenu(panelSubRecord);
        }

        private void btnSaleHist_Click(object sender, EventArgs e)
        {
            openChildForm(new DailySale(this));
            hideSubmenu();
        }

        private void btnPosRecord_Click(object sender, EventArgs e)
        {
            openChildForm(new Record());
            hideSubmenu();
        }

        // Evento para cerrar sesión y volver a la pantalla de inicio de sesión
        private void btnLogout_Click(object sender, EventArgs e)
        {
            hideSubmenu();

            if (MessageBox.Show("¿Salir de la aplicación?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                Login login = new Login();
                login.Show();
            }
        }

        // Carga inicial del formulario principal, se ejecuta al cargar la aplicación
        private void MainForm_Load(object sender, EventArgs e)
        {
            btnDashboard.PerformClick();
            Noti(); // Llamada a la función de notificaciones para artículos críticos
        }

        // Método para mostrar notificaciones de artículos críticos
        public void Noti()
        {
            int i = 0;
            cn.Open();
            cm = new SqlCommand("SELECT * FROM vwCriticalItems", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                Alert alert = new Alert(this);
                alert.lblPcode.Text = dr["pcode"].ToString();
                alert.btnReorder.Enabled = true;
                alert.showAlert(i + ". " + dr["pdesc"].ToString() + " - " + dr["qty"].ToString());
            }
            dr.Close();
            cn.Close();
        }

        // Eventos de pintura para los paneles (pueden personalizarse para añadir gráficos o estilos)
        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelTitle_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
