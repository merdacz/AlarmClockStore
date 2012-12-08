using System.Collections.Generic;
namespace AlarmClockStore.Logic
{
    public class Store
    {
        private Dictionary<int, ShopItem> itemsList = new Dictionary<int, ShopItem>();

        public Dictionary<int, ShopItem> ItemsGet
        {
            get
            {
                return this.itemsList;
            }
        }
        public Dictionary<int, ShopItem> ItemsSet
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

        public void AddProduct(int id, string nameProduct, decimal price, int amountProduct)
        {
            this.ItemsSet.Add(id, new ShopItem(nameProduct, price, amountProduct));
        }

        public Cart CreateCart()
        {
            return new Cart();
        }

        public void RegisterDiscountPromotion(ShopItem item, int amountProduct, int rabat)
        {
        }

        public void RemoveProduct(int id)
        {
            this.ItemsSet.Remove(id);
        }

        public List<ShopItem> ValuesMethod()
        {
            return new List<ShopItem>(this.ItemsGet.Values);
        }

    }
}