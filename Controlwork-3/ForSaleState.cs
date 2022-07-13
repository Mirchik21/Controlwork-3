using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlwork_3
{
    class ForSaleState : Istate
    {
        Product[] products = JsonManager.GetProducts();
        string name = "for_sale";
        public string Name { get { return name; } }

        public void RaisePrice(Product product)
        {
            Console.WriteLine("Product price successfully increased by 5 units");
            product.price = product.price + 5;
        }
        public void SetUp(Product product)
        {
            Console.WriteLine("Operation is not possible, the product cannot be re-bid.");
        }
        public void GiveToTheWinner(Product product)
        {
            if(product.price == 0)
            {
                Console.WriteLine("Operation is not possible, you can't give away the product for free");
            }
            else if(product.price > 0)
            {
                product.state = "sold";
                Console.WriteLine("Product sold");
            }
        }
        public void SetOff(Product product)
        {
            product.state = "in_stock";
            Console.WriteLine("Product returned to stock");
        }
    }
}
