using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductMgmt
{
    internal class Product1
    {
        public int pCode;
         string pName;
        
        int qtyStock;
         int discountAllowed;
         

        static string brand;
         

        public int price;
         
        //pcode(which is different for every product, and once it is set for one product, it shall remain same), pname, qty_in_stock,discount_allowed, brand

        static Product1()
        {
            brand = "Lewis";
        }
        public Product1()
        {
            
        }
        public Product1(int pCode, string pName,int qtyStock, int discountAllowed,int price)
        {
             
            this.pCode = pCode;
            this.pName = pName;
            this.qtyStock = qtyStock;
            this.discountAllowed = discountAllowed;
            this.price = price;
        }

        public void GetProduct()
        {
            Console.WriteLine("enter product code");
            pCode = byte.Parse(Console.ReadLine());
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