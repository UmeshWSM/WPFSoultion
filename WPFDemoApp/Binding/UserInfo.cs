using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFDemoApp.Binding
{
    public class UserInfo : INotifyPropertyChanged
    {
        string _UserName;
        int _Age;
        string _FavColor;

        public string UserName
        {
            get
            {
                return _UserName;
            }

            set
            {
                _UserName = value;
                PropertyChanged(this, new PropertyChangedEventArgs("UserName"));
            }
        }

        public int Age
        {
            get
            {
                return _Age;
            }

            set
            {
                _Age = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Age"));
            }
        }

        public string FavColor
        {
            get
            {
                return _FavColor;
            }

            set
            {
                _FavColor = value;
                PropertyChanged(this, new PropertyChangedEventArgs("FavColor"));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged=delegate { };
    }
}
