namespace Baitaptuan3
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gbThongtin = new System.Windows.Forms.GroupBox();
            this.btexit = new DevExpress.XtraEditors.SimpleButton();
            this.btCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btsave = new DevExpress.XtraEditors.SimpleButton();
            this.btdeleted = new DevExpress.XtraEditors.SimpleButton();
            this.btupdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnew = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.tbxdiachi = new System.Windows.Forms.TextBox();
            this.dtpngaydat = new System.Windows.Forms.DateTimePicker();
            this.cbsodienthoai = new System.Windows.Forms.ComboBox();
            this.tbxtenkhachhang = new System.Windows.Forms.TextBox();
            this.tbxsophieu = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bde = new DevExpress.XtraEditors.SimpleButton();
            this.btadd = new DevExpress.XtraEditors.SimpleButton();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.cbtapchi = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbxtong = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvctdb = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThangBD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThangKT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGiaThang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbThongtin.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvctdb)).BeginInit();
            this.SuspendLayout();
            // 
            // gbThongtin
            // 
            this.gbThongtin.Controls.Add(this.btexit);
            this.gbThongtin.Controls.Add(this.btCancel);
            this.gbThongtin.Controls.Add(this.btsave);
            this.gbThongtin.Controls.Add(this.btdeleted);
            this.gbThongtin.Controls.Add(this.btupdate);
            this.gbThongtin.Controls.Add(this.btnew);
            this.gbThongtin.Controls.Add(this.groupBox1);
            this.gbThongtin.Controls.Add(this.tbxdiachi);
            this.gbThongtin.Controls.Add(this.dtpngaydat);
            this.gbThongtin.Controls.Add(this.cbsodienthoai);
            this.gbThongtin.Controls.Add(this.tbxtenkhachhang);
            this.gbThongtin.Controls.Add(this.tbxsophieu);
            this.gbThongtin.Controls.Add(this.label7);
            this.gbThongtin.Controls.Add(this.label4);
            this.gbThongtin.Controls.Add(this.label3);
            this.gbThongtin.Controls.Add(this.label2);
            this.gbThongtin.Controls.Add(this.label5);
            this.gbThongtin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbThongtin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gbThongtin.Location = new System.Drawing.Point(12, 67);
            this.gbThongtin.Name = "gbThongtin";
            this.gbThongtin.Size = new System.Drawing.Size(1184, 245);
            this.gbThongtin.TabIndex = 0;
            this.gbThongtin.TabStop = false;
            this.gbThongtin.Text = "Thông tin Phiếu Đặt Báo";
            // 
            // btexit
            // 
            this.btexit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btexit.ImageOptions.Image")));
            this.btexit.Location = new System.Drawing.Point(954, 132);
            this.btexit.Name = "btexit";
            this.btexit.Size = new System.Drawing.Size(95, 39);
            this.btexit.TabIndex = 22;
            this.btexit.Text = "Print";
            this.btexit.Click += new System.EventHandler(this.btexit_Click);
            // 
            // btCancel
            // 
            this.btCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btCancel.ImageOptions.Image")));
            this.btCancel.Location = new System.Drawing.Point(954, 85);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(95, 39);
            this.btCancel.TabIndex = 21;
            this.btCancel.Text = "Cancel";
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btsave
            // 
            this.btsave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btsave.ImageOptions.Image")));
            this.btsave.Location = new System.Drawing.Point(954, 35);
            this.btsave.Name = "btsave";
            this.btsave.Size = new System.Drawing.Size(95, 39);
            this.btsave.TabIndex = 20;
            this.btsave.Text = "Save";
            this.btsave.Click += new System.EventHandler(this.btsave_Click);
            // 
            // btdeleted
            // 
            this.btdeleted.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btdeleted.ImageOptions.Image")));
            this.btdeleted.Location = new System.Drawing.Point(834, 132);
            this.btdeleted.Name = "btdeleted";
            this.btdeleted.Size = new System.Drawing.Size(95, 39);
            this.btdeleted.TabIndex = 19;
            this.btdeleted.Text = "Deleted";
            this.btdeleted.Click += new System.EventHandler(this.btdeleted_Click);
            // 
            // btupdate
            // 
            this.btupdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btupdate.ImageOptions.Image")));
            this.btupdate.Location = new System.Drawing.Point(834, 85);
            this.btupdate.Name = "btupdate";
            this.btupdate.Size = new System.Drawing.Size(95, 39);
            this.btupdate.TabIndex = 18;
            this.btupdate.Text = "Update";
            this.btupdate.Click += new System.EventHandler(this.btupdate_Click);
            // 
            // btnew
            // 
            this.btnew.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnew.ImageOptions.Image")));
            this.btnew.Location = new System.Drawing.Point(834, 37);
            this.btnew.Name = "btnew";
            this.btnew.Size = new System.Drawing.Size(95, 39);
            this.btnew.TabIndex = 11;
            this.btnew.Text = "New";
            this.btnew.Click += new System.EventHandler(this.btnew_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.simpleButton4);
            this.groupBox1.Controls.Add(this.simpleButton3);
            this.groupBox1.Controls.Add(this.simpleButton2);
            this.groupBox1.Controls.Add(this.simpleButton1);
            this.groupBox1.Location = new System.Drawing.Point(6, 166);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1178, 73);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // simpleButton4
            // 
            this.simpleButton4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton4.ImageOptions.Image")));
            this.simpleButton4.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.simpleButton4.Location = new System.Drawing.Point(339, 25);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(96, 40);
            this.simpleButton4.TabIndex = 10;
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.simpleButton3.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.simpleButton3.Location = new System.Drawing.Point(229, 25);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Padding = new System.Windows.Forms.Padding(15, 10, 5, 9);
            this.simpleButton3.Size = new System.Drawing.Size(89, 40);
            this.simpleButton3.TabIndex = 9;
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.simpleButton2.Location = new System.Drawing.Point(127, 25);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(84, 40);
            this.simpleButton2.TabIndex = 8;
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.simpleButton1.Location = new System.Drawing.Point(27, 27);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(85, 40);
            this.simpleButton1.TabIndex = 4;
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // tbxdiachi
            // 
            this.tbxdiachi.Location = new System.Drawing.Point(600, 85);
            this.tbxdiachi.Multiline = true;
            this.tbxdiachi.Name = "tbxdiachi";
            this.tbxdiachi.Size = new System.Drawing.Size(200, 49);
            this.tbxdiachi.TabIndex = 16;
            // 
            // dtpngaydat
            // 
            this.dtpngaydat.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpngaydat.Location = new System.Drawing.Point(600, 37);
            this.dtpngaydat.Name = "dtpngaydat";
            this.dtpngaydat.Size = new System.Drawing.Size(200, 28);
            this.dtpngaydat.TabIndex = 11;
            // 
            // cbsodienthoai
            // 
            this.cbsodienthoai.FormattingEnabled = true;
            this.cbsodienthoai.Location = new System.Drawing.Point(184, 79);
            this.cbsodienthoai.Name = "cbsodienthoai";
            this.cbsodienthoai.Size = new System.Drawing.Size(257, 30);
            this.cbsodienthoai.TabIndex = 10;
            this.cbsodienthoai.SelectedIndexChanged += new System.EventHandler(this.cbsodienthoai_SelectedIndexChanged);
            // 
            // tbxtenkhachhang
            // 
            this.tbxtenkhachhang.Location = new System.Drawing.Point(184, 132);
            this.tbxtenkhachhang.Name = "tbxtenkhachhang";
            this.tbxtenkhachhang.Size = new System.Drawing.Size(257, 28);
            this.tbxtenkhachhang.TabIndex = 9;
            // 
            // tbxsophieu
            // 
            this.tbxsophieu.Location = new System.Drawing.Point(184, 39);
            this.tbxsophieu.Name = "tbxsophieu";
            this.tbxsophieu.Size = new System.Drawing.Size(260, 28);
            this.tbxsophieu.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(513, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Địa chỉ :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(499, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ngày đặt :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(29, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên khách hàng :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(29, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tìm theo SĐT :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(29, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Tìm số phiếu :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(437, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "PHIẾU ĐẶT BÁO";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bde);
            this.groupBox2.Controls.Add(this.btadd);
            this.groupBox2.Controls.Add(this.numericUpDown3);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.numericUpDown2);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.numericUpDown1);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.cbtapchi);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.tbxtong);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox2.Location = new System.Drawing.Point(12, 318);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1184, 97);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết đặt báo";
            // 
            // bde
            // 
            this.bde.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bde.ImageOptions.Image")));
            this.bde.Location = new System.Drawing.Point(1083, 27);
            this.bde.Name = "bde";
            this.bde.Size = new System.Drawing.Size(95, 39);
            this.bde.TabIndex = 31;
            this.bde.Text = "Deleted";
            this.bde.Click += new System.EventHandler(this.btexit1_Click);
            // 
            // btadd
            // 
            this.btadd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btadd.ImageOptions.Image")));
            this.btadd.Location = new System.Drawing.Point(982, 25);
            this.btadd.Name = "btadd";
            this.btadd.Size = new System.Drawing.Size(95, 39);
            this.btadd.TabIndex = 23;
            this.btadd.Text = "Add";
            this.btadd.Click += new System.EventHandler(this.btadd_Click);
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(901, 37);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(66, 28);
            this.numericUpDown3.TabIndex = 30;
            this.numericUpDown3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(814, 36);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 20);
            this.label11.TabIndex = 29;
            this.label11.Text = "Tháng KT";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(733, 35);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(66, 28);
            this.numericUpDown2.TabIndex = 28;
            this.numericUpDown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(643, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 20);
            this.label10.TabIndex = 27;
            this.label10.Text = "Tháng BĐ";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(559, 36);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(66, 28);
            this.numericUpDown1.TabIndex = 26;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(479, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 20);
            this.label9.TabIndex = 25;
            this.label9.Text = "Số lượng";
            // 
            // cbtapchi
            // 
            this.cbtapchi.FormattingEnabled = true;
            this.cbtapchi.Location = new System.Drawing.Point(184, 32);
            this.cbtapchi.Name = "cbtapchi";
            this.cbtapchi.Size = new System.Drawing.Size(257, 30);
            this.cbtapchi.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(29, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 20);
            this.label8.TabIndex = 24;
            this.label8.Text = "Tổng tiền";
            // 
            // tbxtong
            // 
            this.tbxtong.Location = new System.Drawing.Point(181, 69);
            this.tbxtong.Name = "tbxtong";
            this.tbxtong.Size = new System.Drawing.Size(260, 28);
            this.tbxtong.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(31, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tìm tên tạp chí";
            // 
            // dgvctdb
            // 
            this.dgvctdb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvctdb.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.TenTC,
            this.ThangBD,
            this.ThangKT,
            this.SoLuong,
            this.DonGiaThang,
            this.ThanhTien});
            this.dgvctdb.EnableHeadersVisualStyles = false;
            this.dgvctdb.Location = new System.Drawing.Point(18, 421);
            this.dgvctdb.Name = "dgvctdb";
            this.dgvctdb.RowTemplate.Height = 24;
            this.dgvctdb.Size = new System.Drawing.Size(1224, 264);
            this.dgvctdb.TabIndex = 4;
            this.dgvctdb.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvctdb_DataBindingComplete);
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            // 
            // TenTC
            // 
            this.TenTC.DataPropertyName = "TenTC";
            this.TenTC.HeaderText = "Tên tạp chí";
            this.TenTC.Name = "TenTC";
            // 
            // ThangBD
            // 
            this.ThangBD.DataPropertyName = "ThangBD";
            this.ThangBD.HeaderText = "Tháng bắt đầu";
            this.ThangBD.Name = "ThangBD";
            // 
            // ThangKT
            // 
            this.ThangKT.DataPropertyName = "ThangKT";
            this.ThangKT.HeaderText = "Tháng kết thúc";
            this.ThangKT.Name = "ThangKT";
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.Name = "SoLuong";
            // 
            // DonGiaThang
            // 
            this.DonGiaThang.DataPropertyName = "DonGiaThang";
            this.DonGiaThang.HeaderText = "Đơn giá tháng";
            this.DonGiaThang.Name = "DonGiaThang";
            // 
            // ThanhTien
            // 
            this.ThanhTien.DataPropertyName = "ThanhTien";
            this.ThanhTien.HeaderText = "Thành tiền";
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.Width = 200;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 597);
            this.Controls.Add(this.dgvctdb);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbThongtin);
            this.Name = "Form1";
            this.Text = "gr";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbThongtin.ResumeLayout(false);
            this.gbThongtin.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvctdb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbThongtin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbxdiachi;
        private System.Windows.Forms.DateTimePicker dtpngaydat;
        private System.Windows.Forms.ComboBox cbsodienthoai;
        private System.Windows.Forms.TextBox tbxtenkhachhang;
        private System.Windows.Forms.TextBox tbxsophieu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btexit;
        private DevExpress.XtraEditors.SimpleButton btCancel;
        private DevExpress.XtraEditors.SimpleButton btsave;
        private DevExpress.XtraEditors.SimpleButton btdeleted;
        private DevExpress.XtraEditors.SimpleButton btupdate;
        private DevExpress.XtraEditors.SimpleButton btnew;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.SimpleButton bde;
        private DevExpress.XtraEditors.SimpleButton btadd;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbtapchi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbxtong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvctdb;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTC;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThangBD;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThangKT;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGiaThang;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
    }
}

