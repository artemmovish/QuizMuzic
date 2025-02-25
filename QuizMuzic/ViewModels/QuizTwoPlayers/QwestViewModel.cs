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
    public partial class QwestViewModel : ObservableObject
    {
        [ObservableProperty]
        string answer = "";

        public ObservableCollection<Qwest> qwests_1;
        public ObservableCollection<Qwest> qwests_2;
        public ObservableCollection<Player> Players;

        [ObservableProperty]
        Qwest selectedQwest;
        [ObservableProperty]
        Player selectedPlaer;

        int counterQwest = 1;
        int counterPlayer = 0;
        public QwestViewModel()
        {

        }
        public QwestViewModel(ObservableCollection<Player> players, ObservableCollection<ObservableCollection<Qwest>> qwests)
        {

        }
    }
}
