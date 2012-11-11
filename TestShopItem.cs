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
          Cart cart=new Cart();
          Assert.IsNotNull(cart);
      }

       [Test] 
      public void ShopItemMethodTest()
       {
           int id = 0;
          ShopItem item=new ShopItem(id);
          
           //int result= cart.AddItem(id);

           Assert.AreEqual(0,item.Id);
       }


   }
  

}
