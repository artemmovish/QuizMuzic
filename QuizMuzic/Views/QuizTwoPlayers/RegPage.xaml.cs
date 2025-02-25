using QuizMuzic.ViewModels.QuizTwoPlayers;
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

namespace QuizMuzic.Views.QuizTwoPlayers
{
    /// <summary>
    /// Логика взаимодействия для RegPage.xaml
    /// </summary>
    public partial class RegPage : Page
    {
        public RegPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var vm = DataContext as RegViewModel;

            var qwests = vm.LoadQwest();

            if (qwests == null)
            {
                return;
            }

            var vm_2 = new QwestViewModel(vm.LoadPlayers(), qwests);

            var page = new QwestPage();
            page.DataContext = vm_2;
            NavigationService.Navigate(page);
        }
    }
}
