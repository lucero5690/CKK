using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
    public class ShoppingCartItem
    {
        private Product product;
        private int quantity;

        public void SetProduct(Product productType)
        {
            product = productType;
        }

        public Product GetProduct()
        {
            return product;
        }

        public void SetQuantity(int itemQuantity)
        {
            quantity = itemQuantity;
        }

        public int GetQuantity()
        {
            return quantity;
        }

        public ShoppingCartItem(Product productType, int itemQuantity)
        {
            product = productType;
            quantity = itemQuantity;
        }
    }
}
