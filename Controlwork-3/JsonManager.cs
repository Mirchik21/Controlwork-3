using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Controlwork_3
{
    internal class JsonManager
    {
        public static Product[] Products;
        public static Product[] GetProducts()
        {
            if(Products == null)
            {
                string fileData = File.ReadAllText("../../../data.json");
                Products = JsonConvert.DeserializeObject<Product[]>(fileData);  
            }
            return Products;
        }
    }
}
