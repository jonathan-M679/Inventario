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
    public partial class UserAccount : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;

        MainFormRoot main2;
        public string username;
        string name;
        string role;
        string accstatus;


        public UserAccount(MainFormRoot mn)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            main2 = mn;
            LoadUser();
            dgvUser.ReadOnly = true; // Establecer el DataGridView como solo lectura
        }




        public void LoadUser()
        {
            int i = 0;
            dgvUser.Rows.Clear();
            cm = new SqlCommand("SELECT * FROM tbUser", cn);
            cn.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvUser.Rows.Add(i, dr[0].ToString(), dr[3].ToString(), dr[4].ToString(), dr[2].ToString());
            }
            dr.Close();
            cn.Close();
        }

        public void Clear()
        {
            txtName.Clear();
            txtPass.Clear();
            txtRePass.Clear();
            txtUsername.Clear();
            cbRole.Text = "";
            txtUsername.Focus();
        }
        private void btnAccSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar si algún campo está vacío
                if (string.IsNullOrWhiteSpace(txtUsername.Text) ||
                    string.IsNullOrWhiteSpace(txtPass.Text) ||
                    string.IsNullOrWhiteSpace(txtRePass.Text) ||
                    string.IsNullOrWhiteSpace(txtName.Text) ||
                    cbRole.SelectedItem == null)
                {
                    MessageBox.Show("Por favor, llene todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Verificar si las contraseñas coinciden
                if (txtPass.Text != txtRePass.Text)
                {
                    MessageBox.Show("¡La contraseña no coincide!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Verificar si la longitud de la contraseña es mayor a 8 caracteres
                if (txtPass.Text.Length <= 7)
                {
                    MessageBox.Show("¡Debe tener al menos 8 caracteres!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Verificar si el usuario ya existe
                cn.Open();
                SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM tbUser WHERE username = @username", cn);
                checkCmd.Parameters.AddWithValue("@username", txtUsername.Text);
                int userCount = (int)checkCmd.ExecuteScalar();
                cn.Close();

                if (userCount > 0)
                {
                    MessageBox.Show("¡El nombre de usuario ya existe!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Verificar si el rol seleccionado es válido
                string selectedRole = cbRole.SelectedItem.ToString();
                if (selectedRole != "Cajero" && selectedRole != "Administrador")
                {
                    MessageBox.Show("Por favor, seleccione un rol válido (Cajero o Administrador).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Si el usuario no existe y el rol es válido, proceder con la inserción
                cn.Open();
                cm = new SqlCommand("Insert into tbUser(username, password, role, name) Values (@username, @password, @role, @name)", cn);
                cm.Parameters.AddWithValue("@username", txtUsername.Text);
                cm.Parameters.AddWithValue("@password", txtPass.Text);
                cm.Parameters.AddWithValue("@role", selectedRole);
                cm.Parameters.AddWithValue("@name", txtName.Text);
                cm.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("¡La nueva cuenta se ha guardado con éxito!", "Guardar Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
                LoadUser();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Advertencia");
            }
        }


        private void btnAccCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnPassSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCurPass.Text != main2._pass)
                {
                    MessageBox.Show("¡La contraseña actual no se marcó!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (txtNPass.Text != txtRePass2.Text)
                {
                    MessageBox.Show("La confirmación de la nueva contraseña no coincide", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                dbcon.ExecuteQuery("UPDATE tbUser SET password= '" + txtNPass.Text + "' WHERE username='" + lblUsername.Text + "'");
                MessageBox.Show("¡La contraseña se ha cambiado exitosamente!", "Changed Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void UserAccount_Load(object sender, EventArgs e)
        {
            lblUsername.Text = main2.lblUsername.Text;
        }


        private void btnPassCancel_Click(object sender, EventArgs e)
        {
            ClearCP();
        }

        public void ClearCP()
        {
            txtCurPass.Clear();
            txtNPass.Clear();
            txtRePass2.Clear();
        }

        private void dgvUser_SelectionChanged(object sender, EventArgs e)
        {
            int i = dgvUser.CurrentRow.Index;
            username = dgvUser[1, i].Value.ToString();
            name = dgvUser[2, i].Value.ToString();
            role = dgvUser[4, i].Value.ToString();
            accstatus = dgvUser[3, i].Value.ToString();
            if (lblUsername.Text == username)
            {
                btnRemove.Enabled = false;
                btnResetPass.Enabled = false;
                lblAccNote.Text = "Para cambiar tu contraseña, ve a la etiqueta de cambio de contraseña";

            }
            else
            {
                btnRemove.Enabled = true;
                btnResetPass.Enabled = true;
                lblAccNote.Text = "Para cambiar la contraseña de " + username + ", haga clic en Restablecer contraseña.";
            }
            gbUser.Text = "Contraseña para: " + username;

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Has elegido eliminar esta cuenta de la lista de usuarios de este sistema de punto de venta. \n\n estas seguro de removerlo? '" + username + "' \\ '" + role + "'", "User Account", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes))
            {
                dbcon.ExecuteQuery("DELETE FROM tbUser WHERE username = '" + username + "'");
                MessageBox.Show("La cuenta ha sido eliminada correctamente.");
                LoadUser();
            }
        }

        private void btnResetPass_Click(object sender, EventArgs e)
        {
            ResetPassword reset = new ResetPassword(this);
            reset.ShowDialog();
        }

        private void btnProperties_Click(object sender, EventArgs e)
        {
            UserProperties properties = new UserProperties(this);
            properties.Text = name + "\\" + username + " Properties";
            properties.txtName.Text = name;
            properties.cbRole.Text = role;
            properties.cbActivate.Text = accstatus;
            properties.username = username;
            properties.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void gbUser_Enter(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroTabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
