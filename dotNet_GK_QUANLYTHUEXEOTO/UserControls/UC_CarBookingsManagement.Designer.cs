﻿namespace dotNet_GK_QUANLYTHUEXEOTO.UserControls
{
    partial class UC_CarBookingsManagement
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            txtToDate = new TextBox();
            label9 = new Label();
            txtFromDate = new TextBox();
            label8 = new Label();
            txtCarId = new TextBox();
            label7 = new Label();
            txtCarType = new TextBox();
            label2 = new Label();
            label6 = new Label();
            txtFullName = new TextBox();
            txtAddress = new TextBox();
            label3 = new Label();
            label5 = new Label();
            txtPhoneNumber = new TextBox();
            txtEmail = new TextBox();
            label4 = new Label();
            groupBox2 = new GroupBox();
            txtPhoneNumberSearch = new TextBox();
            label1 = new Label();
            dgvBookings = new DataGridView();
            BookingId = new DataGridViewTextBoxColumn();
            CustomerName = new DataGridViewTextBoxColumn();
            CustomerPhoneNumber = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            CarType = new DataGridViewTextBoxColumn();
            CarId = new DataGridViewTextBoxColumn();
            FromDate = new DataGridViewTextBoxColumn();
            ToDate = new DataGridViewTextBoxColumn();
            Amount = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBookings).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtToDate);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txtFromDate);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtCarId);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtCarType);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtFullName);
            groupBox1.Controls.Add(txtAddress);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtPhoneNumber);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(29, 35);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(482, 676);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin đơn đặt";
            // 
            // txtToDate
            // 
            txtToDate.Location = new Point(130, 480);
            txtToDate.Margin = new Padding(3, 4, 3, 4);
            txtToDate.Name = "txtToDate";
            txtToDate.Size = new Size(306, 27);
            txtToDate.TabIndex = 27;
            txtToDate.KeyPress += txtValue_KeyPress;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(23, 484);
            label9.Name = "label9";
            label9.Size = new Size(72, 20);
            label9.TabIndex = 26;
            label9.Text = "Đến ngày";
            // 
            // txtFromDate
            // 
            txtFromDate.Location = new Point(130, 415);
            txtFromDate.Margin = new Padding(3, 4, 3, 4);
            txtFromDate.Name = "txtFromDate";
            txtFromDate.Size = new Size(306, 27);
            txtFromDate.TabIndex = 25;
            txtFromDate.KeyPress += txtValue_KeyPress;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(23, 419);
            label8.Name = "label8";
            label8.Size = new Size(62, 20);
            label8.TabIndex = 24;
            label8.Text = "Từ ngày";
            // 
            // txtCarId
            // 
            txtCarId.Location = new Point(130, 347);
            txtCarId.Margin = new Padding(3, 4, 3, 4);
            txtCarId.Name = "txtCarId";
            txtCarId.Size = new Size(306, 27);
            txtCarId.TabIndex = 23;
            txtCarId.KeyPress += txtValue_KeyPress;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(23, 351);
            label7.Name = "label7";
            label7.Size = new Size(57, 20);
            label7.TabIndex = 22;
            label7.Text = "Biển số";
            // 
            // txtCarType
            // 
            txtCarType.Location = new Point(130, 280);
            txtCarType.Margin = new Padding(3, 4, 3, 4);
            txtCarType.Name = "txtCarType";
            txtCarType.Size = new Size(306, 27);
            txtCarType.TabIndex = 21;
            txtCarType.KeyPress += txtValue_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 53);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 12;
            label2.Text = "Họ và tên";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 291);
            label6.Name = "label6";
            label6.Size = new Size(56, 20);
            label6.TabIndex = 20;
            label6.Text = "Loại xe";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(130, 49);
            txtFullName.Margin = new Padding(3, 4, 3, 4);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(306, 27);
            txtFullName.TabIndex = 13;
            txtFullName.KeyPress += txtValue_KeyPress;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(130, 219);
            txtAddress.Margin = new Padding(3, 4, 3, 4);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(306, 27);
            txtAddress.TabIndex = 19;
            txtAddress.KeyPress += txtValue_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 108);
            label3.Name = "label3";
            label3.Size = new Size(97, 20);
            label3.TabIndex = 14;
            label3.Text = "Số điện thoại";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 223);
            label5.Name = "label5";
            label5.Size = new Size(55, 20);
            label5.TabIndex = 18;
            label5.Text = "Địa chỉ";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(130, 104);
            txtPhoneNumber.Margin = new Padding(3, 4, 3, 4);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(306, 27);
            txtPhoneNumber.TabIndex = 15;
            txtPhoneNumber.KeyPress += txtValue_KeyPress;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(130, 159);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(306, 27);
            txtEmail.TabIndex = 17;
            txtEmail.KeyPress += txtValue_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 163);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 16;
            label4.Text = "Email";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtPhoneNumberSearch);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(dgvBookings);
            groupBox2.Location = new Point(601, 35);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(957, 676);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Các đơn đặt";
            // 
            // txtPhoneNumberSearch
            // 
            txtPhoneNumberSearch.Location = new Point(704, 28);
            txtPhoneNumberSearch.Margin = new Padding(3, 4, 3, 4);
            txtPhoneNumberSearch.Name = "txtPhoneNumberSearch";
            txtPhoneNumberSearch.Size = new Size(227, 27);
            txtPhoneNumberSearch.TabIndex = 5;
            txtPhoneNumberSearch.TextChanged += txtPhoneNumberSearch_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(610, 32);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 4;
            label1.Text = "Tìm kiếm";
            // 
            // dgvBookings
            // 
            dgvBookings.AllowUserToAddRows = false;
            dgvBookings.AllowUserToDeleteRows = false;
            dgvBookings.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBookings.Columns.AddRange(new DataGridViewColumn[] { BookingId, CustomerName, CustomerPhoneNumber, Email, Address, CarType, CarId, FromDate, ToDate, Amount });
            dgvBookings.Location = new Point(37, 67);
            dgvBookings.Margin = new Padding(3, 4, 3, 4);
            dgvBookings.Name = "dgvBookings";
            dgvBookings.ReadOnly = true;
            dgvBookings.RowHeadersWidth = 51;
            dgvBookings.RowTemplate.Height = 25;
            dgvBookings.Size = new Size(895, 571);
            dgvBookings.TabIndex = 0;
            dgvBookings.RowHeaderMouseClick += dgvBookings_RowHeaderMouseClick;
            // 
            // BookingId
            // 
            BookingId.HeaderText = "Mã đơn đặt";
            BookingId.MinimumWidth = 6;
            BookingId.Name = "BookingId";
            BookingId.ReadOnly = true;
            BookingId.Width = 125;
            // 
            // CustomerName
            // 
            CustomerName.HeaderText = "Khách hàng";
            CustomerName.MinimumWidth = 6;
            CustomerName.Name = "CustomerName";
            CustomerName.ReadOnly = true;
            CustomerName.Width = 125;
            // 
            // CustomerPhoneNumber
            // 
            CustomerPhoneNumber.HeaderText = "Số điện thoại";
            CustomerPhoneNumber.MinimumWidth = 6;
            CustomerPhoneNumber.Name = "CustomerPhoneNumber";
            CustomerPhoneNumber.ReadOnly = true;
            CustomerPhoneNumber.Width = 125;
            // 
            // Email
            // 
            Email.HeaderText = "Email";
            Email.MinimumWidth = 6;
            Email.Name = "Email";
            Email.ReadOnly = true;
            Email.Width = 125;
            // 
            // Address
            // 
            Address.HeaderText = "Địa chỉ";
            Address.MinimumWidth = 6;
            Address.Name = "Address";
            Address.ReadOnly = true;
            Address.Width = 125;
            // 
            // CarType
            // 
            CarType.HeaderText = "Loại xe";
            CarType.MinimumWidth = 6;
            CarType.Name = "CarType";
            CarType.ReadOnly = true;
            CarType.Width = 125;
            // 
            // CarId
            // 
            CarId.HeaderText = "Biển số";
            CarId.MinimumWidth = 6;
            CarId.Name = "CarId";
            CarId.ReadOnly = true;
            CarId.Width = 125;
            // 
            // FromDate
            // 
            FromDate.HeaderText = "Từ ngày";
            FromDate.MinimumWidth = 6;
            FromDate.Name = "FromDate";
            FromDate.ReadOnly = true;
            FromDate.Width = 125;
            // 
            // ToDate
            // 
            ToDate.HeaderText = "Đến ngày";
            ToDate.MinimumWidth = 6;
            ToDate.Name = "ToDate";
            ToDate.ReadOnly = true;
            ToDate.Width = 125;
            // 
            // Amount
            // 
            Amount.HeaderText = "Tổng tiền";
            Amount.MinimumWidth = 6;
            Amount.Name = "Amount";
            Amount.ReadOnly = true;
            Amount.Width = 125;
            // 
            // UC_CarBookingsManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UC_CarBookingsManagement";
            Size = new Size(1586, 744);
            Load += UC_CarBookingsManagement_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBookings).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private TextBox txtFromDate;
        private Label label8;
        private TextBox txtCarId;
        private Label label7;
        private TextBox txtCarType;
        private Label label2;
        private Label label6;
        private TextBox txtFullName;
        private TextBox txtAddress;
        private Label label3;
        private Label label5;
        private TextBox txtPhoneNumber;
        private TextBox txtEmail;
        private Label label4;
        private TextBox txtToDate;
        private Label label9;
        private GroupBox groupBox2;
        private TextBox txtPhoneNumberSearch;
        private Label label1;
        private DataGridView dgvBookings;
        private DataGridViewTextBoxColumn BookingId;
        private DataGridViewTextBoxColumn CustomerName;
        private DataGridViewTextBoxColumn CustomerPhoneNumber;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn CarType;
        private DataGridViewTextBoxColumn CarId;
        private DataGridViewTextBoxColumn FromDate;
        private DataGridViewTextBoxColumn ToDate;
        private DataGridViewTextBoxColumn Amount;
    }
}
