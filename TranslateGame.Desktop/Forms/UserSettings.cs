using System;
using System.Windows.Forms;
using TranslateGame.Desktop.Interfaces;
using TranslateGame.Desktop.Repositories;

namespace TranslateGame.Desktop.Forms
{
    public partial class UserSettings : Form
    {
        private Guid userId;
        public UserSettings()
        {
            InitializeComponent();
        }

        public void SetUserId(Guid userId)
        {
            this.userId = userId;
            IUserRepository userRepository = new UserRepository();
            var user = userRepository.Get(userId);
            firstnameTextbox.Text = user.Name;
            dateTextbox.Text = user.DateOfBirth;
            usernameTextbox.Text = user.Username;
        }

        private void UserSettings_Load(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            IUserRepository userRepository = new UserRepository();
            var user = userRepository.Get(userId);
            user.DateOfBirth = dateTextbox.Text;
            user.Username = usernameTextbox.Text;
            user.Name = firstnameTextbox.Text;

            if (userRepository.Update(userId, user))
            {
                this.Close();
            }
        }

        private void mainMenuLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void dateTextbox_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
