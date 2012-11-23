using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AlarmClockStore;
using AlarmClockStore.Logic;

namespace AlarmClockStore.Test
{


    [TestFixture]
    public class TestAlarmLogic
    {
        [Test]
        public void TestConstructor()
        {

            var cart = new Store().CreateCart();
            Assert.IsNotNull(cart);
        }
        [Test]
        public void AddMethodTest()
        {
            var store = new Store();
            store.AddProduct("casio" , 120 , 5);
            var cart = new Store().CreateCart();
            cart.ItemsCartSet.Add("casio", 2);
            Assert.AreEqual(store.ItemsGet[0].NameProduct, "casio");
         
           
         
        }
        [Test]
        public void TestCalculateCost()
        {

       
            var store = new Store();
            store.AddProduct("casio", 120, 5);
            var cart = new Store().CreateCart();
            store.AddProduct("CasioGShock", 450, 2);

            cart.ItemsCartSet.Add("casio", 2);
            cart.ItemsCartSet.Add("CasioGShock", 2);
           // Assert.AreEqual(450*2+2*120,cart.CalculateTotal());


            

        }
        [Test]
        public void TestRemoveItemCart()
        {
            var store = new Store();
            store.AddProduct("casio", 120, 5);
            var cart = new Store().CreateCart();
            store.AddProduct("CasioGShock", 450, 2);

            cart.Add("casio", 2);
            cart.Add("CasioGShock", 2);
            cart.Remove("casio");
            
            
            Assert.AreEqual(2,cart.ItemsCartSet.Count);
        }
      
      


    }
}
