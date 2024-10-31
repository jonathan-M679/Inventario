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
    public partial class ResetPassword : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;
        UserAccount user;
        public ResetPassword(UserAccount account)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            user = account;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtNpass.Text.Length < 8)
            {
                MessageBox.Show("La nueva contraseña debe tener al menos 8 caracteres.", "Add User Wizard", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtNpass.Text != txtResPass.Text)
            {
                MessageBox.Show("La contraseña que ha escrito no coincide. Escriba la contraseña de esta cuenta en ambos cuadros de texto.", "Add User Wizard", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (MessageBox.Show("¿Restablecer contraseña?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    dbcon.ExecuteQuery("UPDATE tbUser SET password = '" + txtNpass.Text + "' WHERE username = '" + user.username + "'");
                    MessageBox.Show("La contraseña se ha restablecido correctamente", "Reset Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
            }
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ResetPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Dispose();
            }
        }

        private void ResetPassword_Load(object sender, EventArgs e)
        {

        }
    }
}
