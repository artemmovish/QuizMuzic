using CommunityToolkit.Mvvm.ComponentModel;
using QuizMuzic.Models;
using System.Windows;

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
            else if(player1.Score == player2.Score)
            {
                player1.Name = player1.Name + " и " + player2.Name;
                Player1 = player1;
                Player2 = player1;
                MessageBox.Show("Ничья");
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
