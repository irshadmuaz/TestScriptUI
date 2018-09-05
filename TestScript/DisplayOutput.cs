using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestScript
{
    public class DisplayOutput:INotifyPropertyChanged
    {
        private string _value;
        private string _board;
        public string value
        {
            get { return _value; }
            set
            {
                if(_value != value )
                {
                    _value = value;
                    RaisePropertyChanged("value");
                }
            }
        }
        public string board 
        {
            get { return _board; }
            set
            {
                if (_board != value)
                {
                    _board = value;
                    RaisePropertyChanged("board");
                }
            }
        }
        public DisplayOutput()
        {
            value = "";
            _board = "";
        }
        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertyChanged(string propertyName)
        {
            
            PropertyChangedEventHandler handler = PropertyChanged;
            if(handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
