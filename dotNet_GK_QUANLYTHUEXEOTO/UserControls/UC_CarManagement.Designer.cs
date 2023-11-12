namespace dotNet_GK_QUANLYTHUEXEOTO.UserControls
{
    partial class UC_CarManagement
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
            this.txtCarIdSearch = new System.Windows.Forms.TextBox();
            this.dgvCars = new System.Windows.Forms.DataGridView();
            this.CarId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Manufacturer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RentPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRentPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCarId = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCarType = new System.Windows.Forms.TextBox();
            this.txtManufacturer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCars)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCarIdSearch
            // 
            this.txtCarIdSearch.Location = new System.Drawing.Point(616, 21);
            this.txtCarIdSearch.Name = "txtCarIdSearch";
            this.txtCarIdSearch.Size = new System.Drawing.Size(199, 23);
            this.txtCarIdSearch.TabIndex = 5;
            this.txtCarIdSearch.TextChanged += new System.EventHandler(this.txtCarIdSearch_TextChanged);
            // 
            // dgvCars
            // 
            this.dgvCars.AllowUserToAddRows = false;
            this.dgvCars.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCars.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CarId,
            this.CarType,
            this.Manufacturer,
            this.Model,
            this.RentPrice,
            this.Status});
            this.dgvCars.Location = new System.Drawing.Point(32, 50);
            this.dgvCars.Name = "dgvCars";
            this.dgvCars.RowTemplate.Height = 25;
            this.dgvCars.Size = new System.Drawing.Size(783, 428);
            this.dgvCars.TabIndex = 0;
            this.dgvCars.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCars_RowHeaderMouseClick);
            // 
            // CarId
            // 
            this.CarId.HeaderText = "Biển số";
            this.CarId.Name = "CarId";
            // 
            // CarType
            // 
            this.CarType.HeaderText = "Loại xe";
            this.CarType.Name = "CarType";
            // 
            // Manufacturer
            // 
            this.Manufacturer.HeaderText = "Nhà sản xuất";
            this.Manufacturer.Name = "Manufacturer";
            // 
            // Model
            // 
            this.Model.HeaderText = "Mẫu";
            this.Model.Name = "Model";
            // 
            // RentPrice
            // 
            this.RentPrice.HeaderText = "Giá thuê";
            this.RentPrice.Name = "RentPrice";
            // 
            // Status
            // 
            this.Status.HeaderText = "Trạng thái";
            this.Status.Name = "Status";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCarIdSearch);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dgvCars);
            this.groupBox2.Location = new System.Drawing.Point(526, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(837, 507);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách xe";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(543, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tìm kiếm";
            // 
            // txtRentPrice
            // 
            this.txtRentPrice.Location = new System.Drawing.Point(114, 210);
            this.txtRentPrice.Name = "txtRentPrice";
            this.txtRentPrice.Size = new System.Drawing.Size(268, 23);
            this.txtRentPrice.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Biển số";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 15);
            this.label6.TabIndex = 20;
            this.label6.Text = "Giá thuê";
            // 
            // txtCarId
            // 
            this.txtCarId.Location = new System.Drawing.Point(114, 37);
            this.txtCarId.Name = "txtCarId";
            this.txtCarId.Size = new System.Drawing.Size(268, 23);
            this.txtCarId.TabIndex = 13;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(114, 164);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(268, 23);
            this.txtModel.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "Loại xe";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 15);
            this.label5.TabIndex = 18;
            this.label5.Text = "Mẫu ";
            // 
            // txtCarType
            // 
            this.txtCarType.Location = new System.Drawing.Point(114, 78);
            this.txtCarType.Name = "txtCarType";
            this.txtCarType.Size = new System.Drawing.Size(268, 23);
            this.txtCarType.TabIndex = 15;
            // 
            // txtManufacturer
            // 
            this.txtManufacturer.Location = new System.Drawing.Point(114, 119);
            this.txtManufacturer.Name = "txtManufacturer";
            this.txtManufacturer.Size = new System.Drawing.Size(268, 23);
            this.txtManufacturer.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "Nhà sản xuất";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.txtRentPrice);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtCarId);
            this.groupBox1.Controls.Add(this.txtModel);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtCarType);
            this.groupBox1.Controls.Add(this.txtManufacturer);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(25, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(422, 507);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin xe ô tô";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(307, 269);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 17;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(208, 269);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(114, 269);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // UC_CarManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "UC_CarManagement";
            this.Size = new System.Drawing.Size(1388, 558);
            this.Load += new System.EventHandler(this.UC_CarManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCars)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox txtCarIdSearch;
        private DataGridView dgvCars;
        private GroupBox groupBox2;
        private Label label1;
        private TextBox txtRentPrice;
        private Label label2;
        private Label label6;
        private TextBox txtCarId;
        private TextBox txtModel;
        private Label label3;
        private Label label5;
        private TextBox txtCarType;
        private TextBox txtManufacturer;
        private Label label4;
        private GroupBox groupBox1;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnAdd;
        private DataGridViewTextBoxColumn CarId;
        private DataGridViewTextBoxColumn CarType;
        private DataGridViewTextBoxColumn Manufacturer;
        private DataGridViewTextBoxColumn Model;
        private DataGridViewTextBoxColumn RentPrice;
        private DataGridViewTextBoxColumn Status;
    }
}
