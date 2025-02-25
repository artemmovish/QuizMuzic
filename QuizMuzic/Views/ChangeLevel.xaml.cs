using QuizMuzic.ViewModels;
using QuizMuzic.Views.QuizTwoPlayers;
using System;
using System.Collections.Generic;
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

namespace QuizMuzic.Views
{
    /// <summary>
    /// Логика взаимодействия для ChangeLevel.xaml
    /// </summary>
    public partial class ChangeLevel : Page
    {
        public ChangeLevel()
        {
            InitializeComponent();
            DataContext = new ChangeLevelViewModel();
        }

        private void ToQuiz_Click(object sender, RoutedEventArgs e)
        {
            var page = new RegPage();
            NavigationService.Navigate(page);
        }

        private void ToTest_Click(object sender, RoutedEventArgs e)
        {
            //var page = new RegPage();
            //NavigationService.Navigate(page);
        }
    }
}
