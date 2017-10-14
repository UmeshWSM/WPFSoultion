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
using System.Windows.Shapes;

namespace WPFDemoApp.Events
{
    /// <summary>
    /// Interaction logic for TunnlingEventWindow.xaml
    /// </summary>
    public partial class TunnlingEventWindow : Window
    {
        public TunnlingEventWindow()
        {
            InitializeComponent();
            Button1.PreviewMouseDown += Button1_PreviewMouseDown;
            InnerST.PreviewMouseDown += InnerST_PreviewMouseDown;
            RootST.PreviewMouseDown += RootST_PreviewMouseDown;
        }

        private void RootST_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("On Root Preview Event!!");
        }

        private void InnerST_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("On Inner Preview Event!!");
        }

        private void Button1_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("On Button Preview Event!!");
        }
    }
}
