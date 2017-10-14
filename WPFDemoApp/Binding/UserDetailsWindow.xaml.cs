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
using System.Collections.ObjectModel;

namespace WPFDemoApp.Binding
{
    /// <summary>
    /// Interaction logic for UserDetailsWindow.xaml
    /// </summary>
    public partial class UserDetailsWindow : Window
    {

        ObservableCollection<UserInfo> lstUserInfo = new ObservableCollection<UserInfo>();
        public UserDetailsWindow()
        {
            InitializeComponent();
            this.Loaded += UserDetailsWindow_Loaded;
            btnAdd.Click += BtnAdd_Click;
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            UserInfo _User = new UserInfo { UserName = txtUserName.Text, Age = Convert.ToInt32(txtAge.Text), FavColor = txtFevColor.Text };
            lstUserInfo.Add(_User);
        }

        private void UserDetailsWindow_Loaded(object sender, RoutedEventArgs e)
        {
            this.DataContext = lstUserInfo;
        }

        private void lstUserDetails_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UserInfo _User1 = new UserInfo { };
            
        }
    }
}
