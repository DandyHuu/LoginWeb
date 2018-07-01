using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using login.Data;
using System.Security.Cryptography;

namespace login
{
    public partial class login : Form
    {
        Data.QuanLiCafeEntities manage = new Data.QuanLiCafeEntities();
        HashCode hashcode = new HashCode();
        public bool IsLogin { get; set; }
        public string UserName { get; set; }

        public bool check { get; set; }
        public int Roles { get; set; }
        public int employeeID { get; set; }
        public login()
        {
            InitializeComponent();
            IsLogin = false;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "")
            {
                check = false;
            }
            else if (txtPassword.Text == "")
            {
                check = false;
            }
            foreach (var user in manage.Employees)
            {
                if (user.Users.Replace(" ","") == txtUserName.Text && user.Password.Replace(" ","") == hashcode.HashPass(txtPassword.Text))
                {
                    IsLogin = true;
                    check = true;
                    this.Close();
                    UserName = user.Users;
                    Roles = user.Roles;
                    employeeID = user.EmployeeID;

                }
                else
                {
                    check = false;
                }
            }
            if(check == false)
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu của bạn sai");
            }
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không ?","Comfirm",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void chkPass_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
        }
    }
}
