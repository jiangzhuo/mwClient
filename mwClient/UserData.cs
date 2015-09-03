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
        private string uid;
        private string token;

        protected string resultString;
        private string host;
        private int port;
        private string playerId;
        private int areaId;

        private string entityId;
        private string nickname;
        private string cityName;
        private int avatar;
        private string headline;
        private int col;
        private int row;
        private int power;
        private int researchPower;
        private int heroPower;
        private int questPower;
        private int constructionPower;
        private int trapPower;
        private int troopPower;
        private int kills;
        private int gold;
        private int charge;
        private int active;
        private int loyalty;
        private int food;
        private int cash;
        private int oil;
        private int ore;
        private int munition;
        private DateTime firstLogin;
        private DateTime lastLogin;
        private int continueLogin;
        private int lastSign;
        private int casinoChips;
        private int casinoLottery;
        private string allianceId;
        private int allianceAreaId;
        private string allianceTag;
        private int allianceRank;
        private string allianceName;
        private int isVIPActive;
        private int vip;
        private int title;
        private int inviteCount;
        private int onlineReward;
        private string hashId;



        public string ResultString
        {
            get { return this.resultString; }
            set
            {
                this.resultString = value;
                OnPropertyChanged("ResultString");
            }
        }

        public string Host
        {
            get
            {
                return host;
            }

            set
            {
                host = value;
            }
        }

        public int Port
        {
            get
            {
                return port;
            }

            set
            {
                port = value;
            }
        }

        public string PlayerId
        {
            get
            {
                return playerId;
            }

            set
            {
                playerId = value;
            }
        }

        public int AreaId
        {
            get
            {
                return areaId;
            }

            set
            {
                areaId = value;
            }
        }

        public string Uid
        {
            get
            {
                return uid;
            }

            set
            {
                uid = value;
            }
        }

        public string Token
        {
            get
            {
                return token;
            }

            set
            {
                token = value;
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
