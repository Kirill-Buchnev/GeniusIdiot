namespace GeniusIdiot.Common
{
    public class TableRow
    {
        public int NumberOfGame { get; }
        public string UserName { get; }
        public int RightAnswers { get; }
        public string Diagnose { get; }
        public TableRow(int numberOfGame, string userName, int rightAnswers, string diagnose)
        {
            NumberOfGame = numberOfGame;
            UserName = userName;
            RightAnswers = rightAnswers;
            Diagnose = diagnose;
        }
    }
}
