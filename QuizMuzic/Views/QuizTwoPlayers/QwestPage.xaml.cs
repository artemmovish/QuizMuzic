﻿using System;
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
    /// Логика взаимодействия для QwestPage.xaml
    /// </summary>
    public partial class QwestPage : Page
    {
        public QwestPage()
        {
            InitializeComponent();
        }

        public void NavigateToFinal(Page page)
        {
            NavigationService.Navigate(page);
        }
    }
}
