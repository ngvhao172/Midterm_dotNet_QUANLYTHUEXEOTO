namespace dotNet_GK_QUANLYTHUEXEOTO.UserControls
{
    partial class UC_ReportAndStatistic
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtRevenue = new System.Windows.Forms.TextBox();
            this.txtNumberOfBooking = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGetStatistic = new System.Windows.Forms.Button();
            this.dtpDateTo = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDateFrom = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbModels = new System.Windows.Forms.ComboBox();
            this.cbManufacturers = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbTime = new System.Windows.Forms.ComboBox();
            this.chartForRevenue = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            this.chartForCarStatistic = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.btnGetStatistic);
            this.groupBox1.Controls.Add(this.dtpDateTo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpDateFrom);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbModels);
            this.groupBox1.Controls.Add(this.cbManufacturers);
            this.groupBox1.Location = new System.Drawing.Point(12, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(379, 629);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Báo cáo";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtRevenue);
            this.groupBox3.Controls.Add(this.txtNumberOfBooking);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(34, 244);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(317, 224);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thống kê";
            // 
            // txtRevenue
            // 
            this.txtRevenue.Location = new System.Drawing.Point(134, 78);
            this.txtRevenue.Name = "txtRevenue";
            this.txtRevenue.Size = new System.Drawing.Size(166, 23);
            this.txtRevenue.TabIndex = 3;
            this.txtRevenue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValue_KeyPress);
            // 
            // txtNumberOfBooking
            // 
            this.txtNumberOfBooking.Location = new System.Drawing.Point(134, 34);
            this.txtNumberOfBooking.Name = "txtNumberOfBooking";
            this.txtNumberOfBooking.Size = new System.Drawing.Size(166, 23);
            this.txtNumberOfBooking.TabIndex = 2;
            this.txtNumberOfBooking.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValue_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Doanh thu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Số lượng đơn đặt";
            // 
            // btnGetStatistic
            // 
            this.btnGetStatistic.Location = new System.Drawing.Point(269, 197);
            this.btnGetStatistic.Name = "btnGetStatistic";
            this.btnGetStatistic.Size = new System.Drawing.Size(65, 23);
            this.btnGetStatistic.TabIndex = 9;
            this.btnGetStatistic.Text = "Thống kê";
            this.btnGetStatistic.UseVisualStyleBackColor = true;
            this.btnGetStatistic.Click += new System.EventHandler(this.btnGetStatistic_Click);
            // 
            // dtpDateTo
            // 
            this.dtpDateTo.Location = new System.Drawing.Point(111, 158);
            this.dtpDateTo.Name = "dtpDateTo";
            this.dtpDateTo.Size = new System.Drawing.Size(223, 23);
            this.dtpDateTo.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Đến ngày";
            // 
            // dtpDateFrom
            // 
            this.dtpDateFrom.Location = new System.Drawing.Point(111, 117);
            this.dtpDateFrom.Name = "dtpDateFrom";
            this.dtpDateFrom.Size = new System.Drawing.Size(223, 23);
            this.dtpDateFrom.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Từ ngày";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mẫu xe";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hãng xe";
            // 
            // cbModels
            // 
            this.cbModels.FormattingEnabled = true;
            this.cbModels.Location = new System.Drawing.Point(111, 76);
            this.cbModels.Name = "cbModels";
            this.cbModels.Size = new System.Drawing.Size(223, 23);
            this.cbModels.TabIndex = 1;
            // 
            // cbManufacturers
            // 
            this.cbManufacturers.FormattingEnabled = true;
            this.cbManufacturers.Location = new System.Drawing.Point(111, 37);
            this.cbManufacturers.Name = "cbManufacturers";
            this.cbManufacturers.Size = new System.Drawing.Size(223, 23);
            this.cbManufacturers.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbTime);
            this.groupBox2.Controls.Add(this.chartForRevenue);
            this.groupBox2.Controls.Add(this.chartForCarStatistic);
            this.groupBox2.Location = new System.Drawing.Point(416, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(960, 629);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Biểu đồ";
            // 
            // cbTime
            // 
            this.cbTime.FormattingEnabled = true;
            this.cbTime.Items.AddRange(new object[] {
            "Tháng",
            "Năm"});
            this.cbTime.Location = new System.Drawing.Point(815, 22);
            this.cbTime.Name = "cbTime";
            this.cbTime.Size = new System.Drawing.Size(121, 23);
            this.cbTime.TabIndex = 2;
            this.cbTime.SelectedIndexChanged += new System.EventHandler(this.cbTime_SelectedIndexChanged);
            // 
            // chartForRevenue
            // 
            this.chartForRevenue.Location = new System.Drawing.Point(22, 343);
            this.chartForRevenue.Name = "chartForRevenue";
            this.chartForRevenue.Size = new System.Drawing.Size(914, 260);
            this.chartForRevenue.TabIndex = 1;
            // 
            // chartForCarStatistic
            // 
            this.chartForCarStatistic.Location = new System.Drawing.Point(22, 56);
            this.chartForCarStatistic.Name = "chartForCarStatistic";
            this.chartForCarStatistic.Size = new System.Drawing.Size(914, 280);
            this.chartForCarStatistic.TabIndex = 0;
            // 
            // UC_ReportAndStatistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "UC_ReportAndStatistic";
            this.Size = new System.Drawing.Size(1388, 676);
            this.Load += new System.EventHandler(this.UC_ReportAndStatistic_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DateTimePicker dtpDateTo;
        private Label label2;
        private DateTimePicker dtpDateFrom;
        private Label label4;
        private Label label3;
        private ComboBox cbModels;
        private ComboBox cbManufacturers;
        private Button btnGetStatistic;
        private GroupBox groupBox3;
        private Label label6;
        private Label label5;
        private TextBox txtRevenue;
        private TextBox txtNumberOfBooking;
        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart chartForCarStatistic;
        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart chartForRevenue;
        private ComboBox cbTime;
    }
}
