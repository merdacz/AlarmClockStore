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
        public int Promotion
        {
            get
            {
                return price;

            }
            set
            {
                Price = Price - (Price / 10);
            }
        }
      
       // private int promotion;
        private int id;
        private int price;
        private int amountItem;

        public ShopItem(int nId)
        {
            this.Id = nId;
            this.Price = 100;
            this.Promotion;
            this.amountItem++;
            
        }

    }
}
