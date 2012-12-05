using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlarmClockStore.Logic
{
    using System.Diagnostics.CodeAnalysis;

    public class Store
    {


        private List<ShopItem> itemsList = new List<ShopItem>();

        public List<ShopItem> ItemsSet
        {
            get
            {
                return this.itemsList;
            }
            set
            {
                this.itemsList = value;
            }
        }
     
        public List<ShopItem> ItemsGet
        {
            get
            {
                return this.itemsList;
            }

        }

        public void AddProduct(string nameProduct, decimal price,int amountProduct)
        {

            this.ItemsSet.Add(new ShopItem(nameProduct, price, amountProduct));

        }


        public void RemoveProduct(ShopItem item)
        {

            this.ItemsSet.Remove(item);

        }

        public void RegisterDiscountPromotion(ShopItem item, int amountProduct, int rabat)
        {
            
        }


        public Cart CreateCart()
        {

            return new Cart();

        }


    }
}

