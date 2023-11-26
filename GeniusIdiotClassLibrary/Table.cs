using System.Text;

namespace GeniusIdiot.Common
{
    public class Table
    {
        public List<TableRow> TableRows { get; set; }
        public Table(List<TableRow> tableRows)
        {
            TableRows = tableRows;
        }
        public StringBuilder GetAsString()
        {
            var table = new StringBuilder();
            var tableHeading = new string[4]{
                "Номер игры",
                "ФИО",
                "Количество правильных ответов",
                "Диагноз",
            };
            var line = $" {new string('-', 81)}";
            table.AppendLine($"\n{line}");
            table.AppendLine(FormatRow(tableHeading[0], tableHeading[1], tableHeading[2], tableHeading[3]));
            table.AppendLine($"{line}");
            TableRows.ForEach(row => table.AppendLine(FormatRow(row.NumberOfGame.ToString()
                                                                , row.UserName
                                                                , row.RightAnswers.ToString()
                                                                , row.Diagnose.ToString())));
            table.AppendLine($"{line}");
            return table;
        }
        private string FormatRow(string column1, string column2, string column3, string column4)
        {
            return $"| {column1,-10} | {column2,-20} | {column3,-30} | {column4,-10} |";
        }
        public static Table CreateFromQuizResults(List<QuizResult> quizResults)
        {
            var tableRows = quizResults.Select((result, index) => new TableRow(index + 1, result.User.Name
                                                                                        , result.RightAnswersCount
                                                                                        , result.Diagnose)).ToList();
            return new Table(tableRows);
        }
    }
}
