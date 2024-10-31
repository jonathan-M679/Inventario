﻿
namespace POSales
{
    partial class UserAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserAccount));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.btnAccSave = new System.Windows.Forms.Button();
            this.btnAccCancel = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cbRole = new System.Windows.Forms.ComboBox();
            this.txtRePass = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.lblUsername = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPassSave = new System.Windows.Forms.Button();
            this.btnPassCancel = new System.Windows.Forms.Button();
            this.txtRePass2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNPass = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCurPass = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.gbUser = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblAccNote = new System.Windows.Forms.Label();
            this.btnResetPass = new System.Windows.Forms.Button();
            this.btnProperties = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.dgvUser = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.metroTabPage3.SuspendLayout();
            this.gbUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(242)))), ((int)(((byte)(219)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 481);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 80);
            this.panel1.TabIndex = 3;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Controls.Add(this.metroTabPage3);
            this.metroTabControl1.Location = new System.Drawing.Point(32, 12);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(928, 452);
            this.metroTabControl1.TabIndex = 4;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.BackColor = System.Drawing.Color.White;
            this.metroTabPage1.Controls.Add(this.btnAccSave);
            this.metroTabPage1.Controls.Add(this.btnAccCancel);
            this.metroTabPage1.Controls.Add(this.txtName);
            this.metroTabPage1.Controls.Add(this.cbRole);
            this.metroTabPage1.Controls.Add(this.txtRePass);
            this.metroTabPage1.Controls.Add(this.txtPass);
            this.metroTabPage1.Controls.Add(this.txtUsername);
            this.metroTabPage1.Controls.Add(this.label6);
            this.metroTabPage1.Controls.Add(this.label5);
            this.metroTabPage1.Controls.Add(this.label4);
            this.metroTabPage1.Controls.Add(this.label3);
            this.metroTabPage1.Controls.Add(this.label2);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 1;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(920, 410);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Crear Usuario";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 1;
            this.metroTabPage1.Click += new System.EventHandler(this.metroTabPage1_Click);
            // 
            // btnAccSave
            // 
            this.btnAccSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAccSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(242)))), ((int)(((byte)(219)))));
            this.btnAccSave.FlatAppearance.BorderSize = 0;
            this.btnAccSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccSave.ForeColor = System.Drawing.Color.Black;
            this.btnAccSave.Location = new System.Drawing.Point(584, 344);
            this.btnAccSave.Name = "btnAccSave";
            this.btnAccSave.Size = new System.Drawing.Size(94, 35);
            this.btnAccSave.TabIndex = 31;
            this.btnAccSave.Text = "Crear";
            this.btnAccSave.UseVisualStyleBackColor = false;
            this.btnAccSave.Click += new System.EventHandler(this.btnAccSave_Click);
            // 
            // btnAccCancel
            // 
            this.btnAccCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAccCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(226)))), ((int)(((byte)(5)))));
            this.btnAccCancel.FlatAppearance.BorderSize = 0;
            this.btnAccCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccCancel.ForeColor = System.Drawing.Color.Black;
            this.btnAccCancel.Location = new System.Drawing.Point(698, 344);
            this.btnAccCancel.Name = "btnAccCancel";
            this.btnAccCancel.Size = new System.Drawing.Size(119, 35);
            this.btnAccCancel.TabIndex = 32;
            this.btnAccCancel.Text = "Cancelar";
            this.btnAccCancel.UseVisualStyleBackColor = false;
            this.btnAccCancel.Click += new System.EventHandler(this.btnAccCancel_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(265, 273);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(527, 30);
            this.txtName.TabIndex = 5;
            // 
            // cbRole
            // 
            this.cbRole.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.cbRole.AllowDrop = true;
            this.cbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRole.FormattingEnabled = true;
            this.cbRole.IntegralHeight = false;
            this.cbRole.Items.AddRange(new object[] {
            "Administrador",
            "Cajero"});
            this.cbRole.Location = new System.Drawing.Point(265, 220);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(527, 30);
            this.cbRole.TabIndex = 4;
            this.cbRole.Tag = "";
            this.cbRole.SelectedIndexChanged += new System.EventHandler(this.cbRole_SelectedIndexChanged);
            // 
            // txtRePass
            // 
            this.txtRePass.Location = new System.Drawing.Point(265, 169);
            this.txtRePass.Name = "txtRePass";
            this.txtRePass.Size = new System.Drawing.Size(527, 30);
            this.txtRePass.TabIndex = 3;
            this.txtRePass.UseSystemPasswordChar = true;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(265, 118);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(527, 30);
            this.txtPass.TabIndex = 3;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(265, 67);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(527, 30);
            this.txtUsername.TabIndex = 3;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(190, 22);
            this.label6.TabIndex = 2;
            this.label6.Text = "Nombre Completo :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 22);
            this.label5.TabIndex = 2;
            this.label5.Text = "Rol :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(224, 22);
            this.label4.TabIndex = 2;
            this.label4.Text = "Rescribe la contraseña:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contraseña :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre de Usuario :";
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.BackColor = System.Drawing.Color.White;
            this.metroTabPage2.Controls.Add(this.lblUsername);
            this.metroTabPage2.Controls.Add(this.pictureBox1);
            this.metroTabPage2.Controls.Add(this.btnPassSave);
            this.metroTabPage2.Controls.Add(this.btnPassCancel);
            this.metroTabPage2.Controls.Add(this.txtRePass2);
            this.metroTabPage2.Controls.Add(this.label10);
            this.metroTabPage2.Controls.Add(this.txtNPass);
            this.metroTabPage2.Controls.Add(this.label9);
            this.metroTabPage2.Controls.Add(this.txtCurPass);
            this.metroTabPage2.Controls.Add(this.label8);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 1;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(920, 410);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Cambiar Contraseña";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 1;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(176, 73);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(103, 23);
            this.lblUsername.TabIndex = 36;
            this.lblUsername.Text = "Username";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(114, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // btnPassSave
            // 
            this.btnPassSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPassSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(242)))), ((int)(((byte)(219)))));
            this.btnPassSave.FlatAppearance.BorderSize = 0;
            this.btnPassSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPassSave.ForeColor = System.Drawing.Color.Black;
            this.btnPassSave.Location = new System.Drawing.Point(587, 321);
            this.btnPassSave.Name = "btnPassSave";
            this.btnPassSave.Size = new System.Drawing.Size(106, 35);
            this.btnPassSave.TabIndex = 33;
            this.btnPassSave.Text = "Cambiar";
            this.btnPassSave.UseVisualStyleBackColor = false;
            this.btnPassSave.Click += new System.EventHandler(this.btnPassSave_Click);
            // 
            // btnPassCancel
            // 
            this.btnPassCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPassCancel.BackColor = System.Drawing.Color.Gainsboro;
            this.btnPassCancel.FlatAppearance.BorderSize = 0;
            this.btnPassCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPassCancel.ForeColor = System.Drawing.Color.Black;
            this.btnPassCancel.Location = new System.Drawing.Point(713, 321);
            this.btnPassCancel.Name = "btnPassCancel";
            this.btnPassCancel.Size = new System.Drawing.Size(110, 35);
            this.btnPassCancel.TabIndex = 34;
            this.btnPassCancel.Text = "Cancelar";
            this.btnPassCancel.UseVisualStyleBackColor = false;
            this.btnPassCancel.Click += new System.EventHandler(this.btnPassCancel_Click);
            // 
            // txtRePass2
            // 
            this.txtRePass2.Location = new System.Drawing.Point(280, 234);
            this.txtRePass2.Name = "txtRePass2";
            this.txtRePass2.Size = new System.Drawing.Size(527, 30);
            this.txtRePass2.TabIndex = 11;
            this.txtRePass2.UseSystemPasswordChar = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(41, 237);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(220, 22);
            this.label10.TabIndex = 10;
            this.label10.Text = "Reescribir Contraseña :";
            // 
            // txtNPass
            // 
            this.txtNPass.Location = new System.Drawing.Point(280, 176);
            this.txtNPass.Name = "txtNPass";
            this.txtNPass.Size = new System.Drawing.Size(527, 30);
            this.txtNPass.TabIndex = 9;
            this.txtNPass.UseSystemPasswordChar = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(41, 179);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(198, 22);
            this.label9.TabIndex = 8;
            this.label9.Text = "Nueva Contraseña :";
            // 
            // txtCurPass
            // 
            this.txtCurPass.Location = new System.Drawing.Point(280, 121);
            this.txtCurPass.Name = "txtCurPass";
            this.txtCurPass.Size = new System.Drawing.Size(527, 30);
            this.txtCurPass.TabIndex = 7;
            this.txtCurPass.UseSystemPasswordChar = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(41, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(194, 22);
            this.label8.TabIndex = 6;
            this.label8.Text = "Contraseña actual :";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.Controls.Add(this.gbUser);
            this.metroTabPage3.Controls.Add(this.btnProperties);
            this.metroTabPage3.Controls.Add(this.btnRemove);
            this.metroTabPage3.Controls.Add(this.dgvUser);
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 1;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(920, 410);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "Activar/Desactivar cuenta";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 1;
            // 
            // gbUser
            // 
            this.gbUser.BackColor = System.Drawing.Color.White;
            this.gbUser.Controls.Add(this.pictureBox2);
            this.gbUser.Controls.Add(this.lblAccNote);
            this.gbUser.Controls.Add(this.btnResetPass);
            this.gbUser.Location = new System.Drawing.Point(14, 307);
            this.gbUser.Name = "gbUser";
            this.gbUser.Size = new System.Drawing.Size(890, 100);
            this.gbUser.TabIndex = 23;
            this.gbUser.TabStop = false;
            this.gbUser.Text = "Contraseña de UserName";
            this.gbUser.Enter += new System.EventHandler(this.gbUser_Enter);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(22, 32);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // lblAccNote
            // 
            this.lblAccNote.AutoSize = true;
            this.lblAccNote.Location = new System.Drawing.Point(103, 27);
            this.lblAccNote.Name = "lblAccNote";
            this.lblAccNote.Size = new System.Drawing.Size(668, 22);
            this.lblAccNote.TabIndex = 0;
            this.lblAccNote.Text = "Para cambiar la contrasena de usuario, da click en reiniciar contrasena.";
            // 
            // btnResetPass
            // 
            this.btnResetPass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResetPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnResetPass.FlatAppearance.BorderSize = 0;
            this.btnResetPass.ForeColor = System.Drawing.Color.Black;
            this.btnResetPass.Location = new System.Drawing.Point(613, 59);
            this.btnResetPass.Name = "btnResetPass";
            this.btnResetPass.Size = new System.Drawing.Size(271, 35);
            this.btnResetPass.TabIndex = 22;
            this.btnResetPass.Text = "Reiniciar Contrasena...";
            this.btnResetPass.UseVisualStyleBackColor = false;
            this.btnResetPass.Click += new System.EventHandler(this.btnResetPass_Click);
            // 
            // btnProperties
            // 
            this.btnProperties.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProperties.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnProperties.FlatAppearance.BorderSize = 0;
            this.btnProperties.ForeColor = System.Drawing.Color.Black;
            this.btnProperties.Location = new System.Drawing.Point(761, 246);
            this.btnProperties.Name = "btnProperties";
            this.btnProperties.Size = new System.Drawing.Size(143, 35);
            this.btnProperties.TabIndex = 22;
            this.btnProperties.Text = "Propiedades";
            this.btnProperties.UseVisualStyleBackColor = false;
            this.btnProperties.Click += new System.EventHandler(this.btnProperties_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.ForeColor = System.Drawing.Color.Black;
            this.btnRemove.Location = new System.Drawing.Point(648, 246);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(111, 35);
            this.btnRemove.TabIndex = 22;
            this.btnRemove.Text = "Eliminar";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // dgvUser
            // 
            this.dgvUser.AllowUserToAddRows = false;
            this.dgvUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUser.BackgroundColor = System.Drawing.Color.White;
            this.dgvUser.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(242)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUser.ColumnHeadersHeight = 30;
            this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column4});
            this.dgvUser.EnableHeadersVisualStyles = false;
            this.dgvUser.Location = new System.Drawing.Point(14, 3);
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.RowHeadersVisible = false;
            this.dgvUser.RowHeadersWidth = 51;
            this.dgvUser.Size = new System.Drawing.Size(890, 237);
            this.dgvUser.TabIndex = 3;
            this.dgvUser.SelectionChanged += new System.EventHandler(this.dgvUser_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "Num";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 80;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.HeaderText = "Nombre de Usuario";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 211;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Nombre Completo";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column5.HeaderText = "Estado de cuenta ";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 207;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column4.HeaderText = "Rol";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 64;
            // 
            // UserAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.ControlBox = false;
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UserAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cusntas de Usarios";
            this.Load += new System.EventHandler(this.UserAccount_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.metroTabPage3.ResumeLayout(false);
            this.gbUser.ResumeLayout(false);
            this.gbUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cbRole;
        private System.Windows.Forms.TextBox txtRePass;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        public System.Windows.Forms.Button btnAccSave;
        public System.Windows.Forms.Button btnAccCancel;
        public System.Windows.Forms.Button btnPassSave;
        public System.Windows.Forms.Button btnPassCancel;
        private System.Windows.Forms.TextBox txtRePass2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNPass;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCurPass;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvUser;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gbUser;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblAccNote;
        public System.Windows.Forms.Button btnResetPass;
        public System.Windows.Forms.Button btnProperties;
        public System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}