using BilgeAdam.Northwind.Bussiness.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.Entity;//Include için yazıldı
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgeAdam.Northwind.Client
{
    public partial class frmLazyLoad : Form
    {
        public frmLazyLoad()
        {
            InitializeComponent();
        }

        private void frmLazyLoad_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            var ctx = new NorthwindContext();
            //var a = ctx.Employees.Select(i => i.Orders).ToList();
            var emp = ctx.Employees.Include(f => f.Orders).FirstOrDefault(i => i.EmployeeId == 5);//.FirstOrDefault(i => i.FirstName == "Nancy" && i.LastName == "Davolio");
            if (emp != null)
            {
                dataGridView1.DataSource = emp.Orders.ToList();
            }
        }
    }
}
