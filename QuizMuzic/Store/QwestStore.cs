using QuizMuzic.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizMuzic.Store
{
    static class QwestStore
    {
        static public ObservableCollection<Qwest> Qwests90_1 = new ObservableCollection<Qwest>
{
    new Qwest
    {
        Part = "Раздел 90-е",
        Text = "Название трека",
        Answer = "Бухгалтер",
        Score = 1,
        Color = "#F5F5F5",
        ImagePathBackground = Environment.CurrentDirectory + "\\Resources\\background90.png",
        ImagePath = Environment.CurrentDirectory + "\\Resources\\Музыкальный квиз\\90-е\\1.1.jpg",
        MusicPath = "Resources//Музыкальный квиз//90-е//1.1 Бухгалтер.mp3"
    },
    new Qwest
    {
        Part = "Раздел 90-е",
        Text = "Имя исполнителя",
        Answer = "Алла Пугачева",
        Score = 2,
        Color = "#F5F5F5",
        ImagePathBackground = Environment.CurrentDirectory + "\\Resources\\background90.png",
        ImagePath = Environment.CurrentDirectory + "\\Resources\\Музыкальный квиз\\90-е\\2.1.jpg",
        MusicPath = "Resources//Музыкальный квиз//90-е//2.1 Алла Пугачева.mp3"
    },
    new Qwest
    {
        Text = "Название трека",
        Part = "Раздел 90-е",
        Answer = "Люби меня, люби",
        Score = 1,
        Color = "#F5F5F5",
        ImagePathBackground = Environment.CurrentDirectory + "\\Resources\\background90.png",
        ImagePath = Environment.CurrentDirectory + "\\Resources\\Музыкальный квиз\\90-е\\3.1.jpg",
        MusicPath = "Resources//Музыкальный квиз//90-е//3.1 Люби меня, люби.mp3"
    },
    new Qwest
    {
        Text = "Имя исполнителя",
        Part = "Раздел 90-е",
        Answer = "Жанна Фриске",
        Score = 2,
        Color = "#F5F5F5",
        ImagePathBackground = Environment.CurrentDirectory + "\\Resources\\background90.png",
        ImagePath = Environment.CurrentDirectory + "\\Resources\\Музыкальный квиз\\90-е\\4.1.jpg",
        MusicPath = "Resources//Музыкальный квиз//90-е//4.1 Жанна Фриске.mp3"
    },
    new Qwest
    {
        Text = "Название трека",
        Part = "Раздел 90-е",
        Answer = "Любочка",
        Score = 1,
        Color = "#F5F5F5",
        ImagePathBackground = Environment.CurrentDirectory + "\\Resources\\background90.png",
        ImagePath = Environment.CurrentDirectory + "\\Resources\\Музыкальный квиз\\90-е\\5.1.jpg",
        MusicPath = "Resources//Музыкальный квиз//90-е//5.1 Любочка.mp3"
    }
};
        static public ObservableCollection<Qwest> Qwests90_2 = new ObservableCollection<Qwest>
{
    new Qwest
    {
        Text = "Название трека",
        Part = "Раздел 90-е",
        Answer = "Я - это ты",
        Score = 1,
        Color = "#F5F5F5",
        ImagePathBackground = Environment.CurrentDirectory + "\\Resources\\background90.png",
        ImagePath = Environment.CurrentDirectory + "\\Resources\\Музыкальный квиз\\90-е\\1.2.jpg",
        MusicPath = "Resources//Музыкальный квиз//90-е//1.2 Я - это ты.mp3"
    },
    new Qwest
    {
        Text = "Имя исполнителя",
        Part = "Раздел 90-е",
        Answer = "Андрей Губин",
        Score = 2,
        Color = "#F5F5F5",
        ImagePathBackground = Environment.CurrentDirectory + "\\Resources\\background90.png",
        ImagePath = Environment.CurrentDirectory + "\\Resources\\Музыкальный квиз\\90-е\\2.2.jpg",
        MusicPath = "Resources//Музыкальный квиз//90-е//2.2 Андрей Губин.mp3"
    },
    new Qwest
    {
        Text = "Название трека",
        Part = "Раздел 90-е",
        Answer = "Маленькая страна",
        Score = 1,
        Color = "#F5F5F5",
        ImagePathBackground = Environment.CurrentDirectory + "\\Resources\\background90.png",
        ImagePath = Environment.CurrentDirectory + "\\Resources\\Музыкальный квиз\\90-е\\3.2.jpg",
        MusicPath = "Resources//Музыкальный квиз//90-е//3.2 Маленькая страна.mp3"
    },
    new Qwest
    {
        Text = "Имя исполнителя",
        Part = "Раздел 90-е",
        Answer = "Юрий Шатунов",
        Score = 2,
        Color = "#F5F5F5",
        ImagePathBackground = Environment.CurrentDirectory + "\\Resources\\background90.png",
        ImagePath = Environment.CurrentDirectory + "\\Resources\\Музыкальный квиз\\90-е\\4.2.jpg",
        MusicPath = "Resources//Музыкальный квиз//90-е//4.2 Юрий Шатунов.mp3"
    },
    new Qwest
    {
        Text = "Название трека",
        Part = "Раздел 90-е",
        Answer = "Музыка нас связала",
        Score = 1,
        Color = "#F5F5F5",
        ImagePathBackground = Environment.CurrentDirectory + "\\Resources\\background90.png",
        ImagePath = Environment.CurrentDirectory + "\\Resources\\Музыкальный квиз\\90-е\\5.2.jpg",
        MusicPath = "Resources//Музыкальный квиз//90-е//5.2 Музыка нас связала.mp3"
    }
};


        static public ObservableCollection<Qwest> QwestsClasic_1 = new ObservableCollection<Qwest>
{
    new Qwest
    {
        Text = "Название трека",
        Part = "Раздел Классической музыки",
        Answer = "К Элизе",
        Score = 1,
        Color = "#D1CFEE",
        ImagePathBackground = Environment.CurrentDirectory + "\\Resources\\backgroundclassic.png",
        ImagePath = Environment.CurrentDirectory + "\\Resources\\Музыкальный квиз\\90-е\\1.1.jpg",
        MusicPath = "Resources//Музыкальный квиз//90-е//1.1 К Элизе.mp3"
    },
    new Qwest
    {
        Text = "Имя исполнителя",
        Part = "Раздел Классической музыки",
        Answer = "Вивальди",
        Score = 2,
        Color = "#F5F5F5",
        ImagePathBackground = Environment.CurrentDirectory + "\\Resources\\backgroundclassic.png",
        ImagePath = Environment.CurrentDirectory + "\\Resources\\Музыкальный квиз\\90-е\\2.1.jpg",
        MusicPath = "Resources//Музыкальный квиз//90-е//2.1 Вивальди.mp3"
    },
    new Qwest
    {
        Text = "Название трека",
        Part = "Раздел Классической музыки",
        Answer = "Утро",
        Score = 1,
        Color = "#F5F5F5",
        ImagePathBackground = Environment.CurrentDirectory + "\\Resources\\backgroundclassic.png",
        ImagePath = Environment.CurrentDirectory + "\\Resources\\Музыкальный квиз\\90-е\\3.1.jpg",
        MusicPath = "Resources//Музыкальный квиз//90-е//3.1 Утро.mp3"
    },
    new Qwest
    {
        Text = "Имя исполнителя",
        Part = "Раздел Классической музыки",
        Answer = "Моцарт", // Исправлено с "Жанна Фриске" на "Моцарт"
        Score = 2,
        Color = "#F5F5F5",
        ImagePathBackground = Environment.CurrentDirectory + "\\Resources\\backgroundclassic.png",
        ImagePath = Environment.CurrentDirectory + "\\Resources\\Музыкальный квиз\\90-е\\4.1.jpg",
        MusicPath = "Resources//Музыкальный квиз//90-е//4.1 Моцарт.mp3"
    },
    new Qwest
    {
        Text = "Название трека",
        Part = "Раздел Классической музыки",
        Answer = "Шутка", // Исправлено с "Любочка" на "Шутка"
        Score = 1,
        Color = "#F5F5F5",
        ImagePathBackground = Environment.CurrentDirectory + "\\Resources\\backgroundclassic.png",
        ImagePath = Environment.CurrentDirectory + "\\Resources\\Музыкальный квиз\\90-е\\5.1.jpg",
        MusicPath = "Resources//Музыкальный квиз//90-е//5.1 Шутка.mp3"
    }
};
        static public ObservableCollection<Qwest> QwestsClasic_2 = new ObservableCollection<Qwest>
{
    new Qwest
    {
        Text = "Название трека",
        Part = "Раздел Классической музыки",
        Answer = "Я - это ты",
        Score = 1,
        Color = "#F5F5F5",
        ImagePathBackground = Environment.CurrentDirectory + "\\Resources\\backgroundclassic.png",
        ImagePath = Environment.CurrentDirectory + "\\Resources\\Музыкальный квиз\\90-е\\1.2.jpg", // Добавлено расширение .jpg
        MusicPath = "Resources//Музыкальный квиз//90-е//1.2 Я - это ты.mp3"
    },
    new Qwest
    {
        Text = "Имя исполнителя",
        Part = "Раздел Классической музыки",
        Answer = "Андрей Губин",
        Score = 2,
        Color = "#F5F5F5",
        ImagePathBackground = Environment.CurrentDirectory + "\\Resources\\backgroundclassic.png",
        ImagePath = Environment.CurrentDirectory + "\\Resources\\Музыкальный квиз\\90-е\\2.2.jpg", // Добавлено расширение .jpg
        MusicPath = "Resources//Музыкальный квиз//90-е//2.2 Андрей Губин.mp3"
    },
    new Qwest
    {
        Text = "Название трека",
        Part = "Раздел Классической музыки",
        Answer = "Маленькая страна",
        Score = 1,
        Color = "#F5F5F5",
        ImagePathBackground = Environment.CurrentDirectory + "\\Resources\\backgroundclassic.png",
        ImagePath = Environment.CurrentDirectory + "\\Resources\\Музыкальный квиз\\90-е\\3.2.jpg", // Добавлено расширение .jpg
        MusicPath = "Resources//Музыкальный квиз//90-е//3.2 Маленькая страна.mp3"
    },
    new Qwest
    {
        Text = "Имя исполнителя",
        Part = "Раздел Классической музыки",
        Answer = "Юрий Шатунов",
        Score = 2,
        Color = "#F5F5F5",
        ImagePathBackground = Environment.CurrentDirectory + "\\Resources\\backgroundclassic.png",
        ImagePath = Environment.CurrentDirectory + "\\Resources\\Музыкальный квиз\\90-е\\4.2.jpg", // Добавлено расширение .jpg
        MusicPath = "Resources//Музыкальный квиз//90-е//4.2 Юрий Шатунов.mp3"
    },
    new Qwest
    {
        Text = "Название трека",
        Part = "Раздел Классической музыки",
        Answer = "Музыка нас связала",
        Score = 1,
        Color = "#F5F5F5",
        ImagePathBackground = Environment.CurrentDirectory + "\\Resources\\backgroundclassic.png",
        ImagePath = Environment.CurrentDirectory + "\\Resources\\Музыкальный квиз\\90-е\\5.2.jpg", // Добавлено расширение .jpg
        MusicPath = "Resources//Музыкальный квиз//90-е//5.2 Музыка нас связала.mp3"
    }
};


        static public ObservableCollection<Qwest> QwestsPop_1 = new ObservableCollection<Qwest>
{
    new Qwest
    {
        Text = "Название трека",
        Part = "Раздел поп-музыки",
        Answer = "Бухгалтер",
        Score = 1,
        Color = "#F5F5F5",
        ImagePathBackground = Environment.CurrentDirectory + "\\Resources\\backgroundpop.png",
        ImagePath = Environment.CurrentDirectory + "\\Resources\\Музыкальный квиз\\90-е\\1.1.jpg", // Добавлено расширение .jpg
        MusicPath = "Resources//Музыкальный квиз//90-е//1.1 Бухгалтер.mp3"
    },
    new Qwest
    {
        Text = "Имя исполнителя",
        Part = "Раздел поп-музыки",
        Answer = "Алла Пугачева",
        Score = 2,
        Color = "#F5F5F5",
        ImagePathBackground = Environment.CurrentDirectory + "\\Resources\\backgroundpop.png",
        ImagePath = Environment.CurrentDirectory + "\\Resources\\Музыкальный квиз\\90-е\\2.1.jpg", // Добавлено расширение .jpg
        MusicPath = "Resources//Музыкальный квиз//90-е//2.1 Алла Пугачева.mp3"
    },
    new Qwest
    {
        Text = "Название трека",
        Part = "Раздел поп-музыки",
        Answer = "Люби меня, люби",
        Score = 1,
        Color = "#F5F5F5",
        ImagePathBackground = Environment.CurrentDirectory + "\\Resources\\backgroundpop.png",
        ImagePath = Environment.CurrentDirectory + "\\Resources\\Музыкальный квиз\\90-е\\3.1.jpg", // Добавлено расширение .jpg
        MusicPath = "Resources//Музыкальный квиз//90-е//3.1 Люби меня, люби.mp3"
    },
    new Qwest
    {
        Text = "Имя исполнителя",
        Part = "Раздел поп-музыки",
        Answer = "Жанна Фриске",
        Score = 2,
        Color = "#F5F5F5",
        ImagePathBackground = Environment.CurrentDirectory + "\\Resources\\backgroundpop.png",
        ImagePath = Environment.CurrentDirectory + "\\Resources\\Музыкальный квиз\\90-е\\4.1.jpg", // Добавлено расширение .jpg
        MusicPath = "Resources//Музыкальный квиз//90-е//4.1 Жанна Фриске.mp3"
    },
    new Qwest
    {
        Text = "Название трека",
        Part = "Раздел поп-музыки",
        Answer = "Любочка",
        Score = 1,
        Color = "#F5F5F5",
        ImagePathBackground = Environment.CurrentDirectory + "\\Resources\\backgroundpop.png",
        ImagePath = Environment.CurrentDirectory + "\\Resources\\Музыкальный квиз\\90-е\\5.1.jpg", // Добавлено расширение .jpg
        MusicPath = "Resources//Музыкальный квиз//90-е//5.1 Любочка.mp3"
    }
};
        static public ObservableCollection<Qwest> QwestsPop_2 = new ObservableCollection<Qwest>
{
    new Qwest
    {
        Text = "Название трека",
        Part = "Раздел поп-музыки",
        Answer = "Я - это ты",
        Score = 1,
        Color = "#F5F5F5",
        ImagePathBackground = Environment.CurrentDirectory + "\\Resources\\backgroundpop.png",
        ImagePath = Environment.CurrentDirectory + "\\Resources\\Музыкальный квиз\\90-е\\1.2.jpg", // Добавлено расширение .jpg
        MusicPath = "Resources//Музыкальный квиз//90-е//1.2 Я - это ты.mp3"
    },
    new Qwest
    {
        Text = "Имя исполнителя",
        Part = "Раздел поп-музыки",
        Answer = "Андрей Губин",
        Score = 2,
        Color = "#F5F5F5",
        ImagePathBackground = Environment.CurrentDirectory + "\\Resources\\backgroundpop.png",
        ImagePath = Environment.CurrentDirectory + "\\Resources\\Музыкальный квиз\\90-е\\2.2.jpg", // Добавлено расширение .jpg
        MusicPath = "Resources//Музыкальный квиз//90-е//2.2 Андрей Губин.mp3"
    },
    new Qwest
    {
        Text = "Название трека",
        Part = "Раздел поп-музыки",
        Answer = "Маленькая страна",
        Score = 1,
        Color = "#F5F5F5",
        ImagePathBackground = Environment.CurrentDirectory + "\\Resources\\backgroundpop.png",
        ImagePath = Environment.CurrentDirectory + "\\Resources\\Музыкальный квиз\\90-е\\3.2.jpg", // Добавлено расширение .jpg
        MusicPath = "Resources//Музыкальный квиз//90-е//3.2 Маленькая страна.mp3"
    },
    new Qwest
    {
        Text = "Имя исполнителя",
        Part = "Раздел поп-музыки",
        Answer = "Юрий Шатунов",
        Score = 2,
        Color = "#F5F5F5",
        ImagePathBackground = Environment.CurrentDirectory + "\\Resources\\backgroundpop.png",
        ImagePath = Environment.CurrentDirectory + "\\Resources\\Музыкальный квиз\\90-е\\4.2.jpg", // Добавлено расширение .jpg
        MusicPath = "Resources//Музыкальный квиз//90-е//4.2 Юрий Шатунов.mp3"
    },
    new Qwest
    {
        Text = "Название трека",
        Part = "Раздел поп-музыки",
        Answer = "Музыка нас связала",
        Score = 1,
        Color = "#F5F5F5",
        ImagePathBackground = Environment.CurrentDirectory + "\\Resources\\backgroundpop.png",
        ImagePath = Environment.CurrentDirectory + "\\Resources\\Музыкальный квиз\\90-е\\5.2.jpg", // Добавлено расширение .jpg
        MusicPath = "Resources//Музыкальный квиз//90-е//5.2 Музыка нас связала.mp3"
    }
};
    }
}
