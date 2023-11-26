using GeniusIdiot.Common;

namespace GeniyIdiotWinFormsApp
{
    public partial class settingsAddQuestionForm : Form
    {
        private QuestionStorage _questions { get; }
        public settingsAddQuestionForm()
        {
            InitializeComponent();
            _questions = new QuestionStorage();
        }

        private void adminAddQuestionButton_Click(object sender, EventArgs e)
        {
            if (adminAddQuestionTextBox.Text.Last() != '?')
            {
                adminAddQuestionTextBox.Text += "?";
            }
            MessageBox.Show(_questions.AddNew(new Question(adminAddQuestionTextBox.Text, adminAddQuestionNumericUpDown.Text)));
        }

        private void adminAddQuestionBackButton_Click(object sender, EventArgs e)
        {
            OpenAnotherForm(new settingsMainForm());
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