using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using QuizMuzic.Models;
using QuizMuzic.Store;
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
            AllQwest_1 = new ObservableCollection<ObservableCollection<Qwest>>();
            AllQwest_2 = new ObservableCollection<ObservableCollection<Qwest>>();
        }


        ObservableCollection<ObservableCollection<Qwest>> AllQwest_1;
        ObservableCollection<ObservableCollection<Qwest>> AllQwest_2;

        [RelayCommand]
        void Chech_90()
        {
            this.Is90 = !this.Is90;

            if (Is90)
            {
                AllQwest_1.Add(QwestStore.Qwests90_1);
                AllQwest_2.Add(QwestStore.Qwests90_2);
            }
            else
            {
                AllQwest_1.Remove(QwestStore.Qwests90_1);
                AllQwest_2.Remove(QwestStore.Qwests90_2);
            }
        }

        [RelayCommand]
        void Chech_Pop()
        {
            this.IsPop = !this.IsPop;


            if (IsPop)
            {
                AllQwest_1.Add(QwestStore.QwestsPop_1);
                AllQwest_2.Add(QwestStore.QwestsPop_2);
            }
            else
            {
                AllQwest_1.Remove(QwestStore.QwestsPop_1);
                AllQwest_2.Remove(QwestStore.QwestsPop_2);
            }
        }
        [RelayCommand]
        void Chech_Classic()
        {
            this.IsClassic = !this.IsClassic;

            if (IsClassic)
            {
                AllQwest_1.Add(QwestStore.QwestsClasic_1);
                AllQwest_2.Add(QwestStore.QwestsClasic_2);
            }
            else
            {
                AllQwest_1.Remove(QwestStore.QwestsClasic_1);
                AllQwest_2.Remove(QwestStore.QwestsClasic_2);
            }
        }
        public ObservableCollection<ObservableCollection<Qwest>> LoadQwest()
        {

            var Qwests_1 = new ObservableCollection<Qwest>();
            var Qwests_2 = new ObservableCollection<Qwest>();

            var random = new Random();

            if(AllQwest_1.Count == 0)
            {
                return null;
            }

            int selected;
            for (int i = 0; i < 5; i++)
            {
                selected = random.Next(0, AllQwest_1.Count);

                Qwests_1.Add(AllQwest_1[selected][i]);
                Qwests_2.Add(AllQwest_2[selected][i]);
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
