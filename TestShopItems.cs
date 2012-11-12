﻿using System;
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

            int testId = 1;
            ShopItem item = new ShopItem(testId);

            Assert.AreEqual(1, item.Id);

        }
        [Test]
        public void AddMethodTest()
        {
            int id = 1;
            Cart cart=new Cart();
           // ShopItem qwe=new ShopItem(id);
            cart.AddItem(id);
           Assert.AreEqual(id,cart.Items.Count);

            //  Assert.AreEqual(1, item.Id);

        }


    }


}
