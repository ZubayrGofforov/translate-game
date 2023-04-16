using System;
using System.Windows.Forms;
using TranslateGame.Desktop.Interfaces.Services;
using TranslateGame.Desktop.Services;
using TranslateGame.Desktop.ViewModel;

namespace TranslateGame.Desktop.Forms
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void registerBttn_Click(object sender, EventArgs e)
        {
            IUserService userService = new UserServices();
            var userCreateViewModel = new UserCreateViewModel()
            {
                Name = nameTextBox.Text,
                DateOfBirth = dateOdBirthTextBox.Text,
                Username = usernameTextBox.Text,
                Password = passwordTextBox.Text
            };

            var result = await userService.RegisterAsync(userCreateViewModel);
            if (result)
            {
                MessageBox.Show("Successfuly!");
                LoginForm loginForm = new LoginForm();
                this.Hide();
                loginForm.Show();
            }
            else MessageBox.Show("Uknown error!");
        }


        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }
    }
}
