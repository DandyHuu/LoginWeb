using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            login frmlogin = new login();
            Application.Run(frmlogin);
            if(frmlogin.IsLogin == true)
            {
                Application.Run(new Dashboard(frmlogin.UserName,frmlogin.Roles,frmlogin.employeeID));
            }


        }
    }
}
