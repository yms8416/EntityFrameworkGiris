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
            //Tüm ürünler
            //dataGridView1.DataSource = ctx.Products.ToList();

            //Fiyatı 5 liranın altında olan ürünler
            //dataGridView1.DataSource = ctx.Products.Where(i => i.UnitPrice < 5).ToList();

            //En pahalı 5 ürün
            //dataGridView1.DataSource = ctx.Products.Take(5).OrderByDescending(a => a.UnitPrice).ToList();

            /*Çalışma:
             * Adında a harfi geçenler ada göre sıralı gelsin
             * 1960 tan sonra doğanlar soyada göre sıralı gelsin
             */ 
        }
    }
}
