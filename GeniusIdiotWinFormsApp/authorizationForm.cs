using GeniusIdiot.Common;

namespace GeniyIdiotWinFormsApp
{
    public partial class authorizationForm : Form
    {
        public static FileProvider userNameFile { get; set; }
        public static QuestionStorage Questionnaire { get; set; }
        public static UsersResultStorage UsersResultStorage { get; set; }
        public authorizationForm()
        {
            InitializeComponent();
            userNameFile = new FileProvider(@".\userName.json");
            Questionnaire = new QuestionStorage();
            UsersResultStorage = new UsersResultStorage();
        }
        private void authorizationNextButton_Click(object sender, EventArgs e)
        {
            userNameFile.Write(nameTextBox.Text);
            this.Hide();
            var userMainForm = new userMainForm();
            userMainForm.ShowDialog();
            this.Close();
        }

        private void statisticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var userStatisticsForm = new userStatisticsForm();
            userStatisticsForm.ShowDialog();
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var settingsMainForm = new settingsMainForm();
            settingsMainForm.ShowDialog();
            this.Close();
        }
    }
}