using System;
using System.Data.Common;
using GameShop.Enums;

namespace GameShop
{
    public class MarketItemData
    {
        private DateTime _lastBuyingTime;

        private bool _isSold;

        public bool IsSold
        {
            get { return _isSold; }
            private set { _isSold = value; }
        }

        private bool _isTimeless;

        public bool IsTimeLess
        {
            get { return _isTimeless; }
            private set { _isTimeless = value; }
        }

        private TimeSpan _time;

        public TimeSpan Time
        {
            get { return _isTimeless ? TimeSpan.MaxValue : _time; }
            private set { _time = _isTimeless ? TimeSpan.MaxValue : value; }
        }

        public bool Expired => (_lastBuyingTime - DateTime.Now) >= _time;

        public MarketItemData(bool isSold = false, bool timeLess = true, TimeSpan time = default(TimeSpan))
        {
            IsSold = isSold;
            IsTimeLess = timeLess;
            Time = time == default(TimeSpan) ? TimeSpan.MaxValue : time;
        }


        public void Buy()
        {
            IsSold = true;
        }
    }
}