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
         
           
            int testId = 1;
            int testqId = 2;
            ShopItem item = new ShopItem(testId);

            
            Cart cart = new Cart();
            cart.AddItem(testId);
            cart.AddItem(testqId);
           Assert.AreEqual(2,cart.Items.Count);
        
           Assert.AreEqual(100, item.Price);

            

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
                shopItem.GetPromotion(cart);
                Assert.AreEqual(90,cart.Items[1].PromotionPrice );
                Assert.AreEqual(180,cart.Items[0].PromotionPrice+cart.Items[1].PromotionPrice);
                Assert.AreEqual(900,cart.GetPriceTotal());
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
