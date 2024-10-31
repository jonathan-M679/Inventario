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
    public partial class Adjustments : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;
        MainForm main;
        MainFormRoot main2;
        int _qty;

        public Adjustments(MainForm mn)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            main = mn;
            ReferenceNo();
            LoadStock();
            lblUsername.Text = main.lblUsername.Text;
        }

        public Adjustments(MainFormRoot mn)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            main2 = mn;
            ReferenceNo();
            LoadStock();
            lblUsername.Text = main2.lblUsername.Text;
        }

        public void ReferenceNo()
        {
            Random rnd = new Random();
            lblRefNo.Text = rnd.Next().ToString();
        }

        public void LoadStock()
        {
            int i = 0;
            dgvAdjustment.Rows.Clear();
            cm = new SqlCommand("SELECT p.pcode, p.barcode, p.pdesc, b.brand, c.category, p.price, p.qty FROM tbProduct AS p INNER JOIN tbBrand AS b ON b.id = p.bid INNER JOIN tbCategory AS c on c.id = p.cid WHERE CONCAT(p.pdesc, b.brand, c.category) LIKE '%" + txtSearch.Text + "%'", cn);
            cn.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvAdjustment.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString());
            }
            dr.Close();
            cn.Close();

            // Set columns to ReadOnly
            foreach (DataGridViewColumn column in dgvAdjustment.Columns)
            {
                column.ReadOnly = true;
            }
        }

        private void dgvAdjustment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvAdjustment.Columns[e.ColumnIndex].Name;
            if (colName == "Select")
            {
                lblPcode.Text = dgvAdjustment.Rows[e.RowIndex].Cells[1].Value.ToString();
                lblDesc.Text = dgvAdjustment.Rows[e.RowIndex].Cells[3].Value.ToString() + " " + dgvAdjustment.Rows[e.RowIndex].Cells[4].Value.ToString() + " " + dgvAdjustment.Rows[e.RowIndex].Cells[5].Value.ToString();
                _qty = int.Parse(dgvAdjustment.Rows[e.RowIndex].Cells[7].Value.ToString());
                btnSave.Enabled = true;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadStock();
        }

        public void Clear()
        {
            lblDesc.Text = "";
            lblPcode.Text = "";
            txtQty.Clear();
            
            cbAction.SelectedIndex = -1; // Clear the combo box selection
            ReferenceNo();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // validation for empty fields
                if (cbAction.SelectedIndex == -1)
                {
                    MessageBox.Show("Por favor, seleccione una acción para agregar o reducir.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbAction.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtQty.Text))
                {
                    MessageBox.Show("Por favor, ingrese la cantidad para agregar o reducir.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtQty.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtRemark.Text))
                {
                    MessageBox.Show("Se necesita una razón para el ajuste de stock.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtRemark.Focus();
                    return;
                }

                // update stock
                if (cbAction.Text == "Eliminar del Inventario")
                {
                    dbcon.ExecuteQuery("UPDATE tbProduct SET qty = (qty - " + int.Parse(txtQty.Text) + ") WHERE pcode LIKE '" + lblPcode.Text + "'");
                }
                else if (cbAction.Text == "Agregar al Inventario")
                {
                    dbcon.ExecuteQuery("UPDATE tbProduct SET qty = (qty + " + int.Parse(txtQty.Text) + ") WHERE pcode LIKE '" + lblPcode.Text + "'");
                }

                dbcon.ExecuteQuery("INSERT INTO tbAdjustment(referenceno, pcode, qty, action, remarks, sdate, [user]) VALUES ('" + lblRefNo.Text + "','" + lblPcode.Text + "','" + int.Parse(txtQty.Text) + "', '" + cbAction.Text + "', '" + txtRemark.Text + "', '" + DateTime.Now.ToShortDateString() + "','" + lblUsername.Text + "')");
                MessageBox.Show("La cantidad en existencia se ha ajustado con éxito.", "Proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadStock();
                Clear();
                btnSave.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void lblRefNo_Click(object sender, EventArgs e)
        {

        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbAction_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
