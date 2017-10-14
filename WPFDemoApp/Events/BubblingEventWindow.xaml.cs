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
    /// Interaction logic for BubblingEventWindow.xaml
    /// </summary>
    public partial class BubblingEventWindow : Window
    {
        public BubblingEventWindow()
        {
            InitializeComponent();
            CheckBox1.KeyDown += CheckBox1_KeyDown;
            Button1.KeyDown += Button1_KeyDown;
            InnerST.KeyDown += InnerST_KeyDown;
            RootST.KeyDown += RootST_KeyDown;
            CheckBox1.PreviewKeyDown += CheckBox1_PreviewKeyDown;
            RootST.PreviewKeyDown += RootST_PreviewKeyDown;
        }

        private void RootST_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show("Root ST Preview");
        }

        private void CheckBox1_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show("Check Box Preview");
        }

        private void RootST_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show("Root ST KeyDow");
        }

        private void InnerST_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show("Inner ST KeyDow");
        }

        private void Button1_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show("Button KeyDown!!");
        }

        private void CheckBox1_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show("Check Box KeyDown!!");
        }
    }
}
