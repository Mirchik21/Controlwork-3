using Newtonsoft.Json;

namespace Controlwork_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many products to create?");
            int products_size = int.Parse(Console.ReadLine());
            Product[] products = new Product[products_size];
            for(int i = 0; i < products.Length; i++)
            {
                products[i] = new Product();
                products[i].id = i + 1;
                Console.WriteLine("Enter name of product:");
                products[i].name = Console.ReadLine();
                Console.WriteLine("Enter price of product:");
                products[i].price = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter state of product: \n in_stock, for_sale, sold");
                products[i].state = Console.ReadLine();
                Console.WriteLine("Enter honorary code of product:");
                products[i].honorary_code = Console.ReadLine();
            }
            string jsonString = JsonConvert.SerializeObject(products);
            File.WriteAllText("../../../data.json", jsonString);

            for (int i = 0; i < products.Length; i++)
            {
                products[i].SetStates();
            }

            try
            {
                Product[] productses = JsonManager.GetProducts();
                foreach (Product product in productses)
                {
                    Console.WriteLine("id: " + product.id);
                    Console.WriteLine("name: " + product.name);
                    Console.WriteLine("price: " + product.price);
                    Console.WriteLine("honorary_code: " + product.honorary_code);
                    Console.WriteLine("state: " + product.state);
                    Console.WriteLine("-------------------");
                }
                Product product1 = GetProduct(productses);
                Console.WriteLine(product1);
                Console.WriteLine("What operation do you want to perform with this product?");
                Console.WriteLine("Press 1 to auction and call the SetUp method");
                Console.WriteLine("Press 2 to raise the price and call the RaisePrice method");
                Console.WriteLine("Press 3 to give to the winning bidder and call the GiveToTheWinner method");
                Console.WriteLine("Press 4 to unbid and call the SetOff method");
                string action = Console.ReadLine();
                switch (action)
                {
                    case "1":
                        product1.SetUp();
                        break;
                    case "2":
                        product1.RaisePrice();
                        break;
                    case "3":
                        product1.GiveToTheWinner();
                        break;
                    case "4":
                        product1.SetOff();
                        break;
                    default:
                        Console.WriteLine("Incorrect data entered, please enter correctly!");
                        break;
                }
                Console.WriteLine(product1);

                string jsonStringes = JsonConvert.SerializeObject(productses);
                File.WriteAllText("../../../data.json", jsonStringes);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
     
        }

        static Product GetProduct(Product[] products)
        {
            Console.WriteLine("Enter ID for search product");
            int id = int.Parse(Console.ReadLine());
            Product product = Array.Find(products, item => item.id == id);
            return product;
        }
    }
}