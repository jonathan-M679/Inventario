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
    public partial class CancelOrder : Form
    {
        DailySale dailySale;
        public CancelOrder(DailySale sale)
        {
            InitializeComponent();
            dailySale = sale;            
        }

        private void btnCOrder_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboInventory.Text != string.Empty && udCancelQty.Value > 0 && txtReason.Text != string.Empty)
                {
                    int currentInventoryQty = int.Parse(txtQty.Text); // Asume que txtQty es el texto que contiene la cantidad actual en inventario.
                    int cancelQty = (int)udCancelQty.Value;

                    if (currentInventoryQty >= cancelQty)
                    {
                        Void @void = new Void(this);
                        @void.txtUsername.Focus();
                        @void.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("No hay suficiente cantidad en el inventario para cancelar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, complete todos los campos requeridos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        public void ReloadSoldList()
        {
            dailySale.LoadSold();
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cboInventory_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void CancelOrder_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Escape)
            {
                this.Dispose();
            }
        }

        private void udCancelQty_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtTransno_TextChanged(object sender, EventArgs e)
        {

        }

        private void CancelOrder_Load(object sender, EventArgs e)
        {

        }

        private void cboInventory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtCancelBy_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
