using System.Data.Common;
using System.Runtime.InteropServices;
using GameShop.Enums;

namespace GameShop
{
    public abstract class BaseItem
    {
        public double Cost { get; set; }
        public string Name { get; }

        public bool IsActive => MarketItemData.IsSold;

        public MarketItemData MarketItemData { get; }
        
        public BaseItem(MarketItemData data, string name)
        {
            MarketItemData = data;
            Name = name;
        }

        public virtual bool Buy(double value, Currency currency)
        {
            if (value >= Cost)
            {
                MarketItemData.Buy();
                return true;
            }

            return false;
        }
        
    }
}