using System.Collections.Generic;
namespace AlarmClockStore.Logic
{
    

    public class Cart
    {
       
        private Dictionary<string, int> itemsCart = new Dictionary<string, int>();

        public Dictionary<string, int> ItemsCartGet
        {
            get
            {
                return this.itemsCart;
            }
        }

        public Dictionary<string, int> ItemsCartSet
        {
            get
            {
                return this.itemsCart;
            }

            set
            {
                this.itemsCart = value;
            }
        }

        public decimal PriceProducts { get; set; }

        public decimal SubTotal { get; set; }

        public void Add(string product, int amount)
        {
            var helper = new Store();
            var listNumber = new List<ShopItem>(helper.ItemsGet.Values);
            for (int i = 0; i < listNumber.Count; i++)
            {
                if (listNumber[i].NameProduct == product)
                {
                    this.ItemsCartSet.Add(product, amount);
                }
            }
        }

        public decimal CalculateTotal()
        {
            int keys = 0;
            decimal priceAll = 0;
            this.PriceProducts = 0;
            var store = new Store();
            foreach (var itemCart in this.ItemsCartGet)
            {
                keys += itemCart.Value;

                foreach (var itemAll in store.ItemsGet)
                {
                    if (this.ItemsCartSet.ContainsKey(itemAll.Value.NameProduct))
                    {
                        this.PriceProducts = keys * itemAll.Value.Price;
                        return this.PriceProducts;
                    }
                }

                return this.PriceProducts;
            }

            return this.PriceProducts;
        }

        public void MakeOrder()
        {
        }

        public void Remove(int id, string product)
        {
            var helper = new Store();
            if (helper.ItemsGet.ContainsKey(id))
            {
                this.ItemsCartSet.Remove(product);
            }
        }

    }
}