using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
namespace ClockAlarmStore
{
    [TestFixture]
    public class TestCart
    {
        [Test]
        public void CartConstructor()
        {
            Cart cart = new Cart();
            Assert.IsNotNull(cart);
        }

        [Test]
        public void ShopItemMethodTest()
        {
            var id = 1;
         //   ShopItem item = new ShopItem(id);

            //int result= cart.AddItem(id);

           // Assert.AreEqual(1,item.Id);

            Cart cart=new Cart();
            Assert.AreEqual(1,cart.AddItem(id));
         //  Assert.AreEqual(1,cart.Items.);
        }


    }


}