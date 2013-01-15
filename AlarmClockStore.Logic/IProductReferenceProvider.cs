namespace AlarmClockStore.Logic
{
    internal interface IProductReferenceProvider
    {
        object GetProductReference(string productName);
    }
}