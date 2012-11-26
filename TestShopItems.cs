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
           // Cart cart = new Cart();
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
         // int id = 1;
            //int idq = 2;
           // Cart cart=new Cart();
            
          //  Cart carta=new Cart();
           // ShopItem qwe=new ShopItem(id);
           
            int testId = 1;
            int testqId = 2;
            ShopItem item = new ShopItem(testId);

            //ShopItem item2 = new ShopItem(testqId);
            //ShopItem item3 = new ShopItem(4);
            //cart.AddItem(item);
         //   cart.AddItem(item2);
            //cart.AddItem(item);
            //cart.AddItem(item2);
            //cart.AddItem(item3);
            //int licznik = Items.Count;
            Cart cart = new Cart();
            cart.AddItem(testId);
            cart.AddItem(testqId);
           Assert.AreEqual(2,cart.Items.Count);
        //   Assert.AreEqual(2, item.AmountItems);
           Assert.AreEqual(100, item.Price);

            //  Assert.AreEqual(1, item.Id);

        }
        [Test]
        public void RemoveMethodTest()
        {
            int id = 1;
            Cart cart=new Cart();
           
            cart.RemoveItem(id);
            Assert.AreEqual(0,cart.Items.Count);
            
        }
        [Test]
        public void PromotionTestMethod()
        {
            int testId = 5;
            Cart cart = new Cart();
            ShopItem shopItem=new ShopItem(testId);
            cart.AddItem(1);
            cart.AddItem(1);
            cart.AddItem(1);
            cart.AddItem(1);
            cart.AddItem(1);
            cart.AddItem(1);
            cart.AddItem(1);
            cart.AddItem(1);
            cart.AddItem(1);
            cart.AddItem(1);
            if (cart.Items.Count==10)
            {
             



                Assert.AreEqual(5, shopItem.Id);
                Assert.AreEqual(10, cart.Items.Count);
              //  shopItem.Price = 100;
                Assert.AreEqual(90, shopItem.PromotionPrice);
            }
          

        }
        [Test]
        public void TotalPriceTest()
        {
            Cart cart=new Cart();
            int qId = 1;
            int aId = 2;
          
            cart.AddItem(qId);
            cart.AddItem(aId);

            Assert.AreEqual(200,cart.GetPriceTotal());
        }
      


    }


}
