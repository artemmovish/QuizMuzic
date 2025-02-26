using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using QuizMuzic.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace QuizMuzic.ViewModels.QuizTwoPlayers
{
    public partial class QwestViewModel : ObservableObject
    {

        private CancellationTokenSource _cancellationTokenSource = new();

        private MediaPlayer mediaPlayer;

        [ObservableProperty]
        string answerText = "";

        public ObservableCollection<ObservableCollection<Qwest>> Qwests;
        public ObservableCollection<Player> Players;

        [ObservableProperty]
        Qwest selectedQwest;
        [ObservableProperty]
        Player selectedPlayer;

        int counterQwest = 0;
        int counterPlayer = 0;

        [ObservableProperty]
        int timer = 5;
        public QwestViewModel()
        {

        }
        public QwestViewModel(ObservableCollection<Player> players, ObservableCollection<ObservableCollection<Qwest>> qwests)
        {
            Players = players;
            Qwests = qwests;

            SelectedQwest = Qwests[counterPlayer][counterQwest];
            selectedPlayer = Players[0];

            mediaPlayer = new MediaPlayer();
        }

        [RelayCommand]
        async Task Play()
        {
            _cancellationTokenSource = new CancellationTokenSource();
            string musicFilePath = Path.Combine(Directory.GetCurrentDirectory(), SelectedQwest.MusicPath);

            // Проверка существования файла
            if (File.Exists(musicFilePath))
            {
                Uri resourceUri = new Uri(musicFilePath, UriKind.Absolute);

                // Подписываемся на событие MediaOpened, чтобы убедиться, что файл загружен
                mediaPlayer.MediaOpened += async (sender, e) =>
                {
                    // Проверяем, что продолжительность доступна
                    if (mediaPlayer.NaturalDuration.HasTimeSpan)
                    {
                        mediaPlayer.Play();
                        // Ждем завершения воспроизведения
                        await Task.Delay(mediaPlayer.NaturalDuration.TimeSpan);

                        while (true)
                        {
                            await Task.Delay(1000);
                            Timer--;

                            if (Timer == 0)
                            {
                                MessageBox.Show("Время вышло. Переход на другого игрока");
                                Answer();
                                Timer = 20;
                                return;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Не удалось определить продолжительность медиафайла.");
                    }
                };

                // Подписываемся на событие MediaFailed для обработки ошибок
                mediaPlayer.MediaFailed += (sender, e) =>
                {
                    MessageBox.Show($"Ошибка воспроизведения медиафайла: {e.ErrorException.Message}");
                };

                // Загружаем медиафайл
                mediaPlayer.Open(resourceUri);
            }
            else
            {
                MessageBox.Show("Файл не найден.");
            }
        }

        [RelayCommand]
        void Answer()
        {
            _cancellationTokenSource.Cancel(); // Прерываем ожидание

            if (AnswerText.ToLower() == SelectedQwest.Answer.ToLower())
            {                                
                SelectedPlayer.Score++;      
                MessageBox.Show("Правильно. Переход на другого игрока");           
            }
            MessageBox.Show("Не правильно. Переход на другого игрока");

            counterPlayer = counterPlayer == 0 ? 1 : 0;
            counterQwest = counterPlayer == 0 ? counterQwest + 1 : counterQwest;

            if (counterQwest == 6) 
            {
                MessageBox.Show("Конец");

                return;
            }
            AnswerText = "";
            SelectedPlayer = Players[counterPlayer];
            SelectedQwest = Qwests[counterPlayer][counterQwest];
        }
    }
}
