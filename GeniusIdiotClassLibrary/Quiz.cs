namespace GeniusIdiot.Common
{
    public class Quiz
    {
        public User User { get; }
        public string[] Diagnoses { get; }
        public QuestionStorage Questionnaire { get; set; }
        public UsersResultStorage UsersResult { get; }
        public Quiz(string userName, QuestionStorage questionnaire, UsersResultStorage usersResult)
        {
            User = new User(userName);
            Diagnoses = new string[6]
            {
                "идиот",
                "кретин",
                "дурак",
                "нормальный",
                "талант",
                "гений"
            };
            Questionnaire = questionnaire;
            UsersResult = usersResult;
        }
        public void ShuffleQuestions()
        {
            var rand = new Random();
            Questionnaire.Reset();
            Questionnaire.Questions = Questionnaire.Questions.OrderBy(x => rand.Next()).ToList();
        }
        public QuizResult DetermineDiagnose(int countRightAnswers)
        {
            var diagnoseNumber = (int)Math.Round(((double)countRightAnswers / Questionnaire.Questions.Count()) * (Diagnoses.Count() - 1), MidpointRounding.AwayFromZero);
            var quizResults = new QuizResult(User, countRightAnswers, Diagnoses[(int)diagnoseNumber]);
            return quizResults;
        }
    }
}
