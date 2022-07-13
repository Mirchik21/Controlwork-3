using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlwork_3
{
    class SoldState : Istate
    {
        Product[] products = JsonManager.GetProducts();

        string name = "sold";
        public string Name { get { return name; } }
      
        public void RaisePrice(Product product)
        {
            Console.WriteLine("Operation is not possible, the product is already sold");
        }
        public void SetUp(Product product)
        {
            Console.WriteLine("Operation is not possible, the product is already sold");
        }
        public void GiveToTheWinner(Product product)
        {
            Console.WriteLine("Operation is not possible, the product is already sold");
        }
        public void SetOff(Product product)
        {
            Console.WriteLine("Operation is not possible, it is impossible to remove the sold product from the auction");
        }
    }
}
