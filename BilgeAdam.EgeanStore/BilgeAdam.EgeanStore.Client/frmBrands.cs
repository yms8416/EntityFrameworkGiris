using BilgeAdam.EgeanStore.Business.Context;
using BilgeAdam.EgeanStore.Business.Entities;
using System;
using System.Linq;
using System.Windows.Forms;

namespace BilgeAdam.EgeanStore.Client
{
    public partial class frmBrands : Form
    {
        public frmBrands()
        {
            InitializeComponent();
        }
        EgeanStoreContext ctx = new EgeanStoreContext();
        private void frmBrands_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ctx.Brands.OrderBy(i => i.Name).ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ctx = new EgeanStoreContext();
            var br = new Brand
            {
                Name = textBox1.Text.Trim()
            };
            ctx.Brands.Add(br);
            ctx.SaveChanges();
            frmBrands_Load(null, null);
        }
    }
}
