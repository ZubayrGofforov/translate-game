using System;
using System.Windows.Forms;

namespace TranslateGame.Desktop.Forms
{
    public partial class Settings : Form
    {
        private Guid userId;
        public Settings()
        {
            InitializeComponent();
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void levelSettingsBttn_Click(object sender, EventArgs e)
        {
            LevelSettings levelSettings = new LevelSettings();
            levelSettings.SetUserId(userId);
            levelSettings.Show();
            this.Hide();
        }

        private void userSettingsBttn_Click(object sender, EventArgs e)
        {
            UserSettings userSettings = new UserSettings();
            userSettings.SetUserId(userId);
            this.Hide();
            userSettings.ShowDialog();
            this.Show();
        }

        public void SetUserId(Guid userId)
        {
            this.userId = userId;
        }

        private void gameMenuLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm mainForm = new LoginForm();
            mainForm.Show();
            this.Hide();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            RatingForm ratingForm = new RatingForm();
            ratingForm.SetUserId(userId);
            this.Hide();
            ratingForm.Show();
        }

        private void Settings_Load(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton_Click(object sender, EventArgs e)
        {
            AddWordForm addWordForm = new AddWordForm();
            addWordForm.SetUserId(userId);
            this.Hide();
            addWordForm.Show();
        }
    }
}
