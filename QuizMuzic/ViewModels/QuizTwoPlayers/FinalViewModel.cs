using CommunityToolkit.Mvvm.ComponentModel;
using QuizMuzic.Models;

namespace QuizMuzic.ViewModels.QuizTwoPlayers
{
    public partial class FinalViewModel : ObservableObject
    {
        

        [ObservableProperty]
        Player player1;
        [ObservableProperty]
        Player player2;
        [ObservableProperty]
        string imgPath;

        public FinalViewModel()
        {

        }

        public FinalViewModel(Player player1, Player player2, string img)
        {
            if (player1.Score > player2.Score)
            {
                Player1 = player1;
                Player2 = player2;
            }
            else
            {
                Player1 = player2;
                Player2 = player1;
            }
            imgPath = img;
        }


    }
}
