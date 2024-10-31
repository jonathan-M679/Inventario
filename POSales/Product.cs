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
    public partial class Product : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;

        public Product()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            LoadProduct();
        }

        public void LoadProduct()
        {
            int i = 0;
            dgvProduct.Rows.Clear();
            cm = new SqlCommand("SELECT p.pcode, p.barcode, p.pdesc, b.brand, c.category, p.price, p.reorder FROM tbProduct AS p INNER JOIN tbBrand AS b ON b.id = p.bid INNER JOIN tbCategory AS c on c.id = p.cid WHERE CONCAT(p.pdesc, b.brand, c.category) LIKE '%" + txtSearch.Text + "%'", cn);
            cn.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvProduct.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString());
            }
            dr.Close();
            cn.Close();

            // Set columns to ReadOnly
            foreach (DataGridViewColumn column in dgvProduct.Columns)
            {
                column.ReadOnly = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ProductModule productModule = new ProductModule(this);
            productModule.ShowDialog();
        }

        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvProduct.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                ProductModule product = new ProductModule(this);
                product.txtPcode.Text = dgvProduct.Rows[e.RowIndex].Cells[1].Value.ToString();
                product.txtBarcode.Text = dgvProduct.Rows[e.RowIndex].Cells[2].Value.ToString();
                product.txtPdesc.Text = dgvProduct.Rows[e.RowIndex].Cells[3].Value.ToString();
                product.cboBrand.Text = dgvProduct.Rows[e.RowIndex].Cells[4].Value.ToString();
                product.cboCategory.Text = dgvProduct.Rows[e.RowIndex].Cells[5].Value.ToString();
                product.txtPrice.Text = dgvProduct.Rows[e.RowIndex].Cells[6].Value.ToString();
                product.UDReOrder.Value = int.Parse(dgvProduct.Rows[e.RowIndex].Cells[7].Value.ToString());

                product.txtPcode.Enabled = false;
                product.btnSave.Enabled = false;
                product.btnUpdate.Enabled = true;
                product.ShowDialog();
            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("¿Está seguro de que desea eliminar este registro?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        cn.Open();
                        cm = new SqlCommand("DELETE FROM tbProduct WHERE pcode LIKE @pcode", cn);
                        cm.Parameters.AddWithValue("@pcode", dgvProduct[1, e.RowIndex].Value.ToString());
                        cm.ExecuteNonQuery();
                        cn.Close();
                        MessageBox.Show("El producto se ha eliminado correctamente.", "Point Of Sales", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (SqlException ex)
                    {
                        cn.Close();
                        if (ex.Number == 547) // Error de clave externa
                        {
                            MessageBox.Show("No se puede eliminar el producto porque está en uso en otras tablas.", "Error de eliminación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show("Ocurrió un error al eliminar el producto: " + ex.Message, "Error de eliminación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            LoadProduct();
        }


        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadProduct();
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {

        }

        private void Product_Load(object sender, EventArgs e)
        {

        }
    }
}
