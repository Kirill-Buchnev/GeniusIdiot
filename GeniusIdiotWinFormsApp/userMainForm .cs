using GeniusIdiot.Common;

namespace GeniyIdiotWinFormsApp
{
    public partial class userMainForm : Form
    {
        private QuestionStorage _questions { get; set; }
        public userMainForm()
        {
            InitializeComponent();
            _questions = authorizationForm.Questionnaire;
        }
        private void userMainStartButton_Click(object sender, EventArgs e)
        {
            if (_questions.Load().Count != 0)
            {
                OpenAnotherForm(new userQuizForm());
            }
            else
            {
                MessageBox.Show("Список вопросов пуст!");
            }
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

        private void OpenAnotherForm(Form form)
        {
            this.Hide();
            form.ShowDialog();
            this.Close();
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
    }
}