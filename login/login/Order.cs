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
            comboProductOrder.DataSource = (from p in manage.Products  select p).ToList();
            comboProductOrder.ValueMember = "ProductID";
            comboProductOrder.DisplayMember = "ProductName";
        }

        private void comboProductOrder_SelectedValueChanged(object sender, EventArgs e)
        {
            var index = Convert.ToInt32(comboProductOrder.SelectedValue);
            var list_P_Order = (from p in manage.Products where p.ProductID == index select p).ToList();
            for (int j = 0; j < list_P_Order.Count; j++)
            {
                txtPriceOrderDetail.Text = list_P_Order[j].Price.ToString();
            }
        }

        private void btnSaveOrderDetail_Click(object sender, EventArgs e)
        {
            var listDetail = manage.OrdersDetails.ToList();
            int TotalOrder = Convert.ToInt32(txtTotalOrder.Text);
            int monney = Convert.ToInt32(monneyOrderDetail.Text);
            TotalOrder = TotalOrder + monney;
            txtTotalOrder.Text = TotalOrder.ToString();

        }

        private void numberOrder_ValueChanged(object sender, EventArgs e)
        {
            int price = Convert.ToInt32(txtPriceOrderDetail.Text);
            int count = Convert.ToInt32(numberOrder.Value);
            int total = price * count;
            monneyOrderDetail.Text = total.ToString();
        }

        private void btnSaveOrder_Click(object sender, EventArgs e)
        {
            int idname = _EmployeeId;
            int monney = Convert.ToInt32(txtTotalOrder.Text);

            Data.Order newOrder = new Data.Order();
            newOrder.OrdersUserID = idname;
            newOrder.OrdersTotal = monney;

            manage.Orders.Add(newOrder);
            manage.SaveChanges();
            MessageBox.Show("Bạn đã thêm 1 mục");

        }

        
    }
}
