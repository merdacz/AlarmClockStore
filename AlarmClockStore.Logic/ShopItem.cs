namespace AlarmClockStore.Logic
{
    public class ShopItem
    {
       
        public ShopItem(int id, decimal price, int amountProduct)
        {
            this.Price = price;
            this.Amount = amountProduct;
            this.Id = id;
        }

        public int Amount { get; set; }

        public int Id { get; set; }

        public decimal Price { get; set; }

    }
}