namespace AlarmClockStore.Logic
{
    public class CartItem
    {
        #region Constructors and Destructors

        public CartItem(int amount)
        {
            this.Amount = amount;
        }

        #endregion

        #region Public Properties

        public int Amount { get; set; }

        #endregion
    }
}