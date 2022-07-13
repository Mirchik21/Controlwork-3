using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlwork_3
{
    class Product
    {
        public int id;
        public string name;
        public double price;
        public string honorary_code;
        public string state;

        public Istate State;
       
        public Product()
        {

        }

        public override string ToString()
        {
            return $"id: {id}, name: {name}, price: {price}, honorary_code: {honorary_code}, state: {state}";
        }
        public void SetStates()
        {
            if (state == "in_stock")
            {
                this.State = new InStockState();
            }
            else if(state == "for_sale")
            {
                this.State = new ForSaleState();
            }
            else if (state == "sold")
            {
                this.State = new SoldState();
            }
        }
        
        public void RaisePrice()
        {
            SetStates();
            this.State.RaisePrice(this);
        }

        public void SetUp()
        {
            SetStates();
            this.State.SetUp(this);
        }
        public void SetOff()
        {
            SetStates();
            this.State.SetOff(this);
        }
        public void GiveToTheWinner()
        {
            SetStates();
            this.State.GiveToTheWinner(this);
        }
    }
}
