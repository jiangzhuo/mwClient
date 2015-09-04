using Pomelo.DotNetClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
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
        private Int64 port;
        private string playerId;
        private Int64 areaId;

        private string entityId;
        private string nickname;
        private string cityName;
        private Int64 avatar;
        private string headline;
        private Int64 col;
        private Int64 row;
        private Int64 power;
        private Int64 researchPower;
        private Int64 heroPower;
        private Int64 questPower;
        private Int64 constructionPower;
        private Int64 trapPower;
        private Int64 troopPower;
        private Int64 kills;
        private Int64 gold;
        private Int64 charge;
        private Int64 active;
        private Int64 loyalty;
        private Int64 food;
        private Int64 cash;
        private Int64 oil;
        private Int64 ore;
        private Int64 munition;
        private Int64 firstLogin;
        private Int64 lastLogin;
        private Int64 continueLogin;
        private Int64 lastSign;
        private Int64 casinoChips;
        private Int64 casinoLottery;
        private string allianceId;
        private Int64 allianceAreaId;
        private string allianceTag;
        private Int64 allianceRank;
        private string allianceName;
        private Int64 isVIPActive;
        private Int64 vip;
        private Int64 title;
        private Int64 inviteCount;
        private Int64 onlineReward;
        private string hashId;
        private Int64 timeZone;



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

        public Int64 Port
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

        public Int64 AreaId
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

        public Int64 TimeZone
        {
            get
            {
                return timeZone;
            }

            set
            {
                timeZone = value;
            }
        }

        public string EntityId
        {
            get
            {
                return entityId;
            }

            set
            {
                entityId = value;
            }
        }

        public string Nickname
        {
            get
            {
                return nickname;
            }

            set
            {
                nickname = value;
            }
        }

        public string CityName
        {
            get
            {
                return cityName;
            }

            set
            {
                cityName = value;
            }
        }

        public Int64 Avatar
        {
            get
            {
                return avatar;
            }

            set
            {
                avatar = value;
            }
        }

        public string Headline
        {
            get
            {
                return headline;
            }

            set
            {
                headline = value;
            }
        }

        public Int64 Col
        {
            get
            {
                return col;
            }

            set
            {
                col = value;
            }
        }

        public Int64 Row
        {
            get
            {
                return row;
            }

            set
            {
                row = value;
            }
        }

        public Int64 Power
        {
            get
            {
                return power;
            }

            set
            {
                power = value;
            }
        }

        public Int64 ResearchPower
        {
            get
            {
                return researchPower;
            }

            set
            {
                researchPower = value;
            }
        }

        public Int64 QuestPower
        {
            get
            {
                return questPower;
            }

            set
            {
                questPower = value;
            }
        }

        public Int64 ConstructionPower
        {
            get
            {
                return constructionPower;
            }

            set
            {
                constructionPower = value;
            }
        }

        public Int64 TrapPower
        {
            get
            {
                return trapPower;
            }

            set
            {
                trapPower = value;
            }
        }

        public Int64 TroopPower
        {
            get
            {
                return troopPower;
            }

            set
            {
                troopPower = value;
            }
        }

        public Int64 Kills
        {
            get
            {
                return kills;
            }

            set
            {
                kills = value;
            }
        }

        public Int64 Gold
        {
            get
            {
                return gold;
            }

            set
            {
                gold = value;
            }
        }

        public Int64 Charge
        {
            get
            {
                return charge;
            }

            set
            {
                charge = value;
            }
        }

        public Int64 Active
        {
            get
            {
                return active;
            }

            set
            {
                active = value;
            }
        }

        public Int64 Loyalty
        {
            get
            {
                return loyalty;
            }

            set
            {
                loyalty = value;
            }
        }

        public Int64 Food
        {
            get
            {
                return food;
            }

            set
            {
                food = value;
            }
        }

        public Int64 Cash
        {
            get
            {
                return cash;
            }

            set
            {
                cash = value;
            }
        }

        public Int64 Oil
        {
            get
            {
                return oil;
            }

            set
            {
                oil = value;
            }
        }

        public Int64 Ore
        {
            get
            {
                return ore;
            }

            set
            {
                ore = value;
            }
        }

        public Int64 Munition
        {
            get
            {
                return munition;
            }

            set
            {
                munition = value;
            }
        }

        public Int64 FirstLogin
        {
            get
            {
                return firstLogin;
            }

            set
            {
                firstLogin = value;
            }
        }

        public Int64 LastLogin
        {
            get
            {
                return lastLogin;
            }

            set
            {
                lastLogin = value;
            }
        }

        public Int64 ContinueLogin
        {
            get
            {
                return continueLogin;
            }

            set
            {
                continueLogin = value;
            }
        }

        public Int64 LastSign
        {
            get
            {
                return lastSign;
            }

            set
            {
                lastSign = value;
            }
        }

        public Int64 CasinoChips
        {
            get
            {
                return casinoChips;
            }

            set
            {
                casinoChips = value;
            }
        }

        public Int64 CasinoLottery
        {
            get
            {
                return casinoLottery;
            }

            set
            {
                casinoLottery = value;
            }
        }

        public string AllianceId
        {
            get
            {
                return allianceId;
            }

            set
            {
                allianceId = value;
            }
        }

        public Int64 AllianceAreaId
        {
            get
            {
                return allianceAreaId;
            }

            set
            {
                allianceAreaId = value;
            }
        }

        public string AllianceTag
        {
            get
            {
                return allianceTag;
            }

            set
            {
                allianceTag = value;
            }
        }

        public Int64 AllianceRank
        {
            get
            {
                return allianceRank;
            }

            set
            {
                allianceRank = value;
            }
        }

        public string AllianceName
        {
            get
            {
                return allianceName;
            }

            set
            {
                allianceName = value;
            }
        }

        public Int64 IsVIPActive
        {
            get
            {
                return isVIPActive;
            }

            set
            {
                isVIPActive = value;
            }
        }

        public Int64 Vip
        {
            get
            {
                return vip;
            }

            set
            {
                vip = value;
            }
        }

        public Int64 Title
        {
            get
            {
                return title;
            }

            set
            {
                title = value;
            }
        }

        public Int64 InviteCount
        {
            get
            {
                return inviteCount;
            }

            set
            {
                inviteCount = value;
            }
        }

        public Int64 OnlineReward
        {
            get
            {
                return onlineReward;
            }

            set
            {
                onlineReward = value;
            }
        }

        public string HashId
        {
            get
            {
                return hashId;
            }

            set
            {
                hashId = value;
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

        public void ProcessenterAreaResult(dynamic obj)
        {
            foreach(var kvPair in obj.character)
            {
                var type = this.GetType();
                char[] a = kvPair.Key.ToCharArray();
                a[0] = char.ToUpper(a[0]);
                var upperKey = new string(a);

                if (type.GetProperty(upperKey)!= null)
                {
                    
                    PropertyInfo prop = this.GetType().GetProperty(upperKey, BindingFlags.Public | BindingFlags.Instance);
                    if (null != prop && prop.CanWrite)
                    {
                        prop.SetValue(this, kvPair.Value, null);
                    }
                }
            }
            this.TimeZone = obj.timeZone;
        }
    }
}
