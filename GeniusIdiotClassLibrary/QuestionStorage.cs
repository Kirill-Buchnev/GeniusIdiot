using Newtonsoft.Json;
using System.Collections;

namespace GeniusIdiot.Common
{
    public class QuestionStorage : IEnumerable<Question>, IEnumerator<Question>
    {
        public List<Question> Questions { get; set; }
        private FileProvider _fileProvider { get; }
        private int index = -1;
        public QuestionStorage()
        {
            _fileProvider = new FileProvider(@".\questions.json");
            Questions = Load();
        }
        IEnumerator<Question> IEnumerable<Question>.GetEnumerator()
        {
            return this;
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this;
        }
        public Question Current => Questions[index];
        object IEnumerator.Current => Questions[index];
        public bool MoveNext()
        {
            index++;
            return index < Questions.Count;
        }
        public void Reset()
        {
            index = -1;
        }
        public void Dispose() { }
        public int Count()
        {
            return Questions.Count;
        }
        public List<Question> Load()
        {
            if (_fileProvider.Exists())
            {
                var json = _fileProvider.Get();
                return JsonConvert.DeserializeObject<List<Question>>(json);
            }
            else
            {
                ResetToDefaultQuestions();
                return Load();
            }
        }
        public List<Question> GetDefaultQuestions()
        {
            var questionList = new List<Question>()
                {
                    new Question("Сколько будет два плюс два умноженное на два?" , "6"),
                    new Question("Бревно нужно распилить на 10 частей. Сколько распилов нужно сделать?" , "9"),
                    new Question("На двух руках 10 пальцев. Сколько пальцев на 5 руках?" , "25"),
                    new Question("Укол делают каждые полчаса. Сколько нужно минут, чтобы сделать три укола?" , "60"),
                    new Question("Пять свечей горело, две потухли. Сколько свечей осталось?" , "2"),
                };
            return questionList;
        }
        public string AddNew(Question question)
        {
            Questions.Add(question);
            var json = JsonConvert.SerializeObject(Questions);
            _fileProvider.Write(json);
            return "Вопрос добавлен!";
        }
        public string ResetToDefaultQuestions()
        {
            Questions = GetDefaultQuestions();
            var json = JsonConvert.SerializeObject(Questions);
            _fileProvider.Write(json);
            return "Стандартный список вопросов добавлен!";
        }
        public string RemoveQuestionAtText(string questionText)
        {
            var question = Questions.FirstOrDefault(question => question.Text == questionText);
            Questions.Remove(question);
            var json = JsonConvert.SerializeObject(Questions);
            _fileProvider.Write(json);
            return "Вопрос удален!";
        }
        public string RemoveQuestionAtIndex(int questionIndex)
        {
            Questions.RemoveAt(questionIndex);
            var json = JsonConvert.SerializeObject(Questions);
            _fileProvider.Write(json);
            return "Вопрос удален!";
        }

        public string ShowQuestionList()
        {
            Questions = Load();
            string questionList;
            if (Questions.Count != 0)
            {
                questionList = $"Список вопросов:";
                var row = 1;
                Questions.ForEach(question => questionList += ($"\n{row++}. {question.Text}"));
            }
            else
            {
                questionList = $"\nСписок вопросов пуст!";
            }
            return questionList;
        }
    }    
}
