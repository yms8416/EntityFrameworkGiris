using BilgeAdam.Northwind.Bussiness.Context;
using BilgeAdam.Northwind.Bussiness.Dtos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgeAdam.Northwind.Client
{
    public partial class frmProductDetails : Form
    {
        public frmProductDetails()
        {
            InitializeComponent();
            Context = new NorthwindContext();
        }
        public NorthwindContext Context { get; set; }
        private void frmProductDetails_Load(object sender, EventArgs e)
        {
            var products = Context.Products.Select(i => new BasicProductDto
            {
                Id = i.ProductId,
                Name = i.ProductName
            }).OrderBy(i => i.Name).ToList();
            cmbProducts.DataSource = products;
            cmbProducts.DisplayMember = "Name";
            cmbProducts.ValueMember = "Id";
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            var productId = Convert.ToInt32(cmbProducts.SelectedValue);
            var details = Context.OrderDetails
                                 .Include(i => i.Product)
                                 .Where(i => i.ProductId == productId)
                                 .OrderByDescending(i => i.OrderId)
                                 .Select(i => new BasicOrderDetailDto {
                                     OrderId = i.OrderId,
                                     Amount = i.Quantity,
                                     Price = i.UnitPrice,
                                     ProductName = i.Product.ProductName
                                 })
                                 .ToList();
            var totalPrice = details.Sum(i => i.Price * i.Amount);
            var totalProductCount = details.Sum(i => i.Amount);
            var totalOrderCount = details.Count;
            dgvOrderDetails.DataSource = details;
            lblSummary.Text = totalPrice.ToString();
            lblTotalOrderCount.Text = totalOrderCount.ToString();
            lblTotalProductCount.Text = totalProductCount.ToString();
        }
    }
}
