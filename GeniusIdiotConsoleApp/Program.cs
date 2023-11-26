using GeniusIdiot.Common;
using System;
using System.Linq;
using System.Threading;

namespace GeniusIdiotConsoleApp
{
    class Program
    {
        static Timer _timer = null;
        static int countdownTime;
        static void Main(string[] args)
        {
            bool queryToStartGame;
            var heading = "Введите номер пункта в меню:";
            bool queryToAddNewQuestion;
            bool queryToShowResults;
            int questionNumber;
            string[] menu;
            QuizResult quizResults;
            var questionnaire = new QuestionStorage();
            var usersResultStorage = new UsersResultStorage();
            Console.Write($"Введите Ваше имя: ");
            var name = Console.ReadLine();
            Console.Clear();
            var user = new User(name);
            if (user.Name == string.Empty) user.Name = "Undefined";
        ApplicationStarts:
            Console.Clear();
            Console.WriteLine($"{heading}");
            menu = new string[] { "1. Начать игру"
                                    , "2. Настройки"};
            ShowMenu(menu);
            var userChoice = Console.ReadKey().Key;
            Console.Clear();
            switch (userChoice)
            {
                case ConsoleKey.D1: queryToStartGame = true; break;
                case ConsoleKey.D2: queryToStartGame = false; break;
                default:
                    {
                        Console.WriteLine("Вы ввели некорректное значение!");
                        goto ApplicationStarts;
                    }
            }
            if (queryToStartGame)
            {
                if (questionnaire.Questions.Count() == 0)
                {
                    questionnaire.ResetToDefaultQuestions();
                }
                var newQuiz = new Quiz(user.Name, questionnaire, usersResultStorage);
                newQuiz.ShuffleQuestions();
                quizResults = TakeQuiz(newQuiz);
                Console.WriteLine($"Количество правильных ответов: {quizResults.RightAnswersCount}" +
                                    $"\n{quizResults.User}, ваш диагноз: {quizResults.Diagnose}");
                usersResultStorage.Save(quizResults);
                Console.Write("Нажмите любую клавишу...");
                Console.ReadKey();
            UserChooseOptionToFinish:
                Console.Clear();
                Console.WriteLine($"{heading}");
                menu = new string[] { "1. Главное меню"
                                    , "2. Выйти"
                                    , "3. Выйти и посмотреть статистику игр"};
                ShowMenu(menu);
                var userAnswerToRepeatGame = Console.ReadKey().Key;
                Console.Clear();
                switch (userAnswerToRepeatGame)
                {
                    case ConsoleKey.D1: goto ApplicationStarts;
                    case ConsoleKey.D2: queryToShowResults = false; break;
                    case ConsoleKey.D3: queryToShowResults = true; break;
                    default:
                        {
                            Console.WriteLine("Вы ввели некорректное значение!");
                            goto UserChooseOptionToFinish;
                        }
                }
                if (queryToShowResults)
                {
                    var results = usersResultStorage.GetAll();
                    Console.WriteLine(Table.CreateFromQuizResults(results).GetAsString());
                }
                Console.WriteLine($"Спасибо за Ваше участие в тестировании нашей игры, {user.Name}! Ждём Вас снова!");
            }
            else
            {
            UserChooseSettings:
                Console.Clear();
                Console.WriteLine($"{heading}");
                menu = new string[] { "1. Загрузить стандартный список вопросов"
                                    , "2. Добавить вопрос"
                                    , "3. Удалить вопрос"
                                    , "4. Показать список вопросов"
                                    , "5. Вернуться в главное меню"};
                ShowMenu(menu);
                var userAnswerToModifyQuestionList = Console.ReadKey().Key;
                Console.Clear();
                switch (userAnswerToModifyQuestionList)
                {
                    case ConsoleKey.D1:
                        {
                            Console.WriteLine($"{questionnaire.ResetToDefaultQuestions()}");
                            Console.Write("Нажмите любую клавишу...");
                            Console.ReadKey();
                            goto UserChooseSettings;
                        }
                    case ConsoleKey.D2: queryToAddNewQuestion = true; break;
                    case ConsoleKey.D3:
                        {
                            if (questionnaire.Load().Count() == 0)
                            {
                                Console.Write("Список вопросов пуст!");
                                Console.Write("Нажмите любую клавишу...");
                                Console.ReadKey();
                                goto UserChooseSettings;
                            }
                            queryToAddNewQuestion = false;
                            Console.WriteLine(questionnaire.ShowQuestionList());
                            break;
                        }
                    case ConsoleKey.D4:
                        {
                            Console.WriteLine(questionnaire.ShowQuestionList());
                            Console.WriteLine();
                            Console.Write("Нажмите любую клавишу...");
                            Console.ReadKey();
                            goto UserChooseSettings;
                        }
                    case ConsoleKey.D5: goto ApplicationStarts;
                    default:
                        {
                            Console.Write("Вы ввели некорректное значение!");
                            Console.Write("Нажмите любую клавишу...");
                            Console.ReadKey();
                            goto UserChooseSettings;
                        }
                }
                if (queryToAddNewQuestion)
                {
                    var questionToAdd = AskUserAboutQuestionToAdd();
                    Console.WriteLine(questionnaire.AddNew(questionToAdd));
                    Console.Write("\nНажмите любую клавишу...");
                    Console.ReadKey();
                }
                else
                {
                    if (questionnaire.Load().Count() == 0)
                    {
                        Console.WriteLine("\nСписок вопросов пуст!");
                        Console.Write("Нажмите любую клавишу...");
                        Console.ReadKey();
                        goto UserChooseSettings;
                    }
                    var questionToRemove = AskUserAboutQuestionToRemove(questionnaire);
                    if (questionToRemove == null) goto UserChooseSettings;
                    if (int.TryParse(questionToRemove, out questionNumber))
                    {
                        Console.WriteLine();
                        Console.WriteLine(questionnaire.RemoveQuestionAtIndex(questionNumber - 1));
                        Console.WriteLine();
                        Console.Write("Нажмите любую клавишу...");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine(questionnaire.RemoveQuestionAtText(questionToRemove));
                        Console.WriteLine();
                        Console.Write("Нажмите любую клавишу...");
                        Console.ReadKey();
                    }
                }
                goto UserChooseSettings;
            }
        }
        static void ShowMenu(string[] menu)
        {
            menu.ToList().ForEach(item => Console.WriteLine(item));
        }

