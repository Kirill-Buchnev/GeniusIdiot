using Newtonsoft.Json;

namespace GeniusIdiot.Common
{
    public class UsersResultStorage
    {
        private FileProvider _fileProvider { get; }
        public UsersResultStorage()
        {
            _fileProvider = new FileProvider(@".\gameResults.json");
        }
        public void Save(QuizResult quizResults)
        {
            var results = GetAll() ?? new List<QuizResult>();
            results.Add(quizResults);
            var json = JsonConvert.SerializeObject(results);
            _fileProvider.Write(json);
        }

        public List<QuizResult> GetAll()
        {
            var json = _fileProvider.Get();
            return JsonConvert.DeserializeObject<List<QuizResult>>(json);
        }

        public static Table ToTable(List<QuizResult> quizResults)
        {
            var tableRows = quizResults.Select((result, index) => new TableRow(index + 1, result.User.Name
                                                                                        , result.RightAnswersCount
                                                                                        , result.Diagnose)).ToList();
            return new Table(tableRows);
        }
    }
}