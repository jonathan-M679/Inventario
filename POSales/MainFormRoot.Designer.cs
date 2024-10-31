﻿
namespace POSales
{
    partial class MainFormRoot
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFormRoot));
            this.panelTitle = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.panelSubStock = new System.Windows.Forms.Panel();
            this.btnStockEntry = new System.Windows.Forms.Button();
            this.btnStockAdjustment = new System.Windows.Forms.Button();
            this.btnSupplier = new System.Windows.Forms.Button();
            this.btnRecord = new System.Windows.Forms.Button();
            this.panelSubRecord = new System.Windows.Forms.Panel();
            this.btnSaleHist = new System.Windows.Forms.Button();
            this.btnPosRecord = new System.Windows.Forms.Button();
            this.btnSetting = new System.Windows.Forms.Button();
            this.panelSubSetting = new System.Windows.Forms.Panel();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panelSlide = new System.Windows.Forms.Panel();
            this.btnProductList = new System.Windows.Forms.Button();
            this.btnCategory = new System.Windows.Forms.Button();
            this.btnBrand = new System.Windows.Forms.Button();
            this.panelSubProduct = new System.Windows.Forms.Panel();
            this.btnInStock = new System.Windows.Forms.Button();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelSubStock.SuspendLayout();
            this.panelSubRecord.SuspendLayout();
            this.panelSubSetting.SuspendLayout();
            this.panelSlide.SuspendLayout();
            this.panelSubProduct.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.Black;
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(200, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(984, 40);
            this.panelTitle.TabIndex = 1;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(200, 40);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(984, 723);
            this.panelMain.TabIndex = 2;
            this.panelMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMain_Paint);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.Red;
            this.panelLogo.Controls.Add(this.lblName);
            this.panelLogo.Controls.Add(this.lblUsername);
            this.panelLogo.Controls.Add(this.lblRole);
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(179, 170);
            this.panelLogo.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Red;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(53, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 75);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.ForeColor = System.Drawing.Color.White;
            this.lblRole.Location = new System.Drawing.Point(12, 148);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(146, 22);
            this.lblRole.TabIndex = 0;
            this.lblRole.Text = "S.Administrador";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(52, 115);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(102, 22);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "UserName";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(5, 97);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(31, 22);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Ln";
            this.lblName.Visible = false;
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.Red;
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.Black;
            this.btnDashboard.Location = new System.Drawing.Point(0, 170);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnDashboard.Size = new System.Drawing.Size(179, 66);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "Existencias";
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.BackColor = System.Drawing.Color.Red;
            this.btnProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProduct.FlatAppearance.BorderSize = 0;
            this.btnProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduct.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduct.ForeColor = System.Drawing.Color.Black;
            this.btnProduct.Location = new System.Drawing.Point(0, 236);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnProduct.Size = new System.Drawing.Size(179, 46);
            this.btnProduct.TabIndex = 2;
            this.btnProduct.Text = "Productos";
            this.btnProduct.UseVisualStyleBackColor = false;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // panelSubStock
            // 
            this.panelSubStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(200)))));
            this.panelSubStock.Controls.Add(this.btnStockAdjustment);
            this.panelSubStock.Controls.Add(this.btnStockEntry);
            this.panelSubStock.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubStock.Location = new System.Drawing.Point(0, 486);
            this.panelSubStock.Name = "panelSubStock";
            this.panelSubStock.Size = new System.Drawing.Size(179, 130);
            this.panelSubStock.TabIndex = 0;
            // 
            // btnStockEntry
            // 
            this.btnStockEntry.BackColor = System.Drawing.Color.Red;
            this.btnStockEntry.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStockEntry.FlatAppearance.BorderSize = 0;
            this.btnStockEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStockEntry.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockEntry.ForeColor = System.Drawing.Color.Black;
            this.btnStockEntry.Location = new System.Drawing.Point(0, 0);
            this.btnStockEntry.Name = "btnStockEntry";
            this.btnStockEntry.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnStockEntry.Size = new System.Drawing.Size(179, 54);
            this.btnStockEntry.TabIndex = 4;
            this.btnStockEntry.Text = "Ajustes de Stock";
            this.btnStockEntry.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStockEntry.UseVisualStyleBackColor = false;
            this.btnStockEntry.Click += new System.EventHandler(this.btnStockEntry_Click);
            // 
            // btnStockAdjustment
            // 
            this.btnStockAdjustment.BackColor = System.Drawing.Color.Red;
            this.btnStockAdjustment.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStockAdjustment.FlatAppearance.BorderSize = 0;
            this.btnStockAdjustment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStockAdjustment.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockAdjustment.ForeColor = System.Drawing.Color.Black;
            this.btnStockAdjustment.Location = new System.Drawing.Point(0, 54);
            this.btnStockAdjustment.Name = "btnStockAdjustment";
            this.btnStockAdjustment.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnStockAdjustment.Size = new System.Drawing.Size(179, 76);
            this.btnStockAdjustment.TabIndex = 5;
            this.btnStockAdjustment.Text = "Entrada de Stock ";
            this.btnStockAdjustment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStockAdjustment.UseVisualStyleBackColor = false;
            this.btnStockAdjustment.Click += new System.EventHandler(this.btnStockAdjustment_Click);
            // 
            // btnSupplier
            // 
            this.btnSupplier.BackColor = System.Drawing.Color.Red;
            this.btnSupplier.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSupplier.FlatAppearance.BorderSize = 0;
            this.btnSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupplier.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupplier.ForeColor = System.Drawing.Color.Black;
            this.btnSupplier.Location = new System.Drawing.Point(0, 616);
            this.btnSupplier.Name = "btnSupplier";
            this.btnSupplier.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnSupplier.Size = new System.Drawing.Size(179, 66);
            this.btnSupplier.TabIndex = 4;
            this.btnSupplier.Text = "Proveedor";
            this.btnSupplier.UseVisualStyleBackColor = false;
            this.btnSupplier.Click += new System.EventHandler(this.btnSupplier_Click);
            // 
            // btnRecord
            // 
            this.btnRecord.BackColor = System.Drawing.Color.Red;
            this.btnRecord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRecord.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRecord.FlatAppearance.BorderSize = 0;
            this.btnRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecord.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecord.ForeColor = System.Drawing.Color.Black;
            this.btnRecord.Location = new System.Drawing.Point(0, 682);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnRecord.Size = new System.Drawing.Size(179, 73);
            this.btnRecord.TabIndex = 5;
            this.btnRecord.Text = "Historia ";
            this.btnRecord.UseVisualStyleBackColor = false;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // panelSubRecord
            // 
            this.panelSubRecord.BackColor = System.Drawing.Color.Red;
            this.panelSubRecord.Controls.Add(this.btnPosRecord);
            this.panelSubRecord.Controls.Add(this.btnSaleHist);
            this.panelSubRecord.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubRecord.Location = new System.Drawing.Point(0, 755);
            this.panelSubRecord.Name = "panelSubRecord";
            this.panelSubRecord.Size = new System.Drawing.Size(179, 59);
            this.panelSubRecord.TabIndex = 6;
            // 
            // btnSaleHist
            // 
            this.btnSaleHist.BackColor = System.Drawing.Color.Red;
            this.btnSaleHist.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSaleHist.FlatAppearance.BorderSize = 0;
            this.btnSaleHist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaleHist.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaleHist.ForeColor = System.Drawing.Color.Black;
            this.btnSaleHist.Location = new System.Drawing.Point(0, 0);
            this.btnSaleHist.Name = "btnSaleHist";
            this.btnSaleHist.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnSaleHist.Size = new System.Drawing.Size(179, 32);
            this.btnSaleHist.TabIndex = 4;
            this.btnSaleHist.Text = "Historia de venta";
            this.btnSaleHist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaleHist.UseVisualStyleBackColor = false;
            this.btnSaleHist.Click += new System.EventHandler(this.btnSaleHist_Click);
            // 
            // btnPosRecord
            // 
            this.btnPosRecord.BackColor = System.Drawing.Color.Red;
            this.btnPosRecord.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPosRecord.FlatAppearance.BorderSize = 0;
            this.btnPosRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPosRecord.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPosRecord.ForeColor = System.Drawing.Color.Black;
            this.btnPosRecord.Location = new System.Drawing.Point(0, 32);
            this.btnPosRecord.Name = "btnPosRecord";
            this.btnPosRecord.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnPosRecord.Size = new System.Drawing.Size(179, 27);
            this.btnPosRecord.TabIndex = 5;
            this.btnPosRecord.Text = "POS Record";
            this.btnPosRecord.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPosRecord.UseVisualStyleBackColor = false;
            this.btnPosRecord.Click += new System.EventHandler(this.btnPosRecord_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.BackColor = System.Drawing.Color.Red;
            this.btnSetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSetting.FlatAppearance.BorderSize = 0;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetting.ForeColor = System.Drawing.Color.Black;
            this.btnSetting.Location = new System.Drawing.Point(0, 814);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnSetting.Size = new System.Drawing.Size(179, 61);
            this.btnSetting.TabIndex = 7;
            this.btnSetting.Text = "Usuario";
            this.btnSetting.UseVisualStyleBackColor = false;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // panelSubSetting
            // 
            this.panelSubSetting.BackColor = System.Drawing.Color.Red;
            this.panelSubSetting.Controls.Add(this.btnUser);
            this.panelSubSetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubSetting.Location = new System.Drawing.Point(0, 875);
            this.panelSubSetting.Name = "panelSubSetting";
            this.panelSubSetting.Size = new System.Drawing.Size(179, 74);
            this.panelSubSetting.TabIndex = 8;
            // 
            // btnUser
            // 
            this.btnUser.BackColor = System.Drawing.Color.Red;
            this.btnUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUser.FlatAppearance.BorderSize = 0;
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUser.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.ForeColor = System.Drawing.Color.Black;
            this.btnUser.Location = new System.Drawing.Point(0, 0);
            this.btnUser.Name = "btnUser";
            this.btnUser.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnUser.Size = new System.Drawing.Size(179, 74);
            this.btnUser.TabIndex = 4;
            this.btnUser.Text = "Administrar Usuario";
            this.btnUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUser.UseVisualStyleBackColor = false;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Red;
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.Black;
            this.btnLogout.Location = new System.Drawing.Point(0, 949);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(179, 97);
            this.btnLogout.TabIndex = 9;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // panelSlide
            // 
            this.panelSlide.AutoScroll = true;
            this.panelSlide.Controls.Add(this.btnLogout);
            this.panelSlide.Controls.Add(this.panelSubSetting);
            this.panelSlide.Controls.Add(this.btnSetting);
            this.panelSlide.Controls.Add(this.panelSubRecord);
            this.panelSlide.Controls.Add(this.btnRecord);
            this.panelSlide.Controls.Add(this.btnSupplier);
            this.panelSlide.Controls.Add(this.panelSubStock);
            this.panelSlide.Controls.Add(this.btnInStock);
            this.panelSlide.Controls.Add(this.panelSubProduct);
            this.panelSlide.Controls.Add(this.btnProduct);
            this.panelSlide.Controls.Add(this.btnDashboard);
            this.panelSlide.Controls.Add(this.panelLogo);
            this.panelSlide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSlide.Location = new System.Drawing.Point(0, 0);
            this.panelSlide.Name = "panelSlide";
            this.panelSlide.Size = new System.Drawing.Size(200, 763);
            this.panelSlide.TabIndex = 0;
            // 
            // btnProductList
            // 
            this.btnProductList.BackColor = System.Drawing.Color.Red;
            this.btnProductList.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProductList.FlatAppearance.BorderSize = 0;
            this.btnProductList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductList.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductList.ForeColor = System.Drawing.Color.Black;
            this.btnProductList.Location = new System.Drawing.Point(0, 0);
            this.btnProductList.Name = "btnProductList";
            this.btnProductList.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnProductList.Size = new System.Drawing.Size(179, 61);
            this.btnProductList.TabIndex = 3;
            this.btnProductList.Text = "Lista Producto";
            this.btnProductList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductList.UseVisualStyleBackColor = false;
            this.btnProductList.Click += new System.EventHandler(this.btnProductList_Click);
            // 
            // btnCategory
            // 
            this.btnCategory.BackColor = System.Drawing.Color.Red;
            this.btnCategory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCategory.FlatAppearance.BorderSize = 0;
            this.btnCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategory.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategory.ForeColor = System.Drawing.Color.Black;
            this.btnCategory.Location = new System.Drawing.Point(0, 61);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnCategory.Size = new System.Drawing.Size(179, 43);
            this.btnCategory.TabIndex = 4;
            this.btnCategory.Text = "Categoria";
            this.btnCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategory.UseVisualStyleBackColor = false;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // btnBrand
            // 
            this.btnBrand.BackColor = System.Drawing.Color.Red;
            this.btnBrand.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBrand.FlatAppearance.BorderSize = 0;
            this.btnBrand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrand.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrand.ForeColor = System.Drawing.Color.Black;
            this.btnBrand.Location = new System.Drawing.Point(0, 104);
            this.btnBrand.Name = "btnBrand";
            this.btnBrand.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnBrand.Size = new System.Drawing.Size(179, 51);
            this.btnBrand.TabIndex = 5;
            this.btnBrand.Text = "Marca";
            this.btnBrand.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBrand.UseVisualStyleBackColor = false;
            this.btnBrand.Click += new System.EventHandler(this.btnBrand_Click);
            // 
            // panelSubProduct
            // 
            this.panelSubProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(200)))));
            this.panelSubProduct.Controls.Add(this.btnBrand);
            this.panelSubProduct.Controls.Add(this.btnCategory);
            this.panelSubProduct.Controls.Add(this.btnProductList);
            this.panelSubProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubProduct.Location = new System.Drawing.Point(0, 282);
            this.panelSubProduct.Name = "panelSubProduct";
            this.panelSubProduct.Size = new System.Drawing.Size(179, 155);
            this.panelSubProduct.TabIndex = 0;
            // 
            // btnInStock
            // 
            this.btnInStock.BackColor = System.Drawing.Color.Red;
            this.btnInStock.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInStock.FlatAppearance.BorderSize = 0;
            this.btnInStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInStock.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInStock.ForeColor = System.Drawing.Color.Black;
            this.btnInStock.Location = new System.Drawing.Point(0, 437);
            this.btnInStock.Name = "btnInStock";
            this.btnInStock.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnInStock.Size = new System.Drawing.Size(179, 49);
            this.btnInStock.TabIndex = 3;
            this.btnInStock.Text = "En Stock";
            this.btnInStock.UseVisualStyleBackColor = false;
            this.btnInStock.Click += new System.EventHandler(this.btnInStock_Click);
            // 
            // MainFormRoot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(242)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(1184, 763);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.panelSlide);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(1200, 700);
            this.Name = "MainFormRoot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Punto de Venta";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelSubStock.ResumeLayout(false);
            this.panelSubRecord.ResumeLayout(false);
            this.panelSubSetting.ResumeLayout(false);
            this.panelSlide.ResumeLayout(false);
            this.panelSubProduct.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelLogo;
        public System.Windows.Forms.Label lblName;
        public System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Panel panelSubStock;
        private System.Windows.Forms.Button btnStockAdjustment;
        private System.Windows.Forms.Button btnStockEntry;
        private System.Windows.Forms.Button btnSupplier;
        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.Panel panelSubRecord;
        private System.Windows.Forms.Button btnPosRecord;
        private System.Windows.Forms.Button btnSaleHist;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Panel panelSubSetting;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panelSlide;
        private System.Windows.Forms.Panel panelSubProduct;
        private System.Windows.Forms.Button btnBrand;
        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.Button btnProductList;
        private System.Windows.Forms.Button btnInStock;
    }
}

