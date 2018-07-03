using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;


namespace login
{
    public partial class Dashboard : Form
    {
        Data.QuanLiCafeEntities manage = new Data.QuanLiCafeEntities();
        HashCode hashcode = new HashCode();
        List<Data.Category> listCate = new List<Data.Category>();
        List<Data.Product> listProduct = new List<Data.Product>();
        List<Data.Brand> listBrand = new List<Data.Brand>();
        List<Data.Employee> listEmployee = new List<Data.Employee>();
        List<Data.Order> listOrder = new List<Data.Order>();
        List<Data.OrdersDetail> listOrderDetail = new List<Data.OrdersDetail>();
        public int Role;
        public int _employeeId;
        public bool Exsits;
        public string _employeeUserName;
        public Dashboard(string UserName,int Roles,int employeeID)
        {
            InitializeComponent();
            this.Text = "Hello " + UserName;
            this.Role = Roles;
            this._employeeUserName = UserName;
            this._employeeId = employeeID;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            LoadGridView();
            LoadGridViewCate();
            LoadGridViewProduct();
            LoadGridViewBrand();
            LoadGridViewOrder();

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvCategori_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void LoadGridView()
        {
            dgvEmployee.Rows.Clear();
            listEmployee = manage.Employees.ToList();

            if (listEmployee.Count > 0)
            {
                for (int i = 0; i < listEmployee.Count; i++)
                {
                    dgvEmployee.Rows.Add();
                    dgvEmployee.Rows[i].Cells["index_Employee"].Value = i+1;
                    dgvEmployee.Rows[i].Cells["ID"].Value = listEmployee[i].EmployeeID;
                    dgvEmployee.Rows[i].Cells["EmployeeName"].Value = listEmployee[i].EmployeeName;
                    dgvEmployee.Rows[i].Cells["Birthday"].Value = listEmployee[i].Birthday;
                    dgvEmployee.Rows[i].Cells["Address"].Value = listEmployee[i].Address;
                    dgvEmployee.Rows[i].Cells["CellPhone"].Value = listEmployee[i].CellPhone;
                    dgvEmployee.Rows[i].Cells["Users"].Value = listEmployee[i].Users;
                    dgvEmployee.Rows[i].Cells["Password"].Value = listEmployee[i].Password;
                    dgvEmployee.Rows[i].Cells["Roles"].Value = listEmployee[i].Roles;
                }
            }
        }
        private void LoadGridViewCate()
        {
            //select db
            dgvCategori.Rows.Clear();
            listCate = manage.Categories.ToList();

            if (listCate.Count > 0)
            {
                for (int i = 0; i < listCate.Count; i++)
                {
                    dgvCategori.Rows.Add();
                    dgvCategori.Rows[i].Cells["index_Cate"].Value = i+1;
                    dgvCategori.Rows[i].Cells["id_Cate"].Value = listCate[i].CategoryID;
                    dgvCategori.Rows[i].Cells["Cate"].Value = listCate[i].CategoryName;
                }
            }
        }

        private void LoadGridViewProduct()
        {
            dgvProducts.Rows.Clear();
            var  listProduct = (from pro in manage.Products
                          join brand in manage.Brands on pro.BrandID equals brand.BrandID
                          join cate in manage.Categories on pro.CategoryID equals cate.CategoryID
                          select new
                          {
                              ProductID =  pro.ProductID,
                              ProductName = pro.ProductName,
                              Price= pro.Price,
                              BrandName = brand.BrandName,
                              CategoryName = cate.CategoryName,
                              QuantityInStock =pro.QuantityInStock

                          }).ToList();

            if (listProduct.Count > 0)
            {
                for (int i = 0; i < listProduct.Count; i++)
                {
                    dgvProducts.Rows.Add();
                    dgvProducts.Rows[i].Cells["index_Product"].Value = i+1;
                    dgvProducts.Rows[i].Cells["id_product"].Value = listProduct[i].ProductID;
                    dgvProducts.Rows[i].Cells["name_product"].Value = listProduct[i].ProductName;
                    dgvProducts.Rows[i].Cells["name_Cate"].Value = listProduct[i].CategoryName;
                    dgvProducts.Rows[i].Cells["quantity_product"].Value = listProduct[i].QuantityInStock;
                    dgvProducts.Rows[i].Cells["brand_product"].Value = listProduct[i].BrandName;
                    dgvProducts.Rows[i].Cells["price_product"].Value = listProduct[i].Price;
                }
            }
            
        }
        private void LoadGridViewBrand()
        {
            //select db
            dgvBrand.Rows.Clear();
            listBrand = manage.Brands.ToList();

            if (listBrand.Count > 0)
            {
                for (int i = 0; i < listBrand.Count; i++)
                {
                    dgvBrand.Rows.Add();
                    dgvBrand.Rows[i].Cells["index_brand"].Value = i+1;
                    dgvBrand.Rows[i].Cells["id_brand"].Value = listBrand[i].BrandID;
                    dgvBrand.Rows[i].Cells["name_brand"].Value = listBrand[i].BrandName;
                    dgvBrand.Rows[i].Cells["address_brand"].Value = listBrand[i].BrandAddress;
                    dgvBrand.Rows[i].Cells["phone_brand"].Value = listBrand[i].BrandCellPhone;
                }
            }
        }

        private void LoadGridViewOrder()
        {
            //select db
            dgvOrder.Rows.Clear();
            var listOrder = (from o in manage.Orders
                         join e in manage.Employees on o.OrdersUserID equals e.EmployeeID
                         select new
                         {
                             OrdersID = o.OrdersID,
                             EmployeeName = e.EmployeeName,
                             OrdersTotal = o.OrdersTotal,
                             Created = o.Created
                         }).ToList();

            if (listOrder.Count > 0)
            {
                for (int i = 0; i < listOrder.Count; i++)
                {
                    dgvOrder.Rows.Add();
                    dgvOrder.Rows[i].Cells["index_order"].Value = i + 1;
                    dgvOrder.Rows[i].Cells["id_order"].Value = listOrder[i].OrdersID;
                    dgvOrder.Rows[i].Cells["name_order"].Value = listOrder[i].EmployeeName;
                    dgvOrder.Rows[i].Cells["time_order"].Value = listOrder[i].Created;
                    dgvOrder.Rows[i].Cells["total_order"].Value = listOrder[i].OrdersTotal;
                }
            }
        }

        private void LoadGridViewOrderDetail(int id)
        {
            //select db
            dgvOrderDetail.Rows.Clear();
            var listOrderDetail = (from od in manage.OrdersDetails
                                   join p in manage.Products on od.OrdersDetailProductID equals p.ProductID
                                   where od.OrdersDetailOrderID == id
                                   select new
                                   {
                                       Price = p.Price,
                                       ProductName = p.ProductName,
                                       OrdersDetailQuanlity = od.OrdersDetailQuanlity,
                                       OrdersDetailOrderID = od.OrdersDetailOrderID,
                                       TotalMonneyDetail = od.OrdersDetailQuanlity*p.Price
                                   }).ToList();
                             
            if (listOrderDetail.Count > 0)
            {
                for (int i = 0; i < listOrderDetail.Count; i++)
                {
                    dgvOrderDetail.Rows.Add();
                    dgvOrderDetail.Rows[i].Cells["index_orderDetail"].Value = i + 1;
                    dgvOrderDetail.Rows[i].Cells["id_order_Detail"].Value = listOrderDetail[i].OrdersDetailOrderID;
                    dgvOrderDetail.Rows[i].Cells["name_orderDetail"].Value = listOrderDetail[i].ProductName;
                    dgvOrderDetail.Rows[i].Cells["price_orderDetail"].Value = listOrderDetail[i].Price;
                    dgvOrderDetail.Rows[i].Cells["quantity_orderDetail"].Value = listOrderDetail[i].OrdersDetailQuanlity;
                    dgvOrderDetail.Rows[i].Cells["monney"].Value = listOrderDetail[i].TotalMonneyDetail;
                }
            }
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProducts.SelectedRows.Count > -1)
            {
                //txtCategori.Text = dgvCategory.CurrentRow.Cells["CatName"].Value.ToString();
                txtIdProduct.Text = dgvProducts.CurrentRow.Cells["id_product"].Value.ToString();
                txtNameProduct.Text = dgvProducts.CurrentRow.Cells["name_product"].Value.ToString();
                numberQuantityProduct.Text = dgvProducts.CurrentRow.Cells["quantity_product"].Value.ToString();
                numberPriceProduct.Text = dgvProducts.CurrentRow.Cells["price_product"].Value.ToString();


                ComboBrandProduct.DataSource = (from b in manage.Brands
                                                select b).ToList();
                ComboBrandProduct.ValueMember = "BrandID";
                ComboBrandProduct.DisplayMember = "BrandName";

                ComboCateProduct.DataSource = (from c in manage.Categories
                                               select c).ToList();
                ComboCateProduct.ValueMember = "CategoryID";
                ComboCateProduct.DisplayMember = "CategoryName";


            }
            btnSaveProduct.Enabled = false;
            btnEditProduct.Enabled = true;
            btnRemoveProduct.Enabled = true;
            panelProduct.Enabled = true;
        }

