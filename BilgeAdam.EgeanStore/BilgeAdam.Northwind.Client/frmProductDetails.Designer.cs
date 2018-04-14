namespace BilgeAdam.Northwind.Client
{
    partial class frmProductDetails
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
            this.cmbProducts = new System.Windows.Forms.ComboBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.dgvOrderDetails = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblSummary = new System.Windows.Forms.ToolStripStatusLabel();
            this.dgcOrderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTotalOrderCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTotalProductCount = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetails)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbProducts
            // 
            this.cmbProducts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProducts.FormattingEnabled = true;
            this.cmbProducts.Location = new System.Drawing.Point(13, 13);
            this.cmbProducts.Name = "cmbProducts";
            this.cmbProducts.Size = new System.Drawing.Size(290, 21);
            this.cmbProducts.TabIndex = 0;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(309, 11);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(145, 23);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Satış Verisini Getir";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // dgvOrderDetails
            // 
            this.dgvOrderDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgcOrderId,
            this.dgcProductName,
            this.dgcPrice,
            this.dgcQuantity});
            this.dgvOrderDetails.Location = new System.Drawing.Point(13, 40);
            this.dgvOrderDetails.Name = "dgvOrderDetails";
            this.dgvOrderDetails.Size = new System.Drawing.Size(664, 299);
            this.dgvOrderDetails.TabIndex = 2;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblSummary,
            this.toolStripStatusLabel2,
            this.lblTotalOrderCount,
            this.toolStripStatusLabel3,
            this.lblTotalProductCount});
            this.statusStrip1.Location = new System.Drawing.Point(0, 358);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(689, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(83, 17);
            this.toolStripStatusLabel1.Text = "Toplam Gelir : ";
            // 
            // lblSummary
            // 
            this.lblSummary.Name = "lblSummary";
            this.lblSummary.Size = new System.Drawing.Size(13, 17);
            this.lblSummary.Text = "0";
            // 
            // dgcOrderId
            // 
            this.dgcOrderId.DataPropertyName = "OrderId";
            this.dgcOrderId.HeaderText = "Sipariş Kodu";
            this.dgcOrderId.Name = "dgcOrderId";
            // 
            // dgcProductName
            // 
            this.dgcProductName.DataPropertyName = "ProductName";
            this.dgcProductName.HeaderText = "Ürün Adı";
            this.dgcProductName.Name = "dgcProductName";
            // 
            // dgcPrice
            // 
            this.dgcPrice.DataPropertyName = "Price";
            this.dgcPrice.HeaderText = "Satış Fiyatı";
            this.dgcPrice.Name = "dgcPrice";
            // 
            // dgcQuantity
            // 
            this.dgcQuantity.DataPropertyName = "Amount";
            this.dgcQuantity.HeaderText = "Miktar";
            this.dgcQuantity.Name = "dgcQuantity";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(117, 17);
            this.toolStripStatusLabel2.Text = "Toplam Satış Adedi : ";
            // 
            // lblTotalOrderCount
            // 
            this.lblTotalOrderCount.Name = "lblTotalOrderCount";
            this.lblTotalOrderCount.Size = new System.Drawing.Size(13, 17);
            this.lblTotalOrderCount.Text = "0";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(119, 17);
            this.toolStripStatusLabel3.Text = "Toplam Ürün Adedi : ";
            // 
            // lblTotalProductCount
            // 
            this.lblTotalProductCount.Name = "lblTotalProductCount";
            this.lblTotalProductCount.Size = new System.Drawing.Size(118, 17);
            this.lblTotalProductCount.Text = "toolStripStatusLabel4";
            // 
            // frmProductDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 380);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dgvOrderDetails);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.cmbProducts);
            this.Name = "frmProductDetails";
            this.Text = "Ürün Satış Bilgisi";
            this.Load += new System.EventHandler(this.frmProductDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetails)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbProducts;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.DataGridView dgvOrderDetails;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblSummary;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcOrderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcQuantity;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel lblTotalOrderCount;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel lblTotalProductCount;
    }
}