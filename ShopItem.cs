using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClockAlarmStore
{
    class ShopItem
    {
        /// <summary>
        /// Oddzielenie "logika" przedmiotu, od sklepu
        /// </summary>
        //public int Id
        //{
        //    get { return id; }
        //    set {id=value }
        //}
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                
                
                id = value;
            }  
        }
        public int Price
        {
            get { return price; }
            set { price = value; }
        }
          
        public int AmountItem
        {
            get { return amountItem; }
            set { amountItem = value; }
        }
        
        private int id;
        private int price;
        private int amountItem;

        public ShopItem(int nId)
        {
            this.Id = nId;

        }

    }
}
