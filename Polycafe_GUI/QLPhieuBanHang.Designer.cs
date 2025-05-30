using System.Drawing;
using System.Windows.Forms;

namespace Polycafe_GUI
{
    partial class QLPhieuBanHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvSaleInvoices = new System.Windows.Forms.DataGridView();
            this.dgvSaleInvoiceDetails = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.rdoPaid = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rdoPending = new System.Windows.Forms.RadioButton();
            this.cboEmployeeId = new System.Windows.Forms.ComboBox();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.dtpCreatedDate = new System.Windows.Forms.DateTimePicker();
            this.cboCardId = new System.Windows.Forms.ComboBox();
            this.txtInvoiceId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboProductId = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cboFind = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnResetDetail = new System.Windows.Forms.Button();
            this.btnDeleteDetail = new System.Windows.Forms.Button();
            this.btnUpdateDetail = new System.Windows.Forms.Button();
            this.btnAddDetail = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnResetInvoice = new System.Windows.Forms.Button();
            this.btnDeleteInvoice = new System.Windows.Forms.Button();
            this.btnUpdateInvoice = new System.Windows.Forms.Button();
            this.btnAddInvoice = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaleInvoices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaleInvoiceDetails)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(193)))), ((int)(((byte)(161)))));
            this.groupBox2.Controls.Add(this.dgvSaleInvoices);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(97, 487);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(843, 438);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Quản lý";
            // 
            // dgvSaleInvoices
            // 
            this.dgvSaleInvoices.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(193)))), ((int)(((byte)(161)))));
            this.dgvSaleInvoices.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(160)))), ((int)(((byte)(130)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Tan;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSaleInvoices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvSaleInvoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.BlanchedAlmond;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Tan;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSaleInvoices.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvSaleInvoices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSaleInvoices.EnableHeadersVisualStyles = false;
            this.dgvSaleInvoices.Location = new System.Drawing.Point(3, 25);
            this.dgvSaleInvoices.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvSaleInvoices.Name = "dgvSaleInvoices";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(160)))), ((int)(((byte)(130)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Tan;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSaleInvoices.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvSaleInvoices.RowHeadersWidth = 51;
            this.dgvSaleInvoices.Size = new System.Drawing.Size(837, 411);
            this.dgvSaleInvoices.TabIndex = 5;
            this.dgvSaleInvoices.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSaleInvoices_CellClick);
            // 
            // dgvSaleInvoiceDetails
            // 
            this.dgvSaleInvoiceDetails.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(193)))), ((int)(((byte)(161)))));
            this.dgvSaleInvoiceDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(160)))), ((int)(((byte)(130)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Tan;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSaleInvoiceDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvSaleInvoiceDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.BlanchedAlmond;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Tan;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSaleInvoiceDetails.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvSaleInvoiceDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSaleInvoiceDetails.EnableHeadersVisualStyles = false;
            this.dgvSaleInvoiceDetails.Location = new System.Drawing.Point(3, 26);
            this.dgvSaleInvoiceDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvSaleInvoiceDetails.Name = "dgvSaleInvoiceDetails";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(160)))), ((int)(((byte)(130)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.Tan;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSaleInvoiceDetails.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvSaleInvoiceDetails.RowHeadersWidth = 51;
            this.dgvSaleInvoiceDetails.Size = new System.Drawing.Size(773, 409);
            this.dgvSaleInvoiceDetails.TabIndex = 6;
            this.dgvSaleInvoiceDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSaleInvoiceDetails_CellClick);
            this.dgvSaleInvoiceDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSaleInvoiceDetails_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(193)))), ((int)(((byte)(161)))));
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.btnExport);
            this.groupBox1.Controls.Add(this.rdoPaid);
            this.groupBox1.Controls.Add(this.btnResetInvoice);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnDeleteInvoice);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.rdoPending);
            this.groupBox1.Controls.Add(this.cboEmployeeId);
            this.groupBox1.Controls.Add(this.btnUpdateInvoice);
            this.groupBox1.Controls.Add(this.btnAddInvoice);
            this.groupBox1.Controls.Add(this.txtTotalAmount);
            this.groupBox1.Controls.Add(this.dtpCreatedDate);
            this.groupBox1.Controls.Add(this.cboCardId);
            this.groupBox1.Controls.Add(this.txtInvoiceId);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(97, 178);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1024, 302);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phiếu";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(400, 79);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 25);
            this.label10.TabIndex = 39;
            this.label10.Text = "Thành tiền";
            // 
            // rdoPaid
            // 
            this.rdoPaid.AutoSize = true;
            this.rdoPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoPaid.Location = new System.Drawing.Point(532, 180);
            this.rdoPaid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdoPaid.Name = "rdoPaid";
            this.rdoPaid.Size = new System.Drawing.Size(155, 29);
            this.rdoPaid.TabIndex = 19;
            this.rdoPaid.TabStop = true;
            this.rdoPaid.Text = "Đã thanh toán";
            this.rdoPaid.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(400, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 25);
            this.label7.TabIndex = 26;
            this.label7.Text = "Trạng thái";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 25);
            this.label6.TabIndex = 25;
            this.label6.Text = "Mã NV";
            // 
            // rdoPending
            // 
            this.rdoPending.AutoSize = true;
            this.rdoPending.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoPending.Location = new System.Drawing.Point(532, 132);
            this.rdoPending.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdoPending.Name = "rdoPending";
            this.rdoPending.Size = new System.Drawing.Size(155, 29);
            this.rdoPending.TabIndex = 18;
            this.rdoPending.TabStop = true;
            this.rdoPending.Text = "Chờ xác nhận";
            this.rdoPending.UseVisualStyleBackColor = true;
            // 
            // cboEmployeeId
            // 
            this.cboEmployeeId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.cboEmployeeId.FormattingEnabled = true;
            this.cboEmployeeId.Location = new System.Drawing.Point(142, 160);
            this.cboEmployeeId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboEmployeeId.Name = "cboEmployeeId";
            this.cboEmployeeId.Size = new System.Drawing.Size(238, 24);
            this.cboEmployeeId.TabIndex = 20;
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.txtTotalAmount.Location = new System.Drawing.Point(532, 79);
            this.txtTotalAmount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.ReadOnly = true;
            this.txtTotalAmount.Size = new System.Drawing.Size(181, 23);
            this.txtTotalAmount.TabIndex = 35;
            // 
            // dtpCreatedDate
            // 
            this.dtpCreatedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.dtpCreatedDate.Location = new System.Drawing.Point(142, 212);
            this.dtpCreatedDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpCreatedDate.Name = "dtpCreatedDate";
            this.dtpCreatedDate.Size = new System.Drawing.Size(304, 24);
            this.dtpCreatedDate.TabIndex = 17;
            // 
            // cboCardId
            // 
            this.cboCardId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.cboCardId.FormattingEnabled = true;
            this.cboCardId.Location = new System.Drawing.Point(142, 112);
            this.cboCardId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboCardId.Name = "cboCardId";
            this.cboCardId.Size = new System.Drawing.Size(238, 24);
            this.cboCardId.TabIndex = 16;
            // 
            // txtInvoiceId
            // 
            this.txtInvoiceId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.txtInvoiceId.Location = new System.Drawing.Point(142, 59);
            this.txtInvoiceId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtInvoiceId.Name = "txtInvoiceId";
            this.txtInvoiceId.Size = new System.Drawing.Size(238, 23);
            this.txtInvoiceId.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mã thẻ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ngày tạo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mã phiếu";
            // 
            // cboProductId
            // 
            this.cboProductId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.cboProductId.FormattingEnabled = true;
            this.cboProductId.Location = new System.Drawing.Point(182, 72);
            this.cboProductId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboProductId.Name = "cboProductId";
            this.cboProductId.Size = new System.Drawing.Size(191, 24);
            this.cboProductId.TabIndex = 21;
            this.cboProductId.SelectedIndexChanged += new System.EventHandler(this.cboProductId_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(44, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Sản phẩm";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(193)))), ((int)(((byte)(161)))));
            this.groupBox3.Controls.Add(this.btnResetDetail);
            this.groupBox3.Controls.Add(this.btnDeleteDetail);
            this.groupBox3.Controls.Add(this.btnUpdateDetail);
            this.groupBox3.Controls.Add(this.btnAddDetail);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.cboProductId);
            this.groupBox3.Controls.Add(this.nudQuantity);
            this.groupBox3.Controls.Add(this.txtUnitPrice);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(1128, 178);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(594, 302);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chi tiết";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(47, 122);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 25);
            this.label9.TabIndex = 38;
            this.label9.Text = "Đơn giá ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(47, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 25);
            this.label8.TabIndex = 37;
            this.label8.Text = "Số lượng";
            // 
            // nudQuantity
            // 
            this.nudQuantity.Location = new System.Drawing.Point(182, 181);
            this.nudQuantity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(169, 30);
            this.nudQuantity.TabIndex = 36;
            this.nudQuantity.ValueChanged += new System.EventHandler(this.nudQuantity_ValueChanged);
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.txtUnitPrice.Location = new System.Drawing.Point(182, 126);
            this.txtUnitPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.ReadOnly = true;
            this.txtUnitPrice.Size = new System.Drawing.Size(191, 23);
            this.txtUnitPrice.TabIndex = 34;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(193)))), ((int)(((byte)(161)))));
            this.groupBox4.Controls.Add(this.dgvSaleInvoiceDetails);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(946, 487);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(779, 438);
            this.groupBox4.TabIndex = 33;
            this.groupBox4.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 22F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.label1.Location = new System.Drawing.Point(729, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(459, 50);
            this.label1.TabIndex = 37;
            this.label1.Text = "Quản lý Phiếu Bán Hàng";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(721, 115);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 25);
            this.label11.TabIndex = 35;
            this.label11.Text = "Tìm kiếm";
            // 
            // cboFind
            // 
            this.cboFind.ForeColor = System.Drawing.Color.Black;
            this.cboFind.FormattingEnabled = true;
            this.cboFind.Location = new System.Drawing.Point(877, 116);
            this.cboFind.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboFind.Name = "cboFind";
            this.cboFind.Size = new System.Drawing.Size(311, 24);
            this.cboFind.TabIndex = 36;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Image = global::Polycafe_GUI.Properties.Resources.lo;
            this.pictureBox2.Location = new System.Drawing.Point(1522, 19);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(160, 153);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 39;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::Polycafe_GUI.Properties.Resources.poly;
            this.pictureBox1.Location = new System.Drawing.Point(117, 26);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(233, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // btnResetDetail
            // 
            this.btnResetDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetDetail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnResetDetail.Image = global::Polycafe_GUI.Properties.Resources._14b23287_resized_32x32;
            this.btnResetDetail.Location = new System.Drawing.Point(394, 223);
            this.btnResetDetail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnResetDetail.Name = "btnResetDetail";
            this.btnResetDetail.Size = new System.Drawing.Size(146, 63);
            this.btnResetDetail.TabIndex = 40;
            this.btnResetDetail.Text = "Quay lại";
            this.btnResetDetail.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnResetDetail.UseVisualStyleBackColor = true;
            this.btnResetDetail.Click += new System.EventHandler(this.btnResetDetail_Click);
            // 
            // btnDeleteDetail
            // 
            this.btnDeleteDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteDetail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnDeleteDetail.Image = global::Polycafe_GUI.Properties.Resources.delete;
            this.btnDeleteDetail.Location = new System.Drawing.Point(394, 157);
            this.btnDeleteDetail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteDetail.Name = "btnDeleteDetail";
            this.btnDeleteDetail.Size = new System.Drawing.Size(146, 52);
            this.btnDeleteDetail.TabIndex = 40;
            this.btnDeleteDetail.Text = "Xóa";
            this.btnDeleteDetail.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnDeleteDetail.UseVisualStyleBackColor = true;
            this.btnDeleteDetail.Click += new System.EventHandler(this.btnDeleteDetail_Click);
            // 
            // btnUpdateDetail
            // 
            this.btnUpdateDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateDetail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnUpdateDetail.Image = global::Polycafe_GUI.Properties.Resources.pen;
            this.btnUpdateDetail.Location = new System.Drawing.Point(394, 79);
            this.btnUpdateDetail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdateDetail.Name = "btnUpdateDetail";
            this.btnUpdateDetail.Size = new System.Drawing.Size(146, 68);
            this.btnUpdateDetail.TabIndex = 40;
            this.btnUpdateDetail.Text = "Cập nhật";
            this.btnUpdateDetail.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnUpdateDetail.UseVisualStyleBackColor = true;
            this.btnUpdateDetail.Click += new System.EventHandler(this.btnUpdateDetail_Click);
            // 
            // btnAddDetail
            // 
            this.btnAddDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDetail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAddDetail.Image = global::Polycafe_GUI.Properties.Resources.add;
            this.btnAddDetail.Location = new System.Drawing.Point(394, 22);
            this.btnAddDetail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddDetail.Name = "btnAddDetail";
            this.btnAddDetail.Size = new System.Drawing.Size(146, 52);
            this.btnAddDetail.TabIndex = 40;
            this.btnAddDetail.Text = "Thêm";
            this.btnAddDetail.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAddDetail.UseVisualStyleBackColor = true;
            this.btnAddDetail.Click += new System.EventHandler(this.btnAddDetail_Click);
            // 
            // btnExport
            // 
            this.btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnExport.Image = global::Polycafe_GUI.Properties.Resources.Order_history;
            this.btnExport.Location = new System.Drawing.Point(791, 212);
            this.btnExport.Margin = new System.Windows.Forms.Padding(4);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(160, 62);
            this.btnExport.TabIndex = 32;
            this.btnExport.Text = "Xuất Phiếu";
            this.btnExport.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnResetInvoice
            // 
            this.btnResetInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetInvoice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnResetInvoice.Image = global::Polycafe_GUI.Properties.Resources._14b23287_resized_32x32;
            this.btnResetInvoice.Location = new System.Drawing.Point(873, 130);
            this.btnResetInvoice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnResetInvoice.Name = "btnResetInvoice";
            this.btnResetInvoice.Size = new System.Drawing.Size(132, 63);
            this.btnResetInvoice.TabIndex = 33;
            this.btnResetInvoice.Text = "Quay lại";
            this.btnResetInvoice.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnResetInvoice.UseVisualStyleBackColor = true;
            this.btnResetInvoice.Click += new System.EventHandler(this.btnResetInvoice_Click);
            // 
            // btnDeleteInvoice
            // 
            this.btnDeleteInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteInvoice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnDeleteInvoice.Image = global::Polycafe_GUI.Properties.Resources.delete;
            this.btnDeleteInvoice.Location = new System.Drawing.Point(873, 53);
            this.btnDeleteInvoice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteInvoice.Name = "btnDeleteInvoice";
            this.btnDeleteInvoice.Size = new System.Drawing.Size(132, 62);
            this.btnDeleteInvoice.TabIndex = 32;
            this.btnDeleteInvoice.Text = "Xóa";
            this.btnDeleteInvoice.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnDeleteInvoice.UseVisualStyleBackColor = true;
            this.btnDeleteInvoice.Click += new System.EventHandler(this.btnDeleteInvoice_Click);
            // 
            // btnUpdateInvoice
            // 
            this.btnUpdateInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateInvoice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnUpdateInvoice.Image = global::Polycafe_GUI.Properties.Resources.pen;
            this.btnUpdateInvoice.Location = new System.Drawing.Point(735, 128);
            this.btnUpdateInvoice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdateInvoice.Name = "btnUpdateInvoice";
            this.btnUpdateInvoice.Size = new System.Drawing.Size(132, 65);
            this.btnUpdateInvoice.TabIndex = 31;
            this.btnUpdateInvoice.Text = "Cập nhật";
            this.btnUpdateInvoice.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnUpdateInvoice.UseVisualStyleBackColor = true;
            this.btnUpdateInvoice.Click += new System.EventHandler(this.btnUpdateInvoice_Click);
            // 
            // btnAddInvoice
            // 
            this.btnAddInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddInvoice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAddInvoice.Image = global::Polycafe_GUI.Properties.Resources.add;
            this.btnAddInvoice.Location = new System.Drawing.Point(735, 53);
            this.btnAddInvoice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddInvoice.Name = "btnAddInvoice";
            this.btnAddInvoice.Size = new System.Drawing.Size(132, 62);
            this.btnAddInvoice.TabIndex = 30;
            this.btnAddInvoice.Text = "Thêm";
            this.btnAddInvoice.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAddInvoice.UseVisualStyleBackColor = true;
            this.btnAddInvoice.Click += new System.EventHandler(this.btnAddInvoice_Click);
            // 
            // QLPhieuBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(160)))), ((int)(((byte)(130)))));
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cboFind);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "QLPhieuBanHang";
            this.Size = new System.Drawing.Size(1815, 947);
            this.Load += new System.EventHandler(this.QLPhieuBanHang_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaleInvoices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaleInvoiceDetails)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox2;
        private DataGridView dgvSaleInvoices;
        private GroupBox groupBox1;
        private RadioButton rdoPaid;
        private DateTimePicker dtpCreatedDate;
        private ComboBox cboCardId;
        private Label label5;
        private TextBox txtInvoiceId;
        private Label label4;
        private Label label3;
        private Label label2;
        private RadioButton rdoPending;
        private ComboBox cboProductId;
        private ComboBox cboEmployeeId;
        private Label label7;
        private Label label6;
        private GroupBox groupBox3;
        private Label label10;
        private TextBox txtTotalAmount;
        private Label label9;
        private Label label8;
        private Button btnResetInvoice;
        private Button btnDeleteInvoice;
        private NumericUpDown nudQuantity;
        private Button btnAddInvoice;
        private Button btnUpdateInvoice;
        private TextBox txtUnitPrice;
        private Button btnAddDetail;
        private DataGridView dgvSaleInvoiceDetails;
        private Button btnResetDetail;
        private Button btnDeleteDetail;
        private Button btnUpdateDetail;
        private Button btnExport;
        private GroupBox groupBox4;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label11;
        private ComboBox cboFind;
    }
}
