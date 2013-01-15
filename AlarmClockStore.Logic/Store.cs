namespace AlarmClockStore.Logic
{
    using System;
    using System.Collections.Generic;

    public class Store : IProductReferenceProvider
    {
        #region Fields

        private readonly List<string> nameProducts = new List<string>();

        private Dictionary<string, ShopItem> itemsList = new Dictionary<string, ShopItem>();

        #endregion

        #region Public Properties

        public Dictionary<string, ShopItem> ItemsGet
        {
            get
            {
                return this.itemsList;
            }
        }

        public Dictionary<string, ShopItem> ItemsSet
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

        public List<string> NameProducts
        {
            get
            {
                return this.nameProducts;
            }
        }

        #endregion

        #region Public Methods and Operators

        public void AddProduct(string nameProduct, int id, decimal price, int amountProduct)
        {
            if (this.ItemsSet.ContainsKey(nameProduct))
            {
                throw new Exception("Bug");
            }
            else
            {
                this.ItemsSet.Add(nameProduct, new ShopItem(id, price, amountProduct));
                this.nameProducts.Add(nameProduct);
            }
        }

        public Cart CreateCart()
        {
            return new Cart();
        }

        public object GetProductReference(string nameProduct)
        {
            //nie miałem pomysłu
            if (this.ItemsGet.ContainsKey(nameProduct))
            {
                return this.ItemsGet[nameProduct];
            }

            object nullObject;
            nullObject = null;
            return nullObject;
        }

        public void RegisterDiscountPromotion(ShopItem item, int amountProduct, int discount)
        {
        }

        public void RemoveProduct(string nameProduct)
        {
            this.ItemsSet.Remove(nameProduct);
        }

        public List<ShopItem> ValuesMethod()
        {
            return new List<ShopItem>(this.ItemsGet.Values);
        }

        #endregion
    }
}