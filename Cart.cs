using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClockAlarmStore
{
    class Cart
    {
        public List<ShopItem> Items = new List<ShopItem>(); // lista produktow
                                                            // 
        /// <summary>
        /// tworzymy nowy obiekt newItem, 
        /// </summary>
        /// <param name="id"></param>
        public void AddItem(int id)
        {
            ShopItem newItem = new ShopItem(id);
            if(Items.Contains(newItem))
            {
                foreach (ShopItem shopItem in Items)
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
        public void SetItemAmount(int id, int amount)
        {
            if (amount==0)
            {
                RemoveItem(id);
            }
            CartItem updateItem = new CartItem();
            foreach (CartItem item in Items)
            {
                if (item.Equals(updateItem))
                {
                    item.Amount=amount;
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

