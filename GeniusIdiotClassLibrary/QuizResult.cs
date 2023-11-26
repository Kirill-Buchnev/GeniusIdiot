namespace GeniusIdiot.Common
{
    public class QuizResult
    {
        public User User { get; set; }
        public int RightAnswersCount { get; set;  }
        public string Diagnose { get; set;  }

        //for serialization
        public QuizResult()
        {            
        }

        public QuizResult(User user, int rightAnswersCount, string diagnose)
        {
            User = user;
            RightAnswersCount = rightAnswersCount;
            Diagnose = diagnose;
        }
    }
}
