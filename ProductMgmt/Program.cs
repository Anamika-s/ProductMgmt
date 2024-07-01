
namespace ProductMgmt
{
    internal class Program
    {
        // List initialzer
        static Product product = new Product();
        static List<Product> products = new List<Product>()
            {
             new Product(){ PCode=100, Pname = "Shirt", QtyStock=30, DiscountAllowed=50, Price=1900},
             new Product(){ PCode=101,Pname = "TShirt", QtyStock=10, DiscountAllowed=50, Price=2300},
             new Product(){ PCode=102,Pname = "Trouser", QtyStock=30, DiscountAllowed=50, Price=2900},
             new Product(){ PCode=103 ,Pname = "Jacket", QtyStock=24, DiscountAllowed=50, Price=1200},
             new Product(){ PCode=104,Pname = "Pant", QtyStock=90, DiscountAllowed=50, Price=5900}
            };

        static List<Product> Order = new List<Product>();
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
                                        List<Product> products = GetProducts();
                                        foreach (Product temp in products)
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
                                        List<Product> products = GetProducts();
                                        foreach (Product temp in products)
                                        {
                                            temp.DisplayProduct();
                                        }
                                        break;
                                    }
                                case 2:
                                    {
                                        Console.WriteLine("Enter Product to purchase");
                                        int pCode = byte.Parse(Console.ReadLine());
                                        Product product = GetProductById(pCode);
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
                                        Product product = GetProductById(pCode);
                                        if (product != null)
                                            Order.Add(product);

                                        break;
                                    }
                                case 4:
                                    {
                                        List<Product> order = GetOrder();
                                        int amount = 0;
                                        foreach (Product temp in order)
                                        {
                                            temp.DisplayProduct();
                                            amount += temp.Price;
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

        static List<Product> GetProducts()
        {
            return products;
        }


        static List<Product> GetOrder()
        {
            return Order;
        }

    

    static Product GetProductById(int Pcode)
        {


            foreach (Product product in products)
            {
                if (product.PCode == Pcode)
                {
                    return product;
                    break;
                }
            }
            return null;
        }
    }

}
