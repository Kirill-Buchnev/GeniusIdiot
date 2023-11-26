using GeniusIdiot.Common;

namespace GeniyIdiotWinFormsApp
{
    public partial class userQuizForm : Form
    {
        private int _questionNumber = 1;
        private int _countRightAnswers = 0;
        private int _countdownTime = 10;
        private System.Windows.Forms.Timer timer;
        private bool _timeIsGone = false;
        private QuestionStorage _questions { get; }
        private UsersResultStorage _usersResultStorage { get; }
        private Quiz _quiz { get; }
        private List<Question> _questionList { get; set; }
        public static string UserName { get; set; }
        public userQuizForm()
        {
            InitializeComponent();
            var userNameFile = authorizationForm.userNameFile;
            _questions = authorizationForm.Questionnaire;
            _usersResultStorage = authorizationForm.UsersResultStorage;
            UserName = File.ReadAllText(userNameFile.Path).Replace("\"", "");
            _quiz = new Quiz(UserName, _questions, _usersResultStorage);
            _quiz.ShuffleQuestions();
            _questionList = _quiz.Questionnaire.Questions.ToList();
            userQuizQuestionLabel.Text = _questionList.First().Text;
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += quizTimer_Tick;
            timer.Start();
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
        private void userQuizButton_Click(object sender, EventArgs e)
        {
            timer.Stop();
            GoToNextQuestion();
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

        private void quizTimer_Tick(object sender, EventArgs e)
        {
            _countdownTime--;
            if (_countdownTime > 0)
            {
                timerQuizQuestionLabel.Text = $"{_countdownTime}";
            }
            else
            {
                _timeIsGone = true;
                timer.Stop();
                GoToNextQuestion();
            }
        }

        private void GoToNextQuestion()
        {
            timerQuizQuestionLabel.Text = $"{_countdownTime}";
            if (userQuizAnswerNumericUpDown.Value.ToString()
                == _questionList.First().Answer && !_timeIsGone) _countRightAnswers++;
            _questionList.RemoveAt(0);
            timer.Start();
            _countdownTime = 10;
            _timeIsGone = false;
            if (_questionList.Count != 0)
            {
                _questionNumber++;
                userQuizLabel.Text = $"Вопрос №{_questionNumber}:";
                userQuizQuestionLabel.Text = _questionList.First().Text;
            }
            else
            {
                var quizResults = _quiz.DetermineDiagnose(_countRightAnswers);
                _usersResultStorage.Save(quizResults);
                MessageBox.Show($"\nКоличество правильных ответов: {quizResults.RightAnswersCount}" +
                                      $"\n{quizResults.User}, ваш диагноз: {quizResults.Diagnose}");
                timer.Stop();
                OpenAnotherForm(new userEndQuizForm());
            }
        }
    }
}