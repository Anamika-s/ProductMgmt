using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductMgmt
{
    internal class Product
    {
        int pCode;
        public int PCode
        {
            get { return pCode; }
            set { pCode = value; }

        }
        string pName;
        public string Pname
        {

            get { return pName; }
            set { pName = value; }
        }

        int qtyStock;
        public int QtyStock
        {
            get { return qtyStock; }
            set { qtyStock = value; }
        }
        int discountAllowed;
        public int DiscountAllowed
        {
            get { return discountAllowed; }
            set { discountAllowed = value; }
        }

        static string brand;
        public string BrandName
        {
            get { return brand; }
            set { brand = value; }
        }

        int price;
        public int Price
        {
            get { return price; }
            set { price = value; }
        }
        //pcode(which is different for every product, and once it is set for one product, it shall remain same), pname, qty_in_stock,discount_allowed, brand

        static Product()
        {
            brand = "Lewis";
        }
        //public Product()
        //{
        //    Console.WriteLine("enter pcode");
        //    pCode = byte.Parse(Console.ReadLine());
        //}
        //public Product(int pCode)
        //{
        //    this.pCode = pCode;
        //}

        public void GetProduct()
        {
            Console.WriteLine("enter product code");
            PCode = byte.Parse(Console.ReadLine());
            Console.WriteLine("enter product name");
            pName = Console.ReadLine();
            Console.WriteLine("enter qty in stock");
            qtyStock = byte.Parse(Console.ReadLine());
            Console.WriteLine("enter dicsount allowed");
            discountAllowed = byte.Parse(Console.ReadLine());
            Console.WriteLine("enter prioe");
            price = int.Parse(Console.ReadLine());

        }

        public void DisplayProduct()
        {
            Console.WriteLine($"Product Code is  {pCode}\n Product Name is {pName}\n Qty In Stock {qtyStock}\n Discount Allowed  {discountAllowed}\nPrice is {price}");
        }

        
    }
}