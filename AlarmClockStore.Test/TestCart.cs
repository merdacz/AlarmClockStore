using AlarmClockStoreLogic;
using NUnit.Framework;

namespace AlarmClockStore.Test
{
    [TestFixture]
    public class TestCart
    {
        [Test]
        public void AdminHasEmptyStoreAdminAddToStoreItemInStore()
        {
            var store = new Store();
            store.AddProduct("CasioQw1", 12, 4.52m, 1);
            Assert.AreEqual(store.ShopItems.ContainsKey("CasioQw1"), true);
        }

        [Test]
        public void AdminHasProductInStoreAdminRemoveOfStoreAdminHasStoreWithoutItem()
        {
            var store = new Store();
            store.AddProduct("Casioq", 1, 412m, 1);
            store.RemoveProduct("Casioq");
            Assert.AreEqual(store.ShopItems.Count, 0);
        }

        [Test]
        public void UserHasEmptyCartUserAddToCartItemAddToCart()
        {
            var store = new Store();
            store.AddProduct("CasioQw1", 12, 4.52m, 1);
            var cart = new Cart();

            cart.AddProduct("CasioQw1", 4, ref store);


            Assert.AreEqual(cart.CartItems.ContainsKey("CasioQw1"), true);
        }

        [Test]
        public void UserHasItemInCartUserRemoveToCartUserHasCartWithOutItem()
        {
            var store = new Store();
            store.AddProduct("CasioQw1", 12, 4.52m, 1);
            var cart = new Cart();
            cart.AddProduct("CasioQw1", 1, ref store);
            cart.Remove("CasioQw1");
            Assert.AreEqual(cart.CartItems.Count, 0);
        }

        [Test]
        public void UserMakeOrderUserClickMakeOrderOrderExecuted()
        {
            var store = new Store();
            var cart = new Cart();
            store.AddProduct("Casioq", 1, 412m, 1);
            store.AddProduct("Casio", 2, 121m, 2);

            cart.AddProduct("Casio", 2, ref store);
            cart.AddProduct("Casioq", 1, ref store);
            cart.MakeOrder(ref store);
            Assert.AreEqual(412 + (2*121), cart.TotalOrderPrice);
        }
    }
}