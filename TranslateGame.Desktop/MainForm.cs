using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TranslateGame.Desktop.Forms;
using TranslateGame.Desktop.Interfaces;
using TranslateGame.Desktop.Models;
using TranslateGame.Desktop.Repositories;

namespace TranslateGame.Desktop
{
    public partial class MainForm : Form
    {
        private IList<Word> words;
        private int currentTest = 0;
        private int correctAnswers = 0;
        private Guid userId;

        public MainForm()
        {
            InitializeComponent();
        }

        public void SetUserId(Guid userId)
        {
            this.userId = userId;
        }

        private async void GetTestCollection()
        {   
            IWordRepository wordRepository = new WordRepository();
            words = await wordRepository.GetConfigurated(count, level);

            wordBox.Text = words[currentTest].WordName;
            currentTest++;
        }

        private void xuiButton1_Click(object sender, EventArgs e)
        {
            if (translateBox.Text == words[currentTest - 1].WordValue.ToLower())
                correctAnswers++;

            translateBox.Clear();
            resultLabel.Text = $"correct anwers: {words.Count}/{correctAnswers}  current test: {currentTest}";
            if(currentTest > words.Count - 1)
            {
                MessageBox.Show($"Level: {level}\n\tTotal: {words.Count}\tCorrect: {correctAnswers}");
                IResultRepository resultRepository = new ResultRepositroy();
                resultRepository.Create(new Result()
                {
                    Level = level,
                    Count = words.Count,
                    Percentage = (double)correctAnswers / (double)words.Count * 100,
                    UserId = userId,
                });

                Settings settings = new Settings();
                this.Hide();
                settings.SetUserId(userId);
                settings.Show();
                return;
            }
            wordBox.Text = words[currentTest++].WordName;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {
        }

        private void wordBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void translateBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
