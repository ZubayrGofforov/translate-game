using System;
using System.Windows.Forms;
using TranslateGame.Desktop.Enums;

namespace TranslateGame.Desktop.Forms
{
    public partial class LevelSettings : Form
    {
        private Guid userId;
        public LevelSettings()
        {
            InitializeComponent();
        }

        private void xuiButton1_Click(object sender, EventArgs e)
        {
            TestLevel level = (TestLevel)0;

            if (easyRadio.Checked)
                level = (TestLevel)0;
            else if (mediumRadio.Checked)
                level = (TestLevel)1;
            else if (hardRadio.Checked)
                level = (TestLevel)2;

            int count = 10;

            if (onRadio.Checked)
                count = 10;
            else if (yigirmaRadio.Checked)
                count = 20;
            else if (ottizRadio.Checked)
                count = 30;

            MainForm mainForm = new MainForm();
            mainForm.SetConfigureValues(count, level, userId);
            mainForm.Show();
            this.Hide();

        }

        private void onRadio_Click(object sender, EventArgs e)
        {

        }

        public void SetUserId(Guid userId)
        {
            this.userId = userId;
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.SetUserId(userId);
            settings.Show();
            this.Hide();
        }

        private void LevelSettings_Load(object sender, EventArgs e)
        {

        }

        private void easyRadio_Click(object sender, EventArgs e)
        {

        }

        private void levelCustomGroupbox_Enter(object sender, EventArgs e)
        {

        }
    }
}
