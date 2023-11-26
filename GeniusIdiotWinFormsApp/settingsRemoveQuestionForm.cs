using GeniusIdiot.Common;

namespace GeniyIdiotWinFormsApp
{
    public partial class settingsRemoveQuestionForm : Form
    {
        private QuestionStorage _questions { get; set; }
        public settingsRemoveQuestionForm()
        {
            InitializeComponent();
            _questions = new QuestionStorage();
            ResetDataGrid();
        }

        private void adminRemoveQuestionButton_Click(object sender, EventArgs e)
        {
            var questionText = removeQuestionDataGridView.CurrentRow.Cells[1].Value.ToString();
            MessageBox.Show(_questions.RemoveQuestionAtText(questionText));
            _questions = new QuestionStorage();
            ResetDataGrid();
        }

        private void adminRemoveQuestionBackButton_Click(object sender, EventArgs e)
        {
            OpenAnotherForm(new settingsMainForm());
        }

        private void OpenAnotherForm(Form form)
        {
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void ResetDataGrid()
        {
            removeQuestionDataGridView.Rows.Clear();
            var number = 1;
            _questions.Load().ForEach(question => removeQuestionDataGridView.Rows.Add(number++, question.Text));
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