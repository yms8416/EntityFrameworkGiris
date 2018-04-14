namespace BilgeAdam.Northwind.Client
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dgcOrderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dgcOrderId2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcOrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcCustomerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcEmployeeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgcOrderId,
            this.dgcProductId,
            this.dgcUnitPrice,
            this.dgcQuantity,
            this.dgcDiscount});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(847, 192);
            this.dataGridView1.TabIndex = 0;
            // 
            // dgcOrderId
            // 
            this.dgcOrderId.DataPropertyName = "OrderId";
            this.dgcOrderId.HeaderText = "OrderId";
            this.dgcOrderId.Name = "dgcOrderId";
            // 
            // dgcProductId
            // 
            this.dgcProductId.DataPropertyName = "ProductId";
            this.dgcProductId.HeaderText = "ProductId";
            this.dgcProductId.Name = "dgcProductId";
            // 
            // dgcUnitPrice
            // 
            this.dgcUnitPrice.DataPropertyName = "UnitPrice";
            this.dgcUnitPrice.HeaderText = "UnitPrice";
            this.dgcUnitPrice.Name = "dgcUnitPrice";
            // 
            // dgcQuantity
            // 
            this.dgcQuantity.DataPropertyName = "Quantity";
            this.dgcQuantity.HeaderText = "Quantity";
            this.dgcQuantity.Name = "dgcQuantity";
            // 
            // dgcDiscount
            // 
            this.dgcDiscount.DataPropertyName = "Discount";
            this.dgcDiscount.HeaderText = "Discount";
            this.dgcDiscount.Name = "dgcDiscount";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgcOrderId2,
            this.dgcOrderDate,
            this.dgcCustomerId,
            this.dgcEmployeeId});
            this.dataGridView2.Location = new System.Drawing.Point(12, 235);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(847, 184);
            this.dataGridView2.TabIndex = 1;
            // 
            // dgcOrderId2
            // 
            this.dgcOrderId2.DataPropertyName = "OrderId";
            this.dgcOrderId2.HeaderText = "OrderId";
            this.dgcOrderId2.Name = "dgcOrderId2";
            // 
            // dgcOrderDate
            // 
            this.dgcOrderDate.DataPropertyName = "OrderDate";
            this.dgcOrderDate.HeaderText = "OrderDate";
            this.dgcOrderDate.Name = "dgcOrderDate";
            // 
            // dgcCustomerId
            // 
            this.dgcCustomerId.DataPropertyName = "CustomerId";
            this.dgcCustomerId.HeaderText = "CustomerId";
            this.dgcCustomerId.Name = "dgcCustomerId";
            // 
            // dgcEmployeeId
            // 
            this.dgcEmployeeId.DataPropertyName = "EmployeeId";
            this.dgcEmployeeId.HeaderText = "EmployeeId";
            this.dgcEmployeeId.Name = "dgcEmployeeId";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 487);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcOrderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcDiscount;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcOrderId2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcOrderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcCustomerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcEmployeeId;
    }
}

