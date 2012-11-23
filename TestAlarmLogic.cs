namespace AlarmClockStore.Test
{
    using AlarmClockStore.Logic;

    using NUnit.Framework;

    [TestFixture]
    public class TestAlarmLogic
    {
        #region Public Methods and Operators

        [Test]
        public void AddMethodTest()
        {
            var store = new Store();
            store.AddProduct("casio", 1, 120, 5);
            Cart cart = new Store().CreateCart();

            store.AddProduct("CasioGShock", 2, 450, 2);
            cart.Add("casio", 2, ref store);
            cart.Add("casio", 2, ref store);
            cart.Add("casiooo", 4, ref store);

            // Assert.AreEqual(2, cart.ItemsCartGet.Values.Count);
            Assert.AreEqual(2, cart.ListCartItemsSet.Count);
        }

        [Test]
        public void TestCalculateCost()
        {
            var store = new Store();
            store.AddProduct("casio", 1, 120, 5);
            Cart cart = new Store().CreateCart();
            store.AddProduct("CasioGShock", 2, 450, 2);
            cart.Add("casio", 2, ref store);
        }

        [Test]
        public void TestConstructor()
        {
            Cart cart = new Store().CreateCart();
            Assert.IsNotNull(cart);
        }

        [Test]
        public void TestRefMethod()
        {
            var store = new Store();
            store.AddProduct("casio", 1, 1201, 1);
            Cart cart = store.CreateCart();
            cart.Add("aaa", 2, ref store);
            Assert.AreEqual(cart.ItemsCartGet.ContainsKey("aaa"), true);


        }

        [Test]
        public void TestRefProduct()
        {
            var store = new Store();
            store.AddProduct("casio", 1, 120, 5);
            Cart cart = new Store().CreateCart();
            store.AddProduct("CasioGShock", 2, 450, 2);
            Assert.AreEqual(store.ItemsGet.ContainsKey("CasioGShock"), true);
        }

        [Test]
        public void TestRemoveItemCart()
        {
            var store = new Store();
            store.AddProduct("casio", 1, 120, 5);
            Cart cart = new Store().CreateCart();
            store.AddProduct("CasioGShock", 2, 450, 2);

            cart.Add("casio", 2, ref store);
            cart.Add("CasioGShock", 2, ref store);
            cart.Remove("casio",2);
            cart.Add("casio", 2, ref store);
            Assert.AreEqual(2, cart.ListCartItemsSet.Count);
        }

        #endregion
    }
}
