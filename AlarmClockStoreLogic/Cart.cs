using System.Collections.Generic;

namespace AlarmClockStoreLogic
{
    public class Cart
    {
        private Dictionary<string, CartItem> cartItems = new Dictionary<string, CartItem>();
        private List<ProductSummary> receiptItems = new List<ProductSummary>();

        public List<ProductSummary> ReceiptItems
        {
            get { return receiptItems; }
            set { receiptItems = value; }
        }

        public Dictionary<string, CartItem> CartItems
        {
            get { return cartItems; }
            set { cartItems = value; }
        }

        public decimal TotalOrderPrice { get; set; }

        public void AddProduct(string productName, int quanity, ref Store store)
        {
            if (cartItems.ContainsKey(productName))
            {
                cartItems[productName].Quanity += quanity;
                return;
            }

            if (store.ShopItems.ContainsKey(productName))
            {
                var item = new CartItem {Quanity = quanity, Id = store.ShopItems[productName].Id};
                cartItems.Add(productName, item);
                receiptItems.Add(
                    new ProductSummary
                        {
                            Id = store.ShopItems[productName].Id,
                            Name = productName,
                            Quanity = quanity,
                            UnitPrice = store.ShopItems[productName].Price
                        });
            }
        }


        public void Remove(string id)
        {
            if (cartItems.ContainsKey(id))
            {
                cartItems.Remove(id);
            }
        }

    
        public decimal MakeOrder(ref Store store)
        {
            int helper = 1;
            foreach (ProductSummary productSummary in ReceiptItems)
            {
                foreach (var storeItems in store.ShopItems)
                {
                    if ((storeItems.Value.Quanity >= productSummary.Quanity) && receiptItems.Count >= helper)
                    {
                        TotalOrderPrice += productSummary.Quanity*productSummary.UnitPrice;
                       // this.ShopItems[productName].Quanity = -cart.CartItems[productName].Quanity;
                      //  store.ShopItems
                        storeItems.Value.Quanity -= productSummary.Quanity;
                        helper++;
                    }

                    //return TotalOrderPrice;
                }
            }

            return TotalOrderPrice;
        }
    }
}