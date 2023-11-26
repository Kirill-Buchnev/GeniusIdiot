namespace GeniusIdiot.Common
{
    public class Question : IEquatable<Question>
    {
        public string Text { get; }
        public string Answer { get; }
        public Question(string text, string answer)
        {
            Text = text;
            Answer = answer;
        }
        public override string ToString()
        {
            return Text;
        }
        public bool Equals(Question other)
        {
            return Text == other.Text && Answer == other.Answer;
        }
    }
}
