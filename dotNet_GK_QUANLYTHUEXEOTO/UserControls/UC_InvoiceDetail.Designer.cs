namespace dotNet_GK_QUANLYTHUEXEOTO.UserControls
{
    partial class UC_InvoiceDetail
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label5 = new Label();
            txtPaidDay = new TextBox();
            label6 = new Label();
            txtRentDay = new TextBox();
            label4 = new Label();
            txtCarType = new TextBox();
            label3 = new Label();
            txtPhoneNumber = new TextBox();
            label2 = new Label();
            txtCarId = new TextBox();
            txtCustomerFullName = new TextBox();
            label1 = new Label();
            dgvInvoiceDetail = new DataGridView();
            STT = new DataGridViewTextBoxColumn();
            Feature = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            label7 = new Label();
            label8 = new Label();
            txtEmployee = new TextBox();
            label9 = new Label();
            txtCreate = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvInvoiceDetail).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(411, 164);
            label5.Name = "label5";
            label5.Size = new Size(66, 20);
            label5.TabIndex = 29;
            label5.Text = "Ngày trả";
            // 
            // txtPaidDay
            // 
            txtPaidDay.Location = new Point(526, 160);
            txtPaidDay.Margin = new Padding(3, 4, 3, 4);
            txtPaidDay.Name = "txtPaidDay";
            txtPaidDay.Size = new Size(198, 27);
            txtPaidDay.TabIndex = 28;
            txtPaidDay.KeyPress += txtValue_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(63, 164);
            label6.Name = "label6";
            label6.Size = new Size(77, 20);
            label6.TabIndex = 27;
            label6.Text = "Ngày thuê";
            // 
            // txtRentDay
            // 
            txtRentDay.Location = new Point(168, 160);
            txtRentDay.Margin = new Padding(3, 4, 3, 4);
            txtRentDay.Name = "txtRentDay";
            txtRentDay.Size = new Size(198, 27);
            txtRentDay.TabIndex = 26;
            txtRentDay.KeyPress += txtValue_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(411, 117);
            label4.Name = "label4";
            label4.Size = new Size(56, 20);
            label4.TabIndex = 25;
            label4.Text = "Loại xe";
            // 
            // txtCarType
            // 
            txtCarType.Location = new Point(526, 113);
            txtCarType.Margin = new Padding(3, 4, 3, 4);
            txtCarType.Name = "txtCarType";
            txtCarType.Size = new Size(198, 27);
            txtCarType.TabIndex = 24;
            txtCarType.KeyPress += txtValue_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(411, 68);
            label3.Name = "label3";
            label3.Size = new Size(97, 20);
            label3.TabIndex = 23;
            label3.Text = "Số điện thoại";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(526, 64);
            txtPhoneNumber.Margin = new Padding(3, 4, 3, 4);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(198, 27);
            txtPhoneNumber.TabIndex = 22;
            txtPhoneNumber.KeyPress += txtValue_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(63, 117);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 21;
            label2.Text = "Biển số xe";
            // 
            // txtCarId
            // 
            txtCarId.Location = new Point(168, 113);
            txtCarId.Margin = new Padding(3, 4, 3, 4);
            txtCarId.Name = "txtCarId";
            txtCarId.Size = new Size(198, 27);
            txtCarId.TabIndex = 20;
            txtCarId.KeyPress += txtValue_KeyPress;
            // 
            // txtCustomerFullName
            // 
            txtCustomerFullName.Location = new Point(168, 63);
            txtCustomerFullName.Margin = new Padding(3, 4, 3, 4);
            txtCustomerFullName.Name = "txtCustomerFullName";
            txtCustomerFullName.Size = new Size(198, 27);
            txtCustomerFullName.TabIndex = 18;
            txtCustomerFullName.KeyPress += txtValue_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 67);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 19;
            label1.Text = "Khách hàng";
            // 
            // dgvInvoiceDetail
            // 
            dgvInvoiceDetail.AllowUserToAddRows = false;
            dgvInvoiceDetail.AllowUserToDeleteRows = false;
            dgvInvoiceDetail.AllowUserToResizeColumns = false;
            dgvInvoiceDetail.AllowUserToResizeRows = false;
            dgvInvoiceDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInvoiceDetail.BackgroundColor = SystemColors.ButtonHighlight;
            dgvInvoiceDetail.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvInvoiceDetail.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvInvoiceDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvInvoiceDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInvoiceDetail.Columns.AddRange(new DataGridViewColumn[] { STT, Feature, Price });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvInvoiceDetail.DefaultCellStyle = dataGridViewCellStyle3;
            dgvInvoiceDetail.EnableHeadersVisualStyles = false;
            dgvInvoiceDetail.GridColor = SystemColors.HighlightText;
            dgvInvoiceDetail.Location = new Point(15, 264);
            dgvInvoiceDetail.Margin = new Padding(3, 4, 3, 4);
            dgvInvoiceDetail.MultiSelect = false;
            dgvInvoiceDetail.Name = "dgvInvoiceDetail";
            dgvInvoiceDetail.ReadOnly = true;
            dgvInvoiceDetail.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvInvoiceDetail.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvInvoiceDetail.RowHeadersWidth = 51;
            dgvInvoiceDetail.RowTemplate.Height = 25;
            dgvInvoiceDetail.ShowCellToolTips = false;
            dgvInvoiceDetail.Size = new Size(754, 426);
            dgvInvoiceDetail.TabIndex = 15;
            // 
            // STT
            // 
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            STT.DefaultCellStyle = dataGridViewCellStyle2;
            STT.FillWeight = 16.04278F;
            STT.HeaderText = "STT";
            STT.MinimumWidth = 6;
            STT.Name = "STT";
            STT.ReadOnly = true;
            // 
            // Feature
            // 
            Feature.FillWeight = 141.9786F;
            Feature.HeaderText = "Tính năng";
            Feature.MinimumWidth = 6;
            Feature.Name = "Feature";
            Feature.ReadOnly = true;
            // 
            // Price
            // 
            Price.FillWeight = 141.9786F;
            Price.HeaderText = "Giá";
            Price.MinimumWidth = 6;
            Price.Name = "Price";
            Price.ReadOnly = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(336, 10);
            label7.Name = "label7";
            label7.Size = new Size(131, 38);
            label7.TabIndex = 30;
            label7.Text = "Hóa đơn";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(63, 208);
            label8.Name = "label8";
            label8.Size = new Size(75, 20);
            label8.TabIndex = 32;
            label8.Text = "Nhân viên";
            // 
            // txtEmployee
            // 
            txtEmployee.Location = new Point(168, 204);
            txtEmployee.Margin = new Padding(3, 4, 3, 4);
            txtEmployee.Name = "txtEmployee";
            txtEmployee.Size = new Size(198, 27);
            txtEmployee.TabIndex = 31;
            txtEmployee.KeyPress += txtValue_KeyPress;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(411, 209);
            label9.Name = "label9";
            label9.Size = new Size(70, 20);
            label9.TabIndex = 34;
            label9.Text = "Ngày tạo";
            // 
            // txtCreate
            // 
            txtCreate.Location = new Point(526, 205);
            txtCreate.Margin = new Padding(3, 4, 3, 4);
            txtCreate.Name = "txtCreate";
            txtCreate.Size = new Size(198, 27);
            txtCreate.TabIndex = 33;
            txtCreate.KeyPress += txtValue_KeyPress;
            // 
            // UC_InvoiceDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label9);
            Controls.Add(txtCreate);
            Controls.Add(label8);
            Controls.Add(txtEmployee);
            Controls.Add(label7);
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
            Controls.Add(txtCustomerFullName);
            Controls.Add(label1);
            Controls.Add(dgvInvoiceDetail);
            Name = "UC_InvoiceDetail";
            Size = new Size(789, 744);
            Load += UC_InvoiceDetail_Load;
            ((System.ComponentModel.ISupportInitialize)dgvInvoiceDetail).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private TextBox txtPaidDay;
        private Label label6;
        private TextBox txtRentDay;
        private Label label4;
        private TextBox txtCarType;
        private Label label3;
        private TextBox txtPhoneNumber;
        private Label label2;
        private TextBox txtCarId;
        private TextBox txtCustomerFullName;
        private Label label1;
        private DataGridView dgvInvoiceDetail;
        private Label label7;
        private Label label8;
        private TextBox txtEmployee;
        private Label label9;
        private TextBox txtCreate;
        private DataGridViewTextBoxColumn STT;
        private DataGridViewTextBoxColumn Feature;
        private DataGridViewTextBoxColumn Price;
    }
}
