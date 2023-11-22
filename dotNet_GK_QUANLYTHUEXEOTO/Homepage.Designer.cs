namespace dotNet_GK_QUANLYTHUEXEOTO
{
    partial class Homepage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Homepage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSchedule = new System.Windows.Forms.Button();
            this.btnReportAndStatistic = new System.Windows.Forms.Button();
            this.btnCustomerManagement = new System.Windows.Forms.Button();
            this.btnCarManagement = new System.Windows.Forms.Button();
            this.btnCarOrders = new System.Windows.Forms.Button();
            this.btnRentCar = new System.Windows.Forms.Button();
            this.btnHomepage = new System.Windows.Forms.Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RosyBrown;
            this.panel1.Controls.Add(this.btn_Logout);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1605, 107);
            this.panel1.TabIndex = 0;
            // 
            // btn_Logout
            // 
            this.btn_Logout.BackColor = System.Drawing.Color.DarkRed;
            this.btn_Logout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Logout.ForeColor = System.Drawing.Color.Snow;
            this.btn_Logout.Location = new System.Drawing.Point(1429, 32);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(130, 44);
            this.btn_Logout.TabIndex = 6;
            this.btn_Logout.Text = "Đăng xuất";
            this.btn_Logout.UseVisualStyleBackColor = false;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click_1);
            // 
            // txtName
            // 
            this.txtName.AutoSize = true;
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtName.Location = new System.Drawing.Point(1165, 38);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(182, 30);
            this.txtName.TabIndex = 2;
            this.txtName.Text = "Xin chào Hào!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(163, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "AUTO CAR";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(32, 16);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSchedule);
            this.panel2.Controls.Add(this.btnReportAndStatistic);
            this.panel2.Controls.Add(this.btnCustomerManagement);
            this.panel2.Controls.Add(this.btnCarManagement);
            this.panel2.Controls.Add(this.btnCarOrders);
            this.panel2.Controls.Add(this.btnRentCar);
            this.panel2.Controls.Add(this.btnHomepage);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 107);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1605, 67);
            this.panel2.TabIndex = 1;
            // 
            // btnSchedule
            // 
            this.btnSchedule.BackColor = System.Drawing.Color.White;
            this.btnSchedule.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSchedule.Location = new System.Drawing.Point(267, 0);
            this.btnSchedule.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Size = new System.Drawing.Size(135, 67);
            this.btnSchedule.TabIndex = 6;
            this.btnSchedule.Text = "Quản lý lịch trình";
            this.btnSchedule.UseVisualStyleBackColor = false;
            this.btnSchedule.Click += new System.EventHandler(this.btnSchedule_Click);
            // 
            // btnReportAndStatistic
            // 
            this.btnReportAndStatistic.BackColor = System.Drawing.Color.White;
            this.btnReportAndStatistic.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReportAndStatistic.Location = new System.Drawing.Point(802, 0);
            this.btnReportAndStatistic.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReportAndStatistic.Name = "btnReportAndStatistic";
            this.btnReportAndStatistic.Size = new System.Drawing.Size(135, 67);
            this.btnReportAndStatistic.TabIndex = 5;
            this.btnReportAndStatistic.Text = "Báo cáo";
            this.btnReportAndStatistic.UseVisualStyleBackColor = false;
            this.btnReportAndStatistic.Click += new System.EventHandler(this.btnReportAndStatistic_Click);
            // 
            // btnCustomerManagement
            // 
            this.btnCustomerManagement.BackColor = System.Drawing.Color.White;
            this.btnCustomerManagement.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCustomerManagement.Location = new System.Drawing.Point(669, 0);
            this.btnCustomerManagement.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCustomerManagement.Name = "btnCustomerManagement";
            this.btnCustomerManagement.Size = new System.Drawing.Size(135, 67);
            this.btnCustomerManagement.TabIndex = 4;
            this.btnCustomerManagement.Text = "Quản lý khách hàng";
            this.btnCustomerManagement.UseVisualStyleBackColor = false;
            this.btnCustomerManagement.Click += new System.EventHandler(this.btnCustomerManagement_Click);
            // 
            // btnCarManagement
            // 
            this.btnCarManagement.BackColor = System.Drawing.Color.White;
            this.btnCarManagement.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCarManagement.Location = new System.Drawing.Point(535, 0);
            this.btnCarManagement.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCarManagement.Name = "btnCarManagement";
            this.btnCarManagement.Size = new System.Drawing.Size(135, 67);
            this.btnCarManagement.TabIndex = 3;
            this.btnCarManagement.Text = "Quản lý ô tô";
            this.btnCarManagement.UseVisualStyleBackColor = false;
            this.btnCarManagement.Click += new System.EventHandler(this.btnCarManagement_Click);
            // 
            // btnCarOrders
            // 
            this.btnCarOrders.BackColor = System.Drawing.Color.White;
            this.btnCarOrders.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCarOrders.Location = new System.Drawing.Point(401, 0);
            this.btnCarOrders.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCarOrders.Name = "btnCarOrders";
            this.btnCarOrders.Size = new System.Drawing.Size(135, 67);
            this.btnCarOrders.TabIndex = 2;
            this.btnCarOrders.Text = "Quản lý đơn đặt";
            this.btnCarOrders.UseVisualStyleBackColor = false;
            this.btnCarOrders.Click += new System.EventHandler(this.btnCarOrders_Click);
            // 
            // btnRentCar
            // 
            this.btnRentCar.BackColor = System.Drawing.Color.White;
            this.btnRentCar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRentCar.Location = new System.Drawing.Point(134, 0);
            this.btnRentCar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRentCar.Name = "btnRentCar";
            this.btnRentCar.Size = new System.Drawing.Size(135, 67);
            this.btnRentCar.TabIndex = 1;
            this.btnRentCar.Text = "Thuê xe";
            this.btnRentCar.UseVisualStyleBackColor = false;
            this.btnRentCar.Click += new System.EventHandler(this.btnRentCar_Click);
            // 
            // btnHomepage
            // 
            this.btnHomepage.BackColor = System.Drawing.Color.White;
            this.btnHomepage.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHomepage.Location = new System.Drawing.Point(0, 0);
            this.btnHomepage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHomepage.Name = "btnHomepage";
            this.btnHomepage.Size = new System.Drawing.Size(135, 67);
            this.btnHomepage.TabIndex = 0;
            this.btnHomepage.Text = "Trang chủ";
            this.btnHomepage.UseVisualStyleBackColor = false;
            this.btnHomepage.Click += new System.EventHandler(this.btnHomepage_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 174);
            this.panelContainer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1605, 819);
            this.panelContainer.TabIndex = 2;
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1605, 993);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Homepage";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Homepage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label txtName;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Button btnHomepage;
        private Button btnRentCar;
        private Button btnSchedule;
        private Button btnReportAndStatistic;
        private Button btnCustomerManagement;
        private Button btnCarManagement;
        private Button btnCarOrders;
        private Panel panelContainer;
        private Button btn_Logout;
    }
}