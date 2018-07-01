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
    public partial class ChangePassword : Form
    {
        public string _EmployeeName;
        Data.QuanLiCafeEntities manage = new Data.QuanLiCafeEntities();
        HashCode hashcode = new HashCode();
        public int _EmployeeId;
        public bool changed;
        public ChangePassword()
        {
            InitializeComponent();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to cancel", "Comfirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {
            txtUsersName.Text = _EmployeeName;
        }

        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtConfirmPassword.Text == txtPassoword.Text)
            {
                changed = true;
                lbErr.Text = "Strong";
            }
            else
            {
                lbErr.Text = "Wrong Password";
            }
        }

        private void lbPassoword_Click(object sender, EventArgs e)
        {
            txtPassoword.UseSystemPasswordChar = false;
        }

        private void lbConfirmPassoword_Click(object sender, EventArgs e)
        {
            txtConfirmPassword.UseSystemPasswordChar = false;
        }

        private void lbPassoword_Clicks(object sender, EventArgs e)
        {
            txtPassoword.UseSystemPasswordChar = true;
        }

        private void lbConfirmPassoword_Clicks(object sender, EventArgs e)
        {
            txtConfirmPassword.UseSystemPasswordChar = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (changed == true)
            {
                int id = Convert.ToInt32(_EmployeeId);
                Data.Employee employee = new Data.Employee();
                employee = (from x in manage.Employees where x.EmployeeID == id select x).FirstOrDefault();
                employee.Users = txtUsersName.Text;
                employee.Password = hashcode.HashPass(txtPassoword.Text);
                manage.SaveChanges();
                this.Close();
            }
            else
            {
                MessageBox.Show("You check password enter again", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}