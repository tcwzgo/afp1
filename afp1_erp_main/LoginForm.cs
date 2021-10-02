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
            if(tb_uName.Text == string.Empty)
            {
                tb_uName.Focus();
                errorProvider.SetError(tb_uName, "Please enter your username!");
                
            }
            if (tb_passwd.Text == string.Empty)
            {
                tb_uName.Focus();
                errorProvider.SetError(tb_passwd, "Please enter your password");
                
            }
            if (tb_uName.Text == string.Empty && tb_passwd.Text == string.Empty)
            {
                tb_uName.Focus();
                errorProvider.SetError(tb_uName, "Please enter your username!");
                MessageBox.Show("Incorrect data", "Error", MessageBoxButtons.OK);
            }
            if (tb_uName.Text == string.Empty && tb_passwd.Text != "admin")
            {
                tb_uName.Focus();
                errorProvider.SetError(tb_uName, "Please enter your username!");
                MessageBox.Show("Incorrect data", "Error", MessageBoxButtons.OK);
            }
            if (tb_passwd.Text == string.Empty && tb_uName.Text != "admin")
            {
                tb_uName.Focus();
                errorProvider.SetError(tb_uName, "Incorrect username!");
                MessageBox.Show("Incorrect data", "Error", MessageBoxButtons.OK);
            }
            if (tb_uName.Text != "admin")
            {
                tb_uName.Focus();
                errorProvider.SetError(tb_uName, "Incorrect username!");
                MessageBox.Show("Incorrect data", "Error", MessageBoxButtons.OK);
            }
            if (tb_passwd.Text != "admin")
            {
                tb_uName.Focus();
                errorProvider.SetError(tb_passwd, "Incorrect password!");
                MessageBox.Show("Incorrect data", "Error", MessageBoxButtons.OK);
            }
            if (tb_uName.Text == "admin" && tb_passwd.Text == "admin")
            {
                Thread t = new Thread(Run);
                t.Start();
                Close();
            }
            
        }
        private void Run()
        {
            Thread.Sleep(500);
            Application.Run(new MainForm());
        
        }

        /*private void tb_uName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tb_uName.Text))
            {
                e.Cancel = true;
                tb_uName.Focus();
                errorProvider.SetError(tb_uName, "Please enter your username!");
            }
            else if(tb_uName.Text != "admin")
            {
                e.Cancel = true;
                tb_uName.Focus();
                errorProvider.SetError(tb_uName, "Incorrect username!");
            }
            else
            {
                e.Cancel = true;
                errorProvider.SetError(tb_uName, null);
            }
        }*/

        /*private void tb_passwd_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tb_passwd.Text))
            {
                e.Cancel = true;
                tb_uName.Focus();
                errorProvider.SetError(tb_passwd, "Please enter your password");
            }
            else if (tb_passwd.Text != "admin")
            {
                e.Cancel = true;
                tb_uName.Focus();
                errorProvider.SetError(tb_passwd, "Incorrect username!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(tb_passwd, null);
            }
        }*/
    }
}
