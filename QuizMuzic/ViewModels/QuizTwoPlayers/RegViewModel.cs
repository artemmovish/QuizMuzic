using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using QuizMuzic.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizMuzic.ViewModels.QuizTwoPlayers
{
    public partial class RegViewModel : ObservableObject
    {
        [ObservableProperty]
        Player player1 = new Player()
        {
            Name = "Игрок_1",
            Score = 0
        };
        [ObservableProperty]
        Player player2 = new Player
        {
            Name = "Игрок_2",
            Score = 0
        };

        [ObservableProperty]
        bool is90 = false;
        [ObservableProperty]
        bool isPop = false;
        [ObservableProperty]
        bool isClassic = false;
        public RegViewModel()
        {
            
        }

        [RelayCommand]
        void Chech_90()
        {
            this.Is90 = !this.Is90;
        }

        [RelayCommand]
        void Chech_Pop()
        {
            this.IsPop = !this.IsPop;
        }
        [RelayCommand]
        void Chech_Classic()
        {
            this.IsClassic = !this.IsClassic;
        }
        public ObservableCollection<ObservableCollection<Qwest>> LoadQwest()
        {
            var Qwests90_1 = new ObservableCollection<Qwest>
            {
                new Qwest
                {
                    Text = "Название трека",
                    Answer = "Бухгалтер",
                    Score = 1,
                    Color = "#F5F5F5",
                    ImagePath = "Resources//background90.png",
                    BackgroundPath = "Resources//Музыкальный квиз//90-е//1.1 Бухгалтер.mp3",
                    MusicPath = "Resources//Музыкальный квиз//90-е//1.1 Бухгалтер.mp3"
                },
                new Qwest
                {
                    Text = "Имя исполнителя",
                    Answer = "Алла Пугачева",
                    Score = 2,
                    Color = "#F5F5F5",
                    ImagePath = "Resources//background90.png",
                    BackgroundPath = "Resources//Музыкальный квиз//90-е//2.1 Алла Пугачева.mp3",
                    MusicPath = "Resources//Музыкальный квиз//90-е//2.1 Алла Пугачева.mp3"
                },
                new Qwest
                {
                    Text = "Название трека",
                    Answer = "Люби меня, люби",
                    Score = 1,
                    Color = "#F5F5F5",
                    ImagePath = "Resources//background90.png",
                    BackgroundPath = "Resources//Музыкальный квиз//90-е//3.1 Люби меня, люби.mp3",
                    MusicPath = "Resources//Музыкальный квиз//90-е//3.1 Люби меня, люби.mp3"
                },
                new Qwest
                {
                    Text = "Имя исполнителя",
                    Answer = "Жанна Фриске",
                    Score = 2,
                    Color = "#F5F5F5",
                    ImagePath = "Resources//background90.png",
                    BackgroundPath = "Resources//Музыкальный квиз//90-е//4.1 Жанна Фриске.mp3",
                    MusicPath = "Resources//Музыкальный квиз//90-е//4.1 Жанна Фриске.mp3"
                },
                new Qwest
                {
                    Text = "Название трека",
                    Answer = "Любочка",
                    Score = 1,
                    Color = "#F5F5F5",
                    ImagePath = "Resources//background90.png",
                    BackgroundPath = "Resources//Музыкальный квиз//90-е//5.1 Любочка.mp3",
                    MusicPath = "Resources//Музыкальный квиз//90-е//5.1 Любочка.mp3"
                }
            };
            var Qwests90_2 = new ObservableCollection<Qwest>
        {
            new Qwest
            {
                Text = "Название трека",
                Answer = "Я - это ты",
                Score = 1,
                Color = "#F5F5F5",
                ImagePath = "Resources//background90.png",
                BackgroundPath = "Resources//Музыкальный квиз//90-е//1.2 Я - это ты.mp3",
                MusicPath = "Resources//Музыкальный квиз//90-е//1.2 Я - это ты.mp3"
            },
            new Qwest
            {
                Text = "Имя исполнителя",
                Answer = "Андрей Губин",
                Score = 2,
                Color = "#F5F5F5",
                ImagePath = "Resources//background90.png",
                BackgroundPath = "Resources//Музыкальный квиз//90-е//2.2 Андрей Губин.mp3",
                MusicPath = "Resources//Музыкальный квиз//90-е//2.2 Андрей Губин.mp3"
            },
            new Qwest
            {
                Text = "Название трека",
                Answer = "Маленькая страна",
                Score = 1,
                Color = "#F5F5F5",
                ImagePath = "Resources//background90.png",
                BackgroundPath = "Resources//Музыкальный квиз//90-е//3.2 Маленькая страна.mp3",
                MusicPath = "Resources//Музыкальный квиз//90-е//3.2 Маленькая страна.mp3"
            },
            new Qwest
            {
                Text = "Имя исполнителя",
                Answer = "Юрий Шатунов",
                Score = 2,
                Color = "#F5F5F5",
                ImagePath = "Resources//background90.png",
                BackgroundPath = "Resources//Музыкальный квиз//90-е//4.2 Юрий Шатунов.mp3",
                MusicPath = "Resources//Музыкальный квиз//90-е//4.2 Юрий Шатунов.mp3"
            },
            new Qwest
            {
                Text = "Название трека",
                Answer = "Музыка нас связала",
                Score = 1,
                Color = "#F5F5F5",
                ImagePath = "Resources//background90.png",
                BackgroundPath = "Resources//Музыкальный квиз//90-е//5.2 Музыка нас связала.mp3",
                MusicPath = "Resources//Музыкальный квиз//90-е//5.2 Музыка нас связала.mp3"
            }
        };

            var QwestsClasic_1 = new ObservableCollection<Qwest>
            {
                new Qwest
                {
                    Text = "Название трека",
                    Answer = "Бухгалтер",
                    Score = 1,
                    Color = "#F5F5F5",
                    ImagePath = "Resources//background90.png",
                    BackgroundPath = "Resources//Музыкальный квиз//90-е//1.1 Бухгалтер.mp3",
                    MusicPath = "Resources//Музыкальный квиз//90-е//1.1 Бухгалтер.mp3"
                },
                new Qwest
                {
                    Text = "Имя исполнителя",
                    Answer = "Алла Пугачева",
                    Score = 2,
                    Color = "#F5F5F5",
                    ImagePath = "Resources//background90.png",
                    BackgroundPath = "Resources//Музыкальный квиз//90-е//2.1 Алла Пугачева.mp3",
                    MusicPath = "Resources//Музыкальный квиз//90-е//2.1 Алла Пугачева.mp3"
                },
                new Qwest
                {
                    Text = "Название трека",
                    Answer = "Люби меня, люби",
                    Score = 1,
                    Color = "#F5F5F5",
                    ImagePath = "Resources//background90.png",
                    BackgroundPath = "Resources//Музыкальный квиз//90-е//3.1 Люби меня, люби.mp3",
                    MusicPath = "Resources//Музыкальный квиз//90-е//3.1 Люби меня, люби.mp3"
                },
                new Qwest
                {
                    Text = "Имя исполнителя",
                    Answer = "Жанна Фриске",
                    Score = 2,
                    Color = "#F5F5F5",
                    ImagePath = "Resources//background90.png",
                    BackgroundPath = "Resources//Музыкальный квиз//90-е//4.1 Жанна Фриске.mp3",
                    MusicPath = "Resources//Музыкальный квиз//90-е//4.1 Жанна Фриске.mp3"
                },
                new Qwest
                {
                    Text = "Название трека",
                    Answer = "Любочка",
                    Score = 1,
                    Color = "#F5F5F5",
                    ImagePath = "Resources//background90.png",
                    BackgroundPath = "Resources//Музыкальный квиз//90-е//5.1 Любочка.mp3",
                    MusicPath = "Resources//Музыкальный квиз//90-е//5.1 Любочка.mp3"
                }
            };
            var QwestsClasic_2 = new ObservableCollection<Qwest>
        {
            new Qwest
            {
                Text = "Название трека",
                Answer = "Я - это ты",
                Score = 1,
                Color = "#F5F5F5",
                ImagePath = "Resources//background90.png",
                BackgroundPath = "Resources//Музыкальный квиз//90-е//1.2 Я - это ты.mp3",
                MusicPath = "Resources//Музыкальный квиз//90-е//1.2 Я - это ты.mp3"
            },
            new Qwest
            {
                Text = "Имя исполнителя",
                Answer = "Андрей Губин",
                Score = 2,
                Color = "#F5F5F5",
                ImagePath = "Resources//background90.png",
                BackgroundPath = "Resources//Музыкальный квиз//90-е//2.2 Андрей Губин.mp3",
                MusicPath = "Resources//Музыкальный квиз//90-е//2.2 Андрей Губин.mp3"
            },
            new Qwest
            {
                Text = "Название трека",
                Answer = "Маленькая страна",
                Score = 1,
                Color = "#F5F5F5",
                ImagePath = "Resources//background90.png",
                BackgroundPath = "Resources//Музыкальный квиз//90-е//3.2 Маленькая страна.mp3",
                MusicPath = "Resources//Музыкальный квиз//90-е//3.2 Маленькая страна.mp3"
            },
            new Qwest
            {
                Text = "Имя исполнителя",
                Answer = "Юрий Шатунов",
                Score = 2,
                Color = "#F5F5F5",
                ImagePath = "Resources//background90.png",
                BackgroundPath = "Resources//Музыкальный квиз//90-е//4.2 Юрий Шатунов.mp3",
                MusicPath = "Resources//Музыкальный квиз//90-е//4.2 Юрий Шатунов.mp3"
            },
            new Qwest
            {
                Text = "Название трека",
                Answer = "Музыка нас связала",
                Score = 1,
                Color = "#F5F5F5",
                ImagePath = "Resources//background90.png",
                BackgroundPath = "Resources//Музыкальный квиз//90-е//5.2 Музыка нас связала.mp3",
                MusicPath = "Resources//Музыкальный квиз//90-е//5.2 Музыка нас связала.mp3"
            }
        };

            var QwestsPop_1 = new ObservableCollection<Qwest>
            {
                new Qwest
                {
                    Text = "Название трека",
                    Answer = "Бухгалтер",
                    Score = 1,
                    Color = "#F5F5F5",
                    ImagePath = "Resources//background90.png",
                    BackgroundPath = "Resources//Музыкальный квиз//90-е//1.1 Бухгалтер.mp3",
                    MusicPath = "Resources//Музыкальный квиз//90-е//1.1 Бухгалтер.mp3"
                },
                new Qwest
                {
                    Text = "Имя исполнителя",
                    Answer = "Алла Пугачева",
                    Score = 2,
                    Color = "#F5F5F5",
                    ImagePath = "Resources//background90.png",
                    BackgroundPath = "Resources//Музыкальный квиз//90-е//2.1 Алла Пугачева.mp3",
                    MusicPath = "Resources//Музыкальный квиз//90-е//2.1 Алла Пугачева.mp3"
                },
                new Qwest
                {
                    Text = "Название трека",
                    Answer = "Люби меня, люби",
                    Score = 1,
                    Color = "#F5F5F5",
                    ImagePath = "Resources//background90.png",
                    BackgroundPath = "Resources//Музыкальный квиз//90-е//3.1 Люби меня, люби.mp3",
                    MusicPath = "Resources//Музыкальный квиз//90-е//3.1 Люби меня, люби.mp3"
                },
                new Qwest
                {
                    Text = "Имя исполнителя",
                    Answer = "Жанна Фриске",
                    Score = 2,
                    Color = "#F5F5F5",
                    ImagePath = "Resources//background90.png",
                    BackgroundPath = "Resources//Музыкальный квиз//90-е//4.1 Жанна Фриске.mp3",
                    MusicPath = "Resources//Музыкальный квиз//90-е//4.1 Жанна Фриске.mp3"
                },
                new Qwest
                {
                    Text = "Название трека",
                    Answer = "Любочка",
                    Score = 1,
                    Color = "#F5F5F5",
                    ImagePath = "Resources//background90.png",
                    BackgroundPath = "Resources//Музыкальный квиз//90-е//5.1 Любочка.mp3",
                    MusicPath = "Resources//Музыкальный квиз//90-е//5.1 Любочка.mp3"
                }
            };
            var QwestsPop_2 = new ObservableCollection<Qwest>
        {
            new Qwest
            {
                Text = "Название трека",
                Answer = "Я - это ты",
                Score = 1,
                Color = "#F5F5F5",
                ImagePath = "Resources//background90.png",
                BackgroundPath = "Resources//Музыкальный квиз//90-е//1.2 Я - это ты.mp3",
                MusicPath = "Resources//Музыкальный квиз//90-е//1.2 Я - это ты.mp3"
            },
            new Qwest
            {
                Text = "Имя исполнителя",
                Answer = "Андрей Губин",
                Score = 2,
                Color = "#F5F5F5",
                ImagePath = "Resources//background90.png",
                BackgroundPath = "Resources//Музыкальный квиз//90-е//2.2 Андрей Губин.mp3",
                MusicPath = "Resources//Музыкальный квиз//90-е//2.2 Андрей Губин.mp3"
            },
            new Qwest
            {
                Text = "Название трека",
                Answer = "Маленькая страна",
                Score = 1,
                Color = "#F5F5F5",
                ImagePath = "Resources//background90.png",
                BackgroundPath = "Resources//Музыкальный квиз//90-е//3.2 Маленькая страна.mp3",
                MusicPath = "Resources//Музыкальный квиз//90-е//3.2 Маленькая страна.mp3"
            },
            new Qwest
            {
                Text = "Имя исполнителя",
                Answer = "Юрий Шатунов",
                Score = 2,
                Color = "#F5F5F5",
                ImagePath = "Resources//background90.png",
                BackgroundPath = "Resources//Музыкальный квиз//90-е//4.2 Юрий Шатунов.mp3",
                MusicPath = "Resources//Музыкальный квиз//90-е//4.2 Юрий Шатунов.mp3"
            },
            new Qwest
            {
                Text = "Название трека",
                Answer = "Музыка нас связала",
                Score = 1,
                Color = "#F5F5F5",
                ImagePath = "Resources//background90.png",
                BackgroundPath = "Resources//Музыкальный квиз//90-е//5.2 Музыка нас связала.mp3",
                MusicPath = "Resources//Музыкальный квиз//90-е//5.2 Музыка нас связала.mp3"
            }
        };

            var allQwest_1 = new ObservableCollection<ObservableCollection<Qwest>>
            {
                Qwests90_1,
                QwestsClasic_1,
                QwestsPop_1
            };

            var allQwest_2 = new ObservableCollection<ObservableCollection<Qwest>>
            {
                Qwests90_2,
                QwestsClasic_2,
                QwestsPop_2
            };

            var Qwests_1 = new ObservableCollection<Qwest>();
            var Qwests_2 = new ObservableCollection<Qwest>();

            var random = new Random();
            var checkRule = -1;

            if (Is90) checkRule++;
            if (IsPop) checkRule++;
            if (IsClassic) checkRule++;

            if(checkRule == -1)
            {
                return null;
            }

            int selected;
            for (int i = 0; i < 5; i++)
            {
                selected = random.Next(0, checkRule);

                Qwests_1.Add(allQwest_1[selected][i]);
                Qwests_2.Add(allQwest_2[selected][i]);
            }


            var result = new ObservableCollection<ObservableCollection<Qwest>>
            {
                Qwests_1,
                Qwests_2
            };

            return result;
        }
        public ObservableCollection<Player> LoadPlayers()
        {

            if (Player1.Name == "") Player1.Name = "Игрок 1";
            if (Player2.Name == "") Player2.Name = "Игрок 2";

            return new ObservableCollection<Player> { Player1, Player2 };
        }
    }
}
