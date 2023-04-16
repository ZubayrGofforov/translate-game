using System;
using System.Windows.Forms;
using TranslateGame.Desktop.Enums;
using TranslateGame.Desktop.Interfaces;
using TranslateGame.Desktop.Models;
using TranslateGame.Desktop.Repositories;

namespace TranslateGame.Desktop.Forms
{
    public partial class AddWordForm : Form
    {
        private Guid userId;

        public AddWordForm()
        {
            InitializeComponent();
        }

        public void SetUserId(Guid userId)
        {
            this.userId = userId;
        }

        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomTextbox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddWordForm_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Settings settings = new Settings();
            settings.SetUserId(userId);
            settings.Show();
            this.Hide();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            TestLevel level = (TestLevel)0;

            if (easyRadio.Checked)
                level = (TestLevel)0;
            else if (mediumRadio.Checked)
                level = (TestLevel)1;
            else if (hardRadio.Checked)
                level = (TestLevel)2;

            var word = new Word()
            {
                Level = level,
                WordName = wordTextbox.Text,
                WordValue = translateTextbox.Text
            };

            IWordRepository wordRepository = new WordRepository();
            var res = wordRepository.Create(word);

            if (res) MessageBox.Show("Successfuly!");

        }

        private void xuiRadio2_Click(object sender, EventArgs e)
        {

        }
    }
}
