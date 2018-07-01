namespace login
{
    partial class Order
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSaveOrderDetail = new System.Windows.Forms.Button();
            this.numberOrder = new System.Windows.Forms.NumericUpDown();
            this.comboProductOrder = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvOrderDetail = new System.Windows.Forms.DataGridView();
            this.index_orderDetail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_order_Detail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_orderDetail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price_orderDetail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity_orderDetail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monneyOrderDetail = new System.Windows.Forms.TextBox();
            this.txtPriceOrderDetail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtTotalOrder = new System.Windows.Forms.TextBox();
            this.txtUserOrder = new System.Windows.Forms.TextBox();
            this.dtpOrder = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberOrder)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetail)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 335);
            this.panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSaveOrderDetail);
            this.groupBox2.Controls.Add(this.numberOrder);
            this.groupBox2.Controls.Add(this.comboProductOrder);
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Controls.Add(this.monneyOrderDetail);
            this.groupBox2.Controls.Add(this.txtPriceOrderDetail);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(296, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(501, 335);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tạo chi tiết hóa đơn";
            // 
            // btnSaveOrderDetail
            // 
            this.btnSaveOrderDetail.Location = new System.Drawing.Point(343, 274);
            this.btnSaveOrderDetail.Name = "btnSaveOrderDetail";
            this.btnSaveOrderDetail.Size = new System.Drawing.Size(120, 28);
            this.btnSaveOrderDetail.TabIndex = 3;
            this.btnSaveOrderDetail.Text = "Thêm sản phẩm";
            this.btnSaveOrderDetail.UseVisualStyleBackColor = true;
            // 
            // numberOrder
            // 
            this.numberOrder.Location = new System.Drawing.Point(94, 232);
            this.numberOrder.Name = "numberOrder";
            this.numberOrder.Size = new System.Drawing.Size(78, 22);
            this.numberOrder.TabIndex = 3;
            // 
            // comboProductOrder
            // 
            this.comboProductOrder.FormattingEnabled = true;
            this.comboProductOrder.Location = new System.Drawing.Point(94, 191);
            this.comboProductOrder.Name = "comboProductOrder";
            this.comboProductOrder.Size = new System.Drawing.Size(195, 24);
            this.comboProductOrder.TabIndex = 1;
            this.comboProductOrder.SelectedValueChanged += new System.EventHandler(this.comboProductOrder_SelectedValueChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvOrderDetail);
            this.panel2.Location = new System.Drawing.Point(0, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(501, 158);
            this.panel2.TabIndex = 0;
            // 
            // dgvOrderDetail
            // 
            this.dgvOrderDetail.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.dgvOrderDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.index_orderDetail,
            this.id_order_Detail,
            this.name_orderDetail,
            this.price_orderDetail,
            this.quantity_orderDetail});
            this.dgvOrderDetail.Location = new System.Drawing.Point(0, 0);
            this.dgvOrderDetail.Name = "dgvOrderDetail";
            this.dgvOrderDetail.Size = new System.Drawing.Size(501, 155);
            this.dgvOrderDetail.TabIndex = 1;
            // 
            // index_orderDetail
            // 
            this.index_orderDetail.HeaderText = "STT";
            this.index_orderDetail.Name = "index_orderDetail";
            this.index_orderDetail.Width = 50;
            // 
            // id_order_Detail
            // 
            this.id_order_Detail.HeaderText = "ID Đơn hàng";
            this.id_order_Detail.Name = "id_order_Detail";
            this.id_order_Detail.Width = 120;
            // 
            // name_orderDetail
            // 
            this.name_orderDetail.HeaderText = "Món chọn";
            this.name_orderDetail.Name = "name_orderDetail";
            this.name_orderDetail.Width = 130;
            // 
            // price_orderDetail
            // 
            this.price_orderDetail.HeaderText = "Đơn giá (đ)";
            this.price_orderDetail.Name = "price_orderDetail";
            // 
            // quantity_orderDetail
            // 
            this.quantity_orderDetail.HeaderText = "Số lượng";
            this.quantity_orderDetail.Name = "quantity_orderDetail";
            this.quantity_orderDetail.Width = 50;
            // 
            // monneyOrderDetail
            // 
            this.monneyOrderDetail.Location = new System.Drawing.Point(95, 280);
            this.monneyOrderDetail.Name = "monneyOrderDetail";
            this.monneyOrderDetail.ReadOnly = true;
            this.monneyOrderDetail.Size = new System.Drawing.Size(194, 22);
            this.monneyOrderDetail.TabIndex = 2;
            // 
            // txtPriceOrderDetail
            // 
            this.txtPriceOrderDetail.Location = new System.Drawing.Point(384, 191);
            this.txtPriceOrderDetail.Name = "txtPriceOrderDetail";
            this.txtPriceOrderDetail.ReadOnly = true;
            this.txtPriceOrderDetail.Size = new System.Drawing.Size(108, 22);
            this.txtPriceOrderDetail.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(309, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Đơn giá :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 286);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Số tiến trả :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Số lượng :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Món ăn :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtTotalOrder);
            this.groupBox1.Controls.Add(this.txtUserOrder);
            this.groupBox1.Controls.Add(this.dtpOrder);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 335);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tạo hóa đơn";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(89, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 28);
            this.button1.TabIndex = 3;
            this.button1.Text = "Tạo hóa đơn";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtTotalOrder
            // 
            this.txtTotalOrder.Location = new System.Drawing.Point(118, 149);
            this.txtTotalOrder.Name = "txtTotalOrder";
            this.txtTotalOrder.ReadOnly = true;
            this.txtTotalOrder.Size = new System.Drawing.Size(171, 22);
            this.txtTotalOrder.TabIndex = 2;
            // 
            // txtUserOrder
            // 
            this.txtUserOrder.Location = new System.Drawing.Point(118, 96);
            this.txtUserOrder.Name = "txtUserOrder";
            this.txtUserOrder.ReadOnly = true;
            this.txtUserOrder.Size = new System.Drawing.Size(171, 22);
            this.txtUserOrder.TabIndex = 2;
            // 
            // dtpOrder
            // 
            this.dtpOrder.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpOrder.Location = new System.Drawing.Point(118, 42);
            this.dtpOrder.Name = "dtpOrder";
            this.dtpOrder.Size = new System.Drawing.Size(171, 22);
            this.dtpOrder.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tổng tiền :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nhân viên lập :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ngày lập :";
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 334);
            this.Controls.Add(this.panel1);
            this.Name = "Order";
            this.Text = "Hóa đơn";
            this.Load += new System.EventHandler(this.Order_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberOrder)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetail)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTotalOrder;
        private System.Windows.Forms.TextBox txtUserOrder;
        private System.Windows.Forms.DateTimePicker dtpOrder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvOrderDetail;
        private System.Windows.Forms.ComboBox comboProductOrder;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numberOrder;
        private System.Windows.Forms.TextBox txtPriceOrderDetail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSaveOrderDetail;
        private System.Windows.Forms.TextBox monneyOrderDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn index_orderDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_order_Detail;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_orderDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn price_orderDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity_orderDetail;
    }
}