        private void dgvCategori_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCategori.SelectedRows.Count > -1)
            {
                //txtCategori.Text = dgvCategory.CurrentRow.Cells["CatName"].Value.ToString();
                txtIdCate.Text = dgvCategori.CurrentRow.Cells["id_Cate"].Value.ToString();
                txtCategori.Text = dgvCategori.CurrentRow.Cells["Cate"].Value.ToString();
            }
            btnSaveCategories.Enabled = false;
            btnEditCate.Enabled = true;
            btnRemoveCate.Enabled = true;
            paneCate.Enabled = true;
        }

        private void btnRemoveCate_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa không?", "Some Title", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (Role ==1)
                {
                    int id = Convert.ToInt32(txtIdCate.Text);
                    Data.Category cate = new Data.Category();
                    cate = (from x in manage.Categories where x.CategoryID == id select x).FirstOrDefault();
                    manage.Entry(cate).State = System.Data.Entity.EntityState.Deleted;
                    manage.SaveChanges();
                    txtIdCate.Text = "";
                    txtCategori.Text = "";
                    MessageBox.Show("Bạn đã xóa thành công");

                    LoadGridViewCate();
                }
                else
                {
                    MessageBox.Show("Bạn không có quyền xóa");
                }


            }
        }

        private void btnEditCate_Click_1(object sender, EventArgs e)
        {
            if (Role ==1)
            {
                int id = Convert.ToInt32(txtIdCate.Text);
                Data.Category cate = new Data.Category();
                cate = (from x in manage.Categories where x.CategoryID == id select x).FirstOrDefault();
                cate.CategoryName = txtCategori.Text;
                manage.SaveChanges();
                MessageBox.Show("Bạn đã sửa 1 mục");
                LoadGridViewCate();
            }
            else
                {
                MessageBox.Show("Bạn không có quyền sửa !");
            }
        }

        private void btnNewCategori_Click(object sender, EventArgs e)
        {
            txtIdCate.Text = "";
            txtCategori.Text = "";
            paneCate.Enabled = true;
            btnEditCate.Enabled = false;
            btnRemoveCate.Enabled = false;
            btnNewCategori.Enabled = true;
            btnSaveCategories.Enabled = true;
            
        }
        private void btnSaveCategories_Click(object sender, EventArgs e)
        {
            string name = txtCategori.Text;
            Data.Category cate = new Data.Category();
            cate.CategoryName = name;
            manage.Categories.Add(cate);
            manage.SaveChanges();
            MessageBox.Show("Bạn đã thêm 1 mục");
            LoadGridViewCate();
        }
        private void btnNewProduct_Click(object sender, EventArgs e)
        {
            txtNameProduct.Text = "";
            numberQuantityProduct.Value = 0;
            numberPriceProduct.Value = 0;
            txtIdProduct.Text = "";

            ComboBrandProduct.DataSource = (from b in manage.Brands
                                            select b).ToList();
            ComboBrandProduct.ValueMember = "BrandID";
            ComboBrandProduct.DisplayMember = "BrandName";

            ComboCateProduct.DataSource = (from c in manage.Categories
                                           select c).ToList();
            ComboCateProduct.ValueMember = "CategoryID";
            ComboCateProduct.DisplayMember = "CategoryName";

            ComboBrandProduct.SelectedItem = 0;
            ComboCateProduct.SelectedItem = 0;
            btnNewProduct.Enabled = true;
            panelProduct.Enabled = true;
            btnEditProduct.Enabled = false;
            btnRemoveProduct.Enabled = false;
        }
        private void btnSaveProduct_Click(object sender, EventArgs e)
        {
            string name = txtNameProduct.Text;
            var cate = Convert.ToInt32(ComboCateProduct.SelectedValue);
            int quantity = Convert.ToInt32(numberQuantityProduct.Value);
            int price = Convert.ToInt32(numberPriceProduct.Value);
            var brand = Convert.ToInt32(ComboBrandProduct.SelectedValue);
            Data.Product pro = new Data.Product();
            pro.ProductName = name;
            pro.QuantityInStock = quantity;
            pro.CategoryID = cate;
            pro.BrandID = brand;
            pro.Price = price;
            pro.Avatar = "";

            manage.Products.Add(pro);
            manage.SaveChanges();

            txtNameProduct.Text = "";
            numberQuantityProduct.Value = 0;
            numberPriceProduct.Value = 0;
            txtIdProduct.Text = "";
            ComboBrandProduct.DataSource = (from b in manage.Brands
                                            select b).ToList();
            ComboBrandProduct.ValueMember = "BrandID";
            ComboBrandProduct.DisplayMember = "BrandName";

            ComboCateProduct.DataSource = (from c in manage.Categories
                                           select c).ToList();
            ComboCateProduct.ValueMember = "CategoryID";
            ComboCateProduct.DisplayMember = "CategoryName";
            ComboBrandProduct.SelectedItem = 0;
            ComboCateProduct.SelectedItem = 0;

            MessageBox.Show("Bạn đã thêm thành công");
            LoadGridViewProduct();
        }
        private void btnRemoveProduct_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa không?", "Some Title", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (Role == 1)
                {
                    int id = Convert.ToInt32(txtIdProduct.Text);
                    Data.Product pr = new Data.Product();
                    pr = (from p in manage.Products where p.ProductID == id select p).FirstOrDefault();
                    manage.Entry(pr).State = System.Data.Entity.EntityState.Deleted;
                    manage.SaveChanges();

                    MessageBox.Show("Bạn đã xóa thành công");
                    LoadGridViewProduct();
                }
                else
                {
                    MessageBox.Show("Bạn không có quyền xóa");
                }
            }
        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            if (Role ==1 )
            {
                int id = Convert.ToInt32(txtIdProduct.Text);

                Data.Product pr = new Data.Product();
                pr = (from p in manage.Products where p.ProductID == id select p).FirstOrDefault();
                pr.ProductName = txtNameProduct.Text;
                pr.QuantityInStock = Convert.ToInt32(numberQuantityProduct.Value);
                pr.Price = Convert.ToInt32(numberPriceProduct.Value);
                pr.CategoryID = Convert.ToInt32(ComboCateProduct.SelectedValue);
                pr.BrandID = Convert.ToInt32(ComboBrandProduct.SelectedValue);
                pr.Avatar = "";

                manage.SaveChanges();
                MessageBox.Show("Bạn đã sửa 1 mục");

                LoadGridViewProduct();
            }
            
            else
                {
                MessageBox.Show("Bạn không có quyền sửa !");
            }
        }
        private void dgvBrand_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvBrand.SelectedRows.Count > -1 && dgvBrand.SelectedRows.Count < listBrand.Count)
            {
                //txtCategori.Text = dgvCategory.CurrentRow.Cells["CatName"].Value.ToString();
                txtIdBrand.Text = dgvBrand.CurrentRow.Cells["id_brand"].Value.ToString();
                txtNameBrand.Text = dgvBrand.CurrentRow.Cells["name_brand"].Value.ToString();
                txtAddressBrand.Text = dgvBrand.CurrentRow.Cells["address_brand"].Value.ToString();
                txtPhoneBrand.Text = dgvBrand.CurrentRow.Cells["phone_brand"].Value.ToString();
               
            }
            btnSaveBrand.Enabled = false;
            btnEditBrand.Enabled = true;
            btnRemoveBrand.Enabled = true;
            panelBrand.Enabled = true;
          
        }

        private void btnNewBrand_Click(object sender, EventArgs e)
        {
            txtIdBrand.Text = "";
            txtNameBrand.Text = "";
            txtAddressBrand.Text = "";
            txtPhoneBrand.Text = "";
            panelBrand.Enabled = true;
            btnEditBrand.Enabled = false;
            btnRemoveBrand.Enabled = false;
            btnNewBrand.Enabled = true;
            btnSaveBrand.Enabled = true;

        }

        private void btnSaveBrand_Click(object sender, EventArgs e)
        {
            string name = txtNameBrand.Text;
            string address = txtAddressBrand.Text;
            string phone = txtPhoneBrand.Text;

            Data.Brand br = new Data.Brand();

            br.BrandName = name;
            br.BrandAddress = address;
            br.BrandCellPhone = phone;

            manage.Brands.Add(br);
            manage.SaveChanges();

            MessageBox.Show("Bạn đã thêm thành công");
            LoadGridViewBrand();
        }

        private void btnEditBrand_Click(object sender, EventArgs e)
        {
            if (Role ==1)
            {
                int id = Convert.ToInt32(txtIdBrand.Text);
                Data.Brand br = new Data.Brand();
                br = (from x in manage.Brands where x.BrandID == id select x).FirstOrDefault();
                br.BrandName = txtNameBrand.Text;
                br.BrandAddress = txtAddressBrand.Text;
                br.BrandCellPhone = txtPhoneBrand.Text;

                manage.SaveChanges();
                MessageBox.Show("Bạn đã sửa 1 mục");
                LoadGridViewBrand();
            }
            else
                {
                MessageBox.Show("Bạn không có quyền sửa !");
            }
        }

        private void btnRemoveBrand_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa không?", "Some Title", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (Role == 1)
                {
                    int id = Convert.ToInt32(txtIdBrand.Text);
                    Data.Brand br = new Data.Brand();
                    br = (from b in manage.Brands where b.BrandID == id select b).FirstOrDefault();
                    manage.Entry(br).State = System.Data.Entity.EntityState.Deleted;
                    manage.SaveChanges();

                    txtIdBrand.Text = "";
                    txtNameBrand.Text = "";
                    txtAddressBrand.Text = "";
                    txtPhoneBrand.Text = "";

                    MessageBox.Show("Bạn đã xóa thành công");

                    LoadGridViewBrand();
                }
                else
                {
                    MessageBox.Show("Bạn không có quyền xóa");
                }
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            ChangePassword changeAccount = new ChangePassword();
            changeAccount._EmployeeName = _employeeUserName;
            changeAccount._EmployeeId = _employeeId;
            changeAccount.Show();
        }

        private void btnSaveEmployee_Click(object sender, EventArgs e)
        {
            
                string EmployeeName = txtEmployeeName.Text;
                string Birthday = dtpBirthday.Text;
                string Address = txtAddress.Text;
                string CellPhone = txtCellPhone.Text;
                string UsersName = txtUsersName.Text;
                string Password = hashcode.HashPass(txtPassword.Text);
                int Roles = Convert.ToInt32(cbRoles.Text);
                if (Exsits == false)
                {
                    Data.Employee employee = new Data.Employee();
                    employee.EmployeeName = EmployeeName;
                    employee.Birthday = Convert.ToDateTime(dtpBirthday.Text);
                    employee.Address = Address;
                    employee.CellPhone = CellPhone;
                    employee.Users = UsersName;
                    employee.Password = Password;
                    employee.Roles = Roles;
                    manage.Employees.Add(employee);
                    manage.SaveChanges();
                    MessageBox.Show("Bạn đã thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    txtEmployeeName.Text = "";
                    txtAddress.Text = "";
                    txtCellPhone.Text = "";
                    txtUsersName.Text = "";
                    txtPassword.Text = "";
                    cbRoles.Text = "";
                    LoadGridView();
            }
        }

        private void btnNewEmployee_Click(object sender, EventArgs e)
        {
            txtEmployeeName.Text = "";
            txtAddress.Text = "";
            txtCellPhone.Text = "";
            txtUsersName.Text = "";
            txtPassword.Text = "";
            cbRoles.Text = "";
            panelEmployee.Enabled = true;
            btnEditEmployee.Enabled = false;
            btnRemoveEmployee.Enabled = false;
            btnNewEmployee.Enabled = true;
            btnSaveEmployee.Enabled = true;
        }

        private void dgvEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvEmployee.SelectedRows.Count > -1)
            {
                txtEmployeeName.Text = dgvEmployee.CurrentRow.Cells["EmployeeName"].Value.ToString();
                dtpBirthday.Text = dgvEmployee.CurrentRow.Cells["Birthday"].Value.ToString();
                txtAddress.Text = dgvEmployee.CurrentRow.Cells["Address"].Value.ToString();
                txtCellPhone.Text = dgvEmployee.CurrentRow.Cells["CellPhone"].Value.ToString();
                txtUsersName.Text = dgvEmployee.CurrentRow.Cells["Users"].Value.ToString();
                txtPassword.Text = dgvEmployee.CurrentRow.Cells["Password"].Value.ToString();
                cbRoles.Text = dgvEmployee.CurrentRow.Cells["Roles"].Value.ToString();
                panel1.Enabled = true;
                btnSaveEmployee.Enabled = false;
                btnEditEmployee.Enabled = true;
                btnRemoveEmployee.Enabled = true;
                txtUsersName.ReadOnly = true;
                txtPassword.ReadOnly = true;
                panelEmployee.Enabled = true;

            }
        }

        private void btnEditEmployee_Click(object sender, EventArgs e)
        {
           
            int id = Convert.ToInt32(dgvEmployee.CurrentRow.Cells["ID"].Value.ToString());
            Data.Employee employee = new Data.Employee();
            employee = (from x in manage.Employees where x.EmployeeID == id select x).FirstOrDefault();
            employee.EmployeeName = txtEmployeeName.Text;
            employee.Address = txtAddress.Text;
            employee.CellPhone = txtCellPhone.Text;
            employee.Birthday = Convert.ToDateTime(dtpBirthday.Text);
            employee.Roles = Convert.ToInt32(cbRoles.Text);
            manage.SaveChanges();
            LoadGridView();
        }

        private void btnRemoveEmployee_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Ban muon xoa khong?", "Some Title", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int id = Convert.ToInt32(dgvEmployee.CurrentRow.Cells["ID"].Value.ToString());
                Data.Employee employee = new Data.Employee();
                if (Role == 1)
                {
                    employee = (from x in manage.Employees where x.EmployeeID == id select x).FirstOrDefault();
                    manage.Entry(employee).State = System.Data.Entity.EntityState.Deleted;
                    manage.SaveChanges();
                    listEmployee = manage.Employees.ToList();
                    MessageBox.Show("Bạn đã xóa 1 mục");
                    LoadGridView();
                }
                else
                {
                    MessageBox.Show("Bạn không có quyền xóa");
                }


            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            Data.Employee employee = new Data.Employee();
            string checkPassword = hashcode.HashPass(txtPassword.Text);
            employee = manage.Employees.Where(x => x.Password == checkPassword).FirstOrDefault();
            if (employee == null)
            {
                lberror_2.Text = "";
                Exsits = false;
            }
            else if (employee.Password == checkPassword)
            {
                Exsits = true;
                lberror_2.Text = "Mật khẩu đã tồn tại";
            }
        }

        private void txtSeachEmployee_TextChanged(object sender, EventArgs e)
        {
            dgvEmployee.Rows.Clear();
            listEmployee = manage.Employees.Where(o => o.EmployeeName.Contains(txtSeachEmployee.Text) || o.Address.Contains(txtSeachEmployee.Text)).ToList();
            if (listEmployee.Count > 0)
            {
                for (int i = 0; i < listEmployee.Count; i++)
                {
                    dgvEmployee.Rows.Add();
                    dgvEmployee.Rows[i].Cells["ID"].Value = listEmployee[i].EmployeeID;
                    dgvEmployee.Rows[i].Cells["EmployeeName"].Value = listEmployee[i].EmployeeName;
                    dgvEmployee.Rows[i].Cells["Birthday"].Value = listEmployee[i].Birthday;
                    dgvEmployee.Rows[i].Cells["Address"].Value = listEmployee[i].Address;
                    dgvEmployee.Rows[i].Cells["CellPhone"].Value = listEmployee[i].CellPhone;
                    dgvEmployee.Rows[i].Cells["Users"].Value = listEmployee[i].Users;
                    dgvEmployee.Rows[i].Cells["Password"].Value = listEmployee[i].Password;
                    dgvEmployee.Rows[i].Cells["Roles"].Value = listEmployee[i].Roles;
                }
            }
        }

        private void txtSeachCate_TextChanged(object sender, EventArgs e)
        {
            dgvCategori.Rows.Clear();
            listCate = manage.Categories.Where(c => c.CategoryName.Contains(txtSeachCate.Text)).ToList();

            if (listCate.Count > 0)
            {
                for (int i = 0; i < listCate.Count; i++)
                {
                    dgvCategori.Rows.Add();
                    dgvCategori.Rows[i].Cells["index_Cate"].Value = i + 1;
                    dgvCategori.Rows[i].Cells["id_Cate"].Value = listCate[i].CategoryID;
                    dgvCategori.Rows[i].Cells["Cate"].Value = listCate[i].CategoryName;
                }
            }
        }

        private void txtSeachBrand_TextChanged(object sender, EventArgs e)
        {
            dgvBrand.Rows.Clear();
            listBrand = manage.Brands.Where(b => b.BrandName.Contains(txtSeachBrand.Text)).ToList();

            if (listBrand.Count > 0)
            {
                for (int i = 0; i < listBrand.Count; i++)
                {
                    dgvBrand.Rows.Add();
                    dgvBrand.Rows[i].Cells["index_brand"].Value = i + 1;
                    dgvBrand.Rows[i].Cells["id_brand"].Value = listBrand[i].BrandID;
                    dgvBrand.Rows[i].Cells["name_brand"].Value = listBrand[i].BrandName;
                    dgvBrand.Rows[i].Cells["address_brand"].Value = listBrand[i].BrandAddress;
                    dgvBrand.Rows[i].Cells["phone_brand"].Value = listBrand[i].BrandCellPhone;
                }
            }
        }

        private void txtSeachProduct_TextChanged(object sender, EventArgs e)
        {
            dgvProducts.Rows.Clear();
            var listProduct = (from pro in manage.Products
                               join brand in manage.Brands on pro.BrandID equals brand.BrandID
                               join cate in manage.Categories on pro.CategoryID equals cate.CategoryID
                               where pro.ProductName.Contains(txtSeachProduct.Text)
                               select new
                               {
                                   ProductID = pro.ProductID,
                                   ProductName = pro.ProductName,
                                   Price = pro.Price,
                                   BrandName = brand.BrandName,
                                   CategoryName = cate.CategoryName,
                                   QuantityInStock = pro.QuantityInStock

                               }).ToList();

            if (listProduct.Count > 0)
            {
                for (int i = 0; i < listProduct.Count; i++)
                {
                    dgvProducts.Rows.Add();
                    dgvProducts.Rows[i].Cells["index_Product"].Value = i + 1;
                    dgvProducts.Rows[i].Cells["id_product"].Value = listProduct[i].ProductID;
                    dgvProducts.Rows[i].Cells["name_product"].Value = listProduct[i].ProductName;
                    dgvProducts.Rows[i].Cells["name_Cate"].Value = listProduct[i].CategoryName;
                    dgvProducts.Rows[i].Cells["quantity_product"].Value = listProduct[i].QuantityInStock;
                    dgvProducts.Rows[i].Cells["brand_product"].Value = listProduct[i].BrandName;
                    dgvProducts.Rows[i].Cells["price_product"].Value = listProduct[i].Price;
                }
            }
        }

        private void dgvOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvOrder.SelectedRows.Count > -1)
            {
                int id = Convert.ToInt32(dgvOrder.CurrentRow.Cells["id_order"].Value);
                LoadGridViewOrderDetail(id);

            }
        }

        private void btnNewOrder_Click(object sender, EventArgs e)
        {
            Order orderNew = new Order();
            orderNew._EmployeeName = _employeeUserName;
            orderNew._EmployeeId = _employeeId;
            orderNew.Show();
        }
    }
}
