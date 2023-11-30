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
            this.groupBox1.Location = new System.Drawing.Point(14, 19);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(433, 839);
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
            this.groupBox3.Location = new System.Drawing.Point(39, 325);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(362, 299);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thống kê";
            // 
            // txtRevenue
            // 
            this.txtRevenue.Location = new System.Drawing.Point(153, 104);
            this.txtRevenue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRevenue.Name = "txtRevenue";
            this.txtRevenue.Size = new System.Drawing.Size(189, 27);
            this.txtRevenue.TabIndex = 3;
            this.txtRevenue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValue_KeyPress);
            // 
            // txtNumberOfBooking
            // 
            this.txtNumberOfBooking.Location = new System.Drawing.Point(153, 45);
            this.txtNumberOfBooking.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNumberOfBooking.Name = "txtNumberOfBooking";
            this.txtNumberOfBooking.Size = new System.Drawing.Size(189, 27);
            this.txtNumberOfBooking.TabIndex = 2;
            this.txtNumberOfBooking.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValue_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Doanh thu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Số lượng đơn đặt";
            // 
            // btnGetStatistic
            // 
            this.btnGetStatistic.Location = new System.Drawing.Point(307, 263);
            this.btnGetStatistic.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGetStatistic.Name = "btnGetStatistic";
            this.btnGetStatistic.Size = new System.Drawing.Size(74, 31);
            this.btnGetStatistic.TabIndex = 9;
            this.btnGetStatistic.Text = "Thống kê";
            this.btnGetStatistic.UseVisualStyleBackColor = true;
            this.btnGetStatistic.Click += new System.EventHandler(this.btnGetStatistic_Click);
            // 
            // dtpDateTo
            // 
            this.dtpDateTo.Location = new System.Drawing.Point(127, 211);
            this.dtpDateTo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpDateTo.Name = "dtpDateTo";
            this.dtpDateTo.Size = new System.Drawing.Size(254, 27);
            this.dtpDateTo.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Đến ngày";
            // 
            // dtpDateFrom
            // 
            this.dtpDateFrom.Location = new System.Drawing.Point(127, 156);
            this.dtpDateFrom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpDateFrom.Name = "dtpDateFrom";
            this.dtpDateFrom.Size = new System.Drawing.Size(254, 27);
            this.dtpDateFrom.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Từ ngày";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mẫu xe";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hãng xe";
            // 
            // cbModels
            // 
            this.cbModels.FormattingEnabled = true;
            this.cbModels.Location = new System.Drawing.Point(127, 101);
            this.cbModels.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbModels.Name = "cbModels";
            this.cbModels.Size = new System.Drawing.Size(254, 28);
            this.cbModels.TabIndex = 1;
            // 
            // cbManufacturers
            // 
            this.cbManufacturers.FormattingEnabled = true;
            this.cbManufacturers.Location = new System.Drawing.Point(127, 49);
            this.cbManufacturers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbManufacturers.Name = "cbManufacturers";
            this.cbManufacturers.Size = new System.Drawing.Size(254, 28);
            this.cbManufacturers.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbTime);
            this.groupBox2.Controls.Add(this.chartForRevenue);
            this.groupBox2.Controls.Add(this.chartForCarStatistic);
            this.groupBox2.Location = new System.Drawing.Point(475, 19);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(1097, 839);
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
            this.cbTime.Location = new System.Drawing.Point(931, 29);
            this.cbTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbTime.Name = "cbTime";
            this.cbTime.Size = new System.Drawing.Size(138, 28);
            this.cbTime.TabIndex = 2;
            this.cbTime.SelectedIndexChanged += new System.EventHandler(this.cbTime_SelectedIndexChanged);
            // 
            // chartForRevenue
            // 
            this.chartForRevenue.Location = new System.Drawing.Point(25, 457);
            this.chartForRevenue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chartForRevenue.Name = "chartForRevenue";
            this.chartForRevenue.Size = new System.Drawing.Size(1045, 347);
            this.chartForRevenue.TabIndex = 1;
            // 
            // chartForCarStatistic
            // 
            this.chartForCarStatistic.Location = new System.Drawing.Point(25, 75);
            this.chartForCarStatistic.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chartForCarStatistic.Name = "chartForCarStatistic";
            this.chartForCarStatistic.Size = new System.Drawing.Size(1045, 373);
            this.chartForCarStatistic.TabIndex = 0;
            // 
            // UC_ReportAndStatistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UC_ReportAndStatistic";
            this.Size = new System.Drawing.Size(1586, 901);
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
