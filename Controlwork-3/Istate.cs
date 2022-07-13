using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlwork_3
{
    interface Istate
    {
        public string Name { get;}
        void RaisePrice(Product product);
        void SetUp(Product product);
        void GiveToTheWinner(Product product);
        void SetOff(Product product);

    }
}
