using dotNet_GK_QUANLYTHUEXEOTO.Controller;
using dotNet_GK_QUANLYTHUEXEOTO.Model.Data;
using dotNet_GK_QUANLYTHUEXEOTO.Model.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dotNet_GK_QUANLYTHUEXEOTO
{
    public partial class Login : Form
    {
        private AccountController accountController;

        public Login()
        {
            this.accountController = App.ServiceProvider.GetRequiredService<AccountController>();
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;

            var loginResult = await accountController.Login(email, password);

            if (loginResult.IsSuccessful)
            {
                MessageBox.Show("Login successful!");

                Homepage homepage = new Homepage();
                homepage.FullName = loginResult.FullName;
                homepage.Email = email;
                homepage.UpdateFullNameLabel();
                homepage.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login failed. Please check your credentials.");
            }
        }
    }
}
