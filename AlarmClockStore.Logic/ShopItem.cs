using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlarmClockStore.Logic
{
    public class ShopItem
    {
        
        public decimal Price { get; set; }

        public string NameProduct { get; set; }

        public int Amount { get; set; }
        public ShopItem(string nameProduct,decimal price,int amountProduct)
        {
           
            this.NameProduct = nameProduct;
            this.Price = price;
            this.Amount = amountProduct;
        }
    }
}
