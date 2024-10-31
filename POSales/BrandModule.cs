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
    public partial class BrandModule : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        Brand brand;
        public BrandModule(Brand br)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            brand = br;
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // To insert brand name to brand table 
            try
            {
                if (MessageBox.Show("¿Estás seguro de que quieres salvar esta marca?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("INSERT INTO tbBrand(brand)VALUES(@brand)", cn);
                    cm.Parameters.AddWithValue("@brand", txtBrand.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("El registro se ha guardado correctamente.", "POS");
                    Clear();
                    brand.LoadBrand();
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

        public void Clear()
        {
            txtBrand.Clear();
            btnUpdate.Enabled = false;
            btnSave.Enabled = true;
            txtBrand.Focus();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Update brand name
            if (MessageBox.Show("¿Estás seguro de que quieres actualizar esta marca?", "Update Record!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cn.Open();
                cm = new SqlCommand("UPDATE tbBrand SET brand = @brand WHERE id LIKE'" + lblId.Text + "'", cn);
                cm.Parameters.AddWithValue("@brand", txtBrand.Text);
                cm.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("La marca se ha actualizado con éxito.", "POS");
                Clear();
                this.Dispose();// To close this form after update data
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtBrand_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
