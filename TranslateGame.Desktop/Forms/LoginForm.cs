using System;
using System.Windows.Forms;
using TranslateGame.Desktop.Interfaces.Services;
using TranslateGame.Desktop.Services;

namespace TranslateGame.Desktop.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private async void loginBttn_Click(object sender, EventArgs e)
        {
            IUserService userServices = new UserServices();
            string username = usernameTxtBox.Text;
            string password = passwordLGtxtBox.Text;
            var user = await userServices.LoginAsync(username, password);
            if (user is null) MessageBox.Show("Username or password in correct!");
            else
            {
                Settings settings = new Settings();
                settings.SetUserId(user.Id);
                settings.Show();
                this.Hide();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
            this.Hide();
        }
    }
}
