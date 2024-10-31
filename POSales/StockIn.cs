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
    public partial class StockIn : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;
        string stitle = "Point Of Sales";

        MainFormRoot main2;
        MainForm main;

        public StockIn(MainForm mn)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            main = mn;
            LoadSupplier();
            GetRefeNo();
            txtStockInBy.Text = main.lblUsername.Text;

            // Hacer todos los cuadros de texto de solo lectura excepto txtQTY
            SetReadOnlyTextboxes(this.Controls);
        }

        public StockIn(MainFormRoot mn)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            main2 = mn;
            LoadSupplier();
            GetRefeNo();
            txtStockInBy.Text = main2.lblUsername.Text;

            // Hacer todos los cuadros de texto de solo lectura excepto txtQTY
            SetReadOnlyTextboxes(this.Controls);
        }

        private void SetReadOnlyTextboxes(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                if (control is TextBox && control.Name != "txtQTY")
                {
                    ((TextBox)control).ReadOnly = true;
                }
                else if (control.HasChildren)
                {
                    SetReadOnlyTextboxes(control.Controls);
                }
            }
        }

        public void GetRefeNo()
        {
            Random rnd = new Random();
            txtRefNo.Clear();
            txtRefNo.Text += rnd.Next();
        }

        public void LoadSupplier()
        {
            cbSupplier.Items.Clear();
            cbSupplier.DataSource = dbcon.getTable("SELECT * FROM tbSupplier");
            cbSupplier.DisplayMember = "supplier";
        }

        public void ProductForSupplier(string pcode)
        {
            string supplier = "";
            cn.Open();
            cm = new SqlCommand("SELECT * FROM vwStockIn WHERE pcode LIKE '" + pcode + "'", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                supplier = dr["supplier"].ToString();
            }
            dr.Close();
            cn.Close();
            cbSupplier.Text = supplier;
        }

        public void LoadStockIn()
        {
            int i = 0;
            dgvStockIn.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT * FROM vwStockIn WHERE refno LIKE '" + txtRefNo.Text + "' AND status LIKE 'Pending'", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvStockIn.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr["supplier"].ToString());
            }
            dr.Close();
            cn.Close();
        }

        private void cbSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbSupplier_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void LinGenerate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GetRefeNo();
        }

        private void LinProduct_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProductStockIn productStock = new ProductStockIn(this);
            productStock.ShowDialog();
        }

        private void btnEntry_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvStockIn.Rows.Count > 0)
                {
                    if (MessageBox.Show("¿Está seguro de que desea guardar estos registros?", stitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        for (int i = 0; i < dgvStockIn.Rows.Count; i++)
                        {
                            //update product quantity
                            cn.Open();
                            cm = new SqlCommand("UPDATE tbProduct SET qty = qty + " + int.Parse(dgvStockIn.Rows[i].Cells[5].Value.ToString()) + " WHERE pcode LIKE '" + dgvStockIn.Rows[i].Cells[3].Value.ToString() + "'", cn);
                            cm.ExecuteNonQuery();
                            cn.Close();

                            //update stockin quantity
                            cn.Open();
                            cm = new SqlCommand("UPDATE tbStockIn SET qty = qty + " + int.Parse(dgvStockIn.Rows[i].Cells[5].Value.ToString()) + ", status='Done' WHERE id LIKE '" + dgvStockIn.Rows[i].Cells[1].Value.ToString() + "'", cn);
                            cm.ExecuteNonQuery();
                            cn.Close();
                        }
                        Clear();
                        LoadStockIn();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, stitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }





        private void dgvStockIn_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            // Verificar si la celda editada pertenece al registro número 5
            if (e.RowIndex != 4 || e.ColumnIndex < 0) // Recordar que los índices de fila y columna comienzan desde 0
            {
                e.Cancel = true; // Cancelar la edición si no es el registro número 5
                MessageBox.Show("Solo se puede editar el registro número 5.", stitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void Clear()
        {
            txtRefNo.Clear();
            txtStockInBy.Clear();
            dtStockIn.Value = DateTime.Now;
        }

        private void dgvStockIn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvStockIn.Columns[e.ColumnIndex].Name;
            if (colName == "Delete")
            {
                if (MessageBox.Show("¿Eliminar este artículo?", stitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("DELETE FROM tbStockIn WHERE id='" + dgvStockIn.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("El artículo se ha eliminado con éxito", stitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadStockIn();
                }
            }
        }

        private void cbSupplier_TextChanged(object sender, EventArgs e)
        {
            cn.Open();
            cm = new SqlCommand("SELECT * FROM tbSupplier WHERE supplier LIKE '" + cbSupplier.Text + "'", cn);
            dr = cm.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                lblId.Text = dr["id"].ToString();
                txtConPerson.Text = dr["contactperson"].ToString();
                txtAddress.Text = dr["address"].ToString();
            }
            dr.Close();
            cn.Close();
        }

        private void StockIn_Load(object sender, EventArgs e)
        {

        }

        private void cbSupplier_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
