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

namespace WPFDemoApp.Styles
{
    /// <summary>
    /// Interaction logic for EllipseButtonWindow.xaml
    /// </summary>
    public partial class EllipseButtonWindow : Window
    {
        public EllipseButtonWindow()
        {
            InitializeComponent();
        }

        private void ClieckMeButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Clieck me, Clicked!!");
        }
    }
}
