using BusinessLogic.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFApp
{
    public partial class LoginForm : Form
    {
        private readonly IAuthManager _authManager;
        public LoginForm(IAuthManager authManager)
        {
            _authManager = authManager;
            InitializeComponent();
        }

        private void DoLogin()
        {
            if(_authManager.Login(Login.Text,Password.Text))
            {
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid login or password");
            }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            DoLogin();
        }
    }
}
