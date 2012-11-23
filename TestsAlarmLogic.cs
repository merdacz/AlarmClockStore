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
            store.AddProduct("CasioGShock", 2, 890, 3);
            Cart cart = new Store().CreateCart();
            cart.Add("casio", 2, ref store);
            cart.Add("CasioGShock", 2, ref store);
            // Assert.AreEqual(2, cart.ListCartItemsSet.Count);
            Assert.AreEqual(2, cart.ItemsCartListSet.Count);
        }

        [Test]
        public void TestCalculateCost()
        {
            var store = new Store();
            store.AddProduct("casio", 1, 120, 5);
            Cart cart = new Store().CreateCart();
            store.AddProduct("CasioGShock", 2, 450, 2);
            cart.Add("casio", 2, ref store);
            cart.CalculateTotal(ref store);
            Assert.AreEqual(240, cart.PriceProducts);
        }

        [Test]
        public void TestConstructor()
        {
            Cart cart = new Store().CreateCart();
            Assert.IsNotNull(cart);
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

            cart.Add("casio", 4, ref store);
            cart.Add("CasioGShock", 2, ref store);
            cart.Remove("casio", 2);
            //Assert.AreEqual(2, cart.ListCartItemsSet.Count);
            Assert.AreEqual(2, cart.ItemsCartListSet.Count);
        }

        #endregion
    }
}