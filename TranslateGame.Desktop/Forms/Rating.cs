using System;
using System.Windows.Forms;
using TranslateGame.Desktop.Interfaces.Services;
using TranslateGame.Desktop.Services;

namespace TranslateGame.Desktop.Forms
{
    public partial class RatingForm : Form
    {
        private readonly IResultService resultService;
        private Guid userId;
        public RatingForm()
        {
            InitializeComponent();
            resultService = new ResultService();
        }

        public void SetUserId(Guid userId)
        {
            this.userId = userId;
        }

        private async void Rating_Load(object sender, EventArgs e)
        {
            int count = 1;
            var result = await resultService.GetRatings();
            foreach (var user in result)
            {
                bunifuCustomDataGrid1.Rows.Add(new object[]
                {
                    count++,
                    user.Name,
                    user.HardAvg,
                    user.MediumAvg,
                    user.EasyAvg
                });
            }
        }

        private void raytingBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Settings settings = new Settings();
            settings.SetUserId(userId);
            settings.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
