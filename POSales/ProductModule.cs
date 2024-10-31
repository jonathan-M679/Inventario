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
    public partial class ProductModule : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        string stitle = "Point Of Sales";
        Product product;
        public ProductModule(Product pd)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            product = pd;
            LoadBrand();
            LoadCategory();
        }

        public void LoadCategory()
        {
            cboCategory.Items.Clear();
            cboCategory.DataSource = dbcon.getTable("SELECT * FROM tbCategory");
            cboCategory.DisplayMember = "category";
            cboCategory.ValueMember = "id";
        }

        public void LoadBrand()
        {
            cboBrand.Items.Clear();
            cboBrand.DataSource = dbcon.getTable("SELECT * FROM tbBrand");
            cboBrand.DisplayMember = "brand";
            cboBrand.ValueMember = "id";
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void Clear()
        {
            txtPcode.Clear();
            txtBarcode.Clear();
            txtPdesc.Clear();
            txtPrice.Clear();
            cboBrand.SelectedIndex = 0;
            cboCategory.SelectedIndex = 0;
            UDReOrder.Value = 1;

            txtPcode.Enabled = true;
            txtPcode.Focus();
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
        }

        private bool IsValidBarcode(string barcode)
        {
            // Implementa tu lógica de validación de código de barras aquí
            // Por ejemplo, longitud, formato, etc.
            // Aquí se muestra un ejemplo simple que verifica si el código de barras tiene al menos 8 caracteres.
            return barcode.Length >= 8;
        }

        private bool BarcodeExists(string barcode)
        {
            // Verifica si el código de barras ya existe en la base de datos
            cn.Open();
            cm = new SqlCommand("SELECT COUNT(*) FROM tbProduct WHERE barcode = @barcode", cn);
            cm.Parameters.AddWithValue("@barcode", barcode);
            int count = (int)cm.ExecuteScalar();
            cn.Close();

            // Si el conteo es mayor que 0, significa que el código de barras ya existe
            return count > 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtPcode.Text) || string.IsNullOrWhiteSpace(txtBarcode.Text) || string.IsNullOrWhiteSpace(txtPdesc.Text) || cboBrand.SelectedIndex == -1 || cboCategory.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txtPrice.Text))
                {
                    MessageBox.Show("Todos los campos deben ser llenados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validar si el precio es un número
                if (!double.TryParse(txtPrice.Text, out double price))
                {
                    MessageBox.Show("Por favor ingrese un precio válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validar el código de barras
                if (!IsValidBarcode(txtBarcode.Text))
                {
                    MessageBox.Show("Por favor ingrese un código de barras válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Verificar si el código de barras ya existe
                if (BarcodeExists(txtBarcode.Text))
                {
                    MessageBox.Show("El código de barras ya existe. Por favor, ingrese uno diferente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Si el precio es válido y el código de barras es válido y único, proceder con la inserción en la base de datos
                if (MessageBox.Show("¿Estás seguro de que quieres guardar este producto?", "Save Product", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("INSERT INTO tbProduct(pcode, barcode, pdesc, bid, cid, price, reorder)VALUES (@pcode,@barcode,@pdesc,@bid,@cid,@price, @reorder)", cn);
                    cm.Parameters.AddWithValue("@pcode", txtPcode.Text);
                    cm.Parameters.AddWithValue("@barcode", txtBarcode.Text);
                    cm.Parameters.AddWithValue("@pdesc", txtPdesc.Text);
                    cm.Parameters.AddWithValue("@bid", cboBrand.SelectedValue);
                    cm.Parameters.AddWithValue("@cid", cboCategory.SelectedValue);
                    cm.Parameters.AddWithValue("@price", price);
                    cm.Parameters.AddWithValue("@reorder", UDReOrder.Value);
                    cn.Open();
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("El producto se ha guardado correctamente.", stitle);
                    Clear();
                    product.LoadProduct();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtPcode.Text) || string.IsNullOrWhiteSpace(txtBarcode.Text) || string.IsNullOrWhiteSpace(txtPdesc.Text) || cboBrand.SelectedIndex == -1 || cboCategory.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txtPrice.Text))
                {
                    MessageBox.Show("Todos los campos deben ser llenados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                    cn.Close();
                    cn.Open();
                }

                // Validar si el precio es un número
                if (!double.TryParse(txtPrice.Text, out double price))
                {
                    MessageBox.Show("Por favor ingrese un precio válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                    cn.Close();
                    cn.Open();
                }

                // Validar el código de barras
                if (!IsValidBarcode(txtBarcode.Text))
                {
                    MessageBox.Show("Por favor ingrese un código de barras válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                    cn.Close();
                    cn.Open();
                }

                // Verificar si el código de barras ya existe (excepto para el producto que se está actualizando)
                cn.Open();
                cm = new SqlCommand("SELECT COUNT(*) FROM tbProduct WHERE barcode = @barcode AND pcode <> @pcode", cn);
                cm.Parameters.AddWithValue("@barcode", txtBarcode.Text);
                cm.Parameters.AddWithValue("@pcode", txtPcode.Text);
                int count = (int)cm.ExecuteScalar();
                cn.Close();

                if (count > 0)
                {
                    MessageBox.Show("El código de barras ya existe para otro producto. Por favor, ingrese uno diferente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                    cn.Close();
                    cn.Open();
                }

                // Si el precio es válido y el código de barras es válido y único, proceder con la actualización en la base de datos
                if (MessageBox.Show("¿Estás seguro de que quieres actualizar este producto?", "Update Product", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("UPDATE tbProduct SET barcode=@barcode,pdesc=@pdesc,bid=@bid,cid=@cid,price=@price, reorder=@reorder WHERE pcode LIKE @pcode", cn);
                    cm.Parameters.AddWithValue("@pcode", txtPcode.Text);
                    cm.Parameters.AddWithValue("@barcode", txtBarcode.Text);
                    cm.Parameters.AddWithValue("@pdesc", txtPdesc.Text);
                    cm.Parameters.AddWithValue("@bid", cboBrand.SelectedValue);
                    cm.Parameters.AddWithValue("@cid", cboCategory.SelectedValue);
                    cm.Parameters.AddWithValue("@price", price);
                    cm.Parameters.AddWithValue("@reorder", UDReOrder.Value);
                    cn.Open();
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("El producto se ha actualizado correctamente.", stitle);
                    Clear();
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }




        private void ProductModule_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Dispose();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtPcode_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cboBrand_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ProductModule_Load(object sender, EventArgs e)
        {

        }
    }
}
