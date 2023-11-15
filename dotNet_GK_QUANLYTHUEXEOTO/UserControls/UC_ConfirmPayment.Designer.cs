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
            this.dgvBookingDetail = new System.Windows.Forms.DataGridView();
            this.Feature = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtCustomerFullName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCarId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCarType = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookingDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBookingDetail
            // 
            this.dgvBookingDetail.AllowUserToAddRows = false;
            this.dgvBookingDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBookingDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookingDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Feature,
            this.Price});
            this.dgvBookingDetail.Location = new System.Drawing.Point(13, 114);
            this.dgvBookingDetail.Name = "dgvBookingDetail";
            this.dgvBookingDetail.RowTemplate.Height = 25;
            this.dgvBookingDetail.Size = new System.Drawing.Size(664, 414);
            this.dgvBookingDetail.TabIndex = 0;
            // 
            // Feature
            // 
            this.Feature.HeaderText = "Tính năng";
            this.Feature.Name = "Feature";
            // 
            // Price
            // 
            this.Price.HeaderText = "Giá";
            this.Price.Name = "Price";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(445, 548);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(126, 38);
            this.btnConfirm.TabIndex = 1;
            this.btnConfirm.Text = "Xác nhận thanh toán";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(586, 548);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 38);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtCustomerFullName
            // 
            this.txtCustomerFullName.Location = new System.Drawing.Point(105, 23);
            this.txtCustomerFullName.Name = "txtCustomerFullName";
            this.txtCustomerFullName.Size = new System.Drawing.Size(174, 23);
            this.txtCustomerFullName.TabIndex = 3;
            this.txtCustomerFullName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValue_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Khách hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Biển số xe";
            // 
            // txtCarId
            // 
            this.txtCarId.Location = new System.Drawing.Point(105, 65);
            this.txtCarId.Name = "txtCarId";
            this.txtCarId.Size = new System.Drawing.Size(174, 23);
            this.txtCarId.TabIndex = 5;
            this.txtCarId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValue_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(318, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Số điện thoại";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(418, 26);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(174, 23);
            this.txtPhoneNumber.TabIndex = 7;
            this.txtPhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValue_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(318, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Loại xe";
            // 
            // txtCarType
            // 
            this.txtCarType.Location = new System.Drawing.Point(418, 65);
            this.txtCarType.Name = "txtCarType";
            this.txtCarType.Size = new System.Drawing.Size(174, 23);
            this.txtCarType.TabIndex = 9;
            this.txtCarType.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValue_KeyPress);
            // 
            // UC_ConfirmPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCarType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCarId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCustomerFullName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.dgvBookingDetail);
            this.Name = "UC_ConfirmPayment";
            this.Size = new System.Drawing.Size(690, 602);
            this.Load += new System.EventHandler(this.UC_ConfirmPayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookingDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}
