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
    public partial class ChangePassword : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;
        Cashier cashier;
        public ChangePassword(Cashier cash)
        {
            InitializeComponent();
            cashier = cash;
            lblUsername.Text = cashier.lblUsername.Text;
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                string oldpass = dbcon.getPassword(lblUsername.Text);
                if(oldpass != txtPass.Text)
                {
                    MessageBox.Show("Contraseña incorrecta, ¡inténtelo de nuevo!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    txtPass.Visible = false;
                    btnNext.Visible = false;

                    txtNewPass.Visible = true;
                    txtComPass.Visible = true;
                    btnSave.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtNewPass.Text != txtComPass.Text)
                {
                    MessageBox.Show("¡La nueva contraseña y la contraseña de confirmación no coinciden!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if(MessageBox.Show("¿Cambiar la contraseña?", "Confirm",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                    {
                        dbcon.ExecuteQuery("UPDATE tbUser set password = '" + txtNewPass.Text + "' WHERE username = '" + lblUsername.Text + "'");
                        MessageBox.Show("¡La contraseña se ha actualizado con éxito!", "Save Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Dispose();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void ChangePassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Dispose();
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
