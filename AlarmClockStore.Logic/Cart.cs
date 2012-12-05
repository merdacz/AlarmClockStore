using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlarmClockStore.Logic
{
    public class Cart
    {
        private Dictionary<string,int> itemsCart = new Dictionary<string,int>();

      
        private decimal caluculateTotal;

        private decimal subTotal;

        public Dictionary<string,int> ItemsCartSet
        {
            get
            {
                return this.itemsCart;
            }
            set
            {
                itemsCart = value;
            }
        }

        public decimal SubTotal
        {
           get
           {
               return subTotal;
           }
           set
           {
               subTotal = value;
           }

        }
        public Dictionary<string,int> ItemsCartGet
        {
            get
            {
                return this.itemsCart;
            }
        }
        

        public void Add(string product,int amount)
        {
            Store helper = new Store();
           
            foreach (var item in ItemsCartSet)
            {
                if (item.Key.Contains(product))
                {
                    ItemsCartSet.Add(product, amount);
                }
            }
            
            
        }

        public void Remove(string product)
        {
            this.ItemsCartSet.Remove(product);
        }

        //public decimal CalculateTotal()
        //{
          
        //}

        public void MakeOrder()
        {
            
        }
        

    }
}
