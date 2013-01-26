using System.Collections.Generic;

namespace AlarmClockStoreLogic
{
    public class Store
    {
        private Dictionary<string, ShopItem> shopItems = new Dictionary<string, ShopItem>();

        public Dictionary<string, ShopItem> ShopItems
        {
            get { return shopItems; }
            set { shopItems = value; }
        }

        public void AddProduct(string nameProduct, int quanity, decimal price, int id)
        {
            var shopItem = new ShopItem();
            shopItem.Price = price;
            shopItem.Quanity = quanity;
            shopItem.Id = id;
            shopItems.Add(nameProduct, shopItem);
        }

        public Cart CreateCart()
        {
            return new Cart();
        }

        public void RemoveProduct(string productName)
        {
            shopItems.Remove(productName);
        }

        //public void UpdateQuanity(string productName,ref Cart cart)
        //{
        //    if (cart.CartItems[productName].Quanity<=this.ShopItems[productName].Quanity)
        //    {
        //        this.ShopItems[productName].Quanity =- cart.CartItems[productName].Quanity;
        //    }
        //}

       
    }
}