        static QuizResult TakeQuiz(Quiz quiz)
        {
            var numberOfQuestion = 1;
            var countRightAnswers = 0;
            quiz.Questionnaire = new QuestionStorage();
            Console.WriteLine("Игра началась!\nВнимание! На ответ на каждый вопрос у Вас есть ровно 10 секунд!");
            Console.Write("\nНажмите любую клавишу... ");
            Console.ReadKey();
            Console.WriteLine("\n\nВремя пошло!!!");
            Thread.Sleep(1000);
            Console.Clear();
            foreach (var question in quiz.Questionnaire)
            {
                countdownTime = 10;
                Console.WriteLine($"Вопрос номер {numberOfQuestion}:");
                Console.WriteLine(question);
                Console.WriteLine();
                var _timer = new Timer(TimerCallback, null, 0, 1000);
                var userAnswer = CheckUserAnswer(Console.ReadLine());
                if (userAnswer == question.Answer) countRightAnswers++;
                numberOfQuestion++;
                Console.Clear();
            }
            return quiz.DetermineDiagnose(countRightAnswers);
        }

        static string CheckUserAnswer(string userAnswer, Timer timer=null)
        {
            if (!InputIsNumber(userAnswer))
            {
                Console.WriteLine($"\nПожалуйста, введите число!");
                userAnswer = CheckUserAnswer(Console.ReadLine());
            }
            return userAnswer;
        }

        static bool InputIsNumber(string input)
        {
            if (input == string.Empty) input = null;
            return input?.ToCharArray().All(x => char.IsNumber(x)) ?? false;
        }

        static Question AskUserAboutQuestionToAdd()
        {
            Console.WriteLine($"Введите текст вопроса, который необходимо добавить: ");
            var questionText = Console.ReadLine();
            if (questionText.Last() != '?') questionText += "?";
            var questionAnswer = CheckUserAnswer(Console.ReadLine());
            return new Question(questionText, questionAnswer);
        }

        static string AskUserAboutQuestionToRemove(QuestionStorage questionnaire)
        {
            var questionNumber = -1;
            Console.Write($"\nВведите текст или номер вопроса, который необходимо удалить: ");

            var questionTextOrNumber = Console.ReadLine();
            if (questionnaire.Questions.Any(question => question.Text == questionTextOrNumber))
            {
                return questionTextOrNumber;
            }
            if (int.TryParse(questionTextOrNumber, out questionNumber)) questionNumber = Convert.ToInt32(questionTextOrNumber);
            if (questionNumber > 0 && questionNumber <= questionnaire.Questions.Count())
            {
                return questionTextOrNumber;
            }
            else
            {
                Console.WriteLine($"\nВопрос не найден!");
                Console.Write($"\nДля возврата в меню нажмите Esc. Чтобы ввести вопрос еще раз, нажмите любую другую клавишу...");
                var key = Console.ReadKey().Key;
                if (key == ConsoleKey.Escape) return null;
                questionTextOrNumber = AskUserAboutQuestionToRemove(questionnaire);
            }
            return questionTextOrNumber;
        }

        private static void TimerCallback(Object o)
        {
            countdownTime--;
            Console.Write($"Оставшееся время: {countdownTime}\r");
        }
    }
}