using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
    public class Customer
    {
        private int id;
        private string name;
        private string address;


        public void SetId(int itemId)
        {
            id = itemId;
        }

        public int GetId()
        {
            return id;
        }

        public void SetName(string customerName)
        {
            name = customerName;
        }

        public string GetName()
        {
            return name;
        }

        public void SetAddress(string customerAddress)
        {
            address = customerAddress;
        }

        public string GetAddress()
        {
            return address;
        }
    }
}
