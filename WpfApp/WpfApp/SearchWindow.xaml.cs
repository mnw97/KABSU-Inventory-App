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
using System.Windows.Shapes;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for SearchWindow.xaml
    /// </summary>
    public partial class SearchWindow : Window
    {
        SearchWindowResults windowResults;
        public SearchWindow()
        {
            InitializeComponent();
        }

        private void UxSearchTerm1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void UxSearch_Click(object sender, RoutedEventArgs e)
        {
            windowResults = new SearchWindowResults();
            windowResults.Show();
            this.Close();
        }
    }
}
