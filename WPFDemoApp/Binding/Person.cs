using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFDemoApp.Binding
{
    public class Person: INotifyPropertyChanged
    {
        int _age;
        string _Name;

        public int Age
        {
            get
            {
                return _age;
            }

            set
            {
                _age = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Age"));
            }
        }

        public string Name
        {
            get
            {
                return _Name;
            }

            set
            {
                _Name = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Name"));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged=delegate { };
    }
}
