using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login
{
    public partial class Order : Form
    {
        public string _EmployeeName;
        public int _EmployeeId;
        public Order()
        {
            InitializeComponent();
        }
        Data.QuanLiCafeEntities manage = new Data.QuanLiCafeEntities();
        List<Data.Product> listproduct = new List<Data.Product>();

        private void Order_Load(object sender, EventArgs e)
        {
            txtUserOrder.Text = _EmployeeName;
            comboProductOrder.DataSource = (from p in manage.Products select p).ToList();
            comboProductOrder.ValueMember = "ProductID";
            comboProductOrder.DisplayMember = "ProductName";
        }

        

        private void comboProductOrder_SelectedValueChanged(object sender, EventArgs e)
        {
            var id_p = Convert.ToInt16(comboProductOrder.SelectedValue);
            var list_P_Order = (from p in manage.Products where p.ProductID == id_p select p.Price).ToString();
            txtPriceOrderDetail.Text = list_P_Order;
        }
    }
}
