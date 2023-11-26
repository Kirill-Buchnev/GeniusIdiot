using GeniusIdiot.Common;

namespace GeniyIdiotWinFormsApp
{
    public partial class userEndQuizForm : Form
    {
        public userEndQuizForm()
        {
            InitializeComponent();
            var userNameFile = authorizationForm.userNameFile;
            var userName = userQuizForm.UserName;
            userEndQuizLabel.Text = "Спасибо за Ваше участие в тестировании нашей игры," +
                                    $" {userName}! Ждём Вас снова!";
        }
        private void adminMainCancelButton_Click(object sender, EventArgs e)
        {
            OpenAnotherForm(new authorizationForm());
        }
        private void OpenAnotherForm(Form form)
        {
            this.Hide();
            form.ShowDialog();
            this.Close();
        }
        private void userRepeatQuizButton_Click(object sender, EventArgs e)
        {
            OpenAnotherForm(new userMainForm());
        }

        private void statisticsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var userStatisticsForm = new userStatisticsForm();
            userStatisticsForm.ShowDialog();
        }

        private void restartToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void userEndQuizButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}