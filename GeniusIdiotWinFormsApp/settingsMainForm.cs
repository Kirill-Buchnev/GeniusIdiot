using GeniusIdiot.Common;

namespace GeniyIdiotWinFormsApp
{
    public partial class settingsMainForm : Form
    {
        private QuestionStorage _questions { get; set; }
        public settingsMainForm()
        {
            InitializeComponent();
            _questions = authorizationForm.Questionnaire;
        }

        private void adminMainCancelButton_Click(object sender, EventArgs e)
        {
            OpenAnotherForm(new authorizationForm());
        }

        private void adminMainNextButton_Click(object sender, EventArgs e)
        {
            if (adminMainComboBox.Text == "Загрузить стандартный список вопросов")
            {
                _questions.ResetToDefaultQuestions();
                MessageBox.Show("Стандартный список вопросов добавлен!");
            }
            else if (adminMainComboBox.Text == "Добавить вопрос")
            {
                OpenAnotherForm(new settingsAddQuestionForm());
            }
            else if (adminMainComboBox.Text == "Удалить вопрос")
            {
                OpenAnotherForm(new settingsRemoveQuestionForm());
            }
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