using CommunityToolkit.Mvvm.ComponentModel;
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
        Player player1 = new Player();
        [ObservableProperty]
        Player player2 = new Player();

        [ObservableProperty]
        bool is90 = false;
        [ObservableProperty]
        bool isClassic = false;
        [ObservableProperty]
        bool isPop = false;

        public RegViewModel()
        {
            


        }

        
        public void LoadQwest()
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

            if (is90 && isClassic && isPop)
            {

            }
        }
    }
}
