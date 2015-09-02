using Pomelo.DotNetClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mwClient
{
    public class UserData : INotifyPropertyChanged
    {
        public PomeloClient client = null;
        public string uid;
        public string token;


        protected string resultString = "111111111";
        public string host;
        public int port;
        public string playerId;
        public string areaId;

        public string ResultString
        {
            get { return this.resultString; }
            set
            {
                this.resultString = value;
                OnPropertyChanged("ResultString");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
        private void NotifyPropertyChanged(String propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
