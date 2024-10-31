using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace POSales
{
    public partial class Void : Form
    {
        SqlConnection cn;
        SqlCommand cm;
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;
        CancelOrder cancelOrder;

        public Void(CancelOrder cancel)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            cancelOrder = cancel;
        }

        private void btnVoid_Click(object sender, EventArgs e)
        {
            try
            {
                string user;
                cn.Open();
                cm = new SqlCommand("SELECT * FROM tbUser WHERE username = @username AND password = @password", cn);
                cm.Parameters.AddWithValue("@username", txtUsername.Text);
                cm.Parameters.AddWithValue("@password", txtPass.Text);
                dr = cm.ExecuteReader();
                if (dr.Read())
                {
                    user = dr["username"].ToString();
                    dr.Close();
                    cn.Close();
                    SaveCancelOrder(user);

                    DialogResult inventoryResult = MessageBox.Show("¿Desea añadir los productos cancelados al inventario?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (inventoryResult == DialogResult.Yes)
                    {
                        UpdateInventory();
                    }

                    cn.Open();
                    cm = new SqlCommand("UPDATE tbCart SET qty = qty - @qty WHERE id = @id", cn);
                    cm.Parameters.AddWithValue("@qty", cancelOrder.udCancelQty.Value);
                    cm.Parameters.AddWithValue("@id", cancelOrder.txtId.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();

                    MessageBox.Show("¡La transacción del pedido ha sido cancelada exitosamente!", "Cancel Order", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                    cancelOrder.ReloadSoldList();
                    cancelOrder.Dispose();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrecta", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dr.Close();
                    cn.Close();
                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UpdateInventory()
        {
            try
            {
                cn.Open();
                cm = new SqlCommand("UPDATE tbProduct SET qty = qty + @qty WHERE pcode = @pcode", cn);
                cm.Parameters.AddWithValue("@qty", cancelOrder.udCancelQty.Value);
                cm.Parameters.AddWithValue("@pcode", cancelOrder.txtPcode.Text);
                cm.ExecuteNonQuery();
                cn.Close();
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "Error al actualizar inventario");
            }
        }

        public void SaveCancelOrder(string user)
        {
            try
            {
                cn.Open();
                cm = new SqlCommand("INSERT INTO tbCancel (transno, pcode, price, qty, total, sdate, voidby, cancelledby, reason, action) VALUES (@transno, @pcode, @price, @qty, @total, @sdate, @voidby, @cancelledby, @reason, @action)", cn);
                cm.Parameters.AddWithValue("@transno", cancelOrder.txtTransno.Text);
                cm.Parameters.AddWithValue("@pcode", cancelOrder.txtPcode.Text);
                cm.Parameters.AddWithValue("@price", double.Parse(cancelOrder.txtPrice.Text));
                cm.Parameters.AddWithValue("@qty", cancelOrder.udCancelQty.Value);  // Corrección aquí
                cm.Parameters.AddWithValue("@total", double.Parse(cancelOrder.txtTotal.Text));
                cm.Parameters.AddWithValue("@sdate", DateTime.Now);
                cm.Parameters.AddWithValue("@voidby", user);
                cm.Parameters.AddWithValue("@cancelledby", cancelOrder.txtCancelBy.Text);
                cm.Parameters.AddWithValue("@reason", cancelOrder.txtReason.Text);
                cm.Parameters.AddWithValue("@action", cancelOrder.cboInventory.Text);
                cm.ExecuteNonQuery();
                cn.Close();
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Void_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Dispose();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Void_Load(object sender, EventArgs e)
        {

        }
    }
}
