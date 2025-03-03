using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace QuizMuzic.Views.TestOnePlayer
{
    /// <summary>
    /// Логика взаимодействия для TestPage.xaml
    /// </summary>
    public partial class TestPage : Page
    {
        // Коллекция вопросов
        public ObservableCollection<QuizItem> QuizItems { get; set; }
        private int currentQuestionIndex = 0;
        public TestPage()
        {
            InitializeComponent();

            QuizItems = new ObservableCollection<QuizItem>
            {
                new QuizItem
                {
                    Question = "Кто из ниже перечисленных музыкантов был участником группы \"The Beatles\"?",
                    Options = new[] { "Джон Леннон", "Элтон Джон", "Дэвид Боуи", "Мик Джаггер" },
                    CorrectAnswer = "Джон Леннон"
                },
                new QuizItem
                {
                    Question = "Какой музыкальный стиль возник в США в середине 20-го века и характеризуется импровизацией и сложными ритмическими структурами?",
                    Options = new[] { "Джаз", "Кантри", "Регги", "Хип-хоп" },
                    CorrectAnswer = "Джаз"
                },
                new QuizItem
                {
                    Question = "Как называется музыкальный инструмент, который имеет клавиши, струны и педали, и чаще всего используется в классической музыке?",
                    Options = new[] { "Гитара", "Фортепиано", "Саксофон", "Арфа" },
                    CorrectAnswer = "Фортепиано"
                },
                new QuizItem
                {
                    Question = "Кто из ниже перечисленных композиторов является автором \"Лунной сонаты\"?",
                    Options = new[] { "Иоганн Себастьян Бах", "Людвиг ван Бетховен", "Вольфганг Амадей Моцарт", "Фредерик Шопен" },
                    CorrectAnswer = "Людвиг ван Бетховен"
                },
                new QuizItem
                {
                    Question = "Кто из ниже перечисленных певиц исполнил хит \"Rolling in the Deep\"?",
                    Options = new[] { "Бейонсе", "Рианна", "Адель", "Леди Гага" },
                    CorrectAnswer = "Адель"
                },
                new QuizItem
                {
                    Question = "Кто из ниже перечисленных композиторов известен своим произведением \"Лебединое озеро\"?",
                    Options = new[] { "Петр Ильич Чайковский", "Корней Иванович Чуковский", "Дмитрий Шостакович", "Николай Римский-Корсаков" },
                    CorrectAnswer = "Петр Ильич Чайковский"
                },
                new QuizItem
                {
                    Question = "Какое произведение написал Антонио Вивальди?",
                    Options = new[] { "\"Весна\"", "\"Лунная соната\"", "\"Реквием\"", "\"Турецкий марш\"" },
                    CorrectAnswer = "\"Весна\""
                },
                new QuizItem
                {
                    Question = "Какая песня была популярна у группы \"Руки Вверх!\"?",
                    Options = new[] { "\"Алешка\"", "\"Малыш\"", "\"Крошка моя\"", "\"Танцуй без меня\"" },
                    CorrectAnswer = "\"Крошка моя\""
                },
                new QuizItem
                {
                    Question = "Кто из ниже перечисленных исполнителей выпустил хит \"Маленькая страна\"?",
                    Options = new[] { "Дима Билан", "Игорь Николаев", "Татьяна Буланова", "Наташа Королева" },
                    CorrectAnswer = "Наташа Королева"
                },
                new QuizItem
                {
                    Question = "Какое произведение написал Вольфганг Амадей Моцарт?",
                    Options = new[] { "\"Симфония № 5\"", "\"Фигаро\"", "\"Весна\" из \"Времена года\"", "\"Лунная соната\"" },
                    CorrectAnswer = "\"Фигаро\""
                },
                new QuizItem
                {
                    Question = "Угадай пропущенное слово в песне. \"Never mind, I'll find someone like __________\"",
                    Options = new[] { "You", "Me", "Her", "Him" },
                    CorrectAnswer = "You"
                },
                new QuizItem
                {
                    Question = "Теперь вспомним песни Jony; «Хочешь, не верь, но всё завершено Наша любовь – это _________ в кино»",
                    Options = new[] { "Шутка", "История", "Титры", "Субтитры" },
                    CorrectAnswer = "Титры"
                }
            };

            // Загружаем первый вопрос
            LoadQuestion(currentQuestionIndex);
        }

        // Метод для загрузки вопроса
        private void LoadQuestion(int index)
        {
            if (index >= 0 && index < QuizItems.Count)
            {
                var question = QuizItems[index];
                QuestionText.Text = question.Question;

                // Обновляем варианты ответов
                Option1.Content = question.Options[0];
                Option2.Content = question.Options[1];
                Option3.Content = question.Options[2];
                Option4.Content = question.Options[3];
            }
        }

        // Обработчик нажатия на кнопку "Ответить"
        private void AnswerButton_Click(object sender, RoutedEventArgs e)
        {
            var currentQuestion = QuizItems[currentQuestionIndex];

            // Проверяем, какой RadioButton выбран
            if ((Option1.IsChecked == true && Option1.Content.ToString() == currentQuestion.CorrectAnswer) ||
                (Option2.IsChecked == true && Option2.Content.ToString() == currentQuestion.CorrectAnswer) ||
                (Option3.IsChecked == true && Option3.Content.ToString() == currentQuestion.CorrectAnswer) ||
                (Option4.IsChecked == true && Option4.Content.ToString() == currentQuestion.CorrectAnswer))
            {
                MessageBox.Show("Правильно!", "Результат", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show($"Неправильно! Правильный ответ: {currentQuestion.CorrectAnswer}", "Результат", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            // Переход к следующему вопросу
            currentQuestionIndex++;
            if (currentQuestionIndex < QuizItems.Count)
            {
                LoadQuestion(currentQuestionIndex);
            }
            else
            {
                MessageBox.Show("Тест завершен!", "Конец", MessageBoxButton.OK, MessageBoxImage.Information);
                AnswerButton.IsEnabled = false; // Отключаем кнопку после завершения теста
            }

            // Сброс выбора RadioButton
            Option1.IsChecked = false;
            Option2.IsChecked = false;
            Option3.IsChecked = false;
            Option4.IsChecked = false;
        }
    }

    // Класс для хранения вопроса
    public class QuizItem
    {
        public string Question { get; set; }
        public string[] Options { get; set; }
        public string CorrectAnswer { get; set; }
    }
}
