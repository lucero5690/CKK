using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
   public class Product
    {
        private int id;
        private string name;
        private decimal price;

        public void SetId(int itemId)
        {
            id = itemId;
        }

        public int GetId()
        {
            return id;
        }

        public void SetName(string itemName)
        {
            name = itemName;
        }

        public string GetName()
        {
            return name;
        }

        public void SetPrice(decimal itemPrice)
        {
            price = itemPrice;
        }

        public decimal GetPrice()
        {
            return price;
        }
    }
}
