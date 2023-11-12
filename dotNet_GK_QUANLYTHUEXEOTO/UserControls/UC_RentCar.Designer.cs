namespace dotNet_GK_QUANLYTHUEXEOTO.UserControls
{
    partial class UC_RentCar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_RentCar));
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvFee = new System.Windows.Forms.DataGridView();
            this.Demand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnRent = new System.Windows.Forms.Button();
            this.rdElectric = new System.Windows.Forms.RadioButton();
            this.rdOil = new System.Windows.Forms.RadioButton();
            this.rdGas = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkListBox = new System.Windows.Forms.CheckedListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.pBCarImage = new System.Windows.Forms.PictureBox();
            this.lbCarName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dgvCarForRent = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFee)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBCarImage)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarForRent)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // Price
            // 
            this.Price.HeaderText = "Giá";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            // 
            // dgvFee
            // 
            this.dgvFee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Demand,
            this.Price});
            this.dgvFee.Location = new System.Drawing.Point(26, 30);
            this.dgvFee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvFee.Name = "dgvFee";
            this.dgvFee.RowHeadersWidth = 51;
            this.dgvFee.RowTemplate.Height = 29;
            this.dgvFee.Size = new System.Drawing.Size(204, 380);
            this.dgvFee.TabIndex = 0;
            // 
            // Demand
            // 
            this.Demand.HeaderText = "Yêu cầu";
            this.Demand.MinimumWidth = 6;
            this.Demand.Name = "Demand";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvFee);
            this.groupBox4.Location = new System.Drawing.Point(1129, 56);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(252, 432);
            this.groupBox4.TabIndex = 25;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chi phí";
            // 
            // btnRent
            // 
            this.btnRent.Location = new System.Drawing.Point(1284, 508);
            this.btnRent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRent.Name = "btnRent";
            this.btnRent.Size = new System.Drawing.Size(97, 35);
            this.btnRent.TabIndex = 24;
            this.btnRent.Text = "Thuê xe";
            this.btnRent.UseVisualStyleBackColor = true;
            this.btnRent.Click += new System.EventHandler(this.btnRent_Click);
            // 
            // rdElectric
            // 
            this.rdElectric.AutoSize = true;
            this.rdElectric.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdElectric.Location = new System.Drawing.Point(342, 30);
            this.rdElectric.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdElectric.Name = "rdElectric";
            this.rdElectric.Size = new System.Drawing.Size(69, 29);
            this.rdElectric.TabIndex = 16;
            this.rdElectric.TabStop = true;
            this.rdElectric.Text = "Điện";
            this.rdElectric.UseVisualStyleBackColor = true;
            this.rdElectric.CheckedChanged += new System.EventHandler(this.rdBtn_CheckedChanged);
            // 
            // rdOil
            // 
            this.rdOil.AutoSize = true;
            this.rdOil.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdOil.Location = new System.Drawing.Point(175, 30);
            this.rdOil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdOil.Name = "rdOil";
            this.rdOil.Size = new System.Drawing.Size(120, 29);
            this.rdOil.TabIndex = 15;
            this.rdOil.TabStop = true;
            this.rdOil.Text = "Dầu Diesel";
            this.rdOil.UseVisualStyleBackColor = true;
            this.rdOil.CheckedChanged += new System.EventHandler(this.rdBtn_CheckedChanged);
            // 
            // rdGas
            // 
            this.rdGas.AutoSize = true;
            this.rdGas.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdGas.Location = new System.Drawing.Point(56, 30);
            this.rdGas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdGas.Name = "rdGas";
            this.rdGas.Size = new System.Drawing.Size(73, 29);
            this.rdGas.TabIndex = 14;
            this.rdGas.TabStop = true;
            this.rdGas.Text = "Xăng";
            this.rdGas.UseVisualStyleBackColor = true;
            this.rdGas.CheckedChanged += new System.EventHandler(this.rdBtn_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdElectric);
            this.groupBox3.Controls.Add(this.rdOil);
            this.groupBox3.Controls.Add(this.rdGas);
            this.groupBox3.Location = new System.Drawing.Point(310, 56);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(538, 77);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Nhiên liệu";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkListBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(50, 257);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(798, 241);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            // 
            // checkListBox
            // 
            this.checkListBox.ColumnWidth = 250;
            this.checkListBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkListBox.FormattingEnabled = true;
            this.checkListBox.Location = new System.Drawing.Point(16, 43);
            this.checkListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkListBox.MultiColumn = true;
            this.checkListBox.Name = "checkListBox";
            this.checkListBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkListBox.Size = new System.Drawing.Size(766, 166);
            this.checkListBox.TabIndex = 13;
            this.checkListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox1_ItemCheck);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(5, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Tính năng";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(16, 13);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(55, 22);
            this.btnBack.TabIndex = 21;
            this.btnBack.Text = "Trở lại";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pBCarImage
            // 
            this.pBCarImage.Image = ((System.Drawing.Image)(resources.GetObject("pBCarImage.Image")));
            this.pBCarImage.Location = new System.Drawing.Point(22, 30);
            this.pBCarImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pBCarImage.Name = "pBCarImage";
            this.pBCarImage.Size = new System.Drawing.Size(190, 101);
            this.pBCarImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBCarImage.TabIndex = 10;
            this.pBCarImage.TabStop = false;
            // 
            // lbCarName
            // 
            this.lbCarName.AutoSize = true;
            this.lbCarName.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbCarName.Location = new System.Drawing.Point(57, 145);
            this.lbCarName.Name = "lbCarName";
            this.lbCarName.Size = new System.Drawing.Size(118, 25);
            this.lbCarName.TabIndex = 9;
            this.lbCarName.Text = "4 chỗ (CUV)";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pBCarImage);
            this.groupBox1.Controls.Add(this.lbCarName);
            this.groupBox1.Location = new System.Drawing.Point(55, 56);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(235, 187);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Xe đang được chọn";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.dtpTo);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.dtpFrom);
            this.groupBox5.Location = new System.Drawing.Point(310, 150);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(538, 93);
            this.groupBox5.TabIndex = 26;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Thời gian thuê";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Đến ngày: ";
            // 
            // dtpTo
            // 
            this.dtpTo.Location = new System.Drawing.Point(80, 57);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(200, 23);
            this.dtpTo.TabIndex = 2;
            this.dtpTo.ValueChanged += new System.EventHandler(this.dtpTo_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Từ ngày: ";
            // 
            // dtpFrom
            // 
            this.dtpFrom.Location = new System.Drawing.Point(80, 28);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(200, 23);
            this.dtpFrom.TabIndex = 0;
            this.dtpFrom.ValueChanged += new System.EventHandler(this.dtpFrom_ValueChanged);
            // 
            // dgvCarForRent
            // 
            this.dgvCarForRent.AllowUserToAddRows = false;
            this.dgvCarForRent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCarForRent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarForRent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dgvCarForRent.Location = new System.Drawing.Point(18, 23);
            this.dgvCarForRent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvCarForRent.Name = "dgvCarForRent";
            this.dgvCarForRent.RowHeadersWidth = 51;
            this.dgvCarForRent.RowTemplate.Height = 29;
            this.dgvCarForRent.Size = new System.Drawing.Size(209, 387);
            this.dgvCarForRent.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Biển số";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Trạng thái";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dgvCarForRent);
            this.groupBox6.Location = new System.Drawing.Point(866, 56);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox6.Size = new System.Drawing.Size(245, 442);
            this.groupBox6.TabIndex = 26;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Xe cho thuê";
            // 
            // UC_RentCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnRent);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.groupBox1);
            this.Name = "UC_RentCar";
            this.Size = new System.Drawing.Size(1394, 564);
            this.Load += new System.EventHandler(this.UC_RentCar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFee)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBCarImage)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarForRent)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridViewTextBoxColumn Price;
        private DataGridView dgvFee;
        private DataGridViewTextBoxColumn Demand;
        private GroupBox groupBox4;
        private Button btnRent;
        private RadioButton rdElectric;
        private RadioButton rdOil;
        private RadioButton rdGas;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private CheckedListBox checkListBox;
        private Label label5;
        private Button btnBack;
        private PictureBox pBCarImage;
        private Label lbCarName;
        private GroupBox groupBox1;
        private GroupBox groupBox5;
        private Label label3;
        private DateTimePicker dtpTo;
        private Label label2;
        private DateTimePicker dtpFrom;
        private DataGridView dgvCarForRent;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private GroupBox groupBox6;
    }
}
