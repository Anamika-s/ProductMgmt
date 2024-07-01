
namespace ProductMgmt
{
    internal class Program1
    {
        // List initialzer
        static Product1 product = new Product1();
        static List<Product1> products = new List<Product1>()
            {
             new Product1(pCode:100,pName:"Shirt",qtyStock:30,discountAllowed:50,price:1900),
             new Product1(pCode:100,pName:"Shirt",qtyStock:30,discountAllowed:50,price:1900),
             new Product1(pCode:100,pName:"Shirt",qtyStock:30,discountAllowed:50,price:1900)
            };

        static List<Product1> Order = new List<Product1>();
        static void Main(string[] args)
        {
            string choice = "y";
            while (choice == "y")
            {
                int ch = Menu();
                switch (ch)
                {
                    case 1:
                        {

                            int adminChoice = AdminMenu();
                            switch (adminChoice)
                            {
                                case 1:
                                    {
                                        //Console.WriteLine("enter pCode");
                                        //int pCode = byte.Parse(Console.ReadLine()); ;
                                        //product = new Product();
                                        product.GetProduct();
                                        products.Add(product);
                                        break;
                                    }
                                case 2:
                                    {
                                        List<Product1> products = GetProducts();
                                        foreach (Product1 temp in products)
                                        {
                                            temp.DisplayProduct();
                                        }
                                        break;
                                    }
                            }
                            break;
                        }
                    case 2:
                        {
                            int customerChoice = CustomerMenu();
                            switch (customerChoice)
                            {
                                case 1:
                                    {
                                        List<Product1> products = GetProducts();
                                        foreach (Product1 temp in products)
                                        {
                                            temp.DisplayProduct();
                                        }
                                        break;
                                    }
                                case 2:
                                    {
                                        Console.WriteLine("Enter Product to purchase");
                                        int pCode = byte.Parse(Console.ReadLine());
                                        Product1 product = GetProductById(pCode);
                                        if (product != null)
                                            product.DisplayProduct();
                                        else
                                            Console.WriteLine("Product not found");
                                        break;
                                    }
                                case 3:
                                    {
                                        Console.WriteLine("Enter Product to purchase");
                                        int pCode = byte.Parse(Console.ReadLine());
                                        Product1 product = GetProductById(pCode);
                                        if (product != null)
                                            Order.Add(product);

                                        break;
                                    }
                                case 4:
                                    {
                                        List<Product1> order = GetOrder();
                                        int amount = 0;
                                        foreach (Product1 temp in order)
                                        {
                                            temp.DisplayProduct();
                                            amount += temp.price;
                                        }

                                        Console.WriteLine("*************************");
                                        Console.WriteLine("Total BILL IS " + amount);

                                        Console.WriteLine("*************************");
                                        break;
                                    }
                            }
                            break;
                        }

                }
                Console.WriteLine("Repeat? ");
                choice = Console.ReadLine();
            }
        }
        static int Menu()

        {

            Console.WriteLine("Who are you");
            Console.WriteLine("1. Admin");
            Console.WriteLine("2. Customer");
            Console.WriteLine("Enter ");
            int ch = byte.Parse(Console.ReadLine());
            return ch;
        }

        static int AdminMenu()
        {
            Console.WriteLine("1. Add New Product");
            Console.WriteLine("2. Get List of all products");

            return (byte.Parse(Console.ReadLine()));
        }

        static int CustomerMenu()
        {
            Console.WriteLine("1. Get List of all products");
            Console.WriteLine("2. Search a product");
            Console.WriteLine("3. Order a product");
            Console.WriteLine("4. Get Bill");
            return (byte.Parse(Console.ReadLine()));
        }

        static List<Product1> GetProducts()
        {
            return products;
        }


        static List<Product1> GetOrder()
        {
            return Order;
        }

    

    static Product1 GetProductById(int Pcode)
        {


            foreach (Product1 product in products)
            {
                if (product.pCode == Pcode)
                {
                    return product;
                    break;
                }
            }
            return null;
        }
    }

}
