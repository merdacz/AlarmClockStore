namespace AlarmClockStoreLogic
{
    public interface ICart
    {
        void AddProduct(string productName, int quanity, int id, ref Store store);
        void Remove(string id);
    }
}