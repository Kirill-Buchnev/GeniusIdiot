using GeniusIdiot.Common;

namespace GeniyIdiotWinFormsApp
{
    public partial class userStatisticsForm : Form
    {
        private UsersResultStorage _usersResultStorage { get; }
        public userStatisticsForm()
        {
            InitializeComponent();
            _usersResultStorage = authorizationForm.UsersResultStorage;
            var tableRows = _usersResultStorage.GetAll()?.Select((result, index) => new TableRow(index + 1, result.User.Name
                                                                                        , result.RightAnswersCount
                                                                                        , result.Diagnose)).ToList() ?? null;
            if (tableRows == null)
            {
                MessageBox.Show("Список статистики игр пуст!");
            }
            else
            {
                tableRows.ToList().ForEach(row =>
                {
                    if (row != null)
                    {
                        userStatisticsDataGridView.Rows.Add(row.NumberOfGame, row.UserName, row.RightAnswers, row.Diagnose);
                    }
                });
            }
        }
        private void userStatisticsButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}