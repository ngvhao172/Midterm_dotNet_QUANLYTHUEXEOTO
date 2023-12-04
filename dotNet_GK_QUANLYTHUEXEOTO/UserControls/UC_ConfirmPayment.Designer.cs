namespace dotNet_GK_QUANLYTHUEXEOTO.UserControls
{
    partial class UC_ConfirmPayment
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
            dgvBookingDetail = new DataGridView();
            Feature = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            btnConfirm = new Button();
            btnCancel = new Button();
            txtCustomerFullName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtCarId = new TextBox();
            label3 = new Label();
            txtPhoneNumber = new TextBox();
            label4 = new Label();
            txtCarType = new TextBox();
            label5 = new Label();
            txtPaidDay = new TextBox();
            label6 = new Label();
            txtRentDay = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvBookingDetail).BeginInit();
            SuspendLayout();
            // 
            // dgvBookingDetail
            // 
            dgvBookingDetail.AllowUserToAddRows = false;
            dgvBookingDetail.AllowUserToDeleteRows = false;
            dgvBookingDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBookingDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBookingDetail.Columns.AddRange(new DataGridViewColumn[] { Feature, Price });
            dgvBookingDetail.Location = new Point(15, 152);
            dgvBookingDetail.Margin = new Padding(3, 4, 3, 4);
            dgvBookingDetail.Name = "dgvBookingDetail";
            dgvBookingDetail.ReadOnly = true;
            dgvBookingDetail.RowHeadersWidth = 51;
            dgvBookingDetail.RowTemplate.Height = 25;
            dgvBookingDetail.Size = new Size(759, 474);
            dgvBookingDetail.TabIndex = 0;
            // 
            // Feature
            // 
            Feature.HeaderText = "Tính năng";
            Feature.MinimumWidth = 6;
            Feature.Name = "Feature";
            Feature.ReadOnly = true;
            // 
            // Price
            // 
            Price.HeaderText = "Giá";
            Price.MinimumWidth = 6;
            Price.Name = "Price";
            Price.ReadOnly = true;
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(509, 658);
            btnConfirm.Margin = new Padding(3, 4, 3, 4);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(144, 51);
            btnConfirm.TabIndex = 1;
            btnConfirm.Text = "Xác nhận thanh toán";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(670, 658);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(104, 51);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Hủy";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtCustomerFullName
            // 
            txtCustomerFullName.Location = new Point(120, 15);
            txtCustomerFullName.Margin = new Padding(3, 4, 3, 4);
            txtCustomerFullName.Name = "txtCustomerFullName";
            txtCustomerFullName.Size = new Size(198, 27);
            txtCustomerFullName.TabIndex = 3;
            txtCustomerFullName.KeyPress += txtValue_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 19);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 4;
            label1.Text = "Khách hàng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 69);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 6;
            label2.Text = "Biển số xe";
            // 
            // txtCarId
            // 
            txtCarId.Location = new Point(120, 65);
            txtCarId.Margin = new Padding(3, 4, 3, 4);
            txtCarId.Name = "txtCarId";
            txtCarId.Size = new Size(198, 27);
            txtCarId.TabIndex = 5;
            txtCarId.KeyPress += txtValue_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(363, 23);
            label3.Name = "label3";
            label3.Size = new Size(97, 20);
            label3.TabIndex = 8;
            label3.Text = "Số điện thoại";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(478, 19);
            txtPhoneNumber.Margin = new Padding(3, 4, 3, 4);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(198, 27);
            txtPhoneNumber.TabIndex = 7;
            txtPhoneNumber.KeyPress += txtValue_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(363, 69);
            label4.Name = "label4";
            label4.Size = new Size(56, 20);
            label4.TabIndex = 10;
            label4.Text = "Loại xe";
            // 
            // txtCarType
            // 
            txtCarType.Location = new Point(478, 65);
            txtCarType.Margin = new Padding(3, 4, 3, 4);
            txtCarType.Name = "txtCarType";
            txtCarType.Size = new Size(198, 27);
            txtCarType.TabIndex = 9;
            txtCarType.KeyPress += txtValue_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(363, 116);
            label5.Name = "label5";
            label5.Size = new Size(66, 20);
            label5.TabIndex = 14;
            label5.Text = "Ngày trả";
            // 
            // txtPaidDay
            // 
            txtPaidDay.Location = new Point(478, 112);
            txtPaidDay.Margin = new Padding(3, 4, 3, 4);
            txtPaidDay.Name = "txtPaidDay";
            txtPaidDay.Size = new Size(198, 27);
            txtPaidDay.TabIndex = 13;
            txtPaidDay.TextChanged += txtPaidDay_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 116);
            label6.Name = "label6";
            label6.Size = new Size(77, 20);
            label6.TabIndex = 12;
            label6.Text = "Ngày thuê";
            // 
            // txtRentDay
            // 
            txtRentDay.Location = new Point(120, 112);
            txtRentDay.Margin = new Padding(3, 4, 3, 4);
            txtRentDay.Name = "txtRentDay";
            txtRentDay.Size = new Size(198, 27);
            txtRentDay.TabIndex = 11;
            // 
            // UC_ConfirmPayment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label5);
            Controls.Add(txtPaidDay);
            Controls.Add(label6);
            Controls.Add(txtRentDay);
            Controls.Add(label4);
            Controls.Add(txtCarType);
            Controls.Add(label3);
            Controls.Add(txtPhoneNumber);
            Controls.Add(label2);
            Controls.Add(txtCarId);
            Controls.Add(label1);
            Controls.Add(txtCustomerFullName);
            Controls.Add(btnCancel);
            Controls.Add(btnConfirm);
            Controls.Add(dgvBookingDetail);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UC_ConfirmPayment";
            Size = new Size(789, 744);
            Load += UC_ConfirmPayment_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBookingDetail).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvBookingDetail;
        private Button btnConfirm;
        private DataGridViewTextBoxColumn Feature;
        private DataGridViewTextBoxColumn Price;
        private Button btnCancel;
        private TextBox txtCustomerFullName;
        private Label label1;
        private Label label2;
        private TextBox txtCarId;
        private Label label3;
        private TextBox txtPhoneNumber;
        private Label label4;
        private TextBox txtCarType;
        private Label label5;
        private TextBox txtPaidDay;
        private Label label6;
        private TextBox txtRentDay;
    }
}
