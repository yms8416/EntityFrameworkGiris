﻿namespace BilgeAdam.Northwind.Client
{
    partial class frmLazyLoad
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
            this.dgvOrderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcOrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCustomerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcEmployeeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvOrderId,
            this.dgcOrderDate,
            this.dgvCustomerId,
            this.dgcEmployeeId});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(710, 341);
            this.dataGridView1.TabIndex = 0;
            // 
            // dgvOrderId
            // 
            this.dgvOrderId.DataPropertyName = "OrderId";
            this.dgvOrderId.HeaderText = "OrderId";
            this.dgvOrderId.Name = "dgvOrderId";
            // 
            // dgcOrderDate
            // 
            this.dgcOrderDate.DataPropertyName = "OrderDate";
            this.dgcOrderDate.HeaderText = "OrderDate";
            this.dgcOrderDate.Name = "dgcOrderDate";
            // 
            // dgvCustomerId
            // 
            this.dgvCustomerId.DataPropertyName = "CustomerId";
            this.dgvCustomerId.HeaderText = "CustomerId";
            this.dgvCustomerId.Name = "dgvCustomerId";
            // 
            // dgcEmployeeId
            // 
            this.dgcEmployeeId.DataPropertyName = "EmployeeId";
            this.dgcEmployeeId.HeaderText = "EmployeeId";
            this.dgcEmployeeId.Name = "dgcEmployeeId";
            // 
            // frmLazyLoad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 341);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmLazyLoad";
            this.Text = "frmLazyLoad";
            this.Load += new System.EventHandler(this.frmLazyLoad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvOrderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcOrderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCustomerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcEmployeeId;
    }
}