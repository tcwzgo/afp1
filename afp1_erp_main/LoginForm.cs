using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace afp1_erp_main
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

        }
        private void btn_login_Click(object sender, EventArgs e)
        {
            if (tb_uName.Text == "admin" && tb_passwd.Text == "admin")
            {
                Thread t = new Thread(Run);
                t.Start();
                Close();
            }
            else
            {
                tb_uName.Focus();
                MessageBox.Show("Incorrect data", "Error", MessageBoxButtons.OK);
                tb_uName.Clear();
                tb_passwd.Clear();
            }
        }
        private void Run()
        {
            Thread.Sleep(500);
            Application.Run(new MainForm());
        }
    }
}
