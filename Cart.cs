using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClockAlarmStore
{
    class Cart
    {
        public List<ShopItem> Items = new List<ShopItem>();

        public void AddItem(int id)
        {
            ShopItem newItem = new ShopItem(id);
            if(Items.Contains(newItem))
            {
                foreach (var shopItem in Items)
                {
                    if(shopItem.Equals(newItem))
                    {
                        shopItem.AmountItem++;
                    }
                    else
                    {
                        newItem.AmountItem = 1;
                        Items.Add(newItem);
                    }
                }
            }
     
           
        }
        public void RemoveItem(int id)
        {
            ShopItem shopItemRemove = new ShopItem(id);
            Items.Remove(shopItemRemove);

        }
    }
}
