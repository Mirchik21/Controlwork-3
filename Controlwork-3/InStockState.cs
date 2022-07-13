using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlwork_3
{
    internal class InStockState : Istate
    {
        Product[] products = JsonManager.GetProducts();

        string name = "in_stock";
        public string Name { get { return name; } }

        public void RaisePrice(Product product)
        {
            Console.WriteLine("Operation is not possible. Since the product is not bidding");
        }
        public void SetUp(Product product)
        {
            product.state = "for_sale";
            Console.WriteLine("Product is up for auction");
        }
        public void GiveToTheWinner(Product product)
        {
            Console.WriteLine("Operation is not possible. You can not give the product immediately from the warehouse");
        }
        public void SetOff(Product product)
        {
            Console.WriteLine("Operation is not possible. You can not withdraw from the auction a product that does not participate in them.");
        }
    }
}
