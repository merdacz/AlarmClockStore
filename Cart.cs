namespace AlarmClockStore.Logic
{
    using System;
    using System.Collections.Generic;

    public class Cart
    {
        private List<int> amountCartItems = new List<int>();

        private List<CartItem> cartItemsList = new List<CartItem>();

        private Dictionary<string, int> itemsCartList = new Dictionary<string, int>();

        private List<string> nameCartItems = new List<string>();

        public Dictionary<string, int> ItemsCartListSet
        {
            get
            {
                return this.itemsCartList;
            }
            set
            {
                this.itemsCartList = value;
            }
        }

        public decimal PriceProducts { get; set; }

        public decimal SubTotal { get; set; }

        public void Add(string product, int amount, ref Store store)
        {
            if (product == null)
            {
                throw new ArgumentNullException("product");
            }
            if (store.ItemsGet.ContainsKey(product))
            {
                this.ItemsCartListSet.Add(product, amount);
            }
        }

        public decimal CalculateTotal(ref Store store)
        {
            decimal helpers = 0;
            for (var i = 0; i < store.ItemsGet.Count; i++)
            {
                foreach (var item in store.ItemsGet)
                {
                    foreach (var cartItemName in this.ItemsCartListSet.Keys)
                    {
                        if (item.Key == cartItemName)
                        {
                            if (store.ItemsGet.ContainsKey(item.Key))
                            {
                                decimal helperStore = store.ItemsGet[item.Key].Price;
                                int helperCart = this.ItemsCartListSet[cartItemName];
                                this.PriceProducts += helperCart * helperStore;
                                helpers = this.PriceProducts;
                                return this.PriceProducts;
                            }
                        }
                    }
                    return helpers;
                }
                return helpers;
            }
            return helpers;
        }

        public void MakeOrder()
        {
        }

        public void Remove(string productName, int amount)
        {
        }

    }
}