using BilgeAdam.Northwind.Bussiness.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgeAdam.Northwind.Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var ctx = new NorthwindContext();
            //Tüm ürünler -> SELECT * FROM Products
            //var q1 = ctx.Products.AsQueryable();
            //var s1 = q1.ToString();
            //dataGridView1.DataSource = q1.ToList();

            //Fiyatı 5 liranın altında olan ürünler
            //var q2 = ctx.Products.Where(i => i.UnitPrice < 5).AsQueryable();
            //dataGridView1.DataSource = q2.ToList();

            //En pahalı 5 ürün
            //var q3 = ctx.Products.Take(5).OrderByDescending(a => a.UnitPrice).AsQueryable();
            //dataGridView1.DataSource = q3.ToList();

            //En yaşlı 3 çalışan
            //dataGridView1.DataSource = ctx.Employees.OrderBy(i => i.BirthDate).Take(3).ToList();
            //Stokta kalmayan ürünler
            //dataGridView1.DataSource = ctx.Products.Where(i => i.UnitsInStock == 0).ToList();
            //İçecek kategorisindeki ürünler
            //TODO: 1 ve 5 düzeltilecek
            //dataGridView1.DataSource = ctx.Products.Where(i => i.CategoryId == 1).ToList();
            //Tahıl kategorisindeki ürünlerin fiyata göre sıralı hâli
            dataGridView1.DataSource = ctx.Products.Where(i => i.CategoryId == 5).ToList();
            //Chai ürününe ait satışlar
            dataGridView1.DataSource = ctx.OrderDetails.Where(i => i.ProductId == 1)

            /*Çalışma:
             * Adında a harfi geçenler ada göre sıralı gelsin
             * 1960 tan sonra doğanlar soyada göre sıralı gelsin
             */
        }
    }
}
