using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Customer
    {
        string name;
        string adress;
    }

    class Order
    {
        string date;
        string status;

        public int calcSubTotal()
        {
            return 0;

        }

        public int calcTax()
        {
            return 0;
        }

        public int calcTotal()
        {
            return 0;
        }

        public int calcTotalWeight()
        {
            return 0;
        }
    }

    class OrderDetail
    {
        string quality;
        string taxStatus;
        public int calcSubTotal()
        {
            return 0;

        }

        public int calcTax()
        {
            return 0;
        }

        public int calcWeight() 
        {
            return 0;
        }

    }

    class Item
    {
        string shippingWeight;
        string description;

        public void getPriceForQuantity()
        {
            Console.Write("Quantity?");
        }

        public void getTax()
        {
            Console.Write("Tax");
        }

        public void inStock()
        {
            Console.Write("stock");
        }https://github.com/neiweim1/2eTech19C
    }

    class Payment
    {
        float amount;
    }

    class Cash
    {
        float cashTendered;
        
    }

    class Check
    {
        string name;
        string bankID;

        public void authorized()
        {
            Console.Write("autoryzacja");
        }
    }

    class Credit
    {
        string name;
        string type;
        string expdate;
        public void authorized()
        {
            Console.Write("autoryzacja");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
}

