using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
    public class Store
    {
        private int _id;
        private string _name;
        private Product _product1;
        private Product _product2;
        private Product _product3;

        public void SetId(int id)
        {
            _id = id;
        }

        public int GetId()
        {
            return _id;
        }

        public void SetName(string name)
        {
            _name = name;
        }

        public string GetName()
        {
            return _name;
        }

        public Product AddStoreItem(Product prod)
        {
            if (_product1 == null)
            {
                _product1 = prod;
            }
            else if (_product2 == null)
            {
                _product2 = prod;
            }
            else if (_product3 == null)
            {
                _product3 = prod;
            }

            return null;
        }

        public int RemoveStoreItem(int productNumber)
        {
            if (_product1 != null && productNumber == 1)
            {
                _product1 = null;
                return 1;
            }
            if (_product2 != null && productNumber == 2)
            {
                _product2 = null;
                return 2;
            }
            if (_product3 != null && productNumber == 3)
            {
                _product3 = null;
                return 3;
            }

            return 0;
        }

        public Product GetStoreItem(int productNumber)
        {
            if (_product1 != null && productNumber == 1)
            {
                return _product1;
            }
            if (_product2 != null && productNumber == 2)
            {
                return _product2;
            }
            if (_product3 != null && productNumber == 3)
            {
                return _product3;
            }

            return null;
        }

        public Product FindStoreItemById(int id)
        {
            if (_product1 != null && id == 1)
            {
                return _product1;
            }
            if (_product2 != null && id == 2)
            {
                return _product2;
            }
            if (_product3 != null && id == 3)
            {
                return _product3;
            }

            return null;
        }

    }